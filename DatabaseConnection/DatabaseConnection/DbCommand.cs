using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
    public class DbCommand
    {
        private readonly DbConnection _dBConnection;
        private readonly string _dbInstruction;

        public DbCommand(DbConnection dbConncetion, string dbInstruction)
        {
            if (dbConncetion == null)
                throw new NullReferenceException("No active connection.");

            if(String.IsNullOrEmpty(dbInstruction))
                throw new NullReferenceException("Instruction is non-existant.");

            _dBConnection = dbConncetion;

            _dbInstruction = dbInstruction;
        }

        public void Execute()
        {
            _dBConnection.OpenConn();
            Console.WriteLine("Exicuting the instruction: " + _dbInstruction);
            _dBConnection.CloseConn();
        }


    }
}
