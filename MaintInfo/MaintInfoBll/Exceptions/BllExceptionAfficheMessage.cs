using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBll.Exceptions
{
    class BllExceptionAfficheMessage : BllException
    {
        public BllExceptionAfficheMessage() : base() { }

        public BllExceptionAfficheMessage(string message) : base(message) { }
        public BllExceptionAfficheMessage(string message, System.Exception inner) : base(message, inner) { }
    }
}
