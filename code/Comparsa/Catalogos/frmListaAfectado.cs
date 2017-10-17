using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using QuanterLibNET;
using Comparsa.Data;
using LinqToDB;
using LinqToDB.Data;

namespace Comparsa
{
    public partial class frmListaAfectado : Form
    {

        private static frmListaAfectado Instance = null;

        public frmListaAfectado()
        {
            InitializeComponent();
        }

        public static void ShowAsMDIChild(Form mdiParent)
        {
            if (Instance == null)
            {
                Instance = new frmListaAfectado { MdiParent = mdiParent };
                Instance.Show();
            }
            else
            {
                Instance.Activate();
            }
        }

        private void frmListaAfectado_Load(object sender, EventArgs e)
        {
            LoadWindowConfig();
            LoadGridData();
        }

        private void frmListaAfectado_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveWindowConfig();
            Instance = null;
        }

        private void LoadWindowConfig()
        {
            AppUtils.LoadWindowConfig(Globals.GXmlConfigUser, this, true, true, true);
        }

        private void SaveWindowConfig()
        {
            AppUtils.SaveWindowConfig(Globals.GXmlConfigUser, this, true, true, true);
        }

        private void LoadGridData()
        {
            LoadGridDataWithKeyword();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarRegistro();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarRegistro();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            BorrarRegistro();
        }

        private bool AgregarRegistro()
        {

            bool result = false;

            if (InfoRegistro(CRUDMode.Create))
            {
                LoadGridData();
            }

            return result;

        }

        private bool ModificarRegistro()
        {

            bool result = false;

            if (gridView.SelectedRows.Count > 0)
            {
                if (InfoRegistro(CRUDMode.Update))
                {
                    LoadGridData();
                }
            }

            return result;

        }

        private bool BorrarRegistro()
        {

            bool result = false;

            if (gridView.SelectedRows.Count > 0)
            {

                DataGridViewRow row = null;
                //int id = 0;
                AFECTADO registro = null;

                row = gridView.SelectedRows[0];
                //id = Convert.ToInt32(row.Cells["colID"].Value);
                //registro = TableExtensions.Find(Globals.DataContext.AFECTADOS, id);
                registro = (AFECTADO)row.DataBoundItem;

                if (registro != null)
                {

                    if (AppUtils.MsgConfirmation("¿Desea borrar el registro seleccionado?", "Por favor confirme"))
                    {

                        using (var db = Globals.DataContext.CreateDataConnection())
                        {
                            db.Delete(registro);
                        }

                        LoadGridData();

                    }

                }

            }

            return result;

        }

        private bool InfoRegistro(CRUDMode mode)
        {

            bool result = false;
            DialogResult dr = DialogResult.Cancel;
            DataGridViewRow row = null;
            //int id = 0;
            AFECTADO registro = null;

            if (mode == CRUDMode.Update)
            {
                row = gridView.SelectedRows[0];
                //id = Convert.ToInt32(row.Cells["colID"].Value);
                //registro = TableExtensions.Find(Globals.DataContext.AFECTADOS, id);
                registro = (AFECTADO)row.DataBoundItem;
            }

            if ((mode == CRUDMode.Create) || ((registro != null) && (mode != CRUDMode.Create)))
            {

                frmDetAfectado frmDetAfectado = new frmDetAfectado();
                frmDetAfectado.mode = mode;
                if (mode == CRUDMode.Update)
                {
                    frmDetAfectado.registro = registro;
                }
                dr = frmDetAfectado.ShowDialog();
                frmDetAfectado.Dispose();
                frmDetAfectado = null;

                result = dr == DialogResult.OK;

            }

            return result;

        }

