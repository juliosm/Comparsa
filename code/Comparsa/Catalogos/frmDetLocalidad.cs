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
    public partial class frmDetLocalidad : Form
    {

        public LOCALIDAD registro = null;
        public CRUDMode mode = CRUDMode.Create;

        public frmDetLocalidad()
        {
            InitializeComponent();
        }

        private void frmDetLocalidad_Load(object sender, EventArgs e)
        {

            string titulo = "";

            LoadWindowConfig();

            switch (mode)
            {
                case CRUDMode.Create:
                    registro = new LOCALIDAD();
                    titulo = "Agregar localidad";
                    break;

                case CRUDMode.Update:
                    MapearObjetoAPantalla();
                    titulo = "Modificar localidad";
                    break;

            }

            lbTitulo.Text = titulo;
            this.Text = titulo;

            edNombre.Focus();

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

                if (mode == CRUDMode.Create)
                {
                    Globals.DataContext.DataConnection.Insert(registro);
                }
                else if (mode == CRUDMode.Update)
                {
                    Globals.DataContext.DataConnection.Update(registro);
                }

                this.DialogResult = DialogResult.OK;

            }

        }

        private bool ValidarCaptura()
        {

            bool result = false;
            string mensaje = "";

            if (edNombre.Text == "")
            {
                mensaje += "Debe especificar el nombre.\n";
            }

            if (edMunicipio.Text == "")
            {
                mensaje += "Debe especificar el municipio.\n";
            }

            if (edEstado.Text == "")
            {
                mensaje += "Debe especificar el estado.\n";
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
            registro.NOMBRE = edNombre.Text;
            registro.MUNICIPIO = edMunicipio.Text;
            registro.ESTADO = edEstado.Text;
            registro.NOTAS = edNotas.Text;
        }

        private void MapearObjetoAPantalla()
        {
            edNombre.Text = registro.NOMBRE;
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

        private void frmDetLocalidad_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveWindowConfig();
        }

        private void frmDetLocalidad_FormClosing(object sender, FormClosingEventArgs e)
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
