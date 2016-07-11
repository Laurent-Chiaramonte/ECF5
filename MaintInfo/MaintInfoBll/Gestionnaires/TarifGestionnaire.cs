using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MaintInfoBll.Gestionnaires.GestionnaireExceptions;
using MaintInfoBo;

namespace MaintInfoBll.Gestionnaires
{
    public class TarifGestionnaire
    {
        TarifManager trMngr;

        public TarifGestionnaire()
        {
            trMngr = new TarifManager();
        }

        public bool ajouterTarif(Tarif tr)
        {
            try
            {
                trMngr.ajouterTarif(tr);
                return true;
            }
            catch (Exception)
            {

                throw new BllGestionnaireExceptionAfficheMessage("Ajout impossible");
            }
        }

        public bool modifierTarif(Tarif tr)
        {
            try
            {
                trMngr.modifierTarif(tr);
                return true;
            }
            catch (Exception)
            {

                throw new BllGestionnaireExceptionAfficheMessage("Modification impossible");
            }
        }

        public bool supprimerTarif(Tarif tr)
        {
            try
            {
                trMngr.supprimerTarif(tr);
                return true;
            }
            catch (Exception)
            {

                throw new BllGestionnaireExceptionAfficheMessage("Suppression impossible");
            }
        }

        public IEnumerable<Tarif> afficherTousLesTarifs()
        {
            try
            {
                return trMngr.afficherTousLesTarifs();
            }
            catch (Exception)
            {

                throw new BllGestionnaireExceptionAfficheMessage("Affichage impossible");
            }
        }

        public Tarif afficherTarifParID(int id)
        {
            try
            {
                return trMngr.afficherTarifParID(id);
            }
            catch (Exception)
            {

                throw new BllGestionnaireExceptionAfficheMessage("Affichage impossible");
            }
        }
    }
}
