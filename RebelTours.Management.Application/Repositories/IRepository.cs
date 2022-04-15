using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelTours.Management.Application.Repositories
{
    // Generic 
    // Hangi başka bir tip için bu interface oluşturulacaksa o bahsettiğimiz "başka tip" i
    // generic tip olarak ( tip parametresi olarak) oluştururuz.
    public interface IRepository<TEntity>
    {
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
