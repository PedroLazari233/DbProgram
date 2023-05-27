using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProgram
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public override void CloseDbConnection()
        {
            Console.WriteLine("Closing SQL connection.");
        }

        public override void OpenDbConnection()
        {
            Console.WriteLine("Openning SQl connection");
        }
    }
}
