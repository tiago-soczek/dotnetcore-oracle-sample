using System;
using Oracle.ManagedDataAccess.Client;

namespace OracleCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Connecting to Oracle...");

            using (var conn = new OracleConnection())
            {
                conn.ConnectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=system;Password=oracle;";
                conn.Open();

                Console.WriteLine("Connected!");

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT 1+2 FROM DUAL";

                    Console.WriteLine("Executing command:");

                    var result = cmd.ExecuteScalar();

                    Console.WriteLine($"Result: {result}");
                }
            }

            Console.WriteLine("Done!");
        }
    }
}
