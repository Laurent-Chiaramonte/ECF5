using MaintInfoBll.Gestionnaires.GestionnaireExceptions;
using MaintInfoBo;
using MaintInfoDal.Dao;
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
            stMngr = new SecteurManager(new SecteurDao());
        }

        public void ajouterSecteur(Secteur st)
        {
            try
            {
                stMngr.ajouterSecteur(st); 
            }
            catch (Exception)
            {

                throw new BllGestionnaireExceptionAfficheMessage("Ajout impossible");
            }
        }

        public void modifierSecteur(Secteur st)
        {
            try
            {
                stMngr.modifierSecteur(st); 
            }
            catch (Exception)
            {

                throw new BllGestionnaireExceptionAfficheMessage("Modification impossible");
            }
        }

        public void supprimerSecteur(Secteur st)
        {
            try
            {
                stMngr.supprimerSecteur(st); 
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

        public Secteur afficherSecteurParID(int id)
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

        public bool secteurExiste(string lib)
        {
            return stMngr.secteurExiste(lib);
        }
    }
}
