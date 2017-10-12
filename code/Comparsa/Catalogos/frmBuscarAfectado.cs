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
    public partial class frmBuscarAfectado : Form
    {

        private static frmBuscarAfectado Instance = null;

        public AFECTADO registro = null;

        public frmBuscarAfectado()
        {
            InitializeComponent();
        }

        public static void ShowAsMDIChild(Form mdiParent)
        {
            if (Instance == null)
            {
                Instance = new frmBuscarAfectado { MdiParent = mdiParent };
                Instance.Show();
            }
            else
            {
                Instance.Activate();
            }
        }

        private void frmBuscarAfectado_Load(object sender, EventArgs e)
        {

            CargarLocalidades();
            edLocalidad.SelectedIndex = -1;

            LoadWindowConfig();
            LoadGridData();

            RefrescarFiltroLocalidad();

            edNombre.Focus();

        }

        private void frmBuscarAfectado_FormClosed(object sender, FormClosedEventArgs e)
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

        private void CargarLocalidades()
        {
            bindingSourceLocalidad.DataSource = Globals.DataContext.LOCALIDADES;
        }

        private void LoadGridData()
        {

            string nombre = edNombre.Text;
            int localidadId = 0;

            if (cbLocalidad.Checked)
            {
                localidadId = Convert.ToInt32(edLocalidad.SelectedValue);
            }

            var query = (
                from c in Globals.DataContext.AFECTADOS
                where
                    c.NOMBRE.ToUpper().Contains(nombre.ToUpper())
                    &&
                    (((c.LOCALIDADID == localidadId) && (localidadId != 0)) || (localidadId == 0))
                select c);

            bindingSourceGrid.DataSource = query;

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

        private bool ValidarFiltro()
        {

            bool result = false;
            string mensaje = "";

            if (cbLocalidad.Checked)
            {
                if (edLocalidad.Text == "")
                {
                    mensaje += "Debe seleccionar una localidad.\n";
                }
            }

            if (mensaje != "")
            {
                AppUtils.MsgError(mensaje, "Error");
            }

            result = mensaje == "";

            return result;

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
                id = Convert.ToInt32(row.Cells["colID"].Value);
                registro = TableExtensions.Find(Globals.DataContext.AFECTADOS, id);

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

        private void cbLocalidad_CheckedChanged(object sender, EventArgs e)
        {
            RefrescarFiltroLocalidad();
        }

        private void RefrescarFiltroLocalidad()
        {
            edLocalidad.Enabled = cbLocalidad.Checked;
            LoadGridData();
        }

    }

}
