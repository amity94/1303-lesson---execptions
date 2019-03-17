using System;
using System.Runtime.Serialization;

namespace hw1303
{
    [Serializable]
    internal class StringEmptyException : Exception
    {
        public StringEmptyException()
        {
        }

        public StringEmptyException(string message) : base(message)
        {
        }

        public StringEmptyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected StringEmptyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}