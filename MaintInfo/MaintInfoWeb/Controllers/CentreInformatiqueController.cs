using MaintInfoBll.Gestionnaires;
using MaintInfoBo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaintInfoWeb.Controllers
{
    public class CentreInformatiqueController : Controller
    {
        private CentreInformatiqueGestionnaire ceninfoGes;

        public CentreInformatiqueController()
        {
            ceninfoGes = new CentreInformatiqueGestionnaire();
        }

        // GET: CentreInformatique
        public ActionResult Index()
        {
            IEnumerable<CentreInformatique> listeDesCentres = ceninfoGes.afficherTousLesCentresInformatique();
            return View(listeDesCentres);
        }


        // GET: CentreInformatique/Create
        public ActionResult Create()
        {
            return PartialView("_create");
        }

        // POST: CentreInformatique/Create
        [HttpPost]
        public ActionResult Create(CentreInformatique centreInfo)
        {
            if (ceninfoGes.centreInformatiqueExiste(centreInfo.adresse_centre))
            {
                ModelState.AddModelError("Adresse", "Un centre existe déjà à cette adresse");
                return View(centreInfo);
            }
            if (!ModelState.IsValid)
            {
                return View(centreInfo);
            }
            try
            {
                ceninfoGes.ajouterCentreInformatique(centreInfo);
                return RedirectToAction("Index");
            }
            catch
            {
                ModelState.AddModelError("AddCentreInformatique", "L'ajout a échoué");
                return View();
            }
        }

        // GET: CentreInformatique/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                CentreInformatique centreInfo = ceninfoGes.afficherCentreInformatiqueParID(id);
                if (centreInfo == null)
                    return View("Error");
                return PartialView("_edit", centreInfo);
            }
            catch
            {

                return HttpNotFound();
            }
        }

        // POST: CentreInformatique/Edit/5
        [HttpPost]
        public ActionResult Edit(CentreInformatique centreInfo)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(centreInfo);
                ceninfoGes.modifierCentreInformatique(centreInfo);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        // GET: CentreInformatique/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CentreInformatique/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CentreInformatique/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
