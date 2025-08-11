using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Kamil.Views
{
    public partial class CentrosView : UserControl
    {
        private ApplicationDbContext context;
        private BindingList<CatalogoCentros> centros;

        public CentrosView()
        {
            InitializeComponent();
            context = new ApplicationDbContext();
            LoadData();
        }

        private async void LoadData()
        {
            try
            {
                var list = await context.CatalogoCentros.ToListAsync();
                centros = new BindingList<CatalogoCentros>(list);
                dataGridViewCentros.DataSource = centros;
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
                if (ValidateFields())
                {
                    var centro = new CatalogoCentros
                    {
                        Numero_Centro = int.Parse(textBoxNumeroCentro.Text.Trim()),
                        Nombre_Centro = textBoxNombreCentro.Text.Trim(),
                        Ciudad = textBoxCiudad.Text.Trim()
                    };

                    context.CatalogoCentros.Add(centro);
                    context.SaveChanges();
                    centros.Add(centro);

                    ClearFields();
                    MessageBox.Show("Centro guardado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar centro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridViewCentros.SelectedRows.Count > 0)
            {
                try
                {
                    var selected = (CatalogoCentros)dataGridViewCentros.SelectedRows[0].DataBoundItem;
                    if (ValidateFields())
                    {
                        selected.Nombre_Centro = textBoxNombreCentro.Text.Trim();
                        selected.Ciudad = textBoxCiudad.Text.Trim();
                        context.SaveChanges();
                        dataGridViewCentros.Refresh();

                        ClearFields();
                        MessageBox.Show("Centro modificado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar centro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un centro de la tabla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewCentros.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("¿Está seguro de eliminar este centro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        var selected = (CatalogoCentros)dataGridViewCentros.SelectedRows[0].DataBoundItem;
                        context.CatalogoCentros.Remove(selected);
                        context.SaveChanges();
                        centros.Remove(selected);

                        MessageBox.Show("Centro eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar centro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un centro de la tabla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewCentros_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCentros.SelectedRows.Count > 0)
            {
                var selected = (CatalogoCentros)dataGridViewCentros.SelectedRows[0].DataBoundItem;
                LoadSelectedCentro(selected);
            }
        }

        private void LoadSelectedCentro(CatalogoCentros centro)
        {
            textBoxNumeroCentro.Text = centro.Numero_Centro.ToString();
            textBoxNombreCentro.Text = centro.Nombre_Centro;
            textBoxCiudad.Text = centro.Ciudad;
            textBoxNumeroCentro.Enabled = false; // Es PK
        }

        private bool ValidateFields()
        {
            if (!int.TryParse(textBoxNumeroCentro.Text, out _))
            {
                MessageBox.Show("El número de centro debe ser un entero", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxNombreCentro.Text))
            {
                MessageBox.Show("El nombre del centro es requerido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxCiudad.Text))
            {
                MessageBox.Show("La ciudad es requerida", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void ClearFields()
        {
            textBoxNumeroCentro.Clear();
            textBoxNombreCentro.Clear();
            textBoxCiudad.Clear();
            textBoxNumeroCentro.Enabled = true;
        }
    }
}