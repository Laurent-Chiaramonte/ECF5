using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBo.Exceptions.TypeExceptions
{
    public class TypeException : MaintInfoException
    {
        public TypeException() { }
        public TypeException(string message): base(message)  { }
        public TypeException(string message, Exception inner): base(message, inner) { }
    }
}
