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

        private List<INVENTARIODET> listaDetalle = null;
        private List<INSUMO> listaInsumos = null;
        private INSUMO insumoSeleccionado = null;

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

                listaDetalle = new List<INVENTARIODET>();
                listaInsumos = new List<INSUMO>();

                CargarComboInsumos(db);
                edInsumo.SelectedIndex = -1;

                switch (mode)
                {
                    case CRUDMode.Create:

                        registro = new INVENTARIO();
                        registro.ACTUAL = 1;

                        titulo = "Nuevo inventario físico";

                        GenerarNumero(db);

                        edFecha.Value = DateTime.Now.Date;
                        edHora.Value = Consts.BaseDateTime.Add(DateTime.Now.TimeOfDay);

                        break;

                    case CRUDMode.Update:

                        registro = db.GetTable<INVENTARIO>().LoadWith(x => x.INVENTARIODETs).FirstOrDefault(x => x.INVENTARIOID == registro.INVENTARIOID);

                        MapearObjetoAPantalla(db);
                        titulo = "Modificar inventario físico";
                        break;

                }

                menuDetalle.Visible = registro.ACTUAL == 1;
                panelAgregarInsumo.Visible = registro.ACTUAL == 1;

                lbTitulo.Text = titulo;
                this.Text = titulo;

                bindingSourceDetalle.DataSource = listaDetalle;

                edInsumo.Focus();

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
            listaInsumos = db.GetTable<INSUMO>().ToList();
            bindingSourceInsumo.DataSource = listaInsumos;
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
                        registro.INVENTARIOID = id;
                    }
                    else if (mode == CRUDMode.Update)
                    {
                        db.Update(registro);
                    }

                    GuardarDetalleInventario(db);

                }

                this.DialogResult = DialogResult.OK;

            }

        }

        private void GuardarDetalleInventario(DataConnection db)
        {

            // Borrar los proyectos relacionados que se hayan desmarcado
            List<object> deleteList = new List<object>();

            if (mode != CRUDMode.Create)
            {

                var reg = db.GetTable<INVENTARIO>().LoadWith(a => a.INVENTARIODETs).FirstOrDefault(x => x.INVENTARIOID == registro.INVENTARIOID);

                if (reg != null)
                {

                    if (reg.INVENTARIODETs != null)
                    {

                        foreach (var inventarioDet in reg.INVENTARIODETs)
                        {

                            bool found = listaDetalle.FirstOrDefault(x => x.INVENTARIODETID == inventarioDet.INVENTARIODETID) != null;

                            if (!found)
                            {
                                deleteList.Add(inventarioDet);
                            }

                        }

                        foreach (INVENTARIODET inventarioDet in deleteList)
                        {
                            db.Delete(inventarioDet);
                        }

                    }

                }

            }

            // Guardar los registros detalle
            foreach (var inventarioDet in listaDetalle)
            {

                if (inventarioDet.INVENTARIOID == 0)
                {
                    inventarioDet.INVENTARIOID = registro.INVENTARIOID;
                }

                db.InsertOrReplace(inventarioDet);

                if (registro.ACTUAL == 1)
                {

                    // Actualizar la existencia del insumo

                    INSUMO insumo = inventarioDet.INSUMO;
                    insumo.EXISTENCIA = inventarioDet.EXISTREAL;

                    db.Update(insumo);

                }

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
            registro.FECHA = edFecha.Value;
            registro.HORA = edHora.Value.TimeOfDay;
            registro.NOTAS = edNotas.Text;
        }

        private void MapearObjetoAPantalla(DataConnection db)
        {

            edNumero.Text = registro.NUMERO;
            edFecha.Value = registro.FECHA.Value;
            edHora.Value = Consts.BaseDateTime.Add(registro.HORA.Value);
            edNotas.Text = registro.NOTAS;

            CargarDetalleInventario(db);

        }

        private void CargarDetalleInventario(DataConnection db)
        {

            var q = (
                from d in db.GetTable<INVENTARIODET>().LoadWith(a => a.INSUMO)
                where
                    (d.INVENTARIOID == registro.INVENTARIOID)
                select d);

            foreach (var inventarioDet in q)
            {
                listaDetalle.Add(inventarioDet);
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

                decimal existReal = 0;
                decimal existTeorica = 0;

                existReal = edExistReal.Value;
                if (insumoSeleccionado.EXISTENCIA.HasValue)
                {
                    existTeorica = insumoSeleccionado.EXISTENCIA.Value;
                }

                INVENTARIODET inventarioDet = new INVENTARIODET();
                inventarioDet.INSUMOID = insumoSeleccionado.INSUMOID;
                inventarioDet.INSUMO = insumoSeleccionado;
                inventarioDet.EXISTREAL = edExistReal.Value;
                inventarioDet.EXISTTEORICA = existTeorica;
                inventarioDet.EXISTDIFERENCIA = existReal - existTeorica;

                listaDetalle.Add(inventarioDet);

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
            edExistReal.Value = 0;
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
                INVENTARIODET registro = null;

                row = gridViewDetalle.SelectedRows[0];
                registro = (INVENTARIODET)row.DataBoundItem;

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
            INVENTARIODET registro = null;

            if (mode == CRUDMode.Update)
            {
                row = gridViewDetalle.SelectedRows[0];
                registro = (INVENTARIODET)row.DataBoundItem;
            }

            frmDetInventarioInsumo frmDetInventarioInsumo = new frmDetInventarioInsumo();
            frmDetInventarioInsumo.mode = mode;
            if (mode == CRUDMode.Update)
            {
                frmDetInventarioInsumo.registro = registro;
            }
            dr = frmDetInventarioInsumo.ShowDialog();
            frmDetInventarioInsumo.Dispose();
            frmDetInventarioInsumo = null;

            result = dr == DialogResult.OK;

            return result;

        }

    }

}
