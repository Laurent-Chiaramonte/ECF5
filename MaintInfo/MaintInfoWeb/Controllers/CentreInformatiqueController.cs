using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaintInfoWeb.Controllers
{
    public class CentreInformatiqueController : Controller
    {
        // GET: CentreInformatique
        public ActionResult Index()
        {
            return View();
        }

        // GET: CentreInformatique/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CentreInformatique/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CentreInformatique/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CentreInformatique/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CentreInformatique/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
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
