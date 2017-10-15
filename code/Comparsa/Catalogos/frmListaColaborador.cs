using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanterLibNET;
using Comparsa.Data;
using LinqToDB;
using LinqToDB.Data;

namespace Comparsa
{
    public partial class frmListaColaborador : Form
    {

        private static frmListaColaborador Instance = null;

        public frmListaColaborador()
        {
            InitializeComponent();
        }

        public static void ShowAsMDIChild(Form mdiParent)
        {
            if (Instance == null)
            {
                Instance = new frmListaColaborador { MdiParent = mdiParent };
                Instance.Show();
            }
            else
            {
                Instance.Activate();
            }
        }

        private void frmListaColaborador_Load(object sender, EventArgs e)
        {
            LoadWindowConfig();
            LoadGridData();
        }

        private void frmListaColaborador_FormClosed(object sender, FormClosedEventArgs e)
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
            
            /*
            using (var db = Globals.DataContext.CreateDataConnection())
            {
                bindingSourceGrid.DataSource = db.GetTable<COLABORADOR>().ToList();
            }
            */

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
                COLABORADOR registro = null;

                row = gridView.SelectedRows[0];
                //id = Convert.ToInt32(row.Cells["colCOLABORADORID"].Value);
                //registro = TableExtensions.Find(Globals.DataContext.COLABORADORES, id);
                registro = (COLABORADOR)row.DataBoundItem;

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

            frmDetColaborador frmDetColaborador = new frmDetColaborador();
            frmDetColaborador.mode = mode;
            if (mode == CRUDMode.Update)
            {

                DataGridViewRow row = null;
                int id = 0;
                COLABORADOR registro = null;

                row = gridView.SelectedRows[0];
                id = Convert.ToInt32(row.Cells["colCOLABORADORID"].Value);
                registro = (COLABORADOR)row.DataBoundItem;

                frmDetColaborador.registro = registro;

            }
            dr = frmDetColaborador.ShowDialog();
            frmDetColaborador.Dispose();
            frmDetColaborador = null;

            result = dr == DialogResult.OK;

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarRegistro();
        }

        private void BuscarRegistro()
        {

            DialogResult dr = DialogResult.Cancel;
            COLABORADOR registro = null;

            frmBuscarColaborador frmBuscarColaborador = new frmBuscarColaborador();
            dr = frmBuscarColaborador.ShowDialog();
            if (dr == DialogResult.OK)
            {
                registro = frmBuscarColaborador.registro;
            }
            frmBuscarColaborador.Dispose();
            frmBuscarColaborador = null;

            if (registro != null)
            {
                SeleccionarRegistro(registro.COLABORADORID);
            }

        }

        private void SeleccionarRegistro(int id)
        {

            // Quick and dirty sequential search

            int idRow = 0;

            foreach (DataGridViewRow row in gridView.Rows)
            {

                idRow = Convert.ToInt32(row.Cells["colCOLABORADORID"].Value);

                if (idRow == id)
                {
                    row.Selected = true;
                    break;
                }

            }

        }

        private void demoraBusqueda_Tick(object sender, EventArgs e)
        {
            timerDemoraBusqueda.Enabled = false;
            LoadGridDataWithKeyword();
        }

        private void palabraClave_KeyDown(object sender, KeyEventArgs e)
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
                            from c in db.GetTable<COLABORADOR>()
                            where
                                c.NOMBRE.ToUpper().Contains(keyword) ||
                                c.CALLE.ToUpper().Contains(keyword) ||
                                c.COLONIA.ToUpper().Contains(keyword)

                            select c);

                        bindingSourceGrid.DataSource = query.ToList();

                    }
                    else
                    {
                        bindingSourceGrid.DataSource = db.GetTable<COLABORADOR>().ToList();
                    }

                }

            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

        }

        private void edPalabraClave_TextChanged(object sender, EventArgs e)
        {
            //timerDemoraBusqueda.Enabled = true;
            //FiltrarPalabraClave();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            LoadGridData();
        }

        private void frmListaColaborador_Resize(object sender, EventArgs e)
        {
            this.MdiParent.Refresh();
        }
    }

}
