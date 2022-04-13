using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelTours.Management.Application.Buses
{
    public interface IBusService
    {
        IEnumerable<BusDTO> GetAll();
        BusDTO GetById(int id);
        void Create(BusDTO busDTO);
        void Update(BusDTO busDTO);
        void Delete(BusDTO busDTO);
    }
}
