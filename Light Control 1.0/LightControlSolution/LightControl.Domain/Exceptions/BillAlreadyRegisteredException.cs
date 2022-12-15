using System;
using System.Runtime.Serialization;

namespace LightControl.Domain.Exceptions
{
    [Serializable]
    public class BillAlreadyRegisteredException : Exception
    {
        public BillAlreadyRegisteredException() : this("Esta conta já está cadastrada.")
        {
        }

        public BillAlreadyRegisteredException(string message) : base(message)
        {
        }

        public BillAlreadyRegisteredException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BillAlreadyRegisteredException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}