        private void gridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModificarRegistro();
        }

        private void gridView_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {

                case Keys.Insert:

                    if (btnAgregar.Enabled)
                    {
                        AgregarRegistro();
                    }

                    break;

                case Keys.Enter:

                    if (btnModificar.Enabled) 
                    {
                        ModificarRegistro();
                    }

                    break;

                case Keys.Delete:

                    if (btnBorrar.Enabled)
                    {
                        BorrarRegistro();
                    }

                    break;

                case Keys.F5:

                    LoadGridData();

                    break;

                default:
                    break;
            }

        }

        private void gridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            /*
            var registro = gridView.Rows[e.RowIndex].DataBoundItem;

            //var reg = Globals.DataContext.AFECTADOes.LoadWith(a => a.LOCALIDAD).FirstOrDefault(x => x.AFECTADOID == registro);

            if ((gridView.Rows[e.RowIndex].DataBoundItem != null) &&
                (gridView.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                e.Value = AppUtils.BindProperty(
                        registro,
                        gridView.Columns[e.ColumnIndex].DataPropertyName
                      );
            }
            else
            {

                Type propertyType;
                PropertyInfo propertyInfo;
                string estatus = "";

                propertyType = registro.GetType();
                propertyInfo = propertyType.GetProperty("ESTATUS");
                estatus = propertyInfo.GetValue(registro, null).ToString();

                if (e.ColumnIndex == colESTATUS.Index)
                {
                    if (estatus != null)
                    {
                        e.Value = AppUtils.GetNombreEstatusAfectado(Convert.ToInt32(estatus));
                    }
                }

            }
            */
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarRegistro();
        }

        private void BuscarRegistro()
        {

            DialogResult dr = DialogResult.Cancel;
            AFECTADO registro = null;

            frmBuscarAfectado frmBuscarAfectado = new frmBuscarAfectado();
            dr = frmBuscarAfectado.ShowDialog();
            if (dr == DialogResult.OK)
            {
                registro = frmBuscarAfectado.registro;
            }
            frmBuscarAfectado.Dispose();
            frmBuscarAfectado = null;

            if (registro != null)
            {
                SeleccionarRegistro(registro.AFECTADOID);
            }

        }

        private void SeleccionarRegistro(int id)
        {

            // Quick and dirty sequential search

            int idRow = 0;

            foreach (DataGridViewRow row in gridView.Rows)
            {

                idRow = Convert.ToInt32(row.Cells["colID"].Value);

                if (idRow == id)
                {
                    row.Selected = true;
                    break;
                }

            }

        }

        private void palabraClave_TextChanged(object sender, EventArgs e)
        {
            // REiniciar el timer
            timerDemoraBusqueda.Enabled = false;
            timerDemoraBusqueda.Enabled = true;
        }

        //private void FiltrarPorPalabra(String palabraClave)
        //{
        //    Cursor cursorActual = Cursor.Current;
        //    Cursor.Current = Cursors.AppStarting;

        //    if (palabraClave.Length > 0)
        //    {
        //        var query = (
        //            from c in Globals.DataContext.AFECTADOS
        //            where
        //                c.NOMBRE.ToUpper().Contains(palabraClave) ||
        //                c.CALLE.ToUpper().Contains(palabraClave) ||
        //                c.COLONIA.ToUpper().Contains(palabraClave) ||
        //                c.ESTADO.ToUpper().Contains(palabraClave) ||
        //                c.TELEFONO.ToUpper().Contains(palabraClave) ||
        //                c.EMAIL.ToUpper().Contains(palabraClave) ||
        //                c.TWITTER.ToUpper().Contains(palabraClave)
        //            select c);

        //        bindingSourceGrid.DataSource = query;
        //    }
        //    else
        //    {
        //        bindingSourceGrid.DataSource = Globals.DataContext.AFECTADOS;

        //    }

        //    Cursor.Current = cursorActual;
        //}

        private void demoraBusqueda_Tick(object sender, EventArgs e)
        {
            timerDemoraBusqueda.Enabled = false;
            LoadGridDataWithKeyword();
        }

        private void edPalabraClave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                timerDemoraBusqueda.Enabled = false; // No enviar doble petición
                LoadGridDataWithKeyword();
                e.SuppressKeyPress = true; // Evitar el sonido de "DING!" al presionar ENTER
            }
        }

        private void LoadGridDataWithKeyword()
        {

            try
            {

                Cursor.Current = Cursors.WaitCursor;

                string keyword = edPalabraClave.Text.ToUpper();

                using (var db = Globals.DataContext.CreateDataConnection())
                {

                    if (keyword.Length > 0)
                    {

                        var query = (
                            from a in db.GetTable<AFECTADO>()
                            join l in db.GetTable<LOCALIDAD>() on a.LOCALIDADID equals l.LOCALIDADID
                            where
                                a.NOMBRE.ToUpper().Contains(keyword) ||
                                a.CALLE.ToUpper().Contains(keyword) ||
                                a.COLONIA.ToUpper().Contains(keyword)
                            orderby a.CODIGO
                            select new AFECTADO_EXT
                            {
                                AFECTADOID = a.AFECTADOID,
                                CODIGO = a.CODIGO,
                                NOMBRE = a.NOMBRE,
                                ESTATUS = a.ESTATUS,
                                CALLE = a.CALLE,
                                NUMEXT = a.NUMEXT,
                                NUMINT = a.NUMINT,
                                COLONIA = a.COLONIA,
                                NOMBRELOCALIDAD = l.NOMBRE,
                                MUNICIPIO = l.MUNICIPIO,
                                ESTADO = l.ESTADO,
                                TELEFONO = a.TELEFONO,
                                EMAIL = a.EMAIL
                            });

                        bindingSourceGrid.DataSource = query.ToList();

                    }
                    else
                    {

                        var query = (
                            from a in db.GetTable<AFECTADO>()
                            join l in db.GetTable<LOCALIDAD>() on a.LOCALIDADID equals l.LOCALIDADID
                            orderby a.CODIGO
                            select new AFECTADO_EXT
                            {
                                AFECTADOID = a.AFECTADOID,
                                CODIGO = a.CODIGO,
                                NOMBRE = a.NOMBRE,
                                ESTATUS = a.ESTATUS,
                                CALLE = a.CALLE,
                                NUMEXT = a.NUMEXT,
                                NUMINT = a.NUMINT,
                                COLONIA = a.COLONIA,
                                NOMBRELOCALIDAD = l.NOMBRE,
                                MUNICIPIO = l.MUNICIPIO,
                                ESTADO = l.ESTADO,
                                TELEFONO = a.TELEFONO,
                                EMAIL = a.EMAIL
                            });

                        bindingSourceGrid.DataSource = query.ToList();

                    }

                }

            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

        }

        private void frmListaAfectado_Resize(object sender, EventArgs e)
        {
            this.MdiParent.Refresh();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            RefreshGridData();
        }

        private void RefreshGridData()
        {
            LoadGridData();
        }

    }

}
