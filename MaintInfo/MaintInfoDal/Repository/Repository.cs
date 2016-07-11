using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoDal.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private MaintInfoContext context;
        private DbSet<T> dbSet;

        public Repository()
        {
            this.context = new MaintInfoContext();
            dbSet = context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

        public T GetSingleById(int Id)
        {
            return dbSet.Find(Id);
        }

        public void Insert(T obj)
        {
            dbSet.Add(obj);
        }

        public void Update(T obj)
        {
            context.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(T obj)
        {
            context.Entry(obj).State = EntityState.Deleted;
        }

        public void Save()
        {
            context.SaveChanges();
        }


    }
}
