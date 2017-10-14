using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comparsa.Data;
using LinqToDB;
using LinqToDB.Data;
using QuanterLibNET;

namespace Comparsa
{
    public partial class frmDetColaborador : Form
    {

        public COLABORADOR registro = null;
        public CRUDMode mode = CRUDMode.Create;

        public frmDetColaborador()
        {
            InitializeComponent();
        }

        private void frmDetColaborador_Load(object sender, EventArgs e)
        {

            string titulo = "";

            LoadWindowConfig();

            switch (mode)
            {
                case CRUDMode.Create:
                    registro = new COLABORADOR();
                    titulo = "Agregar colaborador";
                    break;

                case CRUDMode.Update:
                    MapearObjetoAPantalla();
                    titulo = "Modificar colaborador";
                    break;

            }

            lbTitulo.Text = titulo;
            this.Text = titulo;

            edCodigo.Focus();

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CancelarCaptura();
        }

        private void CancelarCaptura()
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ConfirmarCaptura();
        }

        private void ConfirmarCaptura()
        {

            if (ValidarCaptura())
            {

                MapearPantallaAObjeto();

                using (var db = Globals.DataContext.CreateDataConnection())
                {

                    if (mode == CRUDMode.Create)
                    {
                        db.InsertWithIdentity(registro);
                    }
                    else if (mode == CRUDMode.Update)
                    {
                        db.Update(registro);
                    }

                }

                this.DialogResult = DialogResult.OK;

            }

        }

        private bool ValidarCaptura()
        {

            bool result = false;
            string mensaje = "";

            if (edCodigo.Text == "")
            {
                mensaje += "Debe especificar el código.\n";
            }

            if (edNombre.Text == "")
            {
                mensaje += "Debe especificar el nombre.\n";
            }

            if (mensaje != "")
            {
                AppUtils.MsgError(mensaje, "Error");
            }

            result = mensaje == "";

            return result;

        }

        private void MapearPantallaAObjeto()
        {
            registro.CODIGO = edCodigo.Text;
            registro.NOMBRE = edNombre.Text;
            registro.TELEFONO = edTelefono.Text;
            registro.EMAIL = edEmail.Text;
            registro.INSTITUCION = edInstitucion.Text;
            registro.REFERIDOPOR = edReferidoPor.Text;
            registro.ESBRIGADISTA = Convert.ToInt16((cbEsBrigadista.Checked ? 1 : 0));
            registro.ESDONANTE = Convert.ToInt16((cbEsDonante.Checked ? 1 : 0));
            registro.CALLE = edCalle.Text;
            registro.NUMEXT = edNumExt.Text;
            registro.NUMINT = edNumInt.Text;
            registro.COLONIA = edColonia.Text;
            registro.POBLACION = edPoblacion.Text;
            registro.MUNICIPIO = edMunicipio.Text;
            registro.ESTADO = edEstado.Text;
            registro.NOTAS = edNotas.Text;
        }

        private void MapearObjetoAPantalla()
        {
            edCodigo.Text = registro.CODIGO;
            edNombre.Text = registro.NOMBRE;
            edTelefono.Text = registro.TELEFONO;
            edEmail.Text = registro.EMAIL;
            edInstitucion.Text = registro.INSTITUCION;
            edReferidoPor.Text = registro.REFERIDOPOR;
            cbEsBrigadista.Checked = registro.ESBRIGADISTA == 1;
            cbEsDonante.Checked = registro.ESDONANTE == 1;
            edCalle.Text = registro.CALLE;
            edNumExt.Text = registro.NUMEXT;
            edNumInt.Text = registro.NUMINT;
            edColonia.Text = registro.COLONIA;
            edPoblacion.Text = registro.POBLACION;
            edMunicipio.Text = registro.MUNICIPIO;
            edEstado.Text = registro.ESTADO;
            edNotas.Text = registro.NOTAS;
        }

        private void LoadWindowConfig()
        {
            AppUtils.LoadWindowConfig(Globals.GXmlConfigUser, this, true, true, true);
        }

        private void SaveWindowConfig()
        {
            AppUtils.SaveWindowConfig(Globals.GXmlConfigUser, this, true, true, true);
        }

        private void frmDetColaborador_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveWindowConfig();
        }

        private void frmDetColaborador_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.Cancel)
            {
                if (!AppUtils.MsgConfirmation("¿Desea cancelar los cambios en el registro?", "Por favor confirme"))
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
