using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBo.Exceptions.SecteurExceptions
{
    public class SecteurException : MaintInfoException
    {
        public SecteurException() { }
        public SecteurException(string message): base(message)  { }
        public SecteurException(string message, Exception inner): base(message, inner) { }
    }
}
