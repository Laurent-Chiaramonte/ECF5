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
    public class TarifManager
    {
        private IRepository<Tarif> _tarifRepository;

        public TarifManager()
        {
            this._tarifRepository = new Repository<Tarif>();
        }

        public bool ajouterTarif(Tarif tf)
        {
            try
            {
                _tarifRepository.Insert(tf);
                _tarifRepository.Save();
                return true;
            }
            catch (Exception)
            {
                throw new BllExceptionAfficheMessage("Ajout impossible");
            }
        }

        public bool modifierTarif(Tarif tf)
        {
            try
            {
                _tarifRepository.Update(tf);
                _tarifRepository.Save();
                return true;
            }
            catch (Exception)
            {

                throw new BllExceptionAfficheMessage("Modification impossible");
            }
        }

        public bool supprimerTarif(Tarif tf)
        {
            try
            {
                _tarifRepository.Delete(tf);
                _tarifRepository.Save();
                return true;
            }
            catch (Exception)
            {

                throw new BllExceptionAfficheMessage("Suppression impossible");
            }
        }

        public IEnumerable<Tarif> afficherTousLesTarifs()
        {
            try
            {
                return _tarifRepository.GetAll();
            }
            catch (Exception)
            {

                throw new BllExceptionAfficheMessage("Affichage impossible");
            }
        }

        public Tarif afficherTarifParID(int id)
        {
            try
            {
                return _tarifRepository.GetSingleById(id);
            }
            catch (Exception)
            {

                throw new BllExceptionAfficheMessage("Affichage impossible");
            }
        }
    }
}
