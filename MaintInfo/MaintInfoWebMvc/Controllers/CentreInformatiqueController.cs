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
        public ActionResult Index(int? id)
        {
            if (id.HasValue)
            {
                CentreInformatique leCentre = ceninfoGes.afficherCentreInformatiqueParID(id.Value);
                return View(leCentre);
            }
            else
                return HttpNotFound();
        }
    }
}