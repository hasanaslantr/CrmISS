using CrmDataAccess.Abstract;
using CrmDataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmDataAccess.Repository
{
    public class GenericRepository<T> : IGEnericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using var db = new CrmDbContext();
            db.Remove(t);
            db.SaveChangesAsync();
        }

        public T GetById(int id)
        {
            using var db = new CrmDbContext();
            return db.Set<T>().Find(id);
        }

        public List<T> GetList(T t)
        {
            using var db = new CrmDbContext();
            return db.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var db = new CrmDbContext()  ;
            db.AddAsync(t);
            db.SaveChangesAsync();
        }

        public void Update(T t)
        {
            using var db = new CrmDbContext();
            db.Update(t);
            db.SaveChangesAsync();
        }
    }
}
