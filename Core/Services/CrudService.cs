using Relation.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Relation.Core.Services
{
    public class CrudService<T> :ICrudService<T> where T : class
    {
        private readonly IRepository<T> _repo;

        public CrudService(IRepository<T> repo)
        {
            _repo = repo;
        }

        public bool Create(T objToCreate)
        {
            //kolla om objektet behöver få companyID
            var prop = objToCreate.GetType()
                .GetProperties()
                .FirstOrDefault(c => c.Name.ToLower().Equals("companyid"));
            if (prop != null)
            {
                prop.SetValue(objToCreate, Relation.Core.Class.Settings.CompanyID);
            }
            _repo.Add(objToCreate);
            _repo.Save();
            return true;
        }

        public bool Edit(T objToEdit)
        {
            _repo.Update(objToEdit);
            _repo.Save();
            return true;
        }

        public bool Delete(T objToDelete)
        {
            _repo.Remove(objToDelete);
            _repo.Save();
            return true;
        }

        public T GetByID(dynamic id)
        {
            return _repo.GetByID(id);
        }

        public IEnumerable<T> All()
        {
            return _repo.GetAll();
        }

        public IEnumerable<T> Query(Expression<Func<T, bool>> expression)
        {
            return _repo.Query(expression);
        }
    }
}
