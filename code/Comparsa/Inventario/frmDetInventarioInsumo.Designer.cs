namespace Comparsa
{
    partial class frmDetInventarioInsumo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.edNombreInsumo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edNotas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSourceTipoInsumo = new System.Windows.Forms.BindingSource(this.components);
            this.edDiferencia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edExistTeorica = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.edExistReal = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoInsumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edExistReal)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 37);
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
            this.lbTitulo.Size = new System.Drawing.Size(153, 17);
            this.lbTitulo.TabIndex = 2;
            this.lbTitulo.Text = "Insumo en inventario";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnAceptar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 318);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 58);
            this.panel2.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(233, 15);
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
            this.btnAceptar.Location = new System.Drawing.Point(137, 15);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(90, 31);
            this.btnAceptar.TabIndex = 25;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // edNombreInsumo
            // 
            this.edNombreInsumo.Location = new System.Drawing.Point(16, 71);
            this.edNombreInsumo.Name = "edNombreInsumo";
            this.edNombreInsumo.ReadOnly = true;
            this.edNombreInsumo.Size = new System.Drawing.Size(303, 23);
            this.edNombreInsumo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Insumo";
            // 
            // edNotas
            // 
            this.edNotas.Location = new System.Drawing.Point(16, 168);
            this.edNotas.Multiline = true;
            this.edNotas.Name = "edNotas";
            this.edNotas.Size = new System.Drawing.Size(303, 129);
            this.edNotas.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Notas";
            // 
            // bindingSourceTipoInsumo
            // 
            this.bindingSourceTipoInsumo.DataSource = typeof(Comparsa.Data.TIPOINSUMO);
            // 
            // edDiferencia
            // 
            this.edDiferencia.Location = new System.Drawing.Point(222, 122);
            this.edDiferencia.Name = "edDiferencia";
            this.edDiferencia.ReadOnly = true;
            this.edDiferencia.Size = new System.Drawing.Size(97, 23);
            this.edDiferencia.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Diferencia";
            // 
            // edExistTeorica
            // 
            this.edExistTeorica.Location = new System.Drawing.Point(16, 122);
            this.edExistTeorica.Name = "edExistTeorica";
            this.edExistTeorica.ReadOnly = true;
            this.edExistTeorica.Size = new System.Drawing.Size(97, 23);
            this.edExistTeorica.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "Exist. teórica";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "Exist. real";
            // 
            // edExistReal
            // 
            this.edExistReal.Location = new System.Drawing.Point(119, 122);
            this.edExistReal.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.edExistReal.Name = "edExistReal";
            this.edExistReal.Size = new System.Drawing.Size(97, 23);
            this.edExistReal.TabIndex = 33;
            this.edExistReal.ValueChanged += new System.EventHandler(this.edExistReal_ValueChanged);
            // 
            // frmDetInventarioInsumo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(335, 376);
            this.Controls.Add(this.edExistReal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.edExistTeorica);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edDiferencia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edNotas);
            this.Controls.Add(this.edNombreInsumo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetInventarioInsumo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insumo en inventario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDetInventarioInsumo_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDetInventarioInsumo_FormClosed);
            this.Load += new System.EventHandler(this.frmDetInventarioInsumo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoInsumo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edExistReal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox edNombreInsumo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edNotas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edDiferencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edExistTeorica;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource bindingSourceTipoInsumo;
        private System.Windows.Forms.NumericUpDown edExistReal;
    }
}