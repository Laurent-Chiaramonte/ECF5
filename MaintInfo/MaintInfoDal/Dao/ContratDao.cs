using MaintInfoBo;
using MaintInfoBo.Exceptions.ContratExceptions;
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
    public class ContratDao : IRepository<Contrat>
    {
        public void Delete(Contrat obj)
        {
            using (MaintInfoContext db = new MaintInfoContext())
            {
                try
                {
                    db.Entry(obj).State = EntityState.Deleted;
                    db.Entry(obj.leCentre).State = EntityState.Unchanged;

                    int n = db.SaveChanges();
                }
                catch (Exception ex)
                {
                    if (ex.HResult == -2146233087)
                        throw new ContratException("Suppression impossible");
                    throw new DaoException(ex.Message);
                }
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Contrat> GetAll()
        {
            using (MaintInfoContext db = new MaintInfoContext())
            {
                try
                {
                    var query = db.Contrats.ToList();
                    foreach (var p in query)
                    {
                        db.Entry(p).Reference(q => q.leCentre).Load();
                    }
                    return query;
                }
                catch (Exception ex)
                {
                    throw new DaoExceptionAfficheMessage(ex.Message);
                }
            }
        }

        public Contrat GetSingleById(int Id)
        {
            using (MaintInfoContext db = new MaintInfoContext())
            {
                try
                {
                    var obj = db.Contrats.Find(Id);
                    if (obj == null)
                        throw new NotExistContratException("Contrat inexistant");
                    db.Entry(obj).Reference(q => q.leCentre).Load();
                    return obj;
                }
                catch (Exception ex)
                {
                    throw new DaoException(ex.Message);
                }
            }
        }

        public void Insert(Contrat obj)
        {
            using (MaintInfoContext db = new MaintInfoContext())
            {
                try
                {
                    db.Entry(obj).State = EntityState.Added;
                    // 
                    db.Entry(obj.leCentre).State = EntityState.Unchanged;

                    int n = db.SaveChanges();
                }
                catch (Exception ex)
                {
                    if (ex.HResult == -2146233087)
                        throw new ContratException(ex.Message);
                    throw new DaoException(ex.Message);
                }
            }
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Contrat obj)
        {
            using (MaintInfoContext db = new MaintInfoContext())
            {
                try
                {
                    db.Entry(obj).State = EntityState.Modified;
                    db.Entry(obj.leCentre).State = EntityState.Unchanged;

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
