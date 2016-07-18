using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBo.Exceptions.TarifExceptions
{
    public class NotExistTarifException : TarifException
    {
        public NotExistTarifException() { }
        public NotExistTarifException(string message) : base(message) { }
        public NotExistTarifException(string message, Exception inner) : base (message, inner) { }
    }
}
