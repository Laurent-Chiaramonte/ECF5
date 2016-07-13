using MaintInfoBll.Gestionnaires;
using MaintInfoBo;
using MaintInfoDal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaintInfoWeb.Controllers
{
    public class ClientController : Controller
    {
        private ClientGestionnaire cliGes;
        public ClientController()
        {
            cliGes = new ClientGestionnaire();
        }

        // GET: Client
        public ActionResult Index()
        {
            IEnumerable<Client> listeDesClients = cliGes.afficherTousLesClients();
            return View(listeDesClients);
        }

        

        // GET: Client/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Client/Create
        [HttpPost]
        public ActionResult Create(Client client)
        {
            if (cliGes.clientExiste(client.nom_client))
            {
                ModelState.AddModelError("Nom", "Ce nom de client existe déjà");
                return View(client);
            }
            if (!ModelState.IsValid)
                return View(client);
            try
            {
                cliGes.ajouterClient(client);
                return RedirectToAction("Index");
            }
            catch
            {
                ModelState.AddModelError("AddClient", "L'ajout a échoué");
                return View();
            }
        }

        // GET: Client/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                Client client = cliGes.afficherClientParID(id);
                if (client == null)
                    return View("Error");
                return View(client);
            }
            catch
            {
                return HttpNotFound();
            }
        }

        // POST: Client/Edit/5
        [HttpPost]
        public ActionResult Edit(Client client)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(client);
                cliGes.modifierClient(client);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        // GET: Client/Details/5
        public ActionResult Details(int id)
        {
            CentreInformatiqueGestionnaire cenInfoGes = new CentreInformatiqueGestionnaire();
            IEnumerable<CentreInformatique> lstCentre = cenInfoGes.afficherTousLesCentresInformatique();
            IEnumerable<CentreInformatique> lesCentres = lstCentre.Where(client => client.clientID == id).ToList();
            return PartialView("_AfficherLesCentresDuClient", lesCentres);
        }

        #region Méthodes non utilisées


        // GET: Client/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Client/Delete/5
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

        #endregion
    }
}
