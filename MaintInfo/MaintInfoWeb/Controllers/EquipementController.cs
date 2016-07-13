using MaintInfoBll.Gestionnaires;
using MaintInfoBo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaintInfoWeb.Controllers
{
    public class EquipementController : Controller
    {
        private EquipementGestionnaire equGes;

        public EquipementController()
        {
            equGes = new EquipementGestionnaire();
        }

        // GET: Equipement
        public ActionResult Index()
        {
            IEnumerable<Equipement> listeDesEquipements = equGes.afficherTousLesEquipements();
            return View(listeDesEquipements);
        }


        // GET: Equipement/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Equipement/Create
        [HttpPost]
        public ActionResult Create(Equipement equip)
        {
            if (equGes.equipementExiste(equip.num_serie))
            {
                ModelState.AddModelError("Numéro de série", "Ce numéro de série existe déjà");
                return View(equip);
            }
            if (!ModelState.IsValid)
            {
                return View(equip);
            }
            try
            {
                equGes.ajouterEquipement(equip);
                return RedirectToAction("Index");
            }
            catch
            {
                ModelState.AddModelError("AddEquipement", "L'ajout a échoué");
                return View();
            }
        }

        // GET: Equipement/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                Equipement equip = equGes.afficherEquipementParID(id);
                if (equip == null)
                    return View("Error");
                return View(equip);
            }
            catch 
            {
                return HttpNotFound();
            }
        }

        // POST: Equipement/Edit/5
        [HttpPost]
        public ActionResult Edit(Equipement equip)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(equip);
                equGes.modifierEquipement(equip);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Equipement/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Equipement/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Equipement/Delete/5
        [HttpPost]
        public ActionResult Delete(Equipement equip)
        {
            try
            {
                equGes.supprimerEquipement(equip);
                return RedirectToAction("Index");
            }
            catch
            {
                ModelState.AddModelError("DelEquipement", "La suppression a échouée");
                return View();
            }
        }
    }
}
