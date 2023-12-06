using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string sqlConnString)
            : base(sqlConnString)
        {
            Console.WriteLine("Now we using sql connection!");
        }

        public override void OpenConn()
        {
            if (IsConnected)
                throw new InvalidOperationException("Sql DB is already opened.");

            IsConnected = true;
            Console.WriteLine("Sql Connection has been opened.");
        }


        public override void CloseConn()
        {
            if(IsConnected == false)
                throw new InvalidOperationException("Sql DB is not open.");

            IsConnected= false;
            Console.WriteLine("Sql DB has been closed.");
        }
    }
}
