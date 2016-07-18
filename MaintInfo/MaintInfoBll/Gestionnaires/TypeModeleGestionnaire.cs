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
    public class TypeModeleGestionnaire
    {
        TypeModeleManager tmMngr;

        public TypeModeleGestionnaire()
        {
            tmMngr = new TypeModeleManager(new TypeModeleDao());
        }

        public void ajouterTypeModele(TypeModele tm)
        {
            try
            {
                tmMngr.ajouterTypeModele(tm); 
            }
            catch (Exception)
            {

                throw new BllGestionnaireExceptionAfficheMessage("Ajout impossible");
            }
        }

        public void modifierTypeModele(TypeModele tm)
        {
            try
            {
                tmMngr.modifierTypeModele(tm); 
            }
            catch (Exception)
            {

                throw new BllGestionnaireExceptionAfficheMessage("Modification impossible");
            }
        }

        public void supprimerTypeModele(TypeModele tm)
        {
            try
            {
                tmMngr.supprimerTypeModele(tm); 
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

        public bool typeModeleExiste(string des)
        {
            return tmMngr.typeModeleExiste(des);
        }
    }
}
