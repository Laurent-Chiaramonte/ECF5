using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBo.Exceptions.EquipementExceptions
{
    public class NotExistEquipementException : EquipementException
    {
        public NotExistEquipementException() { }
        public NotExistEquipementException(string message) : base(message) { }
        public NotExistEquipementException(string message, Exception inner) : base (message, inner) { }
    }
}
