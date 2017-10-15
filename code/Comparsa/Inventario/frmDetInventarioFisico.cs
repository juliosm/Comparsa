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
    public partial class frmDetInventarioFisico : Form
    {

        public INVENTARIO registro = null;
        public CRUDMode mode = CRUDMode.Create;

        private List<INVENTARIODET_EXT> listaDetalle = null;

        public frmDetInventarioFisico()
        {
            InitializeComponent();
        }

        private void frmDetInventarioFisico_Load(object sender, EventArgs e)
        {

            using (var db = Globals.DataContext.CreateDataConnection())
            {

                string titulo = "";

                LoadWindowConfig();

                listaDetalle = new List<INVENTARIODET_EXT>();

                CargarComboInsumos(db);
                edInsumo.SelectedIndex = -1;

                switch (mode)
                {
                    case CRUDMode.Create:
                        registro = new INVENTARIO();
                        titulo = "Nuevo inventario físico";

                        GenerarNumero(db);

                        edFecha.Value = DateTime.Now.Date;
                        edHora.Value = Consts.BaseDateTime.Add(DateTime.Now.TimeOfDay);

                        break;

                    case CRUDMode.Update:
                        MapearObjetoAPantalla();
                        titulo = "Modificar inventario físico";
                        break;

                }

                lbTitulo.Text = titulo;
                this.Text = titulo;

                bindingSourceDetalle.DataSource = listaDetalle;

                edNumero.Focus();

            }

        }

        private void frmDetInventarioFisico_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mode == CRUDMode.Create)
            {
                DesbloquearNumero();
            }
            SaveWindowConfig();
        }

        private void frmDetInventarioFisico_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.Cancel)
            {
                if (!AppUtils.MsgConfirmation("¿Desea cancelar los cambios en el registro?", "Por favor confirme"))
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CancelarCaptura();
        }

        private void CancelarCaptura()
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void GenerarNumero(DataConnection db)
        {

            edNumero.Text = Globals.DataContext.GenerarNumero(db, Consts.TIPO_NUMERO_INVENTARIO);
            edNumero.Tag = Globals.DataContext.BloquearNumero(db, Consts.TIPO_NUMERO_INVENTARIO,
                edNumero.Text);

        }

        private void CargarComboInsumos(DataConnection db)
        {
            bindingSourceInsumo.DataSource = db.GetTable<INSUMO>().ToList();
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

            if (edNumero.Text == "")
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
            registro.NUMERO = edNumero.Text;
        }

        private void MapearObjetoAPantalla()
        {
            edNumero.Text = registro.NUMERO;
        }

        private void LoadWindowConfig()
        {
            AppUtils.LoadWindowConfig(Globals.GXmlConfigUser, this, true, true, true);
        }

        private void SaveWindowConfig()
        {
            AppUtils.SaveWindowConfig(Globals.GXmlConfigUser, this, true, true, true);
        }

        private void DesbloquearNumero()
        {
            using (var db = Globals.DataContext.CreateDataConnection())
            {
                Globals.DataContext.DesbloquearNumero(db, (NUMEROBLOQ)edNumero.Tag);
            }
        }

        private void btnAgregarInsumo_Click(object sender, EventArgs e)
        {
            AgregarInsumo();
        }

        private void AgregarInsumo()
        {
            //
        }

    }

}
