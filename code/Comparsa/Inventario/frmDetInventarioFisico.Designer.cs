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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.menuDetalle = new System.Windows.Forms.ToolStrip();
            this.btnQuitarInsumo = new System.Windows.Forms.ToolStripButton();
            this.label5 = new System.Windows.Forms.Label();
            this.edInsumo = new System.Windows.Forms.ComboBox();
            this.edCantidad = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregarInsumo = new System.Windows.Forms.Button();
            this.nOMBREINSUMODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNVENTARIODETIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNVENTARIOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNSUMOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOCKTEORICODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOCKREALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOCKDIFERENCIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNSUMODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNVENTARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceDetalle = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceInsumo = new System.Windows.Forms.BindingSource(this.components);
            this.edNotas = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.menuDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInsumo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 37);
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
            this.panel2.Size = new System.Drawing.Size(641, 58);
            this.panel2.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(539, 15);
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
            this.btnAceptar.Location = new System.Drawing.Point(443, 15);
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
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.menuDetalle);
            this.panel3.Location = new System.Drawing.Point(12, 199);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(615, 243);
            this.panel3.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nOMBREINSUMODataGridViewTextBoxColumn,
            this.iNVENTARIODETIDDataGridViewTextBoxColumn,
            this.iNVENTARIOIDDataGridViewTextBoxColumn,
            this.iNSUMOIDDataGridViewTextBoxColumn,
            this.sTOCKTEORICODataGridViewTextBoxColumn,
            this.sTOCKREALDataGridViewTextBoxColumn,
            this.sTOCKDIFERENCIADataGridViewTextBoxColumn,
            this.iNSUMODataGridViewTextBoxColumn,
            this.iNVENTARIODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSourceDetalle;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 65);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(615, 178);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAgregarInsumo);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.edCantidad);
            this.panel4.Controls.Add(this.edInsumo);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(615, 40);
            this.panel4.TabIndex = 0;
            // 
            // menuDetalle
            // 
            this.menuDetalle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQuitarInsumo});
            this.menuDetalle.Location = new System.Drawing.Point(0, 0);
            this.menuDetalle.Name = "menuDetalle";
            this.menuDetalle.Size = new System.Drawing.Size(615, 25);
            this.menuDetalle.TabIndex = 1;
            this.menuDetalle.Text = "toolStrip1";
            // 
            // btnQuitarInsumo
            // 
            this.btnQuitarInsumo.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitarInsumo.Image")));
            this.btnQuitarInsumo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuitarInsumo.Name = "btnQuitarInsumo";
            this.btnQuitarInsumo.Size = new System.Drawing.Size(60, 22);
            this.btnQuitarInsumo.Text = "Quitar";
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
            // edInsumo
            // 
            this.edInsumo.FormattingEnabled = true;
            this.edInsumo.Location = new System.Drawing.Point(55, 8);
            this.edInsumo.Name = "edInsumo";
            this.edInsumo.Size = new System.Drawing.Size(198, 23);
            this.edInsumo.TabIndex = 1;
            // 
            // edCantidad
            // 
            this.edCantidad.Location = new System.Drawing.Point(315, 8);
            this.edCantidad.Name = "edCantidad";
            this.edCantidad.Size = new System.Drawing.Size(82, 23);
            this.edCantidad.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Exist. real";
            // 
            // btnAgregarInsumo
            // 
            this.btnAgregarInsumo.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarInsumo.Image")));
            this.btnAgregarInsumo.Location = new System.Drawing.Point(409, 5);
            this.btnAgregarInsumo.Name = "btnAgregarInsumo";
            this.btnAgregarInsumo.Size = new System.Drawing.Size(81, 28);
            this.btnAgregarInsumo.TabIndex = 3;
            this.btnAgregarInsumo.Text = "Agregar";
            this.btnAgregarInsumo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarInsumo.UseVisualStyleBackColor = true;
            this.btnAgregarInsumo.Click += new System.EventHandler(this.btnAgregarInsumo_Click);
            // 
            // nOMBREINSUMODataGridViewTextBoxColumn
            // 
            this.nOMBREINSUMODataGridViewTextBoxColumn.DataPropertyName = "NOMBREINSUMO";
            this.nOMBREINSUMODataGridViewTextBoxColumn.HeaderText = "Insumo";
            this.nOMBREINSUMODataGridViewTextBoxColumn.Name = "nOMBREINSUMODataGridViewTextBoxColumn";
            this.nOMBREINSUMODataGridViewTextBoxColumn.ReadOnly = true;
            this.nOMBREINSUMODataGridViewTextBoxColumn.Width = 200;
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
            // sTOCKTEORICODataGridViewTextBoxColumn
            // 
            this.sTOCKTEORICODataGridViewTextBoxColumn.DataPropertyName = "STOCKTEORICO";
            this.sTOCKTEORICODataGridViewTextBoxColumn.HeaderText = "Exist. teórica";
            this.sTOCKTEORICODataGridViewTextBoxColumn.Name = "sTOCKTEORICODataGridViewTextBoxColumn";
            this.sTOCKTEORICODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTOCKREALDataGridViewTextBoxColumn
            // 
            this.sTOCKREALDataGridViewTextBoxColumn.DataPropertyName = "STOCKREAL";
            this.sTOCKREALDataGridViewTextBoxColumn.HeaderText = "Exist. real";
            this.sTOCKREALDataGridViewTextBoxColumn.Name = "sTOCKREALDataGridViewTextBoxColumn";
            this.sTOCKREALDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTOCKDIFERENCIADataGridViewTextBoxColumn
            // 
            this.sTOCKDIFERENCIADataGridViewTextBoxColumn.DataPropertyName = "STOCKDIFERENCIA";
            this.sTOCKDIFERENCIADataGridViewTextBoxColumn.HeaderText = "Diferencia";
            this.sTOCKDIFERENCIADataGridViewTextBoxColumn.Name = "sTOCKDIFERENCIADataGridViewTextBoxColumn";
            this.sTOCKDIFERENCIADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iNSUMODataGridViewTextBoxColumn
            // 
            this.iNSUMODataGridViewTextBoxColumn.DataPropertyName = "INSUMO";
            this.iNSUMODataGridViewTextBoxColumn.HeaderText = "INSUMO";
            this.iNSUMODataGridViewTextBoxColumn.Name = "iNSUMODataGridViewTextBoxColumn";
            this.iNSUMODataGridViewTextBoxColumn.ReadOnly = true;
            this.iNSUMODataGridViewTextBoxColumn.Visible = false;
            // 
            // iNVENTARIODataGridViewTextBoxColumn
            // 
            this.iNVENTARIODataGridViewTextBoxColumn.DataPropertyName = "INVENTARIO";
            this.iNVENTARIODataGridViewTextBoxColumn.HeaderText = "INVENTARIO";
            this.iNVENTARIODataGridViewTextBoxColumn.Name = "iNVENTARIODataGridViewTextBoxColumn";
            this.iNVENTARIODataGridViewTextBoxColumn.ReadOnly = true;
            this.iNVENTARIODataGridViewTextBoxColumn.Visible = false;
            // 
            // bindingSourceDetalle
            // 
            this.bindingSourceDetalle.DataSource = typeof(Comparsa.Data.INVENTARIODET_EXT);
            // 
            // bindingSourceInsumo
            // 
            this.bindingSourceInsumo.DataSource = typeof(Comparsa.Data.INSUMO);
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
            this.ClientSize = new System.Drawing.Size(641, 516);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuDetalle.ResumeLayout(false);
            this.menuDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInsumo)).EndInit();
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip menuDetalle;
        private System.Windows.Forms.ToolStripButton btnQuitarInsumo;
        private System.Windows.Forms.Button btnAgregarInsumo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown edCantidad;
        private System.Windows.Forms.ComboBox edInsumo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bindingSourceDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREINSUMODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNVENTARIODETIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNVENTARIOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNSUMOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOCKTEORICODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOCKREALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOCKDIFERENCIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNSUMODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNVENTARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSourceInsumo;
        private System.Windows.Forms.TextBox edNotas;
        private System.Windows.Forms.Label label13;
    }
}