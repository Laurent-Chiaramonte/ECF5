using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBll.Exceptions
{
    class BllManagerExceptionAfficheMessage : BllManagerException
    {
        public BllManagerExceptionAfficheMessage() : base() { }

        public BllManagerExceptionAfficheMessage(string message) : base(message) { }
        public BllManagerExceptionAfficheMessage(string message, System.Exception inner) : base(message, inner) { }
    }
}
