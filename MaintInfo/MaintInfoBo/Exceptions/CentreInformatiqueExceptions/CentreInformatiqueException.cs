using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBo.Exceptions.CentreInformatiqueExceptions
{
    public class CentreInformatiqueException : MaintInfoException
    {
        public CentreInformatiqueException() { }
        public CentreInformatiqueException(string message): base(message)  { }
        public CentreInformatiqueException(string message, Exception inner): base(message, inner) { }
    }
}
