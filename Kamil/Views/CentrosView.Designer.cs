namespace Kamil.Views
{
    partial class CentrosView
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.groupBoxFormulario = new GroupBox();
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.labelNumeroCentro = new Label();
            this.textBoxNumeroCentro = new TextBox();
            this.labelNombreCentro = new Label();
            this.textBoxNombreCentro = new TextBox();
            this.labelCiudad = new Label();
            this.textBoxCiudad = new TextBox();
            this.panelBotones = new Panel();
            this.btnGuardar = new Button();
            this.btnModificar = new Button();
            this.btnEliminar = new Button();
            this.groupBoxTabla = new GroupBox();
            this.dataGridViewCentros = new DataGridView();
            this.groupBoxFormulario.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.groupBoxTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCentros)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxFormulario
            // 
            this.groupBoxFormulario.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxFormulario.Controls.Add(this.panelBotones);
            this.groupBoxFormulario.Dock = DockStyle.Top;
            this.groupBoxFormulario.Location = new Point(0, 0);
            this.groupBoxFormulario.Name = "groupBoxFormulario";
            this.groupBoxFormulario.Size = new Size(800, 200);
            this.groupBoxFormulario.TabIndex = 0;
            this.groupBoxFormulario.TabStop = false;
            this.groupBoxFormulario.Text = "Formulario de Centros";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.labelNumeroCentro, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNumeroCentro, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelNombreCentro, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNombreCentro, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelCiudad, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxCiudad, 1, 1);
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Location = new Point(3, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new Size(794, 142);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelNumeroCentro
            // 
            this.labelNumeroCentro.Anchor = AnchorStyles.Left;
            this.labelNumeroCentro.AutoSize = true;
            this.labelNumeroCentro.Location = new Point(3, 26);
            this.labelNumeroCentro.Name = "labelNumeroCentro";
            this.labelNumeroCentro.Size = new Size(103, 15);
            this.labelNumeroCentro.TabIndex = 0;
            this.labelNumeroCentro.Text = "Número de Centro:";
            // 
            // textBoxNumeroCentro
            // 
            this.textBoxNumeroCentro.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            this.textBoxNumeroCentro.Location = new Point(201, 22);
            this.textBoxNumeroCentro.Name = "textBoxNumeroCentro";
            this.textBoxNumeroCentro.Size = new Size(192, 23);
            this.textBoxNumeroCentro.TabIndex = 1;
            // 
            // labelNombreCentro
            // 
            this.labelNombreCentro.Anchor = AnchorStyles.Left;
            this.labelNombreCentro.AutoSize = true;
            this.labelNombreCentro.Location = new Point(399, 26);
            this.labelNombreCentro.Name = "labelNombreCentro";
            this.labelNombreCentro.Size = new Size(102, 15);
            this.labelNombreCentro.TabIndex = 2;
            this.labelNombreCentro.Text = "Nombre del Centro:";
            // 
            // textBoxNombreCentro
            // 
            this.textBoxNombreCentro.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            this.textBoxNombreCentro.Location = new Point(597, 22);
            this.textBoxNombreCentro.Name = "textBoxNombreCentro";
            this.textBoxNombreCentro.Size = new Size(194, 23);
            this.textBoxNombreCentro.TabIndex = 3;
            // 
            // labelCiudad
            // 
            this.labelCiudad.Anchor = AnchorStyles.Left;
            this.labelCiudad.AutoSize = true;
            this.labelCiudad.Location = new Point(3, 96);
            this.labelCiudad.Name = "labelCiudad";
            this.labelCiudad.Size = new Size(48, 15);
            this.labelCiudad.TabIndex = 4;
            this.labelCiudad.Text = "Ciudad:";
            // 
            // textBoxCiudad
            // 
            this.textBoxCiudad.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            this.textBoxCiudad.Location = new Point(201, 92);
            this.textBoxCiudad.Name = "textBoxCiudad";
            this.textBoxCiudad.Size = new Size(192, 23);
            this.textBoxCiudad.TabIndex = 5;
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.btnGuardar);
            this.panelBotones.Controls.Add(this.btnModificar);
            this.panelBotones.Controls.Add(this.btnEliminar);
            this.panelBotones.Dock = DockStyle.Bottom;
            this.panelBotones.Location = new Point(3, 161);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new Size(794, 36);
            this.panelBotones.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new Point(10, 6);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new Size(75, 25);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new Point(100, 6);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new Size(75, 25);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new Point(190, 6);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new Size(75, 25);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new EventHandler(this.btnEliminar_Click);
            // 
            // groupBoxTabla
            // 
            this.groupBoxTabla.Controls.Add(this.dataGridViewCentros);
            this.groupBoxTabla.Dock = DockStyle.Fill;
            this.groupBoxTabla.Location = new Point(0, 200);
            this.groupBoxTabla.Name = "groupBoxTabla";
            this.groupBoxTabla.Size = new Size(800, 400);
            this.groupBoxTabla.TabIndex = 1;
            this.groupBoxTabla.TabStop = false;
            this.groupBoxTabla.Text = "Lista de Centros";
            // 
            // dataGridViewCentros
            // 
            this.dataGridViewCentros.AllowUserToAddRows = false;
            this.dataGridViewCentros.AllowUserToDeleteRows = false;
            this.dataGridViewCentros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCentros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCentros.Dock = DockStyle.Fill;
            this.dataGridViewCentros.Location = new Point(3, 19);
            this.dataGridViewCentros.MultiSelect = false;
            this.dataGridViewCentros.Name = "dataGridViewCentros";
            this.dataGridViewCentros.ReadOnly = true;
            this.dataGridViewCentros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCentros.Size = new Size(794, 378);
            this.dataGridViewCentros.TabIndex = 0;
            this.dataGridViewCentros.SelectionChanged += new EventHandler(this.dataGridViewCentros_SelectionChanged);
            // 
            // CentrosView
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxTabla);
            this.Controls.Add(this.groupBoxFormulario);
            this.Name = "CentrosView";
            this.Size = new Size(800, 600);
            this.groupBoxFormulario.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            this.groupBoxTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCentros)).EndInit();
            this.ResumeLayout(false);
        }

        private GroupBox groupBoxFormulario;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelNumeroCentro;
        private TextBox textBoxNumeroCentro;
        private Label labelNombreCentro;
        private TextBox textBoxNombreCentro;
        private Label labelCiudad;
        private TextBox textBoxCiudad;
        private Panel panelBotones;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private GroupBox groupBoxTabla;
        private DataGridView dataGridViewCentros;
    }
}