using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBo.Exceptions.ClientExceptions
{
    public class NotExistClientException : ClientException
    {
        public NotExistClientException() { }
        public NotExistClientException(string message) : base(message) { }
        public NotExistClientException(string message, Exception inner) : base (message, inner) { }
    }
}
