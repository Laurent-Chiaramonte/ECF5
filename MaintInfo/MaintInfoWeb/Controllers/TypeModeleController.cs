using MaintInfoBll.Gestionnaires;
using MaintInfoBo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaintInfoWeb.Controllers
{
    public class TypeModeleController : Controller
    {
        private TypeModeleGestionnaire tmodGes;

        public TypeModeleController()
        {
            tmodGes = new TypeModeleGestionnaire();
        }

        // GET: TypeModele
        public ActionResult Index()
        {
            IEnumerable<TypeModele> listeDesTypesModele = tmodGes.afficherTousLesTypesModele();
            return View(listeDesTypesModele);
        }

        // GET: TypeModele/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TypeModele/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TypeModele/Create
        [HttpPost]
        public ActionResult Create(TypeModele typeModele)
        {
            if (!ModelState.IsValid)
                return View(typeModele);
            try
            {
                tmodGes.ajouterTypeModele(typeModele);
                return RedirectToAction("Index");
            }
            catch
            {
                ModelState.AddModelError("AddTypeModele", "L'ajout a échoué");
                return View();
            }
        }

        // GET: TypeModele/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                TypeModele typeModele = tmodGes.afficherTypeModeleParID(id);
                if (typeModele == null)
                    return View("Error");
                return View(typeModele);
            }
            catch
            {
                return HttpNotFound();
            }
        }

        // POST: TypeModele/Edit/5
        [HttpPost]
        public ActionResult Edit(TypeModele typeModele)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(typeModele);
                }
                tmodGes.modifierTypeModele(typeModele);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TypeModele/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TypeModele/Delete/5
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
