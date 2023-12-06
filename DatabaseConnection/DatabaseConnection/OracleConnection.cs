using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
    public class OracleConnection : DbConnection
    {

        public OracleConnection(string oracleConnString)
            : base(oracleConnString)
        {
            Console.WriteLine("Now we using Oracle connection.");
        }

        public override void OpenConn()
        {
            if(IsConnected) 
                throw new InvalidOperationException("Oracle DB is already opened.");

            IsConnected = true;
            Console.WriteLine("Oracle DB has been opened.");
        }

        public override void CloseConn()
        {
            if(IsConnected == false)
                throw new InvalidOperationException("Oracle DB is not open.");

            IsConnected = false;
            Console.WriteLine("Oracle DB has been closed.");
        }
    }
}
