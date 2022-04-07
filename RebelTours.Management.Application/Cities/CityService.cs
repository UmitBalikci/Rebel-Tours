﻿using RebelTours.Domain;
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
        public void Create(CityDTO cityDTO)
        {
            // Mapping
            var city = new City()
            {
                Id = cityDTO.Id,
                Name = cityDTO.Name
            };
            _cityRepository.Create(city);
        }

        public void Delete(CityDTO cityDTO)
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

        public void Update(CityDTO cityDTO)
        {
            var city = _cityRepository.GetById(cityDTO.Id);
            //city.Id = cityDTO.Id;
            city.Name = cityDTO.Name;
            //new City()
            //{
            //    Id = cityDTO.Id,
            //    Name = cityDTO.Name != null ? cityDTO.Name : default
            //};
            _cityRepository.Update(city);
        }
    }
}
