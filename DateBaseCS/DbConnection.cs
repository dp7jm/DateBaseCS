using System;

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
}
