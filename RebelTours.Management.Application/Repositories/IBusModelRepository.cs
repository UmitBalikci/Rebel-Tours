using RebelTours.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelTours.Management.Application.Repositories
{
    public interface IBusModelRepository
    {
        IEnumerable<BusModel> GetAll();
        BusModel GetById(int id);
        void Create(BusModel busModel);
        void Update(BusModel busModel);
        void Delete(BusModel busModel);
    }
}
