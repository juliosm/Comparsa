using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using QuanterLibNET;

namespace Comparsa
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            RefreshVersion();
            RefreshDBPath();

            LoadWindowConfig();

        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveWindowConfig();
        }

        private void RefreshVersion()
        {
            lbVersion.Text = String.Format("Versión: {0}", this.GetType().Assembly.GetName().Version);
        }

        private void RefreshDBPath()
        {
            lbDatabase.Text = Globals.GDBParams.DBName + "@" + Globals.GDBParams.Server;
        }

        private void LoadWindowConfig()
        {
            AppUtils.LoadWindowConfig(Globals.GXmlConfigUser, this, true, true, true);
        }

        private void SaveWindowConfig()
        {
            AppUtils.SaveWindowConfig(Globals.GXmlConfigUser, this, true, true, true);
        }

        private void ShowModalForm(Type type)
        {
            MethodInfo showMethod = type.GetMethod("ShowModal");
            showMethod.Invoke(null, null);
        }

        private void ShowMDIChild(Type type)
        {
            MethodInfo showMethod = type.GetMethod("ShowAsMDIChild");
            showMethod.Invoke(null, new object[] { this });
        }

        private void colaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMDIChild(typeof(frmListaColaborador));
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMDIChild(typeof(frmListaLocalidad));
        }

        private void afectadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMDIChild(typeof(frmListaAfectado));
        }

        private void tiposDeArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMDIChild(typeof(frmListaTipoInsumo));
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMDIChild(typeof(frmListaInsumo));
        }

        private void pingConnexion_Tick(object sender, EventArgs e)
        {
            // Timer para mantener "viva" la conexión a la base de datos.

            /*
            // Envía una query simple que no consume muchos datos cada 2 minutos
            if (Globals.DataContext.IsConnected)
            {
                var query = (
                    from c in Globals.DataContext.TIPOSINSUMOS
                    where
                    c.TIPOINSUMOID == 1
                    select c.TIPOINSUMOID);

                //if (query.First<int>() != 1)
                {
                    //MessageBox.Show("wow OMG!!");
                }
            }
            */

        }

        private void inventariosFísicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMDIChild(typeof(frmListaInventarioFisico));
        }

        private void entradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMDIChild(typeof(frmListaEntradas));
        }

        private void salidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMDIChild(typeof(frmListaSalidas));
        }

        private void nuevoColaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarColaborador();
        }

        private void agregarAfectadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarAfectado();
        }

        private bool AgregarColaborador()
        {

            bool result = false;
            DialogResult dr = DialogResult.Cancel;

            do
            {

                frmDetColaborador frmDetColaborador = new frmDetColaborador();
                frmDetColaborador.mode = CRUDMode.Create;
                dr = frmDetColaborador.ShowDialog();
                frmDetColaborador.Dispose();
                frmDetColaborador = null;

                result = dr == DialogResult.OK;

            } while (result);

            return result;

        }

        private bool AgregarAfectado()
        {

            bool result = false;
            DialogResult dr = DialogResult.Cancel;

            do
            {

                frmDetAfectado frmDetAfectado = new frmDetAfectado();
                frmDetAfectado.mode = CRUDMode.Create;
                dr = frmDetAfectado.ShowDialog();
                frmDetAfectado.Dispose();
                frmDetAfectado = null;

                result = dr == DialogResult.OK;

            } while (result);

            return result;

        }

    }

}
