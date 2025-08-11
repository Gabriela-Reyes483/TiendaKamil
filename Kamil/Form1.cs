using Microsoft.EntityFrameworkCore;

namespace Kamil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ValidateConnection();
        }

        private async void ValidateConnection()
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    bool canConnect = await context.Database.CanConnectAsync();
                    if (canConnect)
                    {
                        MessageBox.Show("Conexión exitosa a la base de datos", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo establecer la conexión a la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar a la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
