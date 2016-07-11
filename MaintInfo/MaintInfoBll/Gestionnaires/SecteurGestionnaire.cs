using MaintInfoBll.Gestionnaires.GestionnaireExceptions;
using MaintInfoBo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBll.Gestionnaires
{
    public class SecteurGestionnaire
    {
        SecteurManager stMngr;

        public SecteurGestionnaire()
        {
            stMngr = new SecteurManager();
        }

        public bool ajouterSecteur(Secteur st)
        {
            try
            {
                stMngr.ajouterSecteur(st);
                return true;
            }
            catch (Exception)
            {

                throw new BllGestionnaireExceptionAfficheMessage("Ajout impossible");
            }
        }

        public bool modifierSecteur(Secteur st)
        {
            try
            {
                stMngr.modifierSecteur(st);
                return true;
            }
            catch (Exception)
            {

                throw new BllGestionnaireExceptionAfficheMessage("Modification impossible");
            }
        }

        public bool supprimerSecteur(Secteur st)
        {
            try
            {
                stMngr.supprimerSecteur(st);
                return true;
            }
            catch (Exception)
            {

                throw new BllGestionnaireExceptionAfficheMessage("Suppression impossible");
            }
        }

        public IEnumerable<Secteur> afficherTousLesSecteurs()
        {
            try
            {
                return stMngr.afficherTousLesSecteurs();
            }
            catch (Exception)
            {

                throw new BllGestionnaireExceptionAfficheMessage("Affichage impossible");
            }
        }

        public Secteur afficherLeSecteurParID(int id)
        {
            try
            {
                return stMngr.afficherSecteurParID(id);
            }
            catch (Exception)
            {

                throw new BllGestionnaireExceptionAfficheMessage("Affichage impossible");
            }
        }
    }
}
