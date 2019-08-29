using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateBaseCS
{

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
