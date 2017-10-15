namespace Comparsa
{
    partial class frmListaColaborador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaColaborador));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnBorrar = new System.Windows.Forms.ToolStripButton();
            this.btnCerrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnRefrescar = new System.Windows.Forms.ToolStripButton();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.colCOLABORADORID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCALLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNUMEXT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNUMINT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCOLONIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMUNICIPIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colINSTITUCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colESBRIGADISTA = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colESDONANTEN = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bindingSourceGrid = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.edPalabraClave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timerDemoraBusqueda = new System.Windows.Forms.Timer(this.components);
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
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Colaboradores";
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
            this.btnBuscar,
            this.btnRefrescar});
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
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Image")));
            this.btnRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(75, 22);
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.AllowUserToOrderColumns = true;
            this.gridView.AutoGenerateColumns = false;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCOLABORADORID,
            this.colCODIGO,
            this.colNOMBRE,
            this.colCALLE,
            this.colNUMEXT,
            this.colNUMINT,
            this.colCOLONIA,
            this.colMUNICIPIO,
            this.colESTADO,
            this.colTELEFONO,
            this.colINSTITUCION,
            this.colESBRIGADISTA,
            this.colESDONANTEN});
            this.gridView.DataSource = this.bindingSourceGrid;
            this.gridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView.Location = new System.Drawing.Point(0, 109);
            this.gridView.MultiSelect = false;
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(671, 316);
            this.gridView.TabIndex = 2;
            this.gridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellContentDoubleClick);
            this.gridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellDoubleClick);
            this.gridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView_KeyDown);
            // 
            // colCOLABORADORID
            // 
            this.colCOLABORADORID.DataPropertyName = "COLABORADORID";
            this.colCOLABORADORID.HeaderText = "Id";
            this.colCOLABORADORID.Name = "colCOLABORADORID";
            this.colCOLABORADORID.ReadOnly = true;
            this.colCOLABORADORID.Visible = false;
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
            // 
            // colINSTITUCION
            // 
            this.colINSTITUCION.DataPropertyName = "Institución";
            this.colINSTITUCION.HeaderText = "Institución";
            this.colINSTITUCION.Name = "colINSTITUCION";
            this.colINSTITUCION.ReadOnly = true;
            this.colINSTITUCION.Width = 200;
            // 
            // colESBRIGADISTA
            // 
            this.colESBRIGADISTA.DataPropertyName = "ESBRIGADISTA";
            this.colESBRIGADISTA.FalseValue = "0";
            this.colESBRIGADISTA.HeaderText = "Brigadista";
            this.colESBRIGADISTA.Name = "colESBRIGADISTA";
            this.colESBRIGADISTA.ReadOnly = true;
            this.colESBRIGADISTA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colESBRIGADISTA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colESBRIGADISTA.TrueValue = "1";
            // 
            // colESDONANTEN
            // 
            this.colESDONANTEN.DataPropertyName = "ESDONANTE";
            this.colESDONANTEN.FalseValue = "0";
            this.colESDONANTEN.HeaderText = "Donante";
            this.colESDONANTEN.Name = "colESDONANTEN";
            this.colESDONANTEN.ReadOnly = true;
            this.colESDONANTEN.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colESDONANTEN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colESDONANTEN.TrueValue = "1";
            // 
            // bindingSourceGrid
            // 
            this.bindingSourceGrid.Sort = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.edPalabraClave);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(671, 47);
            this.panel2.TabIndex = 3;
            // 
            // edPalabraClave
            // 
            this.edPalabraClave.Location = new System.Drawing.Point(60, 10);
            this.edPalabraClave.Name = "edPalabraClave";
            this.edPalabraClave.Size = new System.Drawing.Size(208, 23);
            this.edPalabraClave.TabIndex = 1;
            this.edPalabraClave.TextChanged += new System.EventHandler(this.edPalabraClave_TextChanged);
            this.edPalabraClave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.palabraClave_KeyDown);
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
            // timerDemoraBusqueda
            // 
            this.timerDemoraBusqueda.Interval = 800;
            this.timerDemoraBusqueda.Tick += new System.EventHandler(this.demoraBusqueda_Tick);
            // 
            // frmListaColaborador
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(671, 425);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "frmListaColaborador";
            this.Text = "Colaboradores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmListaColaborador_FormClosed);
            this.Load += new System.EventHandler(this.frmListaColaborador_Load);
            this.Resize += new System.EventHandler(this.frmListaColaborador_Resize);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colCOLABORADORID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCALLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNUMEXT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNUMINT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCOLONIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMUNICIPIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTELEFONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colINSTITUCION;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colESBRIGADISTA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colESDONANTEN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox edPalabraClave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.Timer timerDemoraBusqueda;
        private System.Windows.Forms.ToolStripButton btnRefrescar;
    }
}