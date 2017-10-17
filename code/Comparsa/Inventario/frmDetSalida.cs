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
    public partial class frmDetSalida : Form
    {

        public SALIDA registro = null;
        public CRUDMode mode = CRUDMode.Create;

        private List<SALIDADET> listaDetalle = null;
        private List<INSUMO> listaInsumos = null;

        private INSUMO insumoSeleccionado = null;
        private COLABORADOR responsableSeleccionado = null;
        private LOCALIDAD localidadSeleccionada = null;

        public frmDetSalida()
        {
            InitializeComponent();
        }

        private void frmDetSalida_Load(object sender, EventArgs e)
        {

            using (var db = Globals.DataContext.CreateDataConnection())
            {

                string titulo = "";

                LoadWindowConfig();

                listaDetalle = new List<SALIDADET>();
                listaInsumos = new List<INSUMO>();

                CargarComboInsumos(db);
                edInsumo.SelectedIndex = -1;

                CargarComboLocalidades(db);
                edLocalidad.SelectedIndex = -1;

                switch (mode)
                {
                    case CRUDMode.Create:

                        registro = new SALIDA();

                        titulo = "Nueva salida de almacén";

                        GenerarNumero(db);

                        edFecha.Value = DateTime.Now.Date;
                        edHora.Value = Consts.BaseDateTime.Add(DateTime.Now.TimeOfDay);

                        break;

                    case CRUDMode.Update:
                        MapearObjetoAPantalla(db);
                        titulo = "Modificar salida de almacén";
                        break;

                }

                lbTitulo.Text = titulo;
                this.Text = titulo;

                bindingSourceDetalle.DataSource = listaDetalle;

                edInsumo.Focus();

            }

        }

        private void frmDetSalida_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mode == CRUDMode.Create)
            {
                DesbloquearNumero();
            }
            SaveWindowConfig();
        }

        private void frmDetSalida_FormClosing(object sender, FormClosingEventArgs e)
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

            edNumero.Text = Globals.DataContext.GenerarNumero(db, Consts.TIPO_NUMERO_SALIDA_ALMACEN);
            edNumero.Tag = Globals.DataContext.BloquearNumero(db, Consts.TIPO_NUMERO_SALIDA_ALMACEN,
                edNumero.Text);

        }

        private void CargarComboInsumos(DataConnection db)
        {
            listaInsumos = db.GetTable<INSUMO>().ToList();
            bindingSourceInsumo.DataSource = listaInsumos;
        }

        private void CargarComboLocalidades(DataConnection db)
        {
            bindingSourceLocalidad.DataSource = db.GetTable<LOCALIDAD>().ToList();
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

                    int id = 0;

                    if (mode == CRUDMode.Create)
                    {
                        id = Convert.ToInt32(db.InsertWithIdentity(registro));
                        registro.SALIDAID = id;
                    }
                    else if (mode == CRUDMode.Update)
                    {
                        db.Update(registro);
                    }

                    GuardarDetalle(db);

                }

                this.DialogResult = DialogResult.OK;

            }

        }

        private void GuardarDetalle(DataConnection db)
        {

            // Borrar los proyectos relacionados que se hayan desmarcado
            List<object> deleteList = new List<object>();

            if (mode != CRUDMode.Create)
            {

                var reg = db.GetTable<SALIDA>().LoadWith(a => a.SALIDADETs).FirstOrDefault(x => x.SALIDAID == registro.SALIDAID);

                if (reg != null)
                {

                    if (reg.SALIDADETs != null)
                    {

                        foreach (var entradaDet in reg.SALIDADETs)
                        {

                            bool found = listaDetalle.FirstOrDefault(x => x.SALIDADETID == entradaDet.SALIDADETID) != null;

                            if (!found)
                            {
                                deleteList.Add(entradaDet);
                            }

                        }

                        foreach (var entradaDet in deleteList)
                        {
                            db.Delete(entradaDet);
                        }

                    }

                }

            }

            // Guardar los registros detalle
            foreach (var entradaDet in listaDetalle)
            {

                if (entradaDet.SALIDAID == 0)
                {
                    entradaDet.SALIDAID = registro.SALIDAID;
                }

                db.InsertOrReplace(entradaDet);

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

            if (edFecha.Text == "")
            {
                mensaje += "Debe especificar la fecha.\n";
            }

            if (edHora.Text == "")
            {
                mensaje += "Debe especificar la hora.\n";
            }

            if (localidadSeleccionada == null)
            {
                mensaje += "Debe especificar la localidad.\n";
            }

            if (responsableSeleccionado == null)
            {
                mensaje += "Debe especificar el responsable.\n";
            }

            if (listaDetalle.Count == 0)
            {
                mensaje += "Debe especificar al menos un insumo.\n";
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
            registro.FECHA = edFecha.Value;
            registro.HORA = edHora.Value.TimeOfDay;
            registro.NOTAS = edNotas.Text;
            if (responsableSeleccionado != null)
            {
                registro.RESPONSABLEID = responsableSeleccionado.COLABORADORID;
            }
            if (localidadSeleccionada != null)
            {
                registro.LOCALIDADID = localidadSeleccionada.LOCALIDADID;
            }

        }

        private void MapearObjetoAPantalla(DataConnection db)
        {

            registro.RESPONSABLE = db.GetTable<COLABORADOR>().FirstOrDefault(x => x.COLABORADORID == registro.RESPONSABLEID);
            registro.LOCALIDAD = db.GetTable<LOCALIDAD>().FirstOrDefault(x => x.LOCALIDADID == registro.LOCALIDADID);

            responsableSeleccionado = registro.RESPONSABLE;
            localidadSeleccionada = registro.LOCALIDAD;

            edNumero.Text = registro.NUMERO;
            edFecha.Value = registro.FECHA.Value;
            edHora.Value = Consts.BaseDateTime.Add(registro.HORA.Value);
            edNotas.Text = registro.NOTAS;
            if (responsableSeleccionado != null)
            {
                edResponsable.Text = responsableSeleccionado.NOMBRE;
            }
            if (localidadSeleccionada != null)
            {
                edLocalidad.SelectedIndex = edLocalidad.FindStringExact(localidadSeleccionada.NOMBRE);
            }

            CargarDetalle(db);

        }

        private void CargarDetalle(DataConnection db)
        {

            var q = (
                from d in db.GetTable<SALIDADET>().LoadWith(a => a.INSUMO)
                where
                    (d.SALIDAID == registro.SALIDAID)
                select d);

            foreach (var salidaDet in q)
            {
                listaDetalle.Add(salidaDet);
            }

            bindingSourceDetalle.ResetBindings(false);

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

            if (ValidarInsumo())
            {

                SALIDADET salidaDet = new SALIDADET();
                salidaDet.INSUMOID = insumoSeleccionado.INSUMOID;
                salidaDet.INSUMO = insumoSeleccionado;
                salidaDet.CANTIDAD = edCantidad.Value;
                salidaDet.CANTIDADRET = 0;

                listaDetalle.Add(salidaDet);

                bindingSourceDetalle.ResetBindings(false);

                LimpiarInsumo();

            }

            edInsumo.Focus();

        }

        private bool ValidarInsumo()
        {

            string mensaje = "";
            bool result = false;

            if (edInsumo.Text == "")
            {
                mensaje += "Debe seleccionar el insumo.\n";
            }
            else
            {

                // Validar que el insumo no se encuentre ya agregado
                if (listaDetalle.FirstOrDefault(x => x.INSUMOID == insumoSeleccionado.INSUMOID) != null)
                {
                    mensaje += string.Format("El insumo {0} ya se encuentra agregado.\n", edInsumo.Text);
                }

            }

            result = mensaje == "";

            if (mensaje != "")
            {
                AppUtils.MsgError(mensaje, "Error");
            }

            return result;

        }

        private void LimpiarInsumo()
        {
            edInsumo.SelectedIndex = -1;
            edCantidad.Value = 0;
        }

        private void edInsumo_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefrescarInsumoSeleccionado();
        }

        private void RefrescarInsumoSeleccionado()
        {

            if (edInsumo.Text != "")
            {

                int insumoId = Convert.ToInt32(edInsumo.SelectedValue);
                insumoSeleccionado = listaInsumos.FirstOrDefault(x => x.INSUMOID == insumoId);

                if (insumoSeleccionado != null)
                {

                    decimal existencia = 0;

                    if (insumoSeleccionado.EXISTENCIA.HasValue)
                    {
                        existencia = insumoSeleccionado.EXISTENCIA.Value;
                    }

                    edExistTeorica.Text = existencia.ToString();

                }

            }
            else
            {
                insumoSeleccionado = null;
                edExistTeorica.Text = "0";
            }

        }

        private void gridViewDetalle_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            var registro = gridViewDetalle.Rows[e.RowIndex].DataBoundItem;

            if ((gridViewDetalle.Rows[e.RowIndex].DataBoundItem != null) &&
                (gridViewDetalle.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                e.Value = AppUtils.BindProperty(
                        registro,
                        gridViewDetalle.Columns[e.ColumnIndex].DataPropertyName
                      );
            }

        }

        private void btnModificarDetalle_Click(object sender, EventArgs e)
        {
            ModificarDetalle();
        }

        private void btnQuitarInsumo_Click(object sender, EventArgs e)
        {
            QuitarDetalle();
        }

        private bool ModificarDetalle()
        {

            bool result = false;

            if (gridViewDetalle.SelectedRows.Count > 0)
            {
                if (InfoRegistroDetalle(CRUDMode.Update))
                {
                    bindingSourceDetalle.ResetBindings(false);
                }
            }

            return result;

        }

        private bool QuitarDetalle()
        {

            bool result = false;

            if (gridViewDetalle.SelectedRows.Count > 0)
            {

                DataGridViewRow row = null;
                SALIDADET registro = null;

                row = gridViewDetalle.SelectedRows[0];
                registro = (SALIDADET)row.DataBoundItem;

                if (registro != null)
                {

                    if (AppUtils.MsgConfirmation("¿Desea borrar el registro seleccionado?", "Por favor confirme"))
                    {

                        int index = listaDetalle.IndexOf(registro);

                        listaDetalle.RemoveAt(index);

                        gridViewDetalle.CellFormatting -= gridViewDetalle_CellFormatting; 

                        bindingSourceDetalle.ResetBindings(true);

                        gridViewDetalle.CellFormatting += gridViewDetalle_CellFormatting;

                    }

                }

            }

            return result;

        }

        private bool InfoRegistroDetalle(CRUDMode mode)
        {

            bool result = false;
            DialogResult dr = DialogResult.Cancel;

            DataGridViewRow row = null;
            SALIDADET registro = null;

            if (mode == CRUDMode.Update)
            {
                row = gridViewDetalle.SelectedRows[0];
                registro = (SALIDADET)row.DataBoundItem;
            }

            frmDetSalidaInsumo frmDetSalidaInsumo = new frmDetSalidaInsumo();
            frmDetSalidaInsumo.mode = mode;
            if (mode == CRUDMode.Update)
            {
                frmDetSalidaInsumo.registro = registro;
            }
            dr = frmDetSalidaInsumo.ShowDialog();
            frmDetSalidaInsumo.Dispose();
            frmDetSalidaInsumo = null;

            result = dr == DialogResult.OK;

            return result;

        }

        private bool BuscarResponsable()
        {

            bool result = false;
            DialogResult dr = DialogResult.Cancel;

            frmBuscarColaborador frmBuscarColaborador = new frmBuscarColaborador();
            frmBuscarColaborador.FlagSoloBrigadistas = true;
            dr = frmBuscarColaborador.ShowDialog();
            if (dr == DialogResult.OK)
            {
                responsableSeleccionado = frmBuscarColaborador.registro;
            }
            frmBuscarColaborador.Dispose();
            frmBuscarColaborador = null;

            if (responsableSeleccionado != null)
            {
                edResponsable.Text = responsableSeleccionado.NOMBRE;
            }

            result = (dr == DialogResult.OK);

            return result;

        }

        private void btnBuscarResponsable_Click(object sender, EventArgs e)
        {
            BuscarResponsable();
        }

        private void btnAgregarResponsable_Click(object sender, EventArgs e)
        {
            AgregarBrigadista();
        }

        private bool AgregarBrigadista()
        {

            bool result = false;

            result = AgregarColaborador(false, true);

            return result;

        }

        private bool AgregarColaborador(bool esDonante, bool esBrigadista)
        {

            bool result = false;
            DialogResult dr = DialogResult.Cancel;

            frmDetColaborador frmDetColaborador = new frmDetColaborador();
            frmDetColaborador.mode = CRUDMode.Create;
            frmDetColaborador.SetBrigadista(esBrigadista);
            frmDetColaborador.SetDonante(esDonante);
            dr = frmDetColaborador.ShowDialog();
            frmDetColaborador.Dispose();
            frmDetColaborador = null;

            result = dr == DialogResult.OK;

            return result;

        }

        private void edLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarInfoLocalidadSeleccionada();
        }

        private void CargarInfoLocalidadSeleccionada()
        {

            if (edLocalidad.Text != "")
            {

                using (var db = Globals.DataContext.CreateDataConnection())
                {

                    int localidadId = Convert.ToInt32(edLocalidad.SelectedValue);
                    localidadSeleccionada = TableExtensions.Find(db.GetTable<LOCALIDAD>(), localidadId);

                    edMunicipio.Text = localidadSeleccionada.MUNICIPIO;
                    edEstado.Text = localidadSeleccionada.ESTADO;

                }

            }
            else
            {
                edMunicipio.Text = "";
                edEstado.Text = "";
            }

        }

    }

}
