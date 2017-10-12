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
            LoadWindowConfig();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveWindowConfig();
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

    }

}
