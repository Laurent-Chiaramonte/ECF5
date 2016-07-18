using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBo.Exceptions.ContratExceptions
{
    public class NotExistContratException : ContratException
    {
        public NotExistContratException() { }
        public NotExistContratException(string message) : base(message) { }
        public NotExistContratException(string message, Exception inner) : base (message, inner) { }
    }
}
