using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MaintInfoBll.Exceptions;
using MaintInfoBo;
using MaintInfoDal.Repository;

namespace MaintInfoBll
{
    public class TypeModeleManager
    {
        private IRepository<TypeModele> _typeModeleDao;

        public TypeModeleManager() { }
        public TypeModeleManager(IRepository<TypeModele> repos)
        {
            this._typeModeleDao = repos;
        }

        public void ajouterTypeModele(TypeModele tm)
        {
            try
            {
                _typeModeleDao.Insert(tm);  
            }
            catch (Exception)
            {

                throw new BllManagerExceptionAfficheMessage("Ajout impossible");
            }
        }

        public void modifierTypeModele(TypeModele tm)
        {
            try
            {
                _typeModeleDao.Update(tm); 
            }
            catch (Exception)
            {

                throw new BllManagerExceptionAfficheMessage("Modification impossible");
            }
        }

        public void supprimerTypeModele(TypeModele tm)
        {
            try
            {
                _typeModeleDao.Delete(tm); 
            }
            catch (Exception)
            {

                throw new BllManagerExceptionAfficheMessage("Suppression impossible");
            }
        }

        public IEnumerable<TypeModele> afficherTousLesTypesModele()
        {
            try
            {
                return _typeModeleDao.GetAll();
            }
            catch (Exception)
            {

                throw new BllManagerExceptionAfficheMessage("Affichage impossible");
            }
        }

        public TypeModele afficherTypeModeleParID(int id)
        {
            try
            {
                return _typeModeleDao.GetSingleById(id);
            }
            catch (Exception)
            {

                throw new BllManagerExceptionAfficheMessage("Affichage impossible");
            }
        }

        public bool typeModeleExiste(string des)
        {
            return _typeModeleDao.GetAll().Any(typemode => string.Compare(typemode.designation_type, des,
                StringComparison.CurrentCultureIgnoreCase) == 0);
        }
    }
}
