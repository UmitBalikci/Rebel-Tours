using RebelTours.Domain;
using RebelTours.Management.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelTours.Management.Application.Cities
{
    public class CityService : ICityService
    {
        private readonly ICityRepository _cityRepository;
        public CityService(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }
        public CommandResult Create(CityDTO cityDTO)
        {
            try
            {
                // Mapping
                var city = new City()
                {
                    Id = cityDTO.Id,
                    Name = cityDTO.Name
                };
                _cityRepository.Create(city);

                return CommandResult.Success("Kaydetme işlemi başarılı");
            }
            catch (Exception)
            {
                return CommandResult.Error("Kaydetme sırasında hata meydana geldi");
            }
        }

        public CommandResult Delete(CityDTO cityDTO)
        {
            try
            {
                if (cityDTO != null)
                {
                    var city = new City()
                    {
                        Id = cityDTO.Id,
                        Name = cityDTO.Name
                    };
                    _cityRepository.Delete(city);
                }
                return CommandResult.Success();
            }
            catch (Exception ex)
            {

                return CommandResult.Error(ex.Message);
            }
        }

        public IEnumerable<CityDTO> GetAll()
        {
            var cityEntities = _cityRepository.GetAll();
            var cityDTOs = new List<CityDTO>();

            foreach (var entity in cityEntities)
            {
                cityDTOs.Add(new CityDTO
                {
                    Id = entity.Id,
                    Name = entity.Name
                });
            }
            return cityDTOs;
        }

        public CityDTO GetById(int id)
        {
            var entity = _cityRepository.GetById(id);
            if (entity != null)
            {
                var cityDTO = new CityDTO()
                {
                    Id = entity.Id,
                    Name = entity.Name
                };
                return cityDTO;
            }
            else
            {
                return null;
            }
        }

        public CommandResult Update(CityDTO cityDTO)
        {
            try
            {
                var city = _cityRepository.GetById(cityDTO.Id);
                //city.Id = cityDTO.Id;
                city.Name = cityDTO.Name;
                _cityRepository.Update(city);

                return CommandResult.Success();
            }
            catch (Exception ex)
            {

                return CommandResult.Error(ex.Message);
            }
        }
    }
}
