using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProgram
{
    public abstract class DbConnection
    {
        private string _connectionString;
        private TimeSpan _timeout;

        public DbConnection(string connectionString)
        {
            if(String.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentNullException("A connection string can not be null or empty");
            }

            _connectionString = connectionString;
            _timeout = TimeSpan.FromSeconds(20);
        }

        public abstract void OpenDbConnection();
        public abstract void CloseDbConnection();
    }
}
