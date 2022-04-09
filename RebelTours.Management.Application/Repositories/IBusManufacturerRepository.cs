using RebelTours.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelTours.Management.Application.Repositories
{
    public interface IBusManufacturerRepository
    {
        IEnumerable<BusManufacturer> GetAll();
        BusManufacturer GetById(int id);
        void Create(BusManufacturer busManufacturer);
        void Update(BusManufacturer busManufacturer);
        void Delete(BusManufacturer busManufacturer);
    }
}
