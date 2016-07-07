using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBll.Exceptions
{
    class BllManagerExceptionFinAppli : BllManagerException
    {
        public BllManagerExceptionFinAppli() : base() { }

        public BllManagerExceptionFinAppli(string message) : base(message) { }
        public BllManagerExceptionFinAppli(string message, System.Exception inner) : base(message, inner) { }
    }
}
