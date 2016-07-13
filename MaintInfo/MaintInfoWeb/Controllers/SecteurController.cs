using MaintInfoBll.Gestionnaires;
using MaintInfoBo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaintInfoWeb.Controllers
{
    public class SecteurController : Controller
    {
        private SecteurGestionnaire secGes;

        public SecteurController()
        {
            secGes = new SecteurGestionnaire();
        }
        // GET: Secteur
        public ActionResult Index()
        {
            IEnumerable<Secteur> listeDesSecteurs = secGes.afficherTousLesSecteurs();
            return View(listeDesSecteurs);
        }

        // GET: Secteur/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Secteur/Create
        [HttpPost]
        public ActionResult Create(Secteur secteur)
        {
            if (secGes.secteurExiste(secteur.libelleSecteur))
            {
                ModelState.AddModelError("Secteur", "Ce secteur existe déjà");
                return View(secteur);
            }
            if (!ModelState.IsValid)
                return View(secteur);
            try
            {
                secGes.ajouterSecteur(secteur);
                return RedirectToAction("Index");
            }
            catch
            {
                ModelState.AddModelError("AddSecteur", "L'ajout a échoué");
                return View();
            }
        }

        // GET: Secteur/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                Secteur secteur = secGes.afficherSecteurParID(id);
                if (secteur == null)
                    return View("Error");
                return View(secteur);
            }
            catch
            {
                return HttpNotFound();
            }
        }

        // POST: Secteur/Edit/5
        [HttpPost]
        public ActionResult Edit(Secteur secteur)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(secteur);
                secGes.modifierSecteur(secteur);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Secteur/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Secteur/Delete/5
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


        // GET: Secteur/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
    }
}
