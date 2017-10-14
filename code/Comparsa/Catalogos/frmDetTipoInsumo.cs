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
    public partial class frmDetTipoInsumo : Form
    {

        public TIPOINSUMO registro = null;
        public CRUDMode mode = CRUDMode.Create;

        public frmDetTipoInsumo()
        {
            InitializeComponent();
        }

        private void frmDetTipoInsumo_Load(object sender, EventArgs e)
        {

            string titulo = "";

            LoadWindowConfig();

            switch (mode)
            {
                case CRUDMode.Create:
                    registro = new TIPOINSUMO();
                    titulo = "Agregar tipo de insumo";
                    break;

                case CRUDMode.Update:
                    MapearObjetoAPantalla();
                    titulo = "Modificar tipo de insumo";
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

                using (var db = Globals.DataContext.CreateDataConnection())
                {

                    if (mode == CRUDMode.Create)
                    {
                        db.Insert(registro);
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
            registro.NOMBRE = edNombre.Text;
        }

        private void MapearObjetoAPantalla()
        {
            edNombre.Text = registro.NOMBRE;
        }

        private void LoadWindowConfig()
        {
            AppUtils.LoadWindowConfig(Globals.GXmlConfigUser, this, true, true, true);
        }

        private void SaveWindowConfig()
        {
            AppUtils.SaveWindowConfig(Globals.GXmlConfigUser, this, true, true, true);
        }

        private void frmDetTipoInsumo_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveWindowConfig();
        }

        private void frmDetTipoInsumo_FormClosing(object sender, FormClosingEventArgs e)
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
