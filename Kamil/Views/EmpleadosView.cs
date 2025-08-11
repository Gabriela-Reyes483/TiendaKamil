using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Kamil.Views
{
    public partial class EmpleadosView : UserControl
    {
        private ApplicationDbContext context;
        private BindingList<Empleado> empleados;

        public EmpleadosView()
        {
            InitializeComponent();
            context = new ApplicationDbContext();
            this.Disposed += EmpleadosView_Disposed;
            LoadData();
        }

        private void EmpleadosView_Disposed(object? sender, EventArgs e)
        {
            context?.Dispose();
        }

        private async void LoadData()
        {
            try
            {
                var empleadosList = await context.Empleados
                    .Include(e => e.Puesto)
                    .Include(e => e.Centro)
                    .ToListAsync();

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

        private async Task LoadCombos()
        {
            var puestos = await context.CatalogoPuestos.ToListAsync();
            comboBoxPuesto.DataSource = puestos;
            comboBoxPuesto.DisplayMember = "Descripcion_Puesto";
            comboBoxPuesto.ValueMember = "ID_Puesto";

            var centros = await context.CatalogoCentros.ToListAsync();
            comboBoxCentro.DataSource = centros;
            comboBoxCentro.DisplayMember = "Nombre_Centro";
            comboBoxCentro.ValueMember = "Numero_Centro";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateFields())
                {
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

                    context.Empleados.Add(empleado);
                    context.SaveChanges();
                    empleados.Add(empleado);

                    ClearFields();
                    MessageBox.Show("Empleado guardado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmpleados.SelectedRows.Count > 0)
            {
                try
                {
                    var selectedEmpleado = (Empleado)dataGridViewEmpleados.SelectedRows[0].DataBoundItem;
                    
                    if (ValidateFields())
                    {
                        selectedEmpleado.Nombre = textBoxNombre.Text.Trim();
                        selectedEmpleado.Apellido_Paterno = textBoxApellidoPaterno.Text.Trim();
                        selectedEmpleado.Apellido_Materno = textBoxApellidoMaterno.Text.Trim();
                        selectedEmpleado.Fecha_Nacimiento = dateTimePickerFechaNacimiento.Value;
                        selectedEmpleado.RFC = textBoxRFC.Text.Trim().ToUpper();
                        selectedEmpleado.Directivo = checkBoxDirectivo.Checked;
                        selectedEmpleado.ID_Puesto = (int)comboBoxPuesto.SelectedValue;
                        selectedEmpleado.Numero_Centro = (int)comboBoxCentro.SelectedValue;

                        context.SaveChanges();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmpleados.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("¿Está seguro de eliminar este empleado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
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

        private void dataGridViewEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewEmpleados.SelectedRows.Count > 0)
            {
                var selectedEmpleado = (Empleado)dataGridViewEmpleados.SelectedRows[0].DataBoundItem;
                LoadSelectedEmpleado(selectedEmpleado);
            }
        }

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

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
            {
                MessageBox.Show("El nombre es requerido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxApellidoPaterno.Text))
            {
                MessageBox.Show("El apellido paterno es requerido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxRFC.Text) || textBoxRFC.Text.Length != 13)
            {
                MessageBox.Show("El RFC debe tener 13 caracteres", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (comboBoxPuesto.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un puesto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (comboBoxCentro.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un centro", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}