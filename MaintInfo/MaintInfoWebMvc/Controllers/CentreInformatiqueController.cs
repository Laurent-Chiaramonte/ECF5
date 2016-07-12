using MaintInfoBll.Gestionnaires;
using MaintInfoBo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaintInfoWebMvc.Controllers
{
    public class CentreInformatiqueController : Controller
    {
        private CentreInformatiqueGestionnaire ceninfoGes;

        public CentreInformatiqueController()
        {
            ceninfoGes = new CentreInformatiqueGestionnaire();
        }
        
        
        public ActionResult AfficherCentreParID(int id)
        {
            IEnumerable<CentreInformatique> lstCentre = ceninfoGes.afficherTousLesCentresInformatique();
            IEnumerable<CentreInformatique> lesCentres = lstCentre.Where(client => client.clientID == id).ToList();
            return PartialView("_AfficherCentreParID", lesCentres);
        }
    }
}