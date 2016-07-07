using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBll.Exceptions
{
    public class BllException : Exception
    {
        public BllException() : base() { }

        public BllException(string message) : base(message) { }
        public BllException(string message, System.Exception inner) : base(message, inner) { }
    }
}
