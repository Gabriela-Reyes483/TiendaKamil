using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Kamil.Views
{
    // Vista de usuario para la gestión de empleados
    // Permite realizar operaciones CRUD (Crear, Leer, Actualizar, Eliminar) sobre empleados
    public partial class EmpleadosView : UserControl
    {
        // Contexto de base de datos para acceso a datos
        private ApplicationDbContext context;
        // Lista enlazable de empleados para el DataGridView
        private BindingList<Empleado> empleados;

        // Constructor de la vista de empleados
        // Inicializa componentes, configura el contexto de datos y carga la información inicial
        public EmpleadosView()
        {
            InitializeComponent();
            context = new ApplicationDbContext();
            // Suscribe el evento para liberar recursos cuando se cierre la vista
            this.Disposed += EmpleadosView_Disposed;
            // Carga inicial de datos
            LoadData();
        }

        // Manejador del evento Disposed
        // Libera los recursos del contexto de base de datos cuando se destruye la vista
        private void EmpleadosView_Disposed(object? sender, EventArgs e)
        {
            context?.Dispose();
        }

        // Carga datos de empleados desde la base de datos
        // Obtiene todos los empleados con sus relaciones (Puesto y Centro) y los muestra en el grid
        private async void LoadData()
        {
            try
            {
                // Consulta principal: obtiene todos los empleados incluyendo sus relaciones
                var empleadosList = await context.Empleados
                    .Include(e => e.Puesto)
                    .Include(e => e.Centro)
                    .ToListAsync();

                // Crea una lista enlazable para permitir actualizaciones automáticas en el interfaz
                empleados = new BindingList<Empleado>(empleadosList);
                dataGridViewEmpleados.DataSource = empleados;

                // Cargar ComboBoxes
                await LoadCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Carga asíncrona de datos para los ComboBox de puestos y centros
        // Llena los controles desplegables con información de catálogos
        private async Task LoadCombos()
        {
            // Carga catálogo de puestos
            var puestos = await context.CatalogoPuestos.ToListAsync();
            comboBoxPuesto.DataSource = puestos;
            comboBoxPuesto.DisplayMember = "Descripcion_Puesto";
            comboBoxPuesto.ValueMember = "ID_Puesto";

            // Carga catálogo de centros
            var centros = await context.CatalogoCentros.ToListAsync();
            comboBoxCentro.DataSource = centros;
            comboBoxCentro.DisplayMember = "Nombre_Centro";
            comboBoxCentro.ValueMember = "Numero_Centro";
        }

        // Manejador del botón Guardar
        // Valida los campos y crea un nuevo empleado en la base de datos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Validar campos antes de guardar
                if (ValidateFields())
                {
                    // Crear nuevo empleado
                    // Los valores se obtienen de los elementos del formulario
                    var empleado = new Empleado
                    {
                        Nombre = textBoxNombre.Text.Trim(),
                        Apellido_Paterno = textBoxApellidoPaterno.Text.Trim(),
                        Apellido_Materno = textBoxApellidoMaterno.Text.Trim(),
                        Fecha_Nacimiento = dateTimePickerFechaNacimiento.Value,
                        RFC = textBoxRFC.Text.Trim().ToUpper(),
                        Directivo = checkBoxDirectivo.Checked,
                        ID_Puesto = (int)comboBoxPuesto.SelectedValue,
                        Numero_Centro = (int)comboBoxCentro.SelectedValue
                    };

                    // Agregar el empleado al contexto y guardar cambios
                    context.Empleados.Add(empleado);
                    context.SaveChanges();
                    empleados.Add(empleado);

                    // Limpiar campos del formulario
                    ClearFields();
                    MessageBox.Show("Empleado guardado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Manejador del botón Modificar
        // Actualiza los datos del empleado seleccionado en el grid
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmpleados.SelectedRows.Count > 0)
            {
                try
                {
                    // Obtiene el empleado seleccionado desde el grid
                    var selectedEmpleado = (Empleado)dataGridViewEmpleados.SelectedRows[0].DataBoundItem;

                    if (ValidateFields())
                    {
                        // Actualiza las propiedades del empleado con los valores del formulario
                        selectedEmpleado.Nombre = textBoxNombre.Text.Trim();
                        selectedEmpleado.Apellido_Paterno = textBoxApellidoPaterno.Text.Trim();
                        selectedEmpleado.Apellido_Materno = textBoxApellidoMaterno.Text.Trim();
                        selectedEmpleado.Fecha_Nacimiento = dateTimePickerFechaNacimiento.Value;
                        selectedEmpleado.RFC = textBoxRFC.Text.Trim().ToUpper();
                        selectedEmpleado.Directivo = checkBoxDirectivo.Checked;
                        selectedEmpleado.ID_Puesto = (int)comboBoxPuesto.SelectedValue;
                        selectedEmpleado.Numero_Centro = (int)comboBoxCentro.SelectedValue;

                        // Guarda los cambios en la base de datos
                        context.SaveChanges();
                        // Actualiza la visualización en el grid
                        dataGridViewEmpleados.Refresh();

                        ClearFields();
                        MessageBox.Show("Empleado modificado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un empleado de la tabla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Manejador del botón Eliminar
        // Elimina el empleado seleccionado después de confirmación del usuario
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmpleados.SelectedRows.Count > 0)
            {
                // Solicita confirmación antes de eliminar
                var result = MessageBox.Show("¿Está seguro de eliminar este empleado?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Obtiene y elimina el empleado seleccionado
                        var selectedEmpleado = (Empleado)dataGridViewEmpleados.SelectedRows[0].DataBoundItem;
                        context.Empleados.Remove(selectedEmpleado);
                        context.SaveChanges();
                        empleados.Remove(selectedEmpleado);

                        MessageBox.Show("Empleado eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un empleado de la tabla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Manejador del evento SelectionChanged del DataGridView
        // Carga los datos del empleado seleccionado en los controles del formulario
        private void dataGridViewEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewEmpleados.SelectedRows.Count > 0)
            {
                var selectedEmpleado = (Empleado)dataGridViewEmpleados.SelectedRows[0].DataBoundItem;
                LoadSelectedEmpleado(selectedEmpleado);
            }
        }

        // Carga los datos de un empleado específico en los controles del formulario
        private void LoadSelectedEmpleado(Empleado empleado)
        {
            textBoxNombre.Text = empleado.Nombre;
            textBoxApellidoPaterno.Text = empleado.Apellido_Paterno;
            textBoxApellidoMaterno.Text = empleado.Apellido_Materno;
            dateTimePickerFechaNacimiento.Value = empleado.Fecha_Nacimiento;
            textBoxRFC.Text = empleado.RFC;
            checkBoxDirectivo.Checked = empleado.Directivo;
            comboBoxPuesto.SelectedValue = empleado.ID_Puesto;
            comboBoxCentro.SelectedValue = empleado.Numero_Centro;
        }

        // Valida que todos los campos obligatorios tengan valores válidos
        // Retorna true si todos los campos son válidos, false en caso contrario
        private bool ValidateFields()
        {
            // Validación del campo nombre
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
            {
                MessageBox.Show("El nombre es requerido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validación del campo apellido paterno
            if (string.IsNullOrWhiteSpace(textBoxApellidoPaterno.Text))
            {
                MessageBox.Show("El apellido paterno es requerido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validación del campo RFC
            if (string.IsNullOrWhiteSpace(textBoxRFC.Text) || textBoxRFC.Text.Length != 13)
            {
                MessageBox.Show("El RFC debe tener 13 caracteres", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validación del comboBox de puestos
            if (comboBoxPuesto.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un puesto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validación del comboBox de centros
            if (comboBoxCentro.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un centro", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Limpia todos los campos del formulario y restablece los valores por defecto
        private void ClearFields()
        {
            textBoxNombre.Clear();
            textBoxApellidoPaterno.Clear();
            textBoxApellidoMaterno.Clear();
            textBoxRFC.Clear();
            checkBoxDirectivo.Checked = false;
            dateTimePickerFechaNacimiento.Value = DateTime.Now;
            comboBoxPuesto.SelectedIndex = -1;
            comboBoxCentro.SelectedIndex = -1;
        }

        // Manejador del botón Limpiar
        // Limpia todos los campos del formulario
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}