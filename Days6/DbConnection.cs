using System;

namespace Days6
{
    abstract class DbConnection {
        string ConnectionStrnig;
        TimeSpan TimeOut;

        public abstract void Opening ();
        public abstract void Closing ();
    }
    }

