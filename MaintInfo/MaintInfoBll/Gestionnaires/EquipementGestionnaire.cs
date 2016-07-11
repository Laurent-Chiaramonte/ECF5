using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MaintInfoBll.Gestionnaires.GestionnaireExceptions;
using MaintInfoBo;

namespace MaintInfoBll.Gestionnaires
{
    public class EquipementGestionnaire
    {
        EquipementManager etMngr;

        public EquipementGestionnaire()
        {
            etMngr = new EquipementManager();
        }

        public bool ajouterEquipement(Equipement et)
        {
            try
            {
                etMngr.ajouterEquipement(et);
                return true;
            }
            catch (Exception)
            {
                throw new BllGestionnaireExceptionAfficheMessage("Ajout impossible");
            }
        }

        public bool modifierEquipement(Equipement et)
        {
            try
            {
                etMngr.modifierEquipement(et);
                return true;
            }
            catch (Exception)
            {

                throw new BllGestionnaireExceptionAfficheMessage("Modification impossible");
            }
        }

        public bool supprimerEquipement(Equipement et)
        {
            try
            {
                etMngr.supprimerEquipement(et);
                return true;
            }
            catch (Exception)
            {

                throw new BllGestionnaireExceptionAfficheMessage("Suppression impossible");
            }
        }

        public IEnumerable<Equipement> afficherTousLesEquipements()
        {
            try
            {
                return etMngr.afficherTousLesEquipements();
            }
            catch (Exception)
            {

                throw new BllGestionnaireExceptionAfficheMessage("Affichage impossible"); ;
            }
        }

        public Equipement afficherEquipementParID(int id)
        {
            try
            {
                return etMngr.afficherEquipementParID(id);
            }
            catch (Exception)
            {

                throw new BllGestionnaireExceptionAfficheMessage("Affichage impossible"); ;
            }
        }
    }
}
