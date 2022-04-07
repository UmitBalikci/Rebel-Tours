﻿using RebelTours.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelTours.Management.Application.Repositories
{
    public interface ICityRepository
    {
        IEnumerable<City> GetAll();
        City GetById(int id);
        void Create(City city);
        void Update(City city);
        void Delete(City city);
    }
}
