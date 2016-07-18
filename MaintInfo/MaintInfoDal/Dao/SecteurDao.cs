using MaintInfoBo;
using MaintInfoBo.Exceptions.SecteurExceptions;
using MaintInfoDal.Exceptions;
using MaintInfoDal.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoDal.Dao
{
    public class SecteurDao : IRepository<Secteur>
    {
        public void Delete(Secteur obj)
        {
            using (MaintInfoContext db = new MaintInfoContext())
            {
                try
                {
                    db.Entry(obj).State = EntityState.Deleted;

                    int n = db.SaveChanges();
                }
                catch (Exception ex)
                {
                    if (ex.HResult == -2146233087)
                        throw new SecteurException("Suppression impossible");
                    throw new DaoException(ex.Message);
                }
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Secteur> GetAll()
        {
            using (MaintInfoContext db = new MaintInfoContext())
            {
                try
                {
                    var query = db.Secteurs.ToList();
                    return query;
                }
                catch (Exception ex)
                {
                    throw new DaoExceptionAfficheMessage(ex.Message);
                }
            }
        }

        public Secteur GetSingleById(int Id)
        {
            using (MaintInfoContext db = new MaintInfoContext())
            {
                try
                {
                    var obj = db.Secteurs.Find(Id);
                    if (obj == null)
                        throw new NotExistSecteurException("Secteur inexistant");
                    return obj;
                }
                catch (Exception ex)
                {
                    throw new DaoException(ex.Message);
                }
            }
        }

        public void Insert(Secteur obj)
        {
            using (MaintInfoContext db = new MaintInfoContext())
            {
                try
                {
                    db.Entry(obj).State = EntityState.Added;

                    int n = db.SaveChanges();
                }
                catch (Exception ex)
                {
                    if (ex.HResult == -2146233087)
                        throw new SecteurException(ex.Message);
                    throw new DaoException(ex.Message);
                }
            }
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Secteur obj)
        {
            using (MaintInfoContext db = new MaintInfoContext())
            {
                try
                {
                    db.Entry(obj).State = EntityState.Modified;

                    int n = db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new DaoException(ex.Message);
                }
            }
        }
    }
}
