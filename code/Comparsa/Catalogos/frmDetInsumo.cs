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
    public partial class frmDetInsumo : Form
    {

        public INSUMO registro = null;
        public CRUDMode mode = CRUDMode.Create;

        public frmDetInsumo()
        {
            InitializeComponent();
        }

        private void frmDetInsumo_Load(object sender, EventArgs e)
        {

            using (var db = Globals.DataContext.CreateDataConnection())
            {

                string titulo = "";

                LoadWindowConfig();

                CargarListados();

                edTipoInsumo.SelectedIndex = -1;

                switch (mode)
                {
                    case CRUDMode.Create:

                        registro = new INSUMO();
                        registro.TOTALENTRADAS = 0;
                        registro.TOTALSALIDAS = 0;
                        registro.EXISTENCIA = 0;

                        GenerarCodigo(db);

                        titulo = "Agregar insumo";

                        break;

                    case CRUDMode.Update:
                        MapearObjetoAPantalla();
                        titulo = "Modificar insumo";
                        break;

                }

                lbTitulo.Text = titulo;
                this.Text = titulo;

                edCodigo.Focus();

            }

        }

        private void frmDetInsumo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mode == CRUDMode.Create)
            {
                DesbloquearNumero();
            }
            SaveWindowConfig();
        }

        private void frmDetInsumo_FormClosing(object sender, FormClosingEventArgs e)
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

        private void GenerarCodigo(DataConnection db)
        {
            edCodigo.Text = Globals.DataContext.GenerarNumero(db, Consts.TIPO_CODIGO_INSUMO);
            edCodigo.Tag = Globals.DataContext.BloquearNumero(db, Consts.TIPO_CODIGO_INSUMO,
                edCodigo.Text);
        }

        private void DesbloquearNumero()
        {
            using (var db = Globals.DataContext.CreateDataConnection())
            {
                Globals.DataContext.DesbloquearNumero(db, (NUMEROBLOQ)edCodigo.Tag);
            }
        }

        private void CargarListados()
        {

            using (var db = Globals.DataContext.CreateDataConnection())
            {
                CargarComboTiposInsumos(db);
            }

        }

        private void CargarComboTiposInsumos(DataConnection db)
        {
            bindingSourceTipoInsumo.DataSource = db.GetTable<TIPOINSUMO>().ToList();
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

            if (edCodigo.Text == "")
            {
                mensaje += "Debe especificar el código.\n";
            }

            if (edNombre.Text == "")
            {
                mensaje += "Debe especificar el nombre.\n";
            }

            if (edTipoInsumo.Text == "")
            {
                mensaje += "Debe especificar el tipo de insumo.\n";
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
            registro.TIPOINSUMOID = Convert.ToInt32(edTipoInsumo.SelectedValue);
            registro.NOTAS = edNotas.Text;

        }

        private void MapearObjetoAPantalla()
        {

            using (var db = Globals.DataContext.CreateDataConnection())
            {

                var reg = db.GetTable<INSUMO>().LoadWith(a => a.TIPOINSUMO).FirstOrDefault(x => x.INSUMOID == registro.INSUMOID);

                edCodigo.Text = registro.CODIGO;
                edNombre.Text = registro.NOMBRE;
                edTipoInsumo.SelectedIndex = edTipoInsumo.FindStringExact(reg.TIPOINSUMO.NOMBRE);
                edExistencia.Text = registro.EXISTENCIA.ToString();
                edTotalEntradas.Text = registro.TOTALENTRADAS.ToString();
                edTotalSalidas.Text = registro.TOTALSALIDAS.ToString();
                edNotas.Text = registro.NOTAS;

            }

        }

        private void LoadWindowConfig()
        {
            AppUtils.LoadWindowConfig(Globals.GXmlConfigUser, this, false, true, true);
        }

        private void SaveWindowConfig()
        {
            AppUtils.SaveWindowConfig(Globals.GXmlConfigUser, this, false, true, true);
        }

    }

}
