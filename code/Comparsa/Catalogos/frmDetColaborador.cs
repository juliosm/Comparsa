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

            using (var db = Globals.DataContext.CreateDataConnection())
            {

                string titulo = "";

                LoadWindowConfig();

                CargarListados(db);

                switch (mode)
                {
                    case CRUDMode.Create:

                        registro = new COLABORADOR();

                        GenerarCodigo(db);

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

        }

        private void frmDetColaborador_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mode == CRUDMode.Create)
            {
                DesbloquearNumero();
            }
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

        private void GenerarCodigo(DataConnection db)
        {
            edCodigo.Text = Globals.DataContext.GenerarNumero(db, Consts.TIPO_CODIGO_COLABORADOR);
            edCodigo.Tag = Globals.DataContext.BloquearNumero(db, Consts.TIPO_CODIGO_COLABORADOR,
                edCodigo.Text);
        }

        private void DesbloquearNumero()
        {
            using (var db = Globals.DataContext.CreateDataConnection())
            {
                Globals.DataContext.DesbloquearNumero(db, (NUMEROBLOQ)edCodigo.Tag);
            }
        }

        public void SetBrigadista(bool flag)
        {
            cbEsBrigadista.Checked = flag;
        }

        public void SetDonante(bool flag)
        {
            cbEsDonante.Checked = flag;
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
                int id = 0;
                MapearPantallaAObjeto();

                using (var db = Globals.DataContext.CreateDataConnection())
                {

                    if (mode == CRUDMode.Create)
                    {
                        id = db.InsertWithInt32Identity(registro);
                        registro.COLABORADORID = id;
                    }
                    else if (mode == CRUDMode.Update)
                    {
                        db.Update(registro);
                    }

                    GuardarAportacionesColaborador(db);
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

            using (var db = Globals.DataContext.CreateDataConnection())
            {
                CargarAportacionesColaborador(db);
                
            }
        }

        private void LoadWindowConfig()
        {
            AppUtils.LoadWindowConfig(Globals.GXmlConfigUser, this, true, true, true);
        }

        private void SaveWindowConfig()
        {
            AppUtils.SaveWindowConfig(Globals.GXmlConfigUser, this, true, true, true);
        }

        private void CargarListaAportaciones(DataConnection db)
        {
            try
            {

                checkListAportaciones.BeginUpdate();

                checkListAportaciones.Items.Clear();

                foreach (var tipoInsumo in db.GetTable<TIPOINSUMO>().ToList())
                {
                    checkListAportaciones.Items.Add(tipoInsumo, false);
                }

                checkListAportaciones.ValueMember = "TIPOINSUMOID";
                checkListAportaciones.DisplayMember = "NOMBRE";

            }
            finally
            {
                checkListAportaciones.EndUpdate();
            }

        }

        private void CargarListados(DataConnection db)
        {
            CargarListaAportaciones(db);
        }

        private void GuardarAportacionesColaborador(DataConnection db)
        {

            // Borrar los proyectos relacionados que se hayan desmarcado
            List<object> deleteList = new List<object>();

            
            var reg = db.GetTable<COLABORADOR>().LoadWith(a => a.COLABORADORAPORTACOLABs).FirstOrDefault(x => x.COLABORADORID == registro.COLABORADORID);

            if (reg.COLABORADORAPORTACOLABs != null)
            {

                foreach (var colaboradorAportaColab in reg.COLABORADORAPORTACOLABs)
                {

                    var tipoInsumo = (
                        from t in db.GetTable<TIPOINSUMO>()
                        where t.TIPOINSUMOID == colaboradorAportaColab.TIPOINSUMOID
                        select t).FirstOrDefault();

                    int itemIndex = checkListAportaciones.FindStringExact(tipoInsumo.NOMBRE);

                    if (itemIndex != -1)
                    {
                        if (checkListAportaciones.GetItemChecked(itemIndex) == false)
                        {
                            deleteList.Add(colaboradorAportaColab);
                        }
                    }

                }

                foreach (COLABORADORAPORTA colaboradorAporta in deleteList)
                {
                    db.Delete(colaboradorAporta);
                }

            }
            // Guardar los proyectos relacionados que se hayan marcado
            foreach (object item in checkListAportaciones.CheckedItems)
            {

                int tipoInsumoId = 0;

                tipoInsumoId = ((TIPOINSUMO)item).TIPOINSUMOID;

                COLABORADORAPORTA colaboradorAporta = null;

                if (reg.COLABORADORAPORTACOLABs != null)
                {
                    colaboradorAporta = reg.COLABORADORAPORTACOLABs.FirstOrDefault(
                        x => x.TIPOINSUMOID == tipoInsumoId);
                }

                if (colaboradorAporta == null)
                {

                    colaboradorAporta = new COLABORADORAPORTA();
                    colaboradorAporta.TIPOINSUMOID = tipoInsumoId;
                    colaboradorAporta.COLABORADORID = reg.COLABORADORID;

                    db.Insert(colaboradorAporta);

                }

            }

        }


        private void CargarAportacionesColaborador(DataConnection db)
        {

            var reg = db.GetTable<COLABORADOR>().LoadWith(a => a.COLABORADORAPORTACOLABs).FirstOrDefault(x => x.COLABORADORID == registro.COLABORADORID);

            foreach (var colaboradorAportaColab in reg.COLABORADORAPORTACOLABs)
            {

                var tipoInsumo = (
                    from t in db.GetTable<TIPOINSUMO>()
                    where t.TIPOINSUMOID == colaboradorAportaColab.TIPOINSUMOID
                    select t).FirstOrDefault();

                int itemIndex = checkListAportaciones.FindStringExact(tipoInsumo.NOMBRE);

                if (itemIndex != -1)
                {
                    checkListAportaciones.SetItemChecked(itemIndex, true);
                }

            }

        }
        private void checkListReqs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
