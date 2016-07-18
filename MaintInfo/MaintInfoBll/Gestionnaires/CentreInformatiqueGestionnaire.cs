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
    public class CentreInformatiqueGestionnaire
    {
        CentreInformatiqueManager ciMngr;

        public CentreInformatiqueGestionnaire()
        {
            ciMngr = new CentreInformatiqueManager(new CentreInformatiqueDao());
        }

        public void ajouterCentreInformatique(CentreInformatique ci)
        {
            try
            {
                ciMngr.ajouterCentreInformatique(ci);
            }
            catch (Exception)
            {

                throw new BllGestionnaireExceptionAfficheMessage("Ajout impossible"); ;
            }
        }

        public void modifierCentreInformatique(CentreInformatique ci)
        {
            try
            {
                ciMngr.modifierCentreInformatique(ci);
            }
            catch (Exception)
            {

                throw new BllGestionnaireExceptionAfficheMessage("Modification impossible"); ;
            }
        }

        public void supprimerCentreInformatique(CentreInformatique ci)
        {
            try
            {
                ciMngr.supprimerCentreInformatique(ci);
            }
            catch (Exception)
            {

                throw new BllGestionnaireExceptionAfficheMessage("Suppression impossible"); ;
            }
        }

        public IEnumerable<CentreInformatique> afficherTousLesCentresInformatique()
        {
            try
            {
                return ciMngr.afficherTousLesCentresInformatique();
            }
            catch (Exception)
            {

                throw new BllGestionnaireExceptionAfficheMessage("Affichage impossible"); ;
            }
        }

        public CentreInformatique afficherCentreInformatiqueParID(int id)
        {
            try
            {
                return ciMngr.afficherCentreInformatiqueParID(id);
            }
            catch (Exception)
            {

                throw new BllGestionnaireExceptionAfficheMessage("Affichage impossible"); ;
            }
        }

        public bool centreInformatiqueExiste(string adresse)
        {
            return ciMngr.centreInformatiqueExiste(adresse);
        }
    }
}
