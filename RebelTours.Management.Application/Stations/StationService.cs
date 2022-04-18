using RebelTours.Domain;
using RebelTours.Management.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelTours.Management.Application.Stations
{
    public class StationService : IStationService
    {
        private readonly IStationRepository _stationRepository;

        public StationService(IStationRepository stationRepository)
        {
            _stationRepository = stationRepository;
        }
        public CommandResult Create(StationDTO stationDTO)
        {
            try
            {
                var station = new Station()
                {
                    Id = stationDTO.Id,
                    Name = stationDTO.Name,
                    CityId = stationDTO.CityId
                };
                _stationRepository.Create(station);

                return CommandResult.Success("Kaydetme işlemi başarılı");
            }
            catch (Exception)
            {
                return CommandResult.Error("Kaydetme sırasında hata meydana geldi");
            }
            
        }

        public CommandResult Delete(StationDTO stationDTO)
        {
            try
            {
                if (stationDTO != null)
                {
                    var station = new Station()
                    {
                        Id = stationDTO.Id,
                        Name = stationDTO.Name,
                        CityId = stationDTO.CityId
                    };
                    _stationRepository.Delete(station);
                }

                return CommandResult.Success("Kaydetme işlemi başarılı");
            }
            catch (Exception)
            {
                return CommandResult.Error("Kaydetme sırasında hata meydana geldi");
            }
            
        }

        public IEnumerable<StationDTO> GetAll()
        {
            var stations = _stationRepository.GetAll();
            var stationDTOs = new List<StationDTO>();
            foreach (var station in stations)
            {
                stationDTOs.Add(new StationDTO
                {
                    Id = station.Id,
                    Name = station.Name,
                    CityId = station.CityId
                });
            }
            return stationDTOs;
        }

        public StationDTO GetById(int id)
        {
            var station = _stationRepository.GetById(id);
            var stationDTO = new StationDTO()
            {
                Id = station.Id,
                Name = station.Name,
                CityId = station.CityId
            };
            return stationDTO;
        }

        public CommandResult Update(StationDTO stationDTO)
        {
            try
            {
                var station = _stationRepository.GetById(stationDTO.Id);
                station.Name = stationDTO.Name;
                station.CityId = stationDTO.CityId;
                _stationRepository.Update(station);

                return CommandResult.Success("Kaydetme işlemi başarılı");
            }
            catch (Exception)
            {
                return CommandResult.Error("Kaydetme sırasında hata meydana geldi");
            }
            
        }
    }
}
