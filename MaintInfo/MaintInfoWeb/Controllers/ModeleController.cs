using MaintInfoBll.Gestionnaires;
using MaintInfoBo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaintInfoWeb.Controllers
{
    public class ModeleController : Controller
    {
        private ModeleGestionnaire modGes;

        public ModeleController()
        {
            modGes = new ModeleGestionnaire();
        }

        // GET: Modele
        public ActionResult Index()
        {
            IEnumerable<Modele> listeDesModeles = modGes.afficherTousLesModeles();
            return View(listeDesModeles);
        }
        
        // GET: Modele/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Modele/Create
        [HttpPost]
        public ActionResult Create(Modele modele)
        {
            if (modGes.modeleExiste(modele.designation_modele))
            {
                ModelState.AddModelError("Modele", "Ce modèle existe déjà");
                return View(modele);
            }
            if (!ModelState.IsValid)
                return View(modele);
            try
            {
                modGes.ajouterModele(modele);
                return RedirectToAction("Index");
            }
            catch
            {
                ModelState.AddModelError("AddModele", "L'ajout a échoué");
                return View();
            }
        }

        // GET: Modele/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                Modele modele = modGes.afficherModeleParID(id);
                if (modele == null)
                    return View("Error");
                return View(modele);
            }
            catch 
            {
                return HttpNotFound();
            }
        }

        // POST: Modele/Edit/5
        [HttpPost]
        public ActionResult Edit(Modele modele)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(modele);
                modGes.modifierModele(modele);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Modele/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Modele/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Modele/Delete/5
        [HttpPost]
        public ActionResult Delete(Modele modele)
        {
            try
            {
                modGes.supprimerModele(modele);
                return RedirectToAction("Index");
            }
            catch
            {
                ModelState.AddModelError("DelModele", "La suppression a échouée");
                return View();
            }
        }
    }
}
