using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BolsaEmpleo.EXCEPTIONS
{
    public class MysglException : Exception
    {
        public MysglException()
        {
        }

        public MysglException(string message) : base(message)
        {
        }

        public MysglException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MysglException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
