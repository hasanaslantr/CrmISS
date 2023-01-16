using CrmDataAccess.Abstract;
using CrmDataAccess.Concrete;
using CrmEntity.Concrete;
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
            using var c = new CrmDbContext();
            c.Remove(t);
            c.SaveChanges();
        }
        public T GetById(int id)
        {
            using var c = new CrmDbContext();
            return c.Set<T>().Find(id);
        }
        public List<T> GetList(T t)
        {
            using var c = new CrmDbContext();
            return c.Set<T>().ToList();
        }
        public List<T> GetList()
        {
            using var c = new CrmDbContext();
            return c.Set<T>().ToList();
        }
        public void Insert(T t)
        {
            using var c = new CrmDbContext();
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            using var c = new CrmDbContext();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
