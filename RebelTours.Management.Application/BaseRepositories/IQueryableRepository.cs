using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelTours.Management.Application.BaseRepositories
{
    public interface IQueryableRepository<TEntity>
    {
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
    }
}
