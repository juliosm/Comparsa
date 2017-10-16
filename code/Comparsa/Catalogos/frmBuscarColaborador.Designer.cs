namespace Comparsa
{
    partial class frmBuscarColaborador
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.edNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cbBrigadistas = new System.Windows.Forms.CheckBox();
            this.cbDonantes = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar colaborador";
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.AllowUserToOrderColumns = true;
            this.gridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.gridView.Location = new System.Drawing.Point(10, 119);
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
            this.gridView.Size = new System.Drawing.Size(650, 237);
            this.gridView.TabIndex = 2;
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
            this.panel2.Controls.Add(this.cbDonantes);
            this.panel2.Controls.Add(this.cbBrigadistas);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.edNombre);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(671, 73);
            this.panel2.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(368, 8);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 31);
            this.btnBuscar.TabIndex = 26;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // edNombre
            // 
            this.edNombre.Location = new System.Drawing.Point(70, 12);
            this.edNombre.Name = "edNombre";
            this.edNombre.Size = new System.Drawing.Size(292, 23);
            this.edNombre.TabIndex = 1;
            this.edNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.edNombre_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancelar);
            this.panel3.Controls.Add(this.btnAceptar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 367);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(671, 58);
            this.panel3.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(569, 15);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 31);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(473, 15);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(90, 31);
            this.btnAceptar.TabIndex = 25;
            this.btnAceptar.Text = "&Seleccionar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cbBrigadistas
            // 
            this.cbBrigadistas.AllowDrop = true;
            this.cbBrigadistas.AutoSize = true;
            this.cbBrigadistas.Location = new System.Drawing.Point(70, 48);
            this.cbBrigadistas.Name = "cbBrigadistas";
            this.cbBrigadistas.Size = new System.Drawing.Size(83, 19);
            this.cbBrigadistas.TabIndex = 27;
            this.cbBrigadistas.Text = "Brigadistas";
            this.cbBrigadistas.UseVisualStyleBackColor = true;
            // 
            // cbDonantes
            // 
            this.cbDonantes.AutoSize = true;
            this.cbDonantes.Location = new System.Drawing.Point(179, 48);
            this.cbDonantes.Name = "cbDonantes";
            this.cbDonantes.Size = new System.Drawing.Size(76, 19);
            this.cbDonantes.TabIndex = 28;
            this.cbDonantes.Text = "Donantes";
            this.cbDonantes.UseVisualStyleBackColor = true;
            // 
            // frmBuscarColaborador
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(671, 425);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscarColaborador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar colaborador";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBuscarColaborador_FormClosed);
            this.Load += new System.EventHandler(this.frmBuscarColaborador_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.TextBox edNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.CheckBox cbDonantes;
        private System.Windows.Forms.CheckBox cbBrigadistas;
    }
}