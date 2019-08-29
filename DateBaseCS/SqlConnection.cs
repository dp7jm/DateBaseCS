using System;

namespace DateBaseCS
{
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
}
