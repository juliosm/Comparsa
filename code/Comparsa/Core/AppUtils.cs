using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanterLibNET;
using System.IO;
using System.Windows.Forms;
using QuanterLibNET.Security;
using Comparsa.Data;

namespace Comparsa
{

    public class AppUtils
    {

        public static void InitializeGlobals()
        {

            string pathConfig = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Comparsa\\";
            string userConfigFile = pathConfig + "ConfigUser.xml";

            Globals.GXmlConfig = new XmlConfig("Config.xml", true);
            Globals.GXmlConfig.CommitOnUnload = true;

            if (!Directory.Exists(pathConfig))
            {
                if (Directory.CreateDirectory(pathConfig) == null)
                {
                    AppUtils.MsgError("Error al crear el directorio de configuración", "Error");
                }
            }

            Globals.GXmlConfigUser = new XmlConfig(userConfigFile, true);
            Globals.GXmlConfigUser.CommitOnUnload = true;

        }

        #region Database connection

        public static bool InitializeDBConnection()
        {

            bool flagShowConfigDB = false;
            bool result = false;

            if (Globals.GXmlConfig.Settings["DBConnection"]["DBShowConfig"].Value != "")
            {
                flagShowConfigDB = Globals.GXmlConfig.Settings["DBConnection"]["DBShowConfig"].boolValue;
            }
            else
            {
                flagShowConfigDB = true;
            }

            if (flagShowConfigDB)
            {
                if ((TryDatabaseConnection()))
                {
                    result = true;
                }
            }
            else
            {
                if (!(ConnectDatabase()))
                {
                    if ((TryDatabaseConnection()))
                    {
                        result = true;
                    }
                }
                else
                {
                    result = true;
                }
            }

            return result;

        }

        public static bool TryDatabaseConnection()
        {

            bool CancelConnection = false;
            bool Connected = false;
            DBParameters configDBParams = null;

            while (!CancelConnection)
            {

                DialogResult dr = DialogResult.Cancel;

                DBParameters dbParams = GetDBParameters();

                frmConfigConexionBD frmConfigConexionBD = new frmConfigConexionBD();
                frmConfigConexionBD.dbParams = dbParams;
                dr = frmConfigConexionBD.ShowDialog();
                configDBParams = frmConfigConexionBD.dbParams;
                frmConfigConexionBD.Dispose();

                if (dr == DialogResult.Cancel)
                {
                    CancelConnection = true;
                    break;
                }
                else
                {

                    SaveDBParameters(configDBParams);

                    Connected = ConnectDatabase();

                    if (Connected)
                    {
                        break;
                    }

                }

            }

            return Connected;

        }

        public static bool ConnectDatabase()
        {

            bool result = false;

            try
            {

                DBParameters dbParams = GetDBParameters();

                string connectionString = dbParams.GetConnectionString();
                string errorMessage = "";

                Globals.DataContext = new DataContext();

                if (Globals.DataContext.ConnectDatabase(connectionString, ref errorMessage))
                {
                    Globals.GDBParams = dbParams;
                    result = true;
                }
                else
                {
                    AppUtils.MsgError(errorMessage, "error");
                }

                /*
                if (Globals.DataContext.ConnectDatabase(connectionString, ref errorMessage))
                {
                    Globals.GDBParams = dbParams;
                    result = true;
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }
                */

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                result = false;
            }

            return result;

        }

        public static DBParameters GetDBParameters()
        {

            DBParameters dbParams = new DBParameters();

            dbParams.Server = Globals.GXmlConfig.Settings["DBConnection"]["DBServer"].Value;
            dbParams.DBName = Globals.GXmlConfig.Settings["DBConnection"]["DBName"].Value;
            dbParams.User = Globals.GXmlConfig.Settings["DBConnection"]["DBUser"].Value;
            if (Globals.GXmlConfig.Settings["DBConnection"]["DBPass"].Value != "")
            {
                dbParams.Password = SecurityUtils.DecryptString(Globals.GXmlConfig.Settings["DBConnection"]["DBPass"].Value);
            }
            else
            {
                dbParams.Password = "";
            }
            if (Globals.GXmlConfig.Settings["DBConnection"]["DBShowConfig"].Value != "")
            {
                dbParams.ShowConfigDB = Globals.GXmlConfig.Settings["DBConnection"]["DBShowConfig"].boolValue;
            }
            else
            {
                dbParams.ShowConfigDB = true;
            }

            return dbParams;

        }

        public static void SaveDBParameters(DBParameters dbParams)
        {

            if (dbParams != null)
            {

                Globals.GXmlConfig.Settings["DBConnection"]["DBServer"].Value = dbParams.Server;
                Globals.GXmlConfig.Settings["DBConnection"]["DBName"].Value = dbParams.DBName;
                Globals.GXmlConfig.Settings["DBConnection"]["DBUser"].Value = dbParams.User;
                Globals.GXmlConfig.Settings["DBConnection"]["DBPass"].Value =
                    SecurityUtils.EncryptString(dbParams.Password);
                Globals.GXmlConfig.Settings["DBConnection"]["DBShowConfig"].boolValue = dbParams.ShowConfigDB;

                Globals.GXmlConfig.Commit();

            }

        }

        #endregion

        #region Messages functions 

        public static bool MsgConfirmation(string message, string title)
        {

            bool result = false;

            DialogResult dr = MessageBox.Show(message, title,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            result = (dr == DialogResult.Yes);

            return result;

        }

        public static void MsgError(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
        }

        public static void MsgWarning(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1);
        }

        public static void MsgInformation(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
        }

        #endregion

    }

}
