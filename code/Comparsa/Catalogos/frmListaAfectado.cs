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

            var queryAfectados = (
                from a in Globals.DataContext.AFECTADOS
                join l in Globals.DataContext.LOCALIDADES on a.LOCALIDADID equals l.LOCALIDADID
                select new
                {
                    a.AFECTADOID,
                    a.CODIGO,
                    a.NOMBRE,
                    a.ESTATUS,
                    a.CALLE,
                    a.NUMEXT,
                    a.NUMINT,
                    a.COLONIA,
                    NOMBRELOCALIDAD = l.NOMBRE,
                    l.MUNICIPIO,
                    l.ESTADO,
                    a.TELEFONO,
                    a.EMAIL
                });

            bindingSourceGrid.DataSource = queryAfectados;

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
                int id = 0;
                AFECTADO registro = null;

                row = gridView.SelectedRows[0];
                id = Convert.ToInt32(row.Cells["colID"].Value);
                registro = TableExtensions.Find(Globals.DataContext.AFECTADOS, id);

                if (registro != null)
                {

                    if (AppUtils.MsgConfirmation("¿Desea borrar el registro seleccionado?", "Por favor confirme"))
                    {

                        Globals.DataContext.DataConnection.Delete(registro);

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
            int id = 0;
            AFECTADO registro = null;

            if (mode == CRUDMode.Update)
            {
                row = gridView.SelectedRows[0];
                id = Convert.ToInt32(row.Cells["colID"].Value);
                registro = TableExtensions.Find(Globals.DataContext.AFECTADOS, id);
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
            demoraBusqueda.Enabled = false;
            demoraBusqueda.Enabled = true;
        }

        private void FiltrarPorPalabra(String palabraClave)
        {
            Cursor cursorActual = Cursor.Current;
            Cursor.Current = Cursors.AppStarting;

            if (palabraClave.Length > 0)
            {
                var query = (
                    from c in Globals.DataContext.AFECTADOS
                    where
                        c.NOMBRE.ToUpper().Contains(palabraClave) ||
                        c.CALLE.ToUpper().Contains(palabraClave) ||
                        c.COLONIA.ToUpper().Contains(palabraClave) ||
                        c.ESTADO.ToUpper().Contains(palabraClave) ||
                        c.TELEFONO.ToUpper().Contains(palabraClave) ||
                        c.EMAIL.ToUpper().Contains(palabraClave) ||
                        c.TWITTER.ToUpper().Contains(palabraClave)
                    select c);

                bindingSourceGrid.DataSource = query;
            }
            else
            {
                bindingSourceGrid.DataSource = Globals.DataContext.AFECTADOS;

            }

            Cursor.Current = cursorActual;
        }

        private void demoraBusqueda_Tick(object sender, EventArgs e)
        {
            demoraBusqueda.Enabled = false;
            
            FiltrarPorPalabra(palabraClave.Text.ToUpper());
            
        }

        private void palabraClave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                demoraBusqueda.Enabled = false; // No enviar doble petición
                FiltrarPorPalabra(palabraClave.Text.ToUpper());

                e.SuppressKeyPress = true; // Evitar el sonido de "DING!" al presionar ENTER
            }
        }
    }

}
