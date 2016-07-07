using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBll.Gestionnaires.GestionnaireExceptions
{
    public class BllGestionnaireException : Exception
    {
        public BllGestionnaireException() : base() { }
        public BllGestionnaireException(string message) : base(message) { }
        public BllGestionnaireException(string message, System.Exception inner) : base(message, inner) { }
    }
}
