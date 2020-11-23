using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace lab5
{

    internal class BoquetException : Exception
    {
        private void Log()
        {
            Logger.LogError($"BoquetException! {this.Message}");
        }

        public BoquetException()
        {
            Log();
        }

        public BoquetException(string message) : base(message)
        {
            Log();
        }

        public BoquetException(string message, Exception innerException) : base(message, innerException)
        {
            Log();
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

    internal class EmptyBouquet : BoquetException
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

    internal class FlowersException : BoquetException
    {
        public FlowersException()
        {
        }

        public FlowersException(string message) : base(message)
        {
        }

        public FlowersException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    internal class PaperTextException : BoquetException
    {
        public PaperTextException()
        {
        }

        public PaperTextException(string message) : base(message)
        {
        }

        public PaperTextException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}