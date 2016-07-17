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
        private CentreInformatiqueGestionnaire cenInfoGes;
        private SecteurGestionnaire secGes;

        public ClientController()
        {
            cliGes = new ClientGestionnaire();
            cenInfoGes = new CentreInformatiqueGestionnaire();
            secGes = new SecteurGestionnaire();
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
            return PartialView("_create");
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
                return PartialView("_edit", client);
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
            // Recupérer les centres informatiques du client
            IEnumerable<CentreInformatique> lstCentres = cenInfoGes.afficherTousLesCentresInformatique();
            IEnumerable<CentreInformatique> lesCentres = lstCentres.Where(client => client.clientID == id).ToList();

            // Mettre le client dans le ViewBag
            Client leClient = cliGes.afficherClientParID(id);
            TempData["leClient"] = leClient;
            ViewBag.LeClient = leClient.nom_client;

            // Mettre les secteur dans le ViewBag
            IEnumerable<Secteur> lstSecteurs = secGes.afficherTousLesSecteurs();
            TempData["lstSecteurs"] = lstSecteurs;
            ViewBag.LesSecteurs = new SelectList(lstSecteurs, "secteurID", "libelleSecteur");

            if (lesCentres.Count() == 0)
            {
                return PartialView("_createCentreDuClient");
            }
            else
            {
                return PartialView("_afficherCentresDuClient", lesCentres);
            }
        }

        public ActionResult ContratDuClient(int id)
        {
            ContratGestionnaire conGes = new ContratGestionnaire();
            IEnumerable<Contrat> lstContrats = conGes.afficherTousLesContrats();
            Contrat leContrat = lstContrats.FirstOrDefault(contrat => contrat.centreInformatiqueID == id);
            if (leContrat == null)
            {
                return PartialView("_creerContratDuCentre");
            }
            else
            {
                return PartialView("_afficherContratDuCentre", leContrat);
            } 
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
