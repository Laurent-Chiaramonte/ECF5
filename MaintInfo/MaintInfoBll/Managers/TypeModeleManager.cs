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

        public bool ajouterTypeModele(TypeModele tm)
        {
            try
            {
                _typeModeleRepository.Insert(tm);
                _typeModeleRepository.Save();
                return true;
            }
            catch (Exception)
            {

                throw new BllExceptionAfficheMessage("Ajout impossible");
            }
        }

        public bool modifierTypeModele(TypeModele tm)
        {
            try
            {
                _typeModeleRepository.Update(tm);
                _typeModeleRepository.Save();
                return true;
            }
            catch (Exception)
            {

                throw new BllExceptionAfficheMessage("Modification impossible");
            }
        }

        public bool supprimerTypeModele(TypeModele tm)
        {
            try
            {
                _typeModeleRepository.Delete(tm);
                _typeModeleRepository.Save();
                return true;
            }
            catch (Exception)
            {

                throw new BllExceptionAfficheMessage("Suppression impossible");
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

                throw new BllExceptionAfficheMessage("Affichage impossible");
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

                throw new BllExceptionAfficheMessage("Affichage impossible");
            }
        }
    }
}
