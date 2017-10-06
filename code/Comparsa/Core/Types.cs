using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparsa
{

    public enum CRUDMode
    {
        Create,
        Read,
        Update,
        Delete
    }

    public class DBParameters
    {

        public string Server = "";
        public string Port = "";
        public string DBName = "";
        public string User = "";
        public string Password = "";
        public bool ShowConfigDB = true;

        public string GetConnectionString()
        {

            string connectionString = string.Format(
                "Data Source={0};User ID={2};Password={3};Initial Catalog={1};Persist Security Info=true",
                this.Server, this.DBName, this.User, this.Password);

            return connectionString;

        }

    }

}
