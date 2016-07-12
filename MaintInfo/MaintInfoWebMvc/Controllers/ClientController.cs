using MaintInfoBll.Gestionnaires;
using MaintInfoBo;
using MaintInfoDal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaintInfoWebMvc.Controllers
{
    public class ClientController : Controller
    {
        private ClientGestionnaire cliGes;

        public ClientController()
        {
            cliGes = new ClientGestionnaire();
        }
        public ActionResult Index()
        {
            IEnumerable<Client> listeDesClients = cliGes.afficherTousLesClients();
            return View(listeDesClients);
        }

        public ActionResult ModifierClient(int id)
        {
            if (id != 0)
            {
                Client client = cliGes.afficherClientParID(id);
                if (client == null)
                    return View("Error");
                return View(client);
            }
            else
                return HttpNotFound();
        }

        [HttpPost]
        public ActionResult ModifierClient(Client client)
        {
            if (!ModelState.IsValid)
                return View(client);
            cliGes.modifierClient(client);
            return RedirectToAction("Index");
        }
    }
}