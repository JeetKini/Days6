using System;

namespace Days6
{
    class OracleConnection : DbConnection
    {
        public override void Opening()
        {
            Console.WriteLine("Connection Opened");
        }
        public override void Closing()
        {
            Console.WriteLine("Connection Closed");
        }
    }
}


