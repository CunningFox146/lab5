using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace NetCoreLab5
{
    internal class BoquetException : Exception
    {
        public BoquetException()
        {
        }

        public BoquetException(string message) : base(message)
        {
        }

        public BoquetException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
    internal class NegativeFlowersException : BoquetException
    {
        public NegativeFlowersException()
        {
        }

        public NegativeFlowersException(string message) : base(message)
        {
        }

        public NegativeFlowersException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    internal class EmptyBouquet : Exception
    {
        public EmptyBouquet()
        {
        }

        public EmptyBouquet(string message) : base(message)
        {
        }

        public EmptyBouquet(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

}