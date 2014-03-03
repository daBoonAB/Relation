
using Relation.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Relation.Core.Models;
using System.Linq.Expressions;
using Relation.Core.Class;

namespace Relation.Infrastructure.Data
{
    public class Repository<T> : RepositoryBase, IRepository<T> 
        where T:class 
    {
      
        public virtual void Add(T objToCreate)
        {
            _context.Set<T>().Add(objToCreate);
        }

        public virtual void Update(T objToEdit)
        {
            _context.Entry(objToEdit).State = EntityState.Modified;

        }

        public virtual void Remove(T objToDelete)
        {
            _context.Set<T>().Remove(objToDelete);
        }

        public virtual void Save()
        {
            _context.SaveChanges();
        }

        public virtual T GetByID(dynamic id)
        {
            var model =  _context.Set<T>().Find(int.Parse(id.ToString()));
     
            return model;
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
         
        }

        public virtual IEnumerable<T> Query(Func<T, bool> filter)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Queryable()
        {
            return Context.Set<T>().AsQueryable();
        }


        public IEnumerable<T> Query(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
