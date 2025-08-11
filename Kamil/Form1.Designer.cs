namespace Kamil
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new MenuStrip();
            this.gestionToolStripMenuItem = new ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new ToolStripMenuItem();
            this.directivosToolStripMenuItem = new ToolStripMenuItem();
            this.centrosToolStripMenuItem = new ToolStripMenuItem();
            this.panelMain = new Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new ToolStripItem[] {
            this.gestionToolStripMenuItem});
            this.menuStrip1.Location = new Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new Size(1000, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.empleadosToolStripMenuItem,
            this.directivosToolStripMenuItem,
            this.centrosToolStripMenuItem});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new Size(59, 20);
            this.gestionToolStripMenuItem.Text = "Gestión";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new Size(180, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // directivosToolStripMenuItem
            // 
            this.directivosToolStripMenuItem.Name = "directivosToolStripMenuItem";
            this.directivosToolStripMenuItem.Size = new Size(180, 22);
            this.directivosToolStripMenuItem.Text = "Directivos";
            this.directivosToolStripMenuItem.Click += new EventHandler(this.directivosToolStripMenuItem_Click);
            // 
            // centrosToolStripMenuItem
            // 
            this.centrosToolStripMenuItem.Name = "centrosToolStripMenuItem";
            this.centrosToolStripMenuItem.Size = new Size(180, 22);
            this.centrosToolStripMenuItem.Text = "Centros";
            this.centrosToolStripMenuItem.Click += new EventHandler(this.centrosToolStripMenuItem_Click);
            // 
            // panelMain
            // 
            this.panelMain.Dock = DockStyle.Fill;
            this.panelMain.Location = new Point(0, 24);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new Size(1000, 576);
            this.panelMain.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1000, 600);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Sistema de Gestión Kamil";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gestionToolStripMenuItem;
        private ToolStripMenuItem empleadosToolStripMenuItem;
        private ToolStripMenuItem directivosToolStripMenuItem;
        private ToolStripMenuItem centrosToolStripMenuItem;
        private Panel panelMain;

        #endregion
    }
}
