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

        public void ajouterTarif(Tarif tr)
        {
            try
            {
                trMngr.ajouterTarif(tr); 
            }
            catch (Exception)
            {

                throw new BllGestionnaireExceptionAfficheMessage("Ajout impossible");
            }
        }

        public void modifierTarif(Tarif tr)
        {
            try
            {
                trMngr.modifierTarif(tr); 
            }
            catch (Exception)
            {

                throw new BllGestionnaireExceptionAfficheMessage("Modification impossible");
            }
        }

        public void supprimerTarif(Tarif tr)
        {
            try
            {
                trMngr.supprimerTarif(tr); 
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
