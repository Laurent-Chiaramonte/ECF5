using MaintInfoBo.Exceptions.TypeExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBo.Exceptions.TypeModeleExceptions
{
    public class NotExistTypeModeleException : TypeModeleException
    {
        public NotExistTypeModeleException() { }
        public NotExistTypeModeleException(string message) : base(message) { }
        public NotExistTypeModeleException(string message, Exception inner) : base (message, inner) { }
    }
}
