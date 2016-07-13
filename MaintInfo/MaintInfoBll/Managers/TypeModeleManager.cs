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
        private IRepository<TypeModele> _typeModeleRepository;

        public TypeModeleManager()
        {
            this._typeModeleRepository = new Repository<TypeModele>();
        }

        public void ajouterTypeModele(TypeModele tm)
        {
            try
            {
                _typeModeleRepository.Insert(tm);
                _typeModeleRepository.Save(); 
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
                _typeModeleRepository.Update(tm);
                _typeModeleRepository.Save(); 
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
                _typeModeleRepository.Delete(tm);
                _typeModeleRepository.Save(); 
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
                return _typeModeleRepository.GetAll();
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
                return _typeModeleRepository.GetSingleById(id);
            }
            catch (Exception)
            {

                throw new BllManagerExceptionAfficheMessage("Affichage impossible");
            }
        }

        public bool typeModeleExiste(string des)
        {
            return _typeModeleRepository.GetAll().Any(typemode => string.Compare(typemode.designation_type, des,
                StringComparison.CurrentCultureIgnoreCase) == 0);
        }
    }
}
