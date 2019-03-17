using System;
using System.Runtime.Serialization;

namespace hw1303
{
    [Serializable]
    internal class StringAlreadyExsitsException : Exception
    {
        public StringAlreadyExsitsException()
        {
        }

        public StringAlreadyExsitsException(string message) : base(message)
        {
        }

        public StringAlreadyExsitsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected StringAlreadyExsitsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}