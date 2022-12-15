using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LightControl.Domain.Exceptions
{
    public class BillNotFoundException : Exception
    {
        public BillNotFoundException() : this("||                    NENHUMA FATURA ENCONTRADA                     ||")
        {
        }
        public BillNotFoundException(string message) : base(message)
        {
        }

        public BillNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BillNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
