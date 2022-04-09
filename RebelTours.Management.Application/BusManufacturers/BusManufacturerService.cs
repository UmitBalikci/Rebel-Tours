using RebelTours.Domain;
using RebelTours.Management.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelTours.Management.Application.BusManufacturers
{
    public class BusManufacturerService : IBusManufacturerService
    {
        private readonly IBusManufacturerRepository _busManufacturerRepository;
        public BusManufacturerService(IBusManufacturerRepository busManufacturerRepository)
        {
            _busManufacturerRepository = busManufacturerRepository;
        }
        public void Create(BusManufacturerDTO busManufacturerDTO)
        {
            var busManu = new BusManufacturer(busManufacturerDTO.Id, busManufacturerDTO.Name);
            
            _busManufacturerRepository.Create(busManu);
        }

        public void Delete(BusManufacturerDTO busManufacturerDTO)
        {
            var busManu = new BusManufacturer(busManufacturerDTO.Id, busManufacturerDTO.Name);
            _busManufacturerRepository.Delete(busManu);
        }

        public IEnumerable<BusManufacturerDTO> GetAll()
        {
            var busManufacturers = _busManufacturerRepository.GetAll();
            var busManuDTOs = new List<BusManufacturerDTO>();
            foreach (var busManu in busManufacturers)
            {
                busManuDTOs.Add(new BusManufacturerDTO()
                {
                    Id = busManu.Id,
                    Name = busManu.Name
                });
            }
            return busManuDTOs;
        }

        public BusManufacturerDTO GetById(int id)
        {
            var busManufacturer = _busManufacturerRepository.GetById(id);
            if (busManufacturer != null)
            {
                var busManuDTO = new BusManufacturerDTO()
                {
                    Id = busManufacturer.Id,
                    Name = busManufacturer.Name
                };
                return busManuDTO;
            }
            return null;
        }

        public void Update(BusManufacturerDTO busManufacturerDTO)
        {
            var busManu = new BusManufacturer(busManufacturerDTO.Id, busManufacturerDTO.Name);
            _busManufacturerRepository.Update(busManu);
        }
    }
}
