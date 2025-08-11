namespace Kamil.Views
{
    partial class EmpleadosView
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
            this.labelNombre = new Label();
            this.textBoxNombre = new TextBox();
            this.labelApellidoPaterno = new Label();
            this.textBoxApellidoPaterno = new TextBox();
            this.labelApellidoMaterno = new Label();
            this.textBoxApellidoMaterno = new TextBox();
            this.labelFechaNacimiento = new Label();
            this.dateTimePickerFechaNacimiento = new DateTimePicker();
            this.labelRFC = new Label();
            this.textBoxRFC = new TextBox();
            this.labelPuesto = new Label();
            this.comboBoxPuesto = new ComboBox();
            this.labelCentro = new Label();
            this.comboBoxCentro = new ComboBox();
            this.checkBoxDirectivo = new CheckBox();
            this.panelBotones = new Panel();
            this.btnGuardar = new Button();
            this.btnModificar = new Button();
            this.btnEliminar = new Button();
            this.btnLimpiar = new Button();
            this.groupBoxTabla = new GroupBox();
            this.dataGridViewEmpleados = new DataGridView();
            this.groupBoxFormulario.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.groupBoxTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxFormulario
            // 
            this.groupBoxFormulario.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxFormulario.Controls.Add(this.panelBotones);
            this.groupBoxFormulario.Dock = DockStyle.Top;
            this.groupBoxFormulario.Location = new Point(0, 0);
            this.groupBoxFormulario.Name = "groupBoxFormulario";
            this.groupBoxFormulario.Size = new Size(800, 280);
            this.groupBoxFormulario.TabIndex = 0;
            this.groupBoxFormulario.TabStop = false;
            this.groupBoxFormulario.Text = "Formulario de Empleados";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.labelNombre, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNombre, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelApellidoPaterno, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxApellidoPaterno, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelApellidoMaterno, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxApellidoMaterno, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelFechaNacimiento, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerFechaNacimiento, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelRFC, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxRFC, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxDirectivo, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelPuesto, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxPuesto, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelCentro, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxCentro, 3, 3);
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Location = new Point(3, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new Size(794, 218);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelNombre
            // 
            this.labelNombre.Anchor = AnchorStyles.Left;
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new Point(3, 21);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new Size(51, 15);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            this.textBoxNombre.Location = new Point(201, 17);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new Size(192, 23);
            this.textBoxNombre.TabIndex = 1;
            // 
            // labelApellidoPaterno
            // 
            this.labelApellidoPaterno.Anchor = AnchorStyles.Left;
            this.labelApellidoPaterno.AutoSize = true;
            this.labelApellidoPaterno.Location = new Point(399, 21);
            this.labelApellidoPaterno.Name = "labelApellidoPaterno";
            this.labelApellidoPaterno.Size = new Size(96, 15);
            this.labelApellidoPaterno.TabIndex = 2;
            this.labelApellidoPaterno.Text = "Apellido Paterno:";
            // 
            // textBoxApellidoPaterno
            // 
            this.textBoxApellidoPaterno.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            this.textBoxApellidoPaterno.Location = new Point(597, 17);
            this.textBoxApellidoPaterno.Name = "textBoxApellidoPaterno";
            this.textBoxApellidoPaterno.Size = new Size(194, 23);
            this.textBoxApellidoPaterno.TabIndex = 3;
            // 
            // labelApellidoMaterno
            // 
            this.labelApellidoMaterno.Anchor = AnchorStyles.Left;
            this.labelApellidoMaterno.AutoSize = true;
            this.labelApellidoMaterno.Location = new Point(3, 75);
            this.labelApellidoMaterno.Name = "labelApellidoMaterno";
            this.labelApellidoMaterno.Size = new Size(98, 15);
            this.labelApellidoMaterno.TabIndex = 4;
            this.labelApellidoMaterno.Text = "Apellido Materno:";
            // 
            // textBoxApellidoMaterno
            // 
            this.textBoxApellidoMaterno.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            this.textBoxApellidoMaterno.Location = new Point(201, 71);
            this.textBoxApellidoMaterno.Name = "textBoxApellidoMaterno";
            this.textBoxApellidoMaterno.Size = new Size(192, 23);
            this.textBoxApellidoMaterno.TabIndex = 5;
            // 
            // labelFechaNacimiento
            // 
            this.labelFechaNacimiento.Anchor = AnchorStyles.Left;
            this.labelFechaNacimiento.AutoSize = true;
            this.labelFechaNacimiento.Location = new Point(399, 75);
            this.labelFechaNacimiento.Name = "labelFechaNacimiento";
            this.labelFechaNacimiento.Size = new Size(106, 15);
            this.labelFechaNacimiento.TabIndex = 6;
            this.labelFechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // dateTimePickerFechaNacimiento
            // 
            this.dateTimePickerFechaNacimiento.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            this.dateTimePickerFechaNacimiento.Format = DateTimePickerFormat.Short;
            this.dateTimePickerFechaNacimiento.Location = new Point(597, 71);
            this.dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            this.dateTimePickerFechaNacimiento.Size = new Size(194, 23);
            this.dateTimePickerFechaNacimiento.TabIndex = 7;
            // 
            // labelRFC
            // 
            this.labelRFC.Anchor = AnchorStyles.Left;
            this.labelRFC.AutoSize = true;
            this.labelRFC.Location = new Point(3, 129);
            this.labelRFC.Name = "labelRFC";
            this.labelRFC.Size = new Size(31, 15);
            this.labelRFC.TabIndex = 8;
            this.labelRFC.Text = "RFC:";
            // 
            // textBoxRFC
            // 
            this.textBoxRFC.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            this.textBoxRFC.CharacterCasing = CharacterCasing.Upper;
            this.textBoxRFC.Location = new Point(201, 125);
            this.textBoxRFC.MaxLength = 13;
            this.textBoxRFC.Name = "textBoxRFC";
            this.textBoxRFC.Size = new Size(192, 23);
            this.textBoxRFC.TabIndex = 9;
            // 
            // checkBoxDirectivo
            // 
            this.checkBoxDirectivo.Anchor = AnchorStyles.Left;
            this.checkBoxDirectivo.AutoSize = true;
            this.checkBoxDirectivo.Location = new Point(399, 127);
            this.checkBoxDirectivo.Name = "checkBoxDirectivo";
            this.checkBoxDirectivo.Size = new Size(74, 19);
            this.checkBoxDirectivo.TabIndex = 10;
            this.checkBoxDirectivo.Text = "Directivo";
            this.checkBoxDirectivo.UseVisualStyleBackColor = true;
            // 
            // labelPuesto
            // 
            this.labelPuesto.Anchor = AnchorStyles.Left;
            this.labelPuesto.AutoSize = true;
            this.labelPuesto.Location = new Point(3, 185);
            this.labelPuesto.Name = "labelPuesto";
            this.labelPuesto.Size = new Size(46, 15);
            this.labelPuesto.TabIndex = 11;
            this.labelPuesto.Text = "Puesto:";
            // 
            // comboBoxPuesto
            // 
            this.comboBoxPuesto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            this.comboBoxPuesto.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxPuesto.FormattingEnabled = true;
            this.comboBoxPuesto.Location = new Point(201, 181);
            this.comboBoxPuesto.Name = "comboBoxPuesto";
            this.comboBoxPuesto.Size = new Size(192, 23);
            this.comboBoxPuesto.TabIndex = 12;
            // 
            // labelCentro
            // 
            this.labelCentro.Anchor = AnchorStyles.Left;
            this.labelCentro.AutoSize = true;
            this.labelCentro.Location = new Point(399, 185);
            this.labelCentro.Name = "labelCentro";
            this.labelCentro.Size = new Size(46, 15);
            this.labelCentro.TabIndex = 13;
            this.labelCentro.Text = "Centro:";
            // 
            // comboBoxCentro
            // 
            this.comboBoxCentro.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            this.comboBoxCentro.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxCentro.FormattingEnabled = true;
            this.comboBoxCentro.Location = new Point(597, 181);
            this.comboBoxCentro.Name = "comboBoxCentro";
            this.comboBoxCentro.Size = new Size(194, 23);
            this.comboBoxCentro.TabIndex = 14;
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.btnGuardar);
            this.panelBotones.Controls.Add(this.btnModificar);
            this.panelBotones.Controls.Add(this.btnEliminar);
            this.panelBotones.Controls.Add(this.btnLimpiar);
            this.panelBotones.Dock = DockStyle.Bottom;
            this.panelBotones.Location = new Point(3, 237);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new Size(794, 40);
            this.panelBotones.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new Point(10, 8);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new Size(75, 25);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new Point(100, 8);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new Size(75, 25);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new Point(190, 8);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new Size(75, 25);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new Point(280, 8);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new Size(75, 25);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new EventHandler(this.btnLimpiar_Click);
            // 
            // groupBoxTabla
            // 
            this.groupBoxTabla.Controls.Add(this.dataGridViewEmpleados);
            this.groupBoxTabla.Dock = DockStyle.Fill;
            this.groupBoxTabla.Location = new Point(0, 280);
            this.groupBoxTabla.Name = "groupBoxTabla";
            this.groupBoxTabla.Size = new Size(800, 320);
            this.groupBoxTabla.TabIndex = 1;
            this.groupBoxTabla.TabStop = false;
            this.groupBoxTabla.Text = "Lista de Empleados";
            // 
            // dataGridViewEmpleados
            // 
            this.dataGridViewEmpleados.AllowUserToAddRows = false;
            this.dataGridViewEmpleados.AllowUserToDeleteRows = false;
            this.dataGridViewEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpleados.Dock = DockStyle.Fill;
            this.dataGridViewEmpleados.Location = new Point(3, 19);
            this.dataGridViewEmpleados.MultiSelect = false;
            this.dataGridViewEmpleados.Name = "dataGridViewEmpleados";
            this.dataGridViewEmpleados.ReadOnly = true;
            this.dataGridViewEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmpleados.Size = new Size(794, 298);
            this.dataGridViewEmpleados.TabIndex = 0;
            this.dataGridViewEmpleados.SelectionChanged += new EventHandler(this.dataGridViewEmpleados_SelectionChanged);
            // 
            // EmpleadosView
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxTabla);
            this.Controls.Add(this.groupBoxFormulario);
            this.Name = "EmpleadosView";
            this.Size = new Size(800, 600);
            this.groupBoxFormulario.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            this.groupBoxTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).EndInit();
            this.ResumeLayout(false);
        }

        private GroupBox groupBoxFormulario;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelNombre;
        private TextBox textBoxNombre;
        private Label labelApellidoPaterno;
        private TextBox textBoxApellidoPaterno;
        private Label labelApellidoMaterno;
        private TextBox textBoxApellidoMaterno;
        private Label labelFechaNacimiento;
        private DateTimePicker dateTimePickerFechaNacimiento;
        private Label labelRFC;
        private TextBox textBoxRFC;
        private CheckBox checkBoxDirectivo;
        private Label labelPuesto;
        private ComboBox comboBoxPuesto;
        private Label labelCentro;
        private ComboBox comboBoxCentro;
        private Panel panelBotones;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private GroupBox groupBoxTabla;
        private DataGridView dataGridViewEmpleados;
    }
}