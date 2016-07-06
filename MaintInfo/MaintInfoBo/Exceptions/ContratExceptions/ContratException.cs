using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBo.Exceptions.ContratExceptions
{
    public class ContratException : MaintInfoException
    {
        public ContratException() { }
        public ContratException(string message): base(message)  { }
        public ContratException(string message, Exception inner): base(message, inner) { }
    }
}
