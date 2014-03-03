using Relation.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relation.Infrastructure.Data
{
    public abstract class RepositoryBase
    {
        protected readonly RelationDB _context;

        protected RelationDB Context
        {
            get
            {

                return _context;
            }
        }
        public RepositoryBase()
        {
            this._context = new RelationDB();
        }
        public RepositoryBase(RelationDB context)
        {
            _context = context;
        }
    }
}
