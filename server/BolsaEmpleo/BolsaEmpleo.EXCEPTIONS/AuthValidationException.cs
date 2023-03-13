using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BolsaEmpleo.EXCEPTIONS {
    public class AuthValidationException : Exception {
        public AuthValidationException() {

        }

        public AuthValidationException(string message) : base(message) {}
        public AuthValidationException(string message, Exception innerException) : base(message, innerException) {}
        protected AuthValidationException(SerializationInfo info, StreamingContext context) : base(info, context) {}
    }
}
