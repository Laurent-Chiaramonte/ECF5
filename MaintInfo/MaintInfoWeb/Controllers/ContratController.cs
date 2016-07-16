using MaintInfoBll.Gestionnaires;
using MaintInfoBo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaintInfoWeb.Controllers
{
    public class ContratController : Controller
    {
        private ContratGestionnaire conGes;

        public ContratController()
        {
            conGes = new ContratGestionnaire();
        }

        // GET: Contrat
        public ActionResult Index()
        {
            IEnumerable<Contrat> listeDesContrats = conGes.afficherTousLesContrats();
            return View(listeDesContrats);
        }


        // GET: Contrat/Create
        public ActionResult Create()
        {
            return PartialView("_create");
        }

        // POST: Contrat/Create
        [HttpPost]
        public ActionResult Create(Contrat contrat)
        {
            if (conGes.contratExiste(contrat.centreInformatiqueID))
            {
                ModelState.AddModelError("Contrat", "Ce centre informatique a déjà un contrat");
                return View(contrat);
            }
            if (!ModelState.IsValid)
            {
                return View(contrat);
            }
            try
            {
                conGes.ajouterContrat(contrat);
                return RedirectToAction("Index");
            }
            catch
            {
                ModelState.AddModelError("AddContrat", "L'ajout a échoué");
                return View();
            }
        }

        // GET: Contrat/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                Contrat contrat = conGes.afficherContratParID(id);
                if (contrat == null)
                    return View("Error");
                return PartialView("_edit", contrat);
            }
            catch
            {

                return HttpNotFound();
            }
        }

        // POST: Contrat/Edit/5
        [HttpPost]
        public ActionResult Edit(Contrat contrat)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(contrat);
                conGes.modifierContrat(contrat);
                return RedirectToAction("Index");
            }
            catch
            {

                return View();
            }
        }


        // GET: Contrat/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Contrat/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Contrat/Delete/5
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
