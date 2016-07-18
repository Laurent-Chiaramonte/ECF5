﻿using MaintInfoBll.Gestionnaires;
using MaintInfoBo;
using MaintInfoDal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            // Mettre les clients dans le ViewBag
            IEnumerable<Client> lstClients = cliGes.afficherTousLesClients();
            TempData["lstClients"] = lstClients;
            ViewBag.LesClients = new SelectList(lstClients, "clientID", "nom_client");

            // Mettre le client dans le ViewBag
            Client leClient = cliGes.afficherClientParID(id);
            TempData["leClient"] = leClient;
            ViewBag.LeClient = leClient.nom_client;
            ViewBag.ClientID = leClient.clientID;

            // Mettre les secteurs dans le ViewBag
            IEnumerable<Secteur> lstSecteurs = secGes.afficherTousLesSecteurs();
            TempData["lstSecteurs"] = lstSecteurs;
            ViewBag.LesSecteurs = new SelectList(lstSecteurs, "secteurID", "libelleSecteur");

            if (lesCentres.Count() == 0)
            {
                return PartialView("_creerCentreDuClient");
            }
            else
            {
                return PartialView("_afficherCentresDuClient", lesCentres);
            }
        }

        // GET: Centre/Create
        public ActionResult CreerCentreduClient(int id)
        {
            // Mettre le client dans le ViewBag
            Client leClient = cliGes.afficherClientParID(id);
            TempData["leClient"] = leClient;
            ViewBag.LeClient = leClient.nom_client;
            ViewBag.ClientID = leClient.clientID;
            // Liste clients
            IEnumerable<Client> lstClients = cliGes.afficherTousLesClients();
            TempData["lstClients"] = lstClients;
            ViewBag.LesClients = new SelectList(lstClients, "clientID", "nom_client", leClient.clientID);
            // Liste secteurs
            IEnumerable<Secteur> lstSecteurs = secGes.afficherTousLesSecteurs();
            TempData["lstSecteurs"] = lstSecteurs;
            ViewBag.LesSecteurs = new SelectList(lstSecteurs, "secteurID", "libelleSecteur");

            return PartialView("_creerCentreduClient");
        }

        // POST: Centre/Create
        [HttpPost]
        public ActionResult CreerCentreduClient(CentreInformatique centreInfo)
        {
            if (cenInfoGes.centreInformatiqueExiste(centreInfo.adresse_centre))
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
                cenInfoGes.ajouterCentreInformatique(centreInfo);
                return PartialView("_creerCentreduClient");
            }
            catch
            {
                ModelState.AddModelError("AddCentreInformatique", "L'ajout a échoué");
                return View();
            }
        }

        public ActionResult ContratDuClient(int id)
        {
            // Mettre le client dans le ViewBag
            CentreInformatique leCentre = cenInfoGes.afficherCentreInformatiqueParID(id);
            TempData["leCentreInfo"] = leCentre;
            ViewBag.LeClient = leCentre.leClient.nom_client;
            ViewBag.ClientID = leCentre.leClient.clientID;

            // Mettre le centre informatique dans le ViewBag
            CentreInformatique leCentreInfo = cenInfoGes.afficherCentreInformatiqueParID(id);
            TempData["leCentreInfo"] = leCentreInfo;
            ViewBag.AdresseCentreInfo = leCentreInfo.adresse_centre;
            ViewBag.CentreInfoID = leCentreInfo.centreInformatiqueID;

            
            // Recuperer le contrat
            ContratGestionnaire conGes = new ContratGestionnaire();
            IEnumerable<Contrat> lstContrats = conGes.afficherTousLesContrats();
            Contrat leContrat = lstContrats.FirstOrDefault(contrat => contrat.centreInformatiqueID == id);
            if (leContrat == null)
            {
                return PartialView("_creerContratDuCentre");
            }
            else
            {
                string st = string.Empty;
                switch (leContrat.statut )
                {
                    case 1:
                        st = "En cours";
                        break;
                    case 2:
                        st = "Renouvellé";
                        break;
                    case 3:
                        st = "Résilié";
                        break;
                }
                ViewBag.leStatut = st;
                return PartialView("_afficherContratDuCentre", leContrat);
            } 
        }


        public ActionResult RenouvellerContrat(int id)
        {
            // Recuperer le contrat
            ContratGestionnaire conGes = new ContratGestionnaire();
            Contrat leContrat = conGes.afficherContratParID(id);
            if (leContrat != null)
            {
                int AnNow = Convert.ToInt32(DateTime.Now.Year);
                int AnEch = Convert.ToInt32(leContrat.date_echeance.Year);
                if((AnEch - AnNow) < 1)
                {
                    leContrat.statut = 2;
                    conGes.modifierContrat(leContrat);
                }
            }
            return View("_afficherContratDuCentre", leContrat);
        }

        public ActionResult ResilierContrat(int id)
        {
            // Recuperer le contrat
            ContratGestionnaire conGes = new ContratGestionnaire();
            Contrat leContrat = conGes.afficherContratParID(id);
            if (leContrat != null)
            {
                int AnNow = Convert.ToInt32(DateTime.Now.Year);
                int AnEch = Convert.ToInt32(leContrat.date_echeance.Year);
                if ((AnEch - AnNow) < 1)
                {
                    leContrat.statut = 3;
                    conGes.modifierContrat(leContrat);
                }
            }
            return View("_afficherContratDuCentre", leContrat);
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
