using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
    public abstract class DbConnection
    {
        private string ConnectionString {  get; set; }
        private TimeSpan TimeOut {  get; set; }

        protected bool IsConnected { get; set; }

        public DbConnection(string connString)
        {
            if (String.IsNullOrWhiteSpace(connString))
            {
                throw new ArgumentNullException("Database is not in valid state.");
            }
            else
            {
                ConnectionString = connString;
            }
        }

        public abstract void OpenConn();

        public abstract void CloseConn();
    }
}
