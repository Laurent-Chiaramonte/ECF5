using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBo.Exceptions.SecteurExceptions
{
    public class NotExistSecteurException : SecteurException
    {
        public NotExistSecteurException() { }
        public NotExistSecteurException(string message) : base(message) { }
        public NotExistSecteurException(string message, Exception inner) : base (message, inner) { }
    }
}
