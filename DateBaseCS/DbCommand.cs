using System;

namespace DateBaseCS
{
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
}
