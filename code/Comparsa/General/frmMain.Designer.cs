namespace Comparsa
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colaboradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afectadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeArtículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.inventariosFísicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pingConnexion = new System.Windows.Forms.Timer(this.components);
            this.nuevoColaboradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeColaboradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarAfectadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeAfectadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbDatabase = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programaToolStripMenuItem,
            this.catalogosToolStripMenuItem,
            this.inventarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programaToolStripMenuItem
            // 
            this.programaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.programaToolStripMenuItem.Name = "programaToolStripMenuItem";
            this.programaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.programaToolStripMenuItem.Text = "Programa";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // catalogosToolStripMenuItem
            // 
            this.catalogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colaboradoresToolStripMenuItem,
            this.afectadosToolStripMenuItem,
            this.tiposDeArtículosToolStripMenuItem,
            this.articulosToolStripMenuItem,
            this.localidadesToolStripMenuItem});
            this.catalogosToolStripMenuItem.Name = "catalogosToolStripMenuItem";
            this.catalogosToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.catalogosToolStripMenuItem.Text = "Catálogos";
            // 
            // colaboradoresToolStripMenuItem
            // 
            this.colaboradoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoColaboradorToolStripMenuItem,
            this.listadoDeColaboradoresToolStripMenuItem});
            this.colaboradoresToolStripMenuItem.Name = "colaboradoresToolStripMenuItem";
            this.colaboradoresToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.colaboradoresToolStripMenuItem.Text = "Colaboradores";
            // 
            // afectadosToolStripMenuItem
            // 
            this.afectadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarAfectadoToolStripMenuItem,
            this.listadoDeAfectadosToolStripMenuItem});
            this.afectadosToolStripMenuItem.Name = "afectadosToolStripMenuItem";
            this.afectadosToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.afectadosToolStripMenuItem.Text = "Afectados";
            // 
            // tiposDeArtículosToolStripMenuItem
            // 
            this.tiposDeArtículosToolStripMenuItem.Name = "tiposDeArtículosToolStripMenuItem";
            this.tiposDeArtículosToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.tiposDeArtículosToolStripMenuItem.Text = "Tipos de insumos";
            this.tiposDeArtículosToolStripMenuItem.Click += new System.EventHandler(this.tiposDeArtículosToolStripMenuItem_Click);
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.articulosToolStripMenuItem.Text = "Insumos";
            this.articulosToolStripMenuItem.Click += new System.EventHandler(this.articulosToolStripMenuItem_Click);
            // 
            // localidadesToolStripMenuItem
            // 
            this.localidadesToolStripMenuItem.Name = "localidadesToolStripMenuItem";
            this.localidadesToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.localidadesToolStripMenuItem.Text = "Localidades";
            this.localidadesToolStripMenuItem.Click += new System.EventHandler(this.localidadesToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradasToolStripMenuItem,
            this.salidasToolStripMenuItem,
            this.toolStripMenuItem1,
            this.inventariosFísicosToolStripMenuItem});
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.inventarioToolStripMenuItem.Text = "Almacén";
            // 
            // entradasToolStripMenuItem
            // 
            this.entradasToolStripMenuItem.Name = "entradasToolStripMenuItem";
            this.entradasToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.entradasToolStripMenuItem.Text = "Entradas a almacén";
            this.entradasToolStripMenuItem.Click += new System.EventHandler(this.entradasToolStripMenuItem_Click);
            // 
            // salidasToolStripMenuItem
            // 
            this.salidasToolStripMenuItem.Name = "salidasToolStripMenuItem";
            this.salidasToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.salidasToolStripMenuItem.Text = "Salidas de almacén";
            this.salidasToolStripMenuItem.Click += new System.EventHandler(this.salidasToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(173, 6);
            // 
            // inventariosFísicosToolStripMenuItem
            // 
            this.inventariosFísicosToolStripMenuItem.Name = "inventariosFísicosToolStripMenuItem";
            this.inventariosFísicosToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.inventariosFísicosToolStripMenuItem.Text = "Inventarios físicos";
            this.inventariosFísicosToolStripMenuItem.Click += new System.EventHandler(this.inventariosFísicosToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbVersion,
            this.lbDatabase});
            this.statusStrip1.Location = new System.Drawing.Point(0, 528);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(790, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pingConnexion
            // 
            this.pingConnexion.Interval = 120000;
            this.pingConnexion.Tick += new System.EventHandler(this.pingConnexion_Tick);
            // 
            // nuevoColaboradorToolStripMenuItem
            // 
            this.nuevoColaboradorToolStripMenuItem.Name = "nuevoColaboradorToolStripMenuItem";
            this.nuevoColaboradorToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.nuevoColaboradorToolStripMenuItem.Text = "Agregar colaborador";
            this.nuevoColaboradorToolStripMenuItem.Click += new System.EventHandler(this.nuevoColaboradorToolStripMenuItem_Click);
            // 
            // listadoDeColaboradoresToolStripMenuItem
            // 
            this.listadoDeColaboradoresToolStripMenuItem.Name = "listadoDeColaboradoresToolStripMenuItem";
            this.listadoDeColaboradoresToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.listadoDeColaboradoresToolStripMenuItem.Text = "Listado de colaboradores";
            this.listadoDeColaboradoresToolStripMenuItem.Click += new System.EventHandler(this.colaboradoresToolStripMenuItem_Click);
            // 
            // agregarAfectadoToolStripMenuItem
            // 
            this.agregarAfectadoToolStripMenuItem.Name = "agregarAfectadoToolStripMenuItem";
            this.agregarAfectadoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.agregarAfectadoToolStripMenuItem.Text = "Agregar afectado";
            this.agregarAfectadoToolStripMenuItem.Click += new System.EventHandler(this.agregarAfectadoToolStripMenuItem_Click);
            // 
            // listadoDeAfectadosToolStripMenuItem
            // 
            this.listadoDeAfectadosToolStripMenuItem.Name = "listadoDeAfectadosToolStripMenuItem";
            this.listadoDeAfectadosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.listadoDeAfectadosToolStripMenuItem.Text = "Listado de afectados";
            this.listadoDeAfectadosToolStripMenuItem.Click += new System.EventHandler(this.afectadosToolStripMenuItem_Click);
            // 
            // lbVersion
            // 
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(55, 17);
            this.lbVersion.Text = "lbVersion";
            // 
            // lbDatabase
            // 
            this.lbDatabase.Name = "lbDatabase";
            this.lbDatabase.Size = new System.Drawing.Size(118, 17);
            this.lbDatabase.Text = "toolStripStatusLabel1";
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(790, 550);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comparsa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colaboradoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afectadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeArtículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidasToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.Timer pingConnexion;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inventariosFísicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoColaboradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeColaboradoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarAfectadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeAfectadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lbVersion;
        private System.Windows.Forms.ToolStripStatusLabel lbDatabase;
    }
}

