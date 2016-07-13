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

        public void ajouterModele(Modele md)
        {
            try
            {
                mdMngr.ajouterModele(md); 
            }
            catch (Exception)
            {
                throw new BllGestionnaireExceptionAfficheMessage("Ajout impossible");
            }
        }

        public void modifierModele(Modele md)
        {
            try
            {
                mdMngr.modifierModele(md); 
            }
            catch (Exception)
            {
                throw new BllGestionnaireExceptionAfficheMessage("Modification impossible");
            }
        }

        public void supprimerModele(Modele md)
        {
            try
            {
                mdMngr.supprimerModele(md); 
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

        public Modele afficherModeleParID(int id)
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

        public bool modeleExiste(string des)
        {
            return mdMngr.modeleExiste(des);
        }
    }
}
