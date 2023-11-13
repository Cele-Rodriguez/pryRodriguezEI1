namespace pryRodriguezEI1
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.BarraInferior = new System.Windows.Forms.StatusStrip();
            this.lblEstadoConexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BarraInferior.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraInferior
            // 
            this.BarraInferior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstadoConexion});
            this.BarraInferior.Location = new System.Drawing.Point(0, 326);
            this.BarraInferior.Name = "BarraInferior";
            this.BarraInferior.Size = new System.Drawing.Size(569, 22);
            this.BarraInferior.TabIndex = 0;
            this.BarraInferior.Text = "statusStrip1";
            // 
            // lblEstadoConexion
            // 
            this.lblEstadoConexion.Name = "lblEstadoConexion";
            this.lblEstadoConexion.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedoresToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(569, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarProveedoresToolStripMenuItem,
            this.cargarProveedoresToolStripMenuItem});
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.proveedoresToolStripMenuItem.Text = "Proveedores ";
            // 
            // mostrarProveedoresToolStripMenuItem
            // 
            this.mostrarProveedoresToolStripMenuItem.Name = "mostrarProveedoresToolStripMenuItem";
            this.mostrarProveedoresToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.mostrarProveedoresToolStripMenuItem.Text = "Mostrar Proveedores";
            this.mostrarProveedoresToolStripMenuItem.Click += new System.EventHandler(this.mostrarProveedoresToolStripMenuItem_Click_1);
            // 
            // cargarProveedoresToolStripMenuItem
            // 
            this.cargarProveedoresToolStripMenuItem.Name = "cargarProveedoresToolStripMenuItem";
            this.cargarProveedoresToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.cargarProveedoresToolStripMenuItem.Text = "Cargar Proveedores";
            this.cargarProveedoresToolStripMenuItem.Click += new System.EventHandler(this.cargarProveedoresToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarUsuariosToolStripMenuItem,
            this.buscarUsuariosToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // mostrarUsuariosToolStripMenuItem
            // 
            this.mostrarUsuariosToolStripMenuItem.Name = "mostrarUsuariosToolStripMenuItem";
            this.mostrarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mostrarUsuariosToolStripMenuItem.Text = "Mostrar Usuarios";
            this.mostrarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.mostrarUsuariosToolStripMenuItem_Click_1);
            // 
            // buscarUsuariosToolStripMenuItem
            // 
            this.buscarUsuariosToolStripMenuItem.Name = "buscarUsuariosToolStripMenuItem";
            this.buscarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.buscarUsuariosToolStripMenuItem.Text = "Buscar Usuarios";
            this.buscarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.buscarUsuariosToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 348);
            this.Controls.Add(this.BarraInferior);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Broker Seguros G";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.BarraInferior.ResumeLayout(false);
            this.BarraInferior.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip BarraInferior;
        private System.Windows.Forms.ToolStripStatusLabel lblEstadoConexion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarUsuariosToolStripMenuItem;
    }
}