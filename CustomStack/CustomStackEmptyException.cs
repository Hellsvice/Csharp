using System;
using System.Runtime.Serialization;

namespace _2024_07_05
{
    [Serializable]
    internal class CustomStackEmptyException : Exception
    {
        public CustomStackEmptyException()
        {
        }

        public CustomStackEmptyException(string message) : base(message)
        {
        }

        public CustomStackEmptyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CustomStackEmptyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}