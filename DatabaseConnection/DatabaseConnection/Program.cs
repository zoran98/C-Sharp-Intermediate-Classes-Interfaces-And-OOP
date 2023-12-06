using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbCommand = new DbCommand(new SqlConnection("SQL connection"), "Some instructions");
            Console.WriteLine(dbCommand);

            var dbCommand1 = new DbCommand(new OracleConnection("Oracle connection"), "Some instructions");
            Console.WriteLine(dbCommand1);
        }
    }
}
