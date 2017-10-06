using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Comparsa
{
    public partial class frmConfigConexionBD : Form
    {

        public DBParameters dbParams = null;

        public frmConfigConexionBD()
        {
            InitializeComponent();
        }

        private void frmConfigConexionBD_Load(object sender, EventArgs e)
        {

            LoadConnectionSettings(dbParams);

            edServer.Focus();

        }

        private void LoadConnectionSettings(DBParameters dbParams)
        {

            edServer.Text = dbParams.Server;
            edDBName.Text = dbParams.DBName;
            edUser.Text = dbParams.User;
            edPassword.Text = dbParams.Password;
            cbDontShowConfigDB.Checked = !dbParams.ShowConfigDB;

        }

        private DBParameters SaveConnectionSettings()
        {

            DBParameters dbParams = new DBParameters();

            dbParams.Server = edServer.Text;
            dbParams.DBName = edDBName.Text;
            dbParams.User = edUser.Text;
            dbParams.Password = edPassword.Text;
            dbParams.ShowConfigDB = !cbDontShowConfigDB.Checked;

            return dbParams;

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            
            dbParams = SaveConnectionSettings();

            this.DialogResult = DialogResult.OK;

        }

    }

}
