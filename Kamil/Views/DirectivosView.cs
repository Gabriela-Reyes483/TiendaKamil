using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Kamil.Views
{
    public partial class DirectivosView : UserControl
    {
        private ApplicationDbContext context;
        private BindingList<Directivo> directivos;

        public DirectivosView()
        {
            InitializeComponent();
            context = new ApplicationDbContext();
            LoadData();
        }

        private async void LoadData()
        {
            try
            {
                var directivosList = await context.Directivos
                    .Include(d => d.Empleado)
                    .Include(d => d.CentroSupervisado)
                    .ToListAsync();

                directivos = new BindingList<Directivo>(directivosList);
                dataGridViewDirectivos.DataSource = directivos;

                // Cargar empleados disponibles y centros
                var empleados = await context.Empleados.Where(e => e.Directivo == true).ToListAsync();
                comboBoxEmpleado.DataSource = empleados;
                comboBoxEmpleado.DisplayMember = "Nombre";
                comboBoxEmpleado.ValueMember = "Numero_Empleado";

                var centros = await context.CatalogoCentros.ToListAsync();
                comboBoxCentro.DataSource = centros;
                comboBoxCentro.DisplayMember = "Nombre_Centro";
                comboBoxCentro.ValueMember = "Numero_Centro";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxEmpleado.SelectedValue == null || comboBoxCentro.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un empleado y un centro", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var directivo = new Directivo
                {
                    Numero_Empleado = (int)comboBoxEmpleado.SelectedValue,
                    Centro_Supervisado = (int)comboBoxCentro.SelectedValue,
                    Prestacion_Combustible = checkBoxCombustible.Checked
                };

                context.Directivos.Add(directivo);
                context.SaveChanges();
                directivos.Add(directivo);

                MessageBox.Show("Directivo guardado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar directivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewDirectivos.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("¿Está seguro de eliminar este directivo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        var selected = (Directivo)dataGridViewDirectivos.SelectedRows[0].DataBoundItem;
                        context.Directivos.Remove(selected);
                        context.SaveChanges();
                        directivos.Remove(selected);

                        MessageBox.Show("Directivo eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar directivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un directivo de la tabla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}