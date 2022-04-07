using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelTours.Management.Application.Stations
{
    public interface IStationService
    {
        IEnumerable<StationDTO> GetAll();
        StationDTO GetById(int id);
        void Create(StationDTO stationDTO);
        void Update(StationDTO stationDTO);
        void Delete(StationDTO stationDTO);
    }
}
