using RebelTours.Domain;
using RebelTours.Management.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelTours.Management.Application.Buses
{
    public class BusService : IBusService
    {
        private readonly IBusRepository _busRepository;

        public BusService(IBusRepository busRepository)
        {
            _busRepository = busRepository;
        }
        public CommandResult Create(BusDTO busDTO)
        {
            try
            {
                // Mapping
                var bus = new Bus(
                busDTO.Id,
                busDTO.BusModelId,
                busDTO.RegistrationPlate,
                busDTO.Year,
                busDTO.SeatMapping,
                busDTO.DistanceTraveled);
                _busRepository.Create(bus);

                return CommandResult.Success("Kaydetme işlemi başarılı");
            }
            catch (Exception)
            {
                return CommandResult.Error("Kaydetme sırasında hata meydana geldi");
            }
            
        }

        public CommandResult Delete(BusDTO busDTO)
        {
            try
            {
                var bus = new Bus(
                busDTO.Id,
                busDTO.BusModelId,
                busDTO.RegistrationPlate,
                busDTO.Year,
                busDTO.SeatMapping,
                busDTO.DistanceTraveled);
                _busRepository.Delete(bus);

                return CommandResult.Success("Silme işlemi başarılı");
            }
            catch (Exception)
            {
                return CommandResult.Error("Silme işlemi sırasında hata meydana geldi");
            }
            
        }

        public IEnumerable<BusDTO> GetAll()
        {
            var buses = _busRepository.GetAll();
            var busDTOs = new List<BusDTO>();

            foreach (var bus in buses)
            {
                busDTOs.Add(new BusDTO()
                {
                    Id = bus.Id,
                    BusModelId = bus.BusModelId,
                    RegistrationPlate = bus.RegistrationPlate,
                    Year = bus.Year,
                    SeatMapping = bus.SeatMapping,
                    SeatCount = bus.SeatCount,
                    DistanceTraveled = bus.DistanceTraveled
                });
            }
            return busDTOs;
        }

        public BusDTO GetById(int id)
        {
            var bus = _busRepository.GetById(id);
            if (bus != null)
            {
                var busDTO = new BusDTO()
                {
                    Id = bus.Id,
                    BusModelId = bus.BusModelId,
                    RegistrationPlate = bus.RegistrationPlate,
                    Year = bus.Year,
                    SeatMapping = bus.SeatMapping,
                    SeatCount = bus.SeatCount,
                    DistanceTraveled = bus.DistanceTraveled
                };
                return busDTO;
            }
            return null;
        }

        public CommandResult Update(BusDTO busDTO)
        {
            try
            {
                var bus = _busRepository.GetById(busDTO.Id);
                if (bus != null)
                {

                    bus.Id = busDTO.Id;
                    bus.SeatMapping = busDTO.SeatMapping;
                    bus.DistanceTraveled = busDTO.DistanceTraveled;
                    _busRepository.Update(bus);
                }

                return CommandResult.Success("Gğncelleme işlemi başarılı");
            }
            catch (Exception)
            {
                return CommandResult.Error("Güncelleme sırasında hata meydana geldi");
            }
            

        }
    }
}
