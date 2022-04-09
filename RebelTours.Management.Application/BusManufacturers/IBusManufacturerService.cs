﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelTours.Management.Application.BusManufacturers
{
    public interface IBusManufacturerService
    {
        IEnumerable<BusManufacturerDTO> GetAll();
        BusManufacturerDTO GetById(int id);
        void Create(BusManufacturerDTO busManufacturerDTO);
        void Update(BusManufacturerDTO busManufacturerDTO);
        void Delete(BusManufacturerDTO busManufacturerDTO);
    }
}
