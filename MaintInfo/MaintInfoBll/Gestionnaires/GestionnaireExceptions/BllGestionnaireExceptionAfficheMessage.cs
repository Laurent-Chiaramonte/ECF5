using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBll.Gestionnaires.GestionnaireExceptions
{
    public class BllGestionnaireExceptionAfficheMessage : BllGestionnaireException
    {
        public BllGestionnaireExceptionAfficheMessage() : base() { }
        public BllGestionnaireExceptionAfficheMessage(string message) : base(message) { }
        public BllGestionnaireExceptionAfficheMessage(string message, System.Exception inner) : base(message, inner) { }
    }
}
