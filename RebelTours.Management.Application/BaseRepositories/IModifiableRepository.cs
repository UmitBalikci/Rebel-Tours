using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelTours.Management.Application.BaseRepositories
{
    public interface IModifiableRepository<TEntity>
    {
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
