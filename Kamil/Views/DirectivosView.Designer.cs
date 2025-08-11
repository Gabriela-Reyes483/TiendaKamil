namespace Kamil.Views
{
    partial class DirectivosView
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
            this.labelEmpleado = new Label();
            this.comboBoxEmpleado = new ComboBox();
            this.labelCentro = new Label();
            this.comboBoxCentro = new ComboBox();
            this.checkBoxCombustible = new CheckBox();
            this.panelBotones = new Panel();
            this.btnGuardar = new Button();
            this.btnEliminar = new Button();
            this.groupBoxTabla = new GroupBox();
            this.dataGridViewDirectivos = new DataGridView();
            this.groupBoxFormulario.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.groupBoxTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDirectivos)).BeginInit();
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
            this.groupBoxFormulario.Text = "Asignación de Directivos";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.labelEmpleado, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxEmpleado, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelCentro, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxCentro, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxCombustible, 1, 1);
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Location = new Point(3, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new Size(794, 142);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelEmpleado
            // 
            this.labelEmpleado.Anchor = AnchorStyles.Left;
            this.labelEmpleado.AutoSize = true;
            this.labelEmpleado.Location = new Point(3, 26);
            this.labelEmpleado.Name = "labelEmpleado";
            this.labelEmpleado.Size = new Size(65, 15);
            this.labelEmpleado.TabIndex = 0;
            this.labelEmpleado.Text = "Empleado:";
            // 
            // comboBoxEmpleado
            // 
            this.comboBoxEmpleado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            this.comboBoxEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxEmpleado.FormattingEnabled = true;
            this.comboBoxEmpleado.Location = new Point(201, 22);
            this.comboBoxEmpleado.Name = "comboBoxEmpleado";
            this.comboBoxEmpleado.Size = new Size(192, 23);
            this.comboBoxEmpleado.TabIndex = 1;
            // 
            // labelCentro
            // 
            this.labelCentro.Anchor = AnchorStyles.Left;
            this.labelCentro.AutoSize = true;
            this.labelCentro.Location = new Point(399, 26);
            this.labelCentro.Name = "labelCentro";
            this.labelCentro.Size = new Size(46, 15);
            this.labelCentro.TabIndex = 2;
            this.labelCentro.Text = "Centro:";
            // 
            // comboBoxCentro
            // 
            this.comboBoxCentro.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            this.comboBoxCentro.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxCentro.FormattingEnabled = true;
            this.comboBoxCentro.Location = new Point(597, 22);
            this.comboBoxCentro.Name = "comboBoxCentro";
            this.comboBoxCentro.Size = new Size(194, 23);
            this.comboBoxCentro.TabIndex = 3;
            // 
            // checkBoxCombustible
            // 
            this.checkBoxCombustible.Anchor = AnchorStyles.Left;
            this.checkBoxCombustible.AutoSize = true;
            this.checkBoxCombustible.Location = new Point(201, 96);
            this.checkBoxCombustible.Name = "checkBoxCombustible";
            this.checkBoxCombustible.Size = new Size(155, 19);
            this.checkBoxCombustible.TabIndex = 4;
            this.checkBoxCombustible.Text = "Prestación Combustible";
            this.checkBoxCombustible.UseVisualStyleBackColor = true;
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.btnGuardar);
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
            // btnEliminar
            // 
            this.btnEliminar.Location = new Point(100, 6);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new Size(75, 25);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new EventHandler(this.btnEliminar_Click);
            // 
            // groupBoxTabla
            // 
            this.groupBoxTabla.Controls.Add(this.dataGridViewDirectivos);
            this.groupBoxTabla.Dock = DockStyle.Fill;
            this.groupBoxTabla.Location = new Point(0, 200);
            this.groupBoxTabla.Name = "groupBoxTabla";
            this.groupBoxTabla.Size = new Size(800, 400);
            this.groupBoxTabla.TabIndex = 1;
            this.groupBoxTabla.TabStop = false;
            this.groupBoxTabla.Text = "Lista de Directivos";
            // 
            // dataGridViewDirectivos
            // 
            this.dataGridViewDirectivos.AllowUserToAddRows = false;
            this.dataGridViewDirectivos.AllowUserToDeleteRows = false;
            this.dataGridViewDirectivos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDirectivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDirectivos.Dock = DockStyle.Fill;
            this.dataGridViewDirectivos.Location = new Point(3, 19);
            this.dataGridViewDirectivos.MultiSelect = false;
            this.dataGridViewDirectivos.Name = "dataGridViewDirectivos";
            this.dataGridViewDirectivos.ReadOnly = true;
            this.dataGridViewDirectivos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDirectivos.Size = new Size(794, 378);
            this.dataGridViewDirectivos.TabIndex = 0;
            // 
            // DirectivosView
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxTabla);
            this.Controls.Add(this.groupBoxFormulario);
            this.Name = "DirectivosView";
            this.Size = new Size(800, 600);
            this.groupBoxFormulario.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            this.groupBoxTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDirectivos)).EndInit();
            this.ResumeLayout(false);
        }

        private GroupBox groupBoxFormulario;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelEmpleado;
        private ComboBox comboBoxEmpleado;
        private Label labelCentro;
        private ComboBox comboBoxCentro;
        private CheckBox checkBoxCombustible;
        private Panel panelBotones;
        private Button btnGuardar;
        private Button btnEliminar;
        private GroupBox groupBoxTabla;
        private DataGridView dataGridViewDirectivos;
    }
}