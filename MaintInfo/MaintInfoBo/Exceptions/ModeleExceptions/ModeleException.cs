using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBo.Exceptions.ModeleExceptions
{
    public class ModeleException : MaintInfoException
    {
        public ModeleException() { }
        public ModeleException(string message): base(message)  { }
        public ModeleException(string message, Exception inner): base(message, inner) { }
    }
}
