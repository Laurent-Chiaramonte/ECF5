using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBo.Exceptions.TarifExceptions
{
    public class TarifException : MaintInfoException
    {
        public TarifException() { }
        public TarifException(string message): base(message)  { }
        public TarifException(string message, Exception inner): base(message, inner) { }
    }
}
