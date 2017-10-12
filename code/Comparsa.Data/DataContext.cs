using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB;
using LinqToDB.Data;
using LinqToDB.Common;
using LinqToDB.DataProvider.Firebird;
using LinqToDB.Mapping;

namespace Comparsa.Data
{

    public class DataContext
    {

        public DataConnection DataConnection = null;
        public bool IsConnected = false;

        public ITable<AFECTADO> AFECTADOS { get { return this.DataConnection.GetTable<AFECTADO>(); } }
        public ITable<AFECTADOREQ> AFECTADOREQS { get { return this.DataConnection.GetTable<AFECTADOREQ>(); } }
        public ITable<INSUMO> INSUMOS { get { return this.DataConnection.GetTable<INSUMO>(); } }
        public ITable<COLABORADOR> COLABORADORES { get { return this.DataConnection.GetTable<COLABORADOR>(); } }
        public ITable<ENTRADA> ENTRADAS { get { return this.DataConnection.GetTable<ENTRADA>(); } }
        public ITable<LOCALIDAD> LOCALIDADES { get { return this.DataConnection.GetTable<LOCALIDAD>(); } }
        public ITable<TIPOINSUMO> TIPOSINSUMOS { get { return this.DataConnection.GetTable<TIPOINSUMO>(); } }

        public DataConnection GetFirebirdConnection(string connectionString)
        {
            return FirebirdTools.CreateDataConnection(connectionString);
        }

        public DataConnection GetFirebirdConnection(string host, string port, string server, string database, string uid, string password)
        {
            return GetFirebirdConnection(string.Format("Host={0};Service={1};Server={2};Protocol=onsoctcp;Database={3};UID={4};PWD={5}", host, port, server, database, uid, password));
        }

        public bool ConnectDatabase(string connectionString, ref string messageError)
        {

            try
            {

                this.DataConnection = GetFirebirdConnection(
                    connectionString);

                if (this.DataConnection.Connection != null)
                {

                    LinqToDB.Common.Configuration.Linq.AllowMultipleQuery = true;

                    IsConnected = true;
                }

                return true;

            }
            catch (Exception e)
            {
                messageError = e.Message;
                return false;
            }

        }

    }

}
