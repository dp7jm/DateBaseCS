using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateBaseCS
{
    public abstract class DbConnection
    {
        public string ConectionString { get; private set; }
        public TimeSpan Timneout { get; set; }
        public DbConnection(string conectionString)
        {
            if (string.IsNullOrWhiteSpace(conectionString))
            {
                throw new NullReferenceException("conectoin string must be not empty");
            }
        }
        public abstract void OpenConection();
        
        public abstract void CloseConection();
        
    }
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string conectionString)
            : base(conectionString) { }
        
        public override void CloseConection()
        {
            Console.WriteLine("close conection to sql");
        }

        public override void OpenConection()
        {
            Console.WriteLine("open connection to sql");
        }
    }
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string conectionString)
            : base(conectionString)
        {

        }
        public override void CloseConection()
        {
            Console.WriteLine("close connection to oracle");
        }

        public override void OpenConection()
        {
            Console.WriteLine("open connection to oracle");
        }
    }
    
    public class DbCommand
    {
        private DbConnection DbConnect { get; set; }
        private string Instruction { get; set; }
        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if (dbConnection.Equals(null) || string.IsNullOrWhiteSpace(instruction))
            {
                throw new NullReferenceException("null exception");
            }
            DbConnect = dbConnection;
            Instruction = instruction;
        }
        public void Execute()
        {
            DbConnect.OpenConection();
            Console.WriteLine(Instruction);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DbCommand command = new DbCommand(new SqlConnection("password"), "fier");
            command.Execute();

            DbCommand command2 = new DbCommand(new OracleConnection("password"), "fier");
            command2.Execute();

            
            Console.ReadKey();
        }
    }
}
