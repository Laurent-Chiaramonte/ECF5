using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBo.Exceptions.EquipementExceptions
{
    public class EquipementException : MaintInfoException
    {
        public EquipementException() { }
        public EquipementException(string message): base(message)  { }
        public EquipementException(string message, Exception inner): base(message, inner) { }
    }
}
