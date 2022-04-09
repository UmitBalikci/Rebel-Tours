﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelTours.Management.Application.BusModels
{
    public interface IBusModelService
    {
        IEnumerable<BusModelDTO> GetAll();
        BusModelDTO GetById(int id);
        void Create(BusModelDTO busModelDTO);
        void Update(BusModelDTO busModelDTO);
        void Delete(BusModelDTO busModelDTO);
    }
}
