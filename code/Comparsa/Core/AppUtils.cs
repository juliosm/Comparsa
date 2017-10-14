using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanterLibNET;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using Comparsa.Data;
using System.Reflection;

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
            /*
            if (Globals.GXmlConfig.Settings["DBConnection"]["DBPass"].Value != "")
            {
                dbParams.Password = SecurityUtils.DecryptString(Globals.GXmlConfig.Settings["DBConnection"]["DBPass"].Value);
            }
            else
            {
                dbParams.Password = "";
            }
            */
            dbParams.Password = Globals.GXmlConfig.Settings["DBConnection"]["DBPass"].Value;
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
                /*Globals.GXmlConfig.Settings["DBConnection"]["DBPass"].Value =
                    SecurityUtils.EncryptString(dbParams.Password);*/
                Globals.GXmlConfig.Settings["DBConnection"]["DBPass"].Value = dbParams.Password;
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

        public static void LoadWindowConfig(XmlConfig xmlConfig, Form window, bool loadSize, bool loadLocation, bool loadState)
        {

            Point pointLocation = new Point();
            Size windowSize = new Size();
            int windowState = 0;

            if (loadLocation)
            {

                // Cargar la posición de la ventana

                if (xmlConfig.Settings[window.Name]["Location"]["X"].Value != "")
                {
                    if (xmlConfig.Settings[window.Name]["Location"]["X"].intValue > 0)
                    {
                        pointLocation.X = xmlConfig.Settings[window.Name]["Location"]["X"].intValue;
                    }
                    else
                    {
                        pointLocation.X = 0;
                    }
                }
                if (xmlConfig.Settings[window.Name]["Location"]["Y"].Value != "")
                {
                    if (xmlConfig.Settings[window.Name]["Location"]["Y"].intValue > 0)
                    {
                        pointLocation.Y = xmlConfig.Settings[window.Name]["Location"]["Y"].intValue;
                    }
                    else
                    {
                        pointLocation.Y = 0;
                    }
                }

                if ((pointLocation.X != 0) && (pointLocation.Y != 0))
                {
                    window.Location = pointLocation;
                }

            }

            if (loadSize)
            {

                // Cargar el tamaño de la ventana

                if (xmlConfig.Settings[window.Name]["Size"]["Height"].Value != "")
                {
                    windowSize.Height = xmlConfig.Settings[window.Name]["Size"]["Height"].intValue;
                }
                if (xmlConfig.Settings[window.Name]["Size"]["Width"].Value != "")
                {
                    windowSize.Width = xmlConfig.Settings[window.Name]["Size"]["Width"].intValue;
                }

                if ((windowSize.Height > 0) && (windowSize.Width > 0))
                {
                    window.Size = windowSize;
                }

            }

            if (loadState)
            {

                // Cargar el estado de la ventana

                if (xmlConfig.Settings[window.Name]["State"].intValue != 0)
                {
                    windowState = xmlConfig.Settings[window.Name]["State"].intValue;
                }

                if ((windowState >= 0) && (windowState <= 2))
                {
                    window.WindowState = (FormWindowState)windowState;
                }

            }

        }

        public static void SaveWindowConfig(XmlConfig xmlConfig, Form window, bool saveSize, bool saveLocation, bool saveState)
        {

            if (saveLocation)
            {
                // Guardar la posición de la ventana 
                xmlConfig.Settings[window.Name]["Location"]["X"].intValue = window.Location.X;
                xmlConfig.Settings[window.Name]["Location"]["Y"].intValue = window.Location.Y;
            }

            if (saveSize)
            {
                // Guardar el tamaño de la ventana
                xmlConfig.Settings[window.Name]["Size"]["Height"].intValue = window.Size.Height;
                xmlConfig.Settings[window.Name]["Size"]["Width"].intValue = window.Size.Width;
            }

            if (saveState)
            {
                // Guardar el estado de la ventana
                xmlConfig.Settings[window.Name]["State"].intValue = (int)window.WindowState;
            }

            xmlConfig.Commit();

        }

        public static string BindProperty(object property, string propertyName)
        {

            string retValue;

            retValue = "";

            if (propertyName.Contains("."))
            {
                PropertyInfo[] arrayProperties;
                string leftPropertyName;

                leftPropertyName = propertyName.Substring(0, propertyName.IndexOf("."));
                arrayProperties = property.GetType().GetProperties();

                foreach (PropertyInfo propertyInfo in arrayProperties)
                {
                    if (propertyInfo.Name == leftPropertyName)
                    {
                        retValue = BindProperty(propertyInfo.GetValue(property, null), propertyName.Substring(propertyName.IndexOf(".") + 1));
                        break;
                    }
                }
            }
            else
            {
                Type propertyType;
                PropertyInfo propertyInfo;

                propertyType = property.GetType();
                propertyInfo = propertyType.GetProperty(propertyName);
                retValue = propertyInfo.GetValue(property, null).ToString();
            }

            return retValue;

        }

        public static string GetNombreEstatusAfectado(int estatus)
        {

            string result = "";

            switch (estatus)
            {

                case Consts.ESTATUS_AFECTADO_POR_REVISAR:
                    result = "Por revisar";
                    break;
                case Consts.ESTATUS_AFECTADO_AFECTACION_MENOR:
                    result = "Afectación menor";
                    break;
                case Consts.ESTATUS_AFECTADO_AFECTACION_MAYOR:
                    result = "Afectación mayor";
                    break;
                case Consts.ESTATUS_AFECTADO_SIN_DANOS:
                    result = "Sin daños";
                    break;
                case Consts.ESTATUS_AFECTADO_ATENDIDO:
                    result = "Atendido";
                    break;

                default:
                    break;
            }

            return result;

        }

    }

}
