namespace Comparsa
{
    partial class frmListaAfectado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaAfectado));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnBorrar = new System.Windows.Forms.ToolStripButton();
            this.btnCerrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colESTATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCALLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNUMEXT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNUMINT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCOLONIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMUNICIPIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceGrid = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.palabraClave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.demoraBusqueda = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 37);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Afectados";
            // 
            // toolStrip
            // 
            this.toolStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.btnModificar,
            this.btnBorrar,
            this.btnCerrar,
            this.toolStripSeparator1,
            this.btnBuscar});
            this.toolStrip.Location = new System.Drawing.Point(0, 37);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(671, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(69, 22);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(78, 22);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(59, 22);
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(43, 22);
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(62, 22);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.AllowUserToOrderColumns = true;
            this.gridView.AutoGenerateColumns = false;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colCODIGO,
            this.colNOMBRE,
            this.colESTATUS,
            this.colCALLE,
            this.colNUMEXT,
            this.colNUMINT,
            this.colCOLONIA,
            this.Localidad,
            this.colMUNICIPIO,
            this.colESTADO,
            this.colTELEFONO,
            this.Email});
            this.gridView.DataSource = this.bindingSourceGrid;
            this.gridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView.Location = new System.Drawing.Point(0, 109);
            this.gridView.MultiSelect = false;
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(671, 316);
            this.gridView.TabIndex = 2;
            this.gridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellDoubleClick);
            this.gridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridView_CellFormatting);
            this.gridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView_KeyDown);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "AFECTADOID";
            this.colID.HeaderText = "Id";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            // 
            // colCODIGO
            // 
            this.colCODIGO.DataPropertyName = "CODIGO";
            this.colCODIGO.HeaderText = "Código";
            this.colCODIGO.Name = "colCODIGO";
            this.colCODIGO.ReadOnly = true;
            // 
            // colNOMBRE
            // 
            this.colNOMBRE.DataPropertyName = "NOMBRE";
            this.colNOMBRE.HeaderText = "Nombre";
            this.colNOMBRE.Name = "colNOMBRE";
            this.colNOMBRE.ReadOnly = true;
            this.colNOMBRE.Width = 300;
            // 
            // colESTATUS
            // 
            this.colESTATUS.HeaderText = "Estatus";
            this.colESTATUS.Name = "colESTATUS";
            this.colESTATUS.ReadOnly = true;
            this.colESTATUS.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colESTATUS.Width = 150;
            // 
            // colCALLE
            // 
            this.colCALLE.DataPropertyName = "CALLE";
            this.colCALLE.HeaderText = "Calle";
            this.colCALLE.Name = "colCALLE";
            this.colCALLE.ReadOnly = true;
            this.colCALLE.Width = 200;
            // 
            // colNUMEXT
            // 
            this.colNUMEXT.DataPropertyName = "NUMEXT";
            this.colNUMEXT.HeaderText = "Núm. ext.";
            this.colNUMEXT.Name = "colNUMEXT";
            this.colNUMEXT.ReadOnly = true;
            // 
            // colNUMINT
            // 
            this.colNUMINT.DataPropertyName = "NUMINT";
            this.colNUMINT.HeaderText = "Núm. int.";
            this.colNUMINT.Name = "colNUMINT";
            this.colNUMINT.ReadOnly = true;
            // 
            // colCOLONIA
            // 
            this.colCOLONIA.DataPropertyName = "COLONIA";
            this.colCOLONIA.HeaderText = "Colonia";
            this.colCOLONIA.Name = "colCOLONIA";
            this.colCOLONIA.ReadOnly = true;
            this.colCOLONIA.Width = 200;
            // 
            // Localidad
            // 
            this.Localidad.DataPropertyName = "NOMBRELOCALIDAD";
            this.Localidad.HeaderText = "Localidad";
            this.Localidad.Name = "Localidad";
            this.Localidad.ReadOnly = true;
            // 
            // colMUNICIPIO
            // 
            this.colMUNICIPIO.DataPropertyName = "MUNICIPIO";
            this.colMUNICIPIO.HeaderText = "Municipio";
            this.colMUNICIPIO.Name = "colMUNICIPIO";
            this.colMUNICIPIO.ReadOnly = true;
            this.colMUNICIPIO.Width = 200;
            // 
            // colESTADO
            // 
            this.colESTADO.DataPropertyName = "ESTADO";
            this.colESTADO.HeaderText = "Estado";
            this.colESTADO.Name = "colESTADO";
            this.colESTADO.ReadOnly = true;
            this.colESTADO.Width = 200;
            // 
            // colTELEFONO
            // 
            this.colTELEFONO.DataPropertyName = "TELEFONO";
            this.colTELEFONO.HeaderText = "Teléfono";
            this.colTELEFONO.Name = "colTELEFONO";
            this.colTELEFONO.ReadOnly = true;
            this.colTELEFONO.Width = 150;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "EMAIL";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 200;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.palabraClave);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(671, 47);
            this.panel2.TabIndex = 4;
            // 
            // palabraClave
            // 
            this.palabraClave.Location = new System.Drawing.Point(60, 10);
            this.palabraClave.Name = "palabraClave";
            this.palabraClave.Size = new System.Drawing.Size(208, 23);
            this.palabraClave.TabIndex = 1;
            this.palabraClave.TextChanged += new System.EventHandler(this.palabraClave_TextChanged);
            this.palabraClave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.palabraClave_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buscar:";
            // 
            // demoraBusqueda
            // 
            this.demoraBusqueda.Interval = 800;
            this.demoraBusqueda.Tick += new System.EventHandler(this.demoraBusqueda_Tick);
            // 
            // frmListaAfectado
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(671, 425);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "frmListaAfectado";
            this.Text = "Afectados";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmListaAfectado_FormClosed);
            this.Load += new System.EventHandler(this.frmListaAfectado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnBorrar;
        private System.Windows.Forms.ToolStripButton btnCerrar;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.BindingSource bindingSourceGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn colESTATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCALLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNUMEXT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNUMINT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCOLONIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMUNICIPIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTELEFONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox palabraClave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer demoraBusqueda;
    }
}