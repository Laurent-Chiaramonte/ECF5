using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBo.Exceptions.ModeleExceptions
{
    public class NotExistModeleException : ModeleException
    {
        public NotExistModeleException() { }
        public NotExistModeleException(string message) : base(message) { }
        public NotExistModeleException(string message, Exception inner) : base (message, inner) { }
    }
}
