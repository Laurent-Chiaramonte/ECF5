using MaintInfoBll.Gestionnaires.GestionnaireExceptions;
using MaintInfoBo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBll.Gestionnaires
{
    public class TypeModeleGestionnaire
    {
        TypeModeleManager tmMngr;

        public TypeModeleGestionnaire()
        {
            tmMngr = new TypeModeleManager();
        }

        public bool ajouterTypeModele(TypeModele tm)
        {
            try
            {
                tmMngr.ajouterTypeModele(tm);
                return true;
            }
            catch (Exception)
            {

                throw new BllGestionnaireExceptionAfficheMessage("Ajout impossible");
            }
        }

        public bool modifierTypeModele(TypeModele tm)
        {
            try
            {
                tmMngr.modifierTypeModele(tm);
                return true;
            }
            catch (Exception)
            {

                throw new BllGestionnaireExceptionAfficheMessage("Modification impossible");
            }
        }

        public bool supprimerTypeModele(TypeModele tm)
        {
            try
            {
                tmMngr.supprimerTypeModele(tm);
                return true;
            }
            catch (Exception)
            {

                throw new BllGestionnaireExceptionAfficheMessage("Suppression impossible");
            }
        }

        public IEnumerable<TypeModele> afficherTousLesTypesModele()
        {
            try
            {
                return tmMngr.afficherTousLesTypesModele();
            }
            catch (Exception)
            {

                throw new BllGestionnaireExceptionAfficheMessage("Affichage impossible");
            }
        }

        public TypeModele afficherTypeModeleParID(int id)
        {
            try
            {
                return tmMngr.afficherTypeModeleParID(id);
            }
            catch (Exception)
            {

                throw new BllGestionnaireExceptionAfficheMessage("Affichage impossible");
            }
        }
    }
}
