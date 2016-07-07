using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBll.Exceptions
{
    class BllExceptionFinAppli : BllException
    {
        public BllExceptionFinAppli() : base() { }

        public BllExceptionFinAppli(string message) : base(message) { }
        public BllExceptionFinAppli(string message, System.Exception inner) : base(message, inner) { }
    }
}
