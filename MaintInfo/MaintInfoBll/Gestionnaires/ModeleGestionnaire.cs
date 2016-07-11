using MaintInfoBll.Gestionnaires.GestionnaireExceptions;
using MaintInfoBo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBll.Gestionnaires
{
    public class ModeleGestionnaire
    {
        ModeleManager mdMngr;
        public ModeleGestionnaire()
        {
            mdMngr = new ModeleManager();
        }

        public bool ajouterModele(Modele md)
        {
            try
            {
                mdMngr.ajouterModele(md);
                return true;
            }
            catch (Exception)
            {
                throw new BllGestionnaireExceptionAfficheMessage("Ajout impossible");
            }
        }

        public bool modifierModele(Modele md)
        {
            try
            {
                mdMngr.modifierModele(md);
                return true;
            }
            catch (Exception)
            {
                throw new BllGestionnaireExceptionAfficheMessage("Modification impossible");
            }
        }

        public bool supprimerModele(Modele md)
        {
            try
            {
                mdMngr.supprimerModele(md);
                return true;
            }
            catch (Exception)
            {
                throw new BllGestionnaireExceptionAfficheMessage("Suppression impossible");
            }
        }

        public IEnumerable<Modele> afficherTousLesModeles()
        {
            try
            {
                return mdMngr.afficherTousLesModeles();
            }
            catch (Exception)
            {
                throw new BllGestionnaireExceptionAfficheMessage("Affichage impossible");
            }
        }

        public Modele afficherLeModeleParID(int id)
        {
            try
            {
                return mdMngr.afficherModeleParID(id);
            }
            catch (Exception)
            {
                throw new BllGestionnaireExceptionAfficheMessage("Affichage impossible");
            }
        }
    }
}
