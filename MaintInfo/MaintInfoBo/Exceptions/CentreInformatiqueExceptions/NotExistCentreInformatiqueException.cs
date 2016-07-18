using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBo.Exceptions.CentreInformatiqueExceptions
{
    public class NotExistCentreInformatiqueException : CentreInformatiqueException
    {
        public NotExistCentreInformatiqueException() { }
        public NotExistCentreInformatiqueException(string message) : base(message) { }
        public NotExistCentreInformatiqueException(string message, Exception inner) : base (message, inner) { }
    }
}
