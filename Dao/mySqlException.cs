using System;
using System.Runtime.Serialization;

namespace ProjetoLogin.Dal
{
    [Serializable]
    internal class mySqlException : Exception
    {
        public mySqlException()
        {
        }

        public mySqlException(string message) : base(message)
        {
        }

        public mySqlException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected mySqlException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}