using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBll.Gestionnaires.GestionnaireExceptions
{
    public class BllGestionnaireExceptionFinAppli : BllGestionnaireException
    {
        public BllGestionnaireExceptionFinAppli() : base() { }
        public BllGestionnaireExceptionFinAppli(string message) : base(message) { }
        public BllGestionnaireExceptionFinAppli(string message, System.Exception inner) : base(message, inner) { }
    }
}
