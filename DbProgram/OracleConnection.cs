using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProgram
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void CloseDbConnection()
        {
            Console.WriteLine("Closing Oracle connection.");
        }

        public override void OpenDbConnection()
        {
            Console.WriteLine("Openning Oracle connection");
        }
    }
}
