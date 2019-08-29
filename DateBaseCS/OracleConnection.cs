using System;

namespace DateBaseCS
{
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
}
