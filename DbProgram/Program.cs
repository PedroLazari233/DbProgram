using DbProgram;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("What type of DBMS (Database management system) do you want to connect? (A) Oracle or (B) SQL");
        var connectionString = Console.ReadLine();

        try
        {
            if (connectionString == "A")
            {
                var oracleConnection = new OracleConnection(connectionString);
                oracleConnection.OpenDbConnection();
                Console.WriteLine("Insert an instruction for the Database command");
                var input = Console.ReadLine();
                var dbCommand = new DbCommand(oracleConnection, input);
                dbCommand.Execute();
                oracleConnection.CloseDbConnection();
            }
            else if (connectionString == "B")
            {
                var sQLConnection = new SqlConnection(connectionString);
                sQLConnection.OpenDbConnection();
                Console.WriteLine("Insert an instruction for the Database command");
                var input = Console.ReadLine();
                var dbCommand = new DbCommand(sQLConnection, input);
                dbCommand.Execute();
                sQLConnection.CloseDbConnection();
            }
        }
        catch (ArgumentNullException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}