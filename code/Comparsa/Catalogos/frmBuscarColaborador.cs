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
    public partial class frmBuscarColaborador : Form
    {

        private static frmBuscarColaborador Instance = null;

        public COLABORADOR registro = null;

        public frmBuscarColaborador()
        {
            InitializeComponent();
        }

        public static void ShowAsMDIChild(Form mdiParent)
        {
            if (Instance == null)
            {
                Instance = new frmBuscarColaborador { MdiParent = mdiParent };
                Instance.Show();
            }
            else
            {
                Instance.Activate();
            }
        }

        private void frmBuscarColaborador_Load(object sender, EventArgs e)
        {

            LoadWindowConfig();
            LoadGridData();

            edNombre.Focus();

        }

        private void frmBuscarColaborador_FormClosed(object sender, FormClosedEventArgs e)
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

            using (var db = Globals.DataContext.CreateDataConnection())
            {

                string nombre = edNombre.Text;

                var query = (
                    from c in db.GetTable<COLABORADOR>()
                    where
                        c.NOMBRE.ToUpper().Contains(nombre.ToUpper())
                    select c);

                bindingSourceGrid.DataSource = query.ToList();

            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarRegistro();
        }

        private void gridView_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {

                case Keys.Enter:
                    SeleccionarRegistro();
                    break;

                default:
                    break;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            SeleccionarRegistro();
        }

        private bool ValidarSeleccion()
        {

            bool result = false;
            string mensaje = "";

            if (gridView.SelectedRows.Count == 0)
            {
                mensaje += "Debe seleccionar un registro.\n";
            }

            if (mensaje != "")
            {
                AppUtils.MsgError(mensaje, "Error");
            }

            result = mensaje == "";

            return result;

        }

        private void SeleccionarRegistro()
        {

            if (ValidarSeleccion())
            {

                DataGridViewRow row = null;
                int id = 0;

                row = gridView.SelectedRows[0];
                id = Convert.ToInt32(row.Cells["colCOLABORADORID"].Value);
                registro = (COLABORADOR)row.DataBoundItem;

                if (registro != null)
                {
                    this.DialogResult = DialogResult.OK;
                }

            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            LoadGridData();
        }

        private void edNombre_TextChanged(object sender, EventArgs e)
        {
            LoadGridData();
        }

        private void edNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadGridData();
            }
        }
    }

}
