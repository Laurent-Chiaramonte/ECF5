using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBo.Exceptions
{
    public class MaintInfoException : Exception
    {
        public MaintInfoException() { }
        public MaintInfoException(string message): base(message) { }
        public MaintInfoException(string message, Exception inner): base (message, inner) { }
    }
}
