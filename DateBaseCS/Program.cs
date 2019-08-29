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
            throw new NotImplementedException();
        }

        public override void OpenConection()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public override void OpenConection()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
