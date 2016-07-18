using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBo.Exceptions.TypeExceptions
{
    public class TypeModeleException : MaintInfoException
    {
        public TypeModeleException() { }
        public TypeModeleException(string message): base(message)  { }
        public TypeModeleException(string message, Exception inner): base(message, inner) { }
    }
}
