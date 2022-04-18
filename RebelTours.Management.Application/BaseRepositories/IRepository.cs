using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelTours.Management.Application.BaseRepositories
{
    // Generic 
    // Hangi başka bir tip için bu interface oluşturulacaksa o bahsettiğimiz "başka tip" i
    // generic tip olarak ( tip parametresi olarak) oluştururuz.
    public interface IRepository<TEntity> : IQueryableRepository<TEntity>, IModifiableRepository<TEntity>
    {
    }
}
