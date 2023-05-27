using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProgram
{
    public class DbCommand
    {
        private DbConnection _dbConnection;
        private string _instruction;

        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if (dbConnection == null)
                throw new ArgumentNullException("DbConnection can not be null.");

            this._dbConnection = dbConnection;

            if (String.IsNullOrEmpty(instruction))
                throw new ArgumentNullException("instruction can not be null or empty.");

            this._instruction = instruction;
        }

        public void Execute()
        {
            Console.WriteLine(_instruction);
        }
    }
}
