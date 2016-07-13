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

        public void ajouterEquipement(Equipement et)
        {
            try
            {
                etMngr.ajouterEquipement(et);
            }
            catch (Exception)
            {
                throw new BllGestionnaireExceptionAfficheMessage("Ajout impossible");
            }
        }

        public void modifierEquipement(Equipement et)
        {
            try
            {
                etMngr.modifierEquipement(et);
            }
            catch (Exception)
            {

                throw new BllGestionnaireExceptionAfficheMessage("Modification impossible");
            }
        }

        public void supprimerEquipement(Equipement et)
        {
            try
            {
                etMngr.supprimerEquipement(et);
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

        public bool equipementExiste(string nserie)
        {
            return etMngr.equipementExiste(nserie);
        }
    }
}
