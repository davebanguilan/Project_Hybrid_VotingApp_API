using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VotingApp.CustomExceptions
{
    public class InvalidEmailPasswordException : Exception
    {
        public InvalidEmailPasswordException()
        {
        }

        public InvalidEmailPasswordException(string message) : base(message)
        {
        }

        public InvalidEmailPasswordException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidEmailPasswordException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
