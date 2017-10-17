namespace Comparsa
{
    partial class frmDetInventarioFisico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetInventarioFisico));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.edNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edFecha = new System.Windows.Forms.DateTimePicker();
            this.edHora = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridViewDetalle = new System.Windows.Forms.DataGridView();
            this.iNVENTARIODETIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNVENTARIOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNSUMOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colINSUMONOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNVENTARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEXISTREAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEXISTDIFERENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceDetalle = new System.Windows.Forms.BindingSource(this.components);
            this.panelAgregarInsumo = new System.Windows.Forms.Panel();
            this.edExistTeorica = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAgregarInsumo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.edExistReal = new System.Windows.Forms.NumericUpDown();
            this.edInsumo = new System.Windows.Forms.ComboBox();
            this.bindingSourceInsumo = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.menuDetalle = new System.Windows.Forms.ToolStrip();
            this.btnModificarDetalle = new System.Windows.Forms.ToolStripButton();
            this.btnQuitarInsumo = new System.Windows.Forms.ToolStripButton();
            this.edNotas = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDetalle)).BeginInit();
            this.panelAgregarInsumo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edExistReal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInsumo)).BeginInit();
            this.menuDetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 37);
            this.panel1.TabIndex = 1;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbTitulo.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(8, 10);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(117, 17);
            this.lbTitulo.TabIndex = 2;
            this.lbTitulo.Text = "Inventario físico";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnAceptar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 458);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(695, 58);
            this.panel2.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(593, 15);
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
            this.btnAceptar.Location = new System.Drawing.Point(497, 15);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(90, 31);
            this.btnAceptar.TabIndex = 25;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // edNumero
            // 
            this.edNumero.Location = new System.Drawing.Point(12, 70);
            this.edNumero.Multiline = true;
            this.edNumero.Name = "edNumero";
            this.edNumero.ReadOnly = true;
            this.edNumero.Size = new System.Drawing.Size(100, 23);
            this.edNumero.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Número";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hora";
            // 
            // edFecha
            // 
            this.edFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.edFecha.Location = new System.Drawing.Point(118, 70);
            this.edFecha.Name = "edFecha";
            this.edFecha.Size = new System.Drawing.Size(114, 23);
            this.edFecha.TabIndex = 2;
            // 
            // edHora
            // 
            this.edHora.CustomFormat = "hh:mm tt";
            this.edHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.edHora.Location = new System.Drawing.Point(238, 70);
            this.edHora.Name = "edHora";
            this.edHora.Size = new System.Drawing.Size(114, 23);
            this.edHora.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Detalle de insumos";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.gridViewDetalle);
            this.panel3.Controls.Add(this.panelAgregarInsumo);
            this.panel3.Controls.Add(this.menuDetalle);
            this.panel3.Location = new System.Drawing.Point(12, 199);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(669, 243);
            this.panel3.TabIndex = 11;
            // 
            // gridViewDetalle
            // 
            this.gridViewDetalle.AllowUserToAddRows = false;
            this.gridViewDetalle.AllowUserToDeleteRows = false;
            this.gridViewDetalle.AutoGenerateColumns = false;
            this.gridViewDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iNVENTARIODETIDDataGridViewTextBoxColumn,
            this.iNVENTARIOIDDataGridViewTextBoxColumn,
            this.iNSUMOIDDataGridViewTextBoxColumn,
            this.colINSUMONOMBRE,
            this.iNVENTARIODataGridViewTextBoxColumn,
            this.colEXISTREAL,
            this.colEXISTDIFERENCIA});
            this.gridViewDetalle.DataSource = this.bindingSourceDetalle;
            this.gridViewDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewDetalle.Location = new System.Drawing.Point(0, 65);
            this.gridViewDetalle.MultiSelect = false;
            this.gridViewDetalle.Name = "gridViewDetalle";
            this.gridViewDetalle.ReadOnly = true;
            this.gridViewDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewDetalle.ShowCellErrors = false;
            this.gridViewDetalle.ShowCellToolTips = false;
            this.gridViewDetalle.ShowEditingIcon = false;
            this.gridViewDetalle.ShowRowErrors = false;
            this.gridViewDetalle.Size = new System.Drawing.Size(669, 178);
            this.gridViewDetalle.TabIndex = 2;
            this.gridViewDetalle.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridViewDetalle_CellFormatting);
            // 
            // iNVENTARIODETIDDataGridViewTextBoxColumn
            // 
            this.iNVENTARIODETIDDataGridViewTextBoxColumn.DataPropertyName = "INVENTARIODETID";
            this.iNVENTARIODETIDDataGridViewTextBoxColumn.HeaderText = "INVENTARIODETID";
            this.iNVENTARIODETIDDataGridViewTextBoxColumn.Name = "iNVENTARIODETIDDataGridViewTextBoxColumn";
            this.iNVENTARIODETIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iNVENTARIODETIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // iNVENTARIOIDDataGridViewTextBoxColumn
            // 
            this.iNVENTARIOIDDataGridViewTextBoxColumn.DataPropertyName = "INVENTARIOID";
            this.iNVENTARIOIDDataGridViewTextBoxColumn.HeaderText = "INVENTARIOID";
            this.iNVENTARIOIDDataGridViewTextBoxColumn.Name = "iNVENTARIOIDDataGridViewTextBoxColumn";
            this.iNVENTARIOIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iNVENTARIOIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // iNSUMOIDDataGridViewTextBoxColumn
            // 
            this.iNSUMOIDDataGridViewTextBoxColumn.DataPropertyName = "INSUMOID";
            this.iNSUMOIDDataGridViewTextBoxColumn.HeaderText = "INSUMOID";
            this.iNSUMOIDDataGridViewTextBoxColumn.Name = "iNSUMOIDDataGridViewTextBoxColumn";
            this.iNSUMOIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iNSUMOIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // colINSUMONOMBRE
            // 
            this.colINSUMONOMBRE.DataPropertyName = "INSUMO.NOMBRE";
            this.colINSUMONOMBRE.HeaderText = "Insumo";
            this.colINSUMONOMBRE.Name = "colINSUMONOMBRE";
            this.colINSUMONOMBRE.ReadOnly = true;
            this.colINSUMONOMBRE.Width = 200;
            // 
            // iNVENTARIODataGridViewTextBoxColumn
            // 
            this.iNVENTARIODataGridViewTextBoxColumn.DataPropertyName = "EXISTTEORICA";
            this.iNVENTARIODataGridViewTextBoxColumn.HeaderText = "Exist. teórica";
            this.iNVENTARIODataGridViewTextBoxColumn.Name = "iNVENTARIODataGridViewTextBoxColumn";
            this.iNVENTARIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colEXISTREAL
            // 
            this.colEXISTREAL.DataPropertyName = "EXISTREAL";
            this.colEXISTREAL.HeaderText = "Exist. real";
            this.colEXISTREAL.Name = "colEXISTREAL";
            this.colEXISTREAL.ReadOnly = true;
            // 
            // colEXISTDIFERENCIA
            // 
            this.colEXISTDIFERENCIA.DataPropertyName = "EXISTDIFERENCIA";
            this.colEXISTDIFERENCIA.HeaderText = "Diferencia";
            this.colEXISTDIFERENCIA.Name = "colEXISTDIFERENCIA";
            this.colEXISTDIFERENCIA.ReadOnly = true;
            // 
            // bindingSourceDetalle
            // 
            this.bindingSourceDetalle.DataSource = typeof(Comparsa.Data.INVENTARIODET_EXT);
            // 
            // panelAgregarInsumo
            // 
            this.panelAgregarInsumo.Controls.Add(this.edExistTeorica);
            this.panelAgregarInsumo.Controls.Add(this.label7);
            this.panelAgregarInsumo.Controls.Add(this.btnAgregarInsumo);
            this.panelAgregarInsumo.Controls.Add(this.label6);
            this.panelAgregarInsumo.Controls.Add(this.edExistReal);
            this.panelAgregarInsumo.Controls.Add(this.edInsumo);
            this.panelAgregarInsumo.Controls.Add(this.label5);
            this.panelAgregarInsumo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAgregarInsumo.Location = new System.Drawing.Point(0, 25);
            this.panelAgregarInsumo.Name = "panelAgregarInsumo";
            this.panelAgregarInsumo.Size = new System.Drawing.Size(669, 40);
            this.panelAgregarInsumo.TabIndex = 0;
            // 
            // edExistTeorica
            // 
            this.edExistTeorica.Location = new System.Drawing.Point(335, 8);
            this.edExistTeorica.Multiline = true;
            this.edExistTeorica.Name = "edExistTeorica";
            this.edExistTeorica.ReadOnly = true;
            this.edExistTeorica.Size = new System.Drawing.Size(64, 23);
            this.edExistTeorica.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Exist. teórica:";
            // 
            // btnAgregarInsumo
            // 
            this.btnAgregarInsumo.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarInsumo.Image")));
            this.btnAgregarInsumo.Location = new System.Drawing.Point(534, 5);
            this.btnAgregarInsumo.Name = "btnAgregarInsumo";
            this.btnAgregarInsumo.Size = new System.Drawing.Size(81, 28);
            this.btnAgregarInsumo.TabIndex = 3;
            this.btnAgregarInsumo.Text = "Agregar";
            this.btnAgregarInsumo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarInsumo.UseVisualStyleBackColor = true;
            this.btnAgregarInsumo.Click += new System.EventHandler(this.btnAgregarInsumo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Exist. real";
            // 
            // edExistReal
            // 
            this.edExistReal.Location = new System.Drawing.Point(462, 8);
            this.edExistReal.Name = "edExistReal";
            this.edExistReal.Size = new System.Drawing.Size(64, 23);
            this.edExistReal.TabIndex = 2;
            // 
            // edInsumo
            // 
            this.edInsumo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.edInsumo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.edInsumo.DataSource = this.bindingSourceInsumo;
            this.edInsumo.DisplayMember = "NOMBRE";
            this.edInsumo.FormattingEnabled = true;
            this.edInsumo.Location = new System.Drawing.Point(55, 8);
            this.edInsumo.Name = "edInsumo";
            this.edInsumo.Size = new System.Drawing.Size(198, 23);
            this.edInsumo.TabIndex = 1;
            this.edInsumo.ValueMember = "INSUMOID";
            this.edInsumo.SelectedIndexChanged += new System.EventHandler(this.edInsumo_SelectedIndexChanged);
            // 
            // bindingSourceInsumo
            // 
            this.bindingSourceInsumo.DataSource = typeof(Comparsa.Data.INSUMO);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Insumo";
            // 
            // menuDetalle
            // 
            this.menuDetalle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnModificarDetalle,
            this.btnQuitarInsumo});
            this.menuDetalle.Location = new System.Drawing.Point(0, 0);
            this.menuDetalle.Name = "menuDetalle";
            this.menuDetalle.Size = new System.Drawing.Size(669, 25);
            this.menuDetalle.TabIndex = 1;
            this.menuDetalle.Text = "toolStrip1";
            // 
            // btnModificarDetalle
            // 
            this.btnModificarDetalle.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarDetalle.Image")));
            this.btnModificarDetalle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificarDetalle.Name = "btnModificarDetalle";
            this.btnModificarDetalle.Size = new System.Drawing.Size(78, 22);
            this.btnModificarDetalle.Text = "Modificar";
            this.btnModificarDetalle.Click += new System.EventHandler(this.btnModificarDetalle_Click);
            // 
            // btnQuitarInsumo
            // 
            this.btnQuitarInsumo.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitarInsumo.Image")));
            this.btnQuitarInsumo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuitarInsumo.Name = "btnQuitarInsumo";
            this.btnQuitarInsumo.Size = new System.Drawing.Size(60, 22);
            this.btnQuitarInsumo.Text = "Quitar";
            this.btnQuitarInsumo.Click += new System.EventHandler(this.btnQuitarInsumo_Click);
            // 
            // edNotas
            // 
            this.edNotas.Location = new System.Drawing.Point(12, 116);
            this.edNotas.Multiline = true;
            this.edNotas.Name = "edNotas";
            this.edNotas.Size = new System.Drawing.Size(340, 49);
            this.edNotas.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 15);
            this.label13.TabIndex = 16;
            this.label13.Text = "Notas";
            // 
            // frmDetInventarioFisico
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(695, 516);
            this.Controls.Add(this.edNotas);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edHora);
            this.Controls.Add(this.edFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetInventarioFisico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario físico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDetInventarioFisico_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDetInventarioFisico_FormClosed);
            this.Load += new System.EventHandler(this.frmDetInventarioFisico_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDetalle)).EndInit();
            this.panelAgregarInsumo.ResumeLayout(false);
            this.panelAgregarInsumo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edExistReal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInsumo)).EndInit();
            this.menuDetalle.ResumeLayout(false);
            this.menuDetalle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox edNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker edFecha;
        private System.Windows.Forms.DateTimePicker edHora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelAgregarInsumo;
        private System.Windows.Forms.DataGridView gridViewDetalle;
        private System.Windows.Forms.ToolStrip menuDetalle;
        private System.Windows.Forms.ToolStripButton btnQuitarInsumo;
        private System.Windows.Forms.Button btnAgregarInsumo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown edExistReal;
        private System.Windows.Forms.ComboBox edInsumo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bindingSourceDetalle;
        private System.Windows.Forms.BindingSource bindingSourceInsumo;
        private System.Windows.Forms.TextBox edNotas;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox edExistTeorica;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripButton btnModificarDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNVENTARIODETIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNVENTARIOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNSUMOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colINSUMONOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNVENTARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEXISTREAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEXISTDIFERENCIA;
    }
}