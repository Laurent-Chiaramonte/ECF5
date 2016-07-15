using MaintInfoBll.Gestionnaires;
using MaintInfoBo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaintInfoWeb.Controllers
{
    public class TarifController : Controller
    {
        private TarifGestionnaire tarGes;

        public TarifController()
        {
            tarGes = new TarifGestionnaire();
        }

        // GET: Tarif
        public ActionResult Index()
        {
            IEnumerable<Tarif> listeDesTarifs = tarGes.afficherTousLesTarifs();
            return View(listeDesTarifs);
        }

        // GET: Tarif/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Tarif/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tarif/Create
        [HttpPost]
        public ActionResult Create(Tarif tarif)
        {
            if (!ModelState.IsValid)
                return View(tarif);
            try
            {
                tarGes.ajouterTarif(tarif);
                return RedirectToAction("Index");
            }
            catch
            {
                ModelState.AddModelError("AddTarif", "L'ajout a échoué");
                return View();
            }
        }

        // GET: Tarif/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                Tarif tarif = tarGes.afficherTarifParID(id);
                if (tarif == null)
                    return View("Error");
                return View(tarif);
            }
            catch
            {
                return HttpNotFound();
            }
        }

        // POST: Tarif/Edit/5
        [HttpPost]
        public ActionResult Edit(Tarif tarif)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(tarif);
                }
                tarGes.modifierTarif(tarif);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tarif/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Tarif/Delete/5
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
