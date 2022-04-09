using RebelTours.Domain;
using RebelTours.Management.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelTours.Management.Application.BusModels
{
    public class BusModelService : IBusModelService
    {
        private readonly IBusModelRepository _busModelRepository;

        public BusModelService(IBusModelRepository busModelRepository)
        {
            _busModelRepository = busModelRepository;
        }
        public void Create(BusModelDTO busModelDTO)
        {
            var busModel = new BusModel(
                busModelDTO.Id,
                busModelDTO.Name,
                busModelDTO.BusManufacturerId,
                busModelDTO.Type,
                busModelDTO.SeatCapacity,
                busModelDTO.HasToilet);
            _busModelRepository.Create(busModel);
        }

        public void Delete(BusModelDTO busModelDTO)
        {
            var busModel = new BusModel(
                busModelDTO.Id,
                busModelDTO.Name,
                busModelDTO.BusManufacturerId,
                busModelDTO.Type,
                busModelDTO.SeatCapacity,
                busModelDTO.HasToilet);
            _busModelRepository.Delete(busModel);
        }

        public IEnumerable<BusModelDTO> GetAll()
        {
            var busModels = _busModelRepository.GetAll();
            var busModelDTOs = new List<BusModelDTO>();

            foreach (var busModelDTO in busModels)
            {
                busModelDTOs.Add(new BusModelDTO()
                {
                    Id = busModelDTO.Id,
                    Name = busModelDTO.Name,
                    BusManufacturerId = busModelDTO.BusManufacturerId,
                    Type = busModelDTO.Type,
                    SeatCapacity = busModelDTO.SeatCapacity,
                    HasToilet = busModelDTO.HasToilet
                });
            }
            return busModelDTOs;
        }

        public BusModelDTO GetById(int id)
        {
            var busModel = _busModelRepository.GetById(id);
            var busModelDTO = new BusModelDTO()
            {
                Id = busModel.Id,
                Name = busModel.Name,
                BusManufacturerId = busModel.BusManufacturerId,
                Type = busModel.Type,
                SeatCapacity = busModel.SeatCapacity,
                HasToilet = busModel.HasToilet
            };

            return busModelDTO;
        }

        public void Update(BusModelDTO busModelDTO)
        {
            var busModel = _busModelRepository.GetById(busModelDTO.Id);
            busModel = new BusModel(
                busModelDTO.Id,
                busModelDTO.Name,
                busModelDTO.BusManufacturerId,
                busModelDTO.Type,
                busModelDTO.SeatCapacity,
                busModelDTO.HasToilet);
            _busModelRepository.Update(busModel);
        }
    }
}
