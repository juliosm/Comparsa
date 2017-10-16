namespace Comparsa
{
    partial class frmDetColaborador
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.edCodigo = new System.Windows.Forms.TextBox();
            this.edNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.edReferidoPor = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.edEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.edTelefono = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.edInstitucion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbEsDonante = new System.Windows.Forms.CheckBox();
            this.cbEsBrigadista = new System.Windows.Forms.CheckBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.edEstado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.edMunicipio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.edPoblacion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.edColonia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.edNumInt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.edNumExt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edCalle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.edNotas = new System.Windows.Forms.TextBox();
            this.tabAportaciones = new System.Windows.Forms.TabPage();
            this.checkListAportaciones = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabAportaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 37);
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
            this.lbTitulo.Size = new System.Drawing.Size(95, 17);
            this.lbTitulo.TabIndex = 2;
            this.lbTitulo.Text = "Colaborador";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnAceptar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 322);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(509, 58);
            this.panel2.TabIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(407, 15);
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
            this.btnAceptar.Location = new System.Drawing.Point(311, 15);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(90, 31);
            this.btnAceptar.TabIndex = 25;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(12, 45);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(46, 15);
            this.lbCodigo.TabIndex = 3;
            this.lbCodigo.Text = "Código";
            // 
            // edCodigo
            // 
            this.edCodigo.Location = new System.Drawing.Point(12, 65);
            this.edCodigo.Name = "edCodigo";
            this.edCodigo.ReadOnly = true;
            this.edCodigo.Size = new System.Drawing.Size(100, 23);
            this.edCodigo.TabIndex = 1;
            // 
            // edNombre
            // 
            this.edNombre.Location = new System.Drawing.Point(118, 65);
            this.edNombre.Name = "edNombre";
            this.edNombre.Size = new System.Drawing.Size(280, 23);
            this.edNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabAportaciones);
            this.tabControl1.Location = new System.Drawing.Point(12, 95);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(488, 219);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.edReferidoPor);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.edEmail);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.edTelefono);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.edInstitucion);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.cbEsDonante);
            this.tabPage2.Controls.Add(this.cbEsBrigadista);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(480, 191);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Generales";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // edReferidoPor
            // 
            this.edReferidoPor.Location = new System.Drawing.Point(184, 78);
            this.edReferidoPor.Name = "edReferidoPor";
            this.edReferidoPor.Size = new System.Drawing.Size(160, 23);
            this.edReferidoPor.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(184, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 15);
            this.label13.TabIndex = 13;
            this.label13.Text = "Referido por";
            // 
            // edEmail
            // 
            this.edEmail.Location = new System.Drawing.Point(184, 31);
            this.edEmail.Name = "edEmail";
            this.edEmail.Size = new System.Drawing.Size(160, 23);
            this.edEmail.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(184, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "Correo electrónico";
            // 
            // edTelefono
            // 
            this.edTelefono.Location = new System.Drawing.Point(18, 31);
            this.edTelefono.Name = "edTelefono";
            this.edTelefono.Size = new System.Drawing.Size(160, 23);
            this.edTelefono.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 15);
            this.label11.TabIndex = 9;
            this.label11.Text = "Teléfono";
            // 
            // edInstitucion
            // 
            this.edInstitucion.Location = new System.Drawing.Point(18, 78);
            this.edInstitucion.Name = "edInstitucion";
            this.edInstitucion.Size = new System.Drawing.Size(160, 23);
            this.edInstitucion.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "Institución";
            // 
            // cbEsDonante
            // 
            this.cbEsDonante.AutoSize = true;
            this.cbEsDonante.Location = new System.Drawing.Point(21, 111);
            this.cbEsDonante.Name = "cbEsDonante";
            this.cbEsDonante.Size = new System.Drawing.Size(71, 19);
            this.cbEsDonante.TabIndex = 5;
            this.cbEsDonante.Text = "Donante";
            this.cbEsDonante.UseVisualStyleBackColor = true;
            // 
            // cbEsBrigadista
            // 
            this.cbEsBrigadista.AutoSize = true;
            this.cbEsBrigadista.Location = new System.Drawing.Point(21, 136);
            this.cbEsBrigadista.Name = "cbEsBrigadista";
            this.cbEsBrigadista.Size = new System.Drawing.Size(78, 19);
            this.cbEsBrigadista.TabIndex = 6;
            this.cbEsBrigadista.Text = "Brigadista";
            this.cbEsBrigadista.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.edEstado);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.edMunicipio);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.edPoblacion);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.edColonia);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.edNumInt);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.edNumExt);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.edCalle);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(480, 193);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Domicilio";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // edEstado
            // 
            this.edEstado.Location = new System.Drawing.Point(242, 122);
            this.edEstado.Name = "edEstado";
            this.edEstado.Size = new System.Drawing.Size(218, 23);
            this.edEstado.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(242, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Estado";
            // 
            // edMunicipio
            // 
            this.edMunicipio.Location = new System.Drawing.Point(18, 122);
            this.edMunicipio.Name = "edMunicipio";
            this.edMunicipio.Size = new System.Drawing.Size(218, 23);
            this.edMunicipio.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Municipio";
            // 
            // edPoblacion
            // 
            this.edPoblacion.Location = new System.Drawing.Point(242, 75);
            this.edPoblacion.Name = "edPoblacion";
            this.edPoblacion.Size = new System.Drawing.Size(218, 23);
            this.edPoblacion.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Población";
            // 
            // edColonia
            // 
            this.edColonia.Location = new System.Drawing.Point(18, 75);
            this.edColonia.Name = "edColonia";
            this.edColonia.Size = new System.Drawing.Size(218, 23);
            this.edColonia.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Colonia";
            // 
            // edNumInt
            // 
            this.edNumInt.Location = new System.Drawing.Point(320, 31);
            this.edNumInt.Name = "edNumInt";
            this.edNumInt.Size = new System.Drawing.Size(72, 23);
            this.edNumInt.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Núm. int.";
            // 
            // edNumExt
            // 
            this.edNumExt.Location = new System.Drawing.Point(242, 31);
            this.edNumExt.Name = "edNumExt";
            this.edNumExt.Size = new System.Drawing.Size(72, 23);
            this.edNumExt.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Núm. ext.";
            // 
            // edCalle
            // 
            this.edCalle.Location = new System.Drawing.Point(18, 31);
            this.edCalle.Name = "edCalle";
            this.edCalle.Size = new System.Drawing.Size(218, 23);
            this.edCalle.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Calle";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.edNotas);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(480, 193);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Notas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // edNotas
            // 
            this.edNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edNotas.Location = new System.Drawing.Point(3, 3);
            this.edNotas.Multiline = true;
            this.edNotas.Name = "edNotas";
            this.edNotas.Size = new System.Drawing.Size(474, 187);
            this.edNotas.TabIndex = 0;
            // 
            // tabAportaciones
            // 
            this.tabAportaciones.Controls.Add(this.checkListAportaciones);
            this.tabAportaciones.Location = new System.Drawing.Point(4, 22);
            this.tabAportaciones.Name = "tabAportaciones";
            this.tabAportaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tabAportaciones.Size = new System.Drawing.Size(480, 193);
            this.tabAportaciones.TabIndex = 3;
            this.tabAportaciones.Text = "Aportaciones";
            this.tabAportaciones.UseVisualStyleBackColor = true;
            // 
            // checkListAportaciones
            // 
            this.checkListAportaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkListAportaciones.CheckOnClick = true;
            this.checkListAportaciones.FormattingEnabled = true;
            this.checkListAportaciones.Location = new System.Drawing.Point(6, 11);
            this.checkListAportaciones.Name = "checkListAportaciones";
            this.checkListAportaciones.Size = new System.Drawing.Size(291, 166);
            this.checkListAportaciones.TabIndex = 1;
            this.checkListAportaciones.SelectedIndexChanged += new System.EventHandler(this.checkListReqs_SelectedIndexChanged);
            // 
            // frmDetColaborador
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(509, 380);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.edNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edCodigo);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetColaborador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colaborador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDetColaborador_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDetColaborador_FormClosed);
            this.Load += new System.EventHandler(this.frmDetColaborador_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabAportaciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox edCodigo;
        private System.Windows.Forms.TextBox edNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox edEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox edMunicipio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox edPoblacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox edColonia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edNumInt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edNumExt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edCalle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox cbEsDonante;
        private System.Windows.Forms.CheckBox cbEsBrigadista;
        private System.Windows.Forms.TextBox edEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox edTelefono;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox edInstitucion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox edReferidoPor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox edNotas;
        private System.Windows.Forms.TabPage tabAportaciones;
        private System.Windows.Forms.CheckedListBox checkListAportaciones;
    }
}