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
    public partial class frmDetEntradaInsumo : Form
    {

        public ENTRADADET registro = null;
        public CRUDMode mode = CRUDMode.Create;
        public List<ENTRADADET> listaDetalle = null;

        public frmDetEntradaInsumo()
        {
            InitializeComponent();
        }

        private void frmDetEntradaInsumo_Load(object sender, EventArgs e)
        {

            string titulo = "";

            LoadWindowConfig();

            switch (mode)
            {
                /*
                case CRUDMode.Create:
                    registro = new INSUMO();
                    registro.TOTALENTRADAS = 0;
                    registro.TOTALSALIDAS = 0;
                    registro.EXISTENCIA = 0;
                    titulo = "Agregar insumo en inventario";
                    break;
                */
                case CRUDMode.Update:
                    MapearObjetoAPantalla();
                    titulo = "Modificar insumo en entrada de almacén";
                    break;

            }

            lbTitulo.Text = titulo;
            this.Text = titulo;

            edNombreInsumo.Focus();

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
                    listaDetalle.Add(registro);
                }

                this.DialogResult = DialogResult.OK;

            }

        }

        private bool ValidarCaptura()
        {

            bool result = false;
            string mensaje = "";

            if (edCantidad.Text == "")
            {
                mensaje += "Debe especificar la cantidad.\n";
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

            registro.CANTIDAD = edCantidad.Value;
            registro.NOTAS = edNotas.Text;

        }

        private void MapearObjetoAPantalla()
        {

            if (registro.INSUMO != null)
            {
                edNombreInsumo.Text = registro.INSUMO.NOMBRE;
            }
            edCantidad.Value = registro.CANTIDAD.Value;
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

        private void frmDetEntradaInsumo_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveWindowConfig();
        }

        private void frmDetEntradaInsumo_FormClosing(object sender, FormClosingEventArgs e)
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
