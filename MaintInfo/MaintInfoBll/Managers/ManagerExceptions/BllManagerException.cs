using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBll.Exceptions
{
    public class BllManagerException : Exception
    {
        public BllManagerException() : base() { }

        public BllManagerException(string message) : base(message) { }
        public BllManagerException(string message, System.Exception inner) : base(message, inner) { }
    }
}
