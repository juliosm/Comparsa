namespace Comparsa
{
    partial class frmDetInsumo
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
            this.edNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.edNotas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edTipoInsumo = new System.Windows.Forms.ComboBox();
            this.bindingSourceTipoInsumo = new System.Windows.Forms.BindingSource(this.components);
            this.edExistencia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edTotalEntradas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.edTotalSalidas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoInsumo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 37);
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
            this.lbTitulo.Size = new System.Drawing.Size(59, 17);
            this.lbTitulo.TabIndex = 2;
            this.lbTitulo.Text = "Insumo";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnAceptar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 296);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 58);
            this.panel2.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(281, 15);
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
            this.btnAceptar.Location = new System.Drawing.Point(185, 15);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(90, 31);
            this.btnAceptar.TabIndex = 25;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // edNombre
            // 
            this.edNombre.Location = new System.Drawing.Point(140, 71);
            this.edNombre.Name = "edNombre";
            this.edNombre.Size = new System.Drawing.Size(218, 23);
            this.edNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Tipo de insumo";
            // 
            // edNotas
            // 
            this.edNotas.Location = new System.Drawing.Point(16, 206);
            this.edNotas.Multiline = true;
            this.edNotas.Name = "edNotas";
            this.edNotas.Size = new System.Drawing.Size(342, 76);
            this.edNotas.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Notas";
            // 
            // edCodigo
            // 
            this.edCodigo.Location = new System.Drawing.Point(16, 71);
            this.edCodigo.Name = "edCodigo";
            this.edCodigo.ReadOnly = true;
            this.edCodigo.Size = new System.Drawing.Size(118, 23);
            this.edCodigo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Código";
            // 
            // edTipoInsumo
            // 
            this.edTipoInsumo.DataSource = this.bindingSourceTipoInsumo;
            this.edTipoInsumo.DisplayMember = "NOMBRE";
            this.edTipoInsumo.FormattingEnabled = true;
            this.edTipoInsumo.Location = new System.Drawing.Point(16, 116);
            this.edTipoInsumo.Name = "edTipoInsumo";
            this.edTipoInsumo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edTipoInsumo.Size = new System.Drawing.Size(218, 23);
            this.edTipoInsumo.TabIndex = 3;
            this.edTipoInsumo.ValueMember = "TIPOINSUMOID";
            // 
            // bindingSourceTipoInsumo
            // 
            this.bindingSourceTipoInsumo.DataSource = typeof(Comparsa.Data.TIPOINSUMO);
            // 
            // edExistencia
            // 
            this.edExistencia.Location = new System.Drawing.Point(240, 116);
            this.edExistencia.Name = "edExistencia";
            this.edExistencia.ReadOnly = true;
            this.edExistencia.Size = new System.Drawing.Size(118, 23);
            this.edExistencia.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Existencia";
            // 
            // edTotalEntradas
            // 
            this.edTotalEntradas.Location = new System.Drawing.Point(16, 161);
            this.edTotalEntradas.Name = "edTotalEntradas";
            this.edTotalEntradas.ReadOnly = true;
            this.edTotalEntradas.Size = new System.Drawing.Size(118, 23);
            this.edTotalEntradas.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "Total entradas";
            // 
            // edTotalSalidas
            // 
            this.edTotalSalidas.Location = new System.Drawing.Point(140, 161);
            this.edTotalSalidas.Name = "edTotalSalidas";
            this.edTotalSalidas.ReadOnly = true;
            this.edTotalSalidas.Size = new System.Drawing.Size(118, 23);
            this.edTotalSalidas.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "Total salidas";
            // 
            // frmDetInsumo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(383, 354);
            this.Controls.Add(this.edTotalSalidas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.edTotalEntradas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edExistencia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edTipoInsumo);
            this.Controls.Add(this.edCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edNotas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.edNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetInsumo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insumo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDetInsumo_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDetInsumo_FormClosed);
            this.Load += new System.EventHandler(this.frmDetInsumo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoInsumo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox edNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox edNotas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox edTipoInsumo;
        private System.Windows.Forms.TextBox edExistencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edTotalEntradas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edTotalSalidas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource bindingSourceTipoInsumo;
    }
}