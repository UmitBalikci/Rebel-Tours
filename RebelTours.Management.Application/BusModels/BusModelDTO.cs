using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelTours.Management.Application.BusModels
{
    public class BusModelDTO
    {
        //public BusModelDTO(int id, string name, int busManufacturerId, BusType type, int seatCapacity, bool hasToilet)
        //{
        //    Id = id;
        //    Name = name;
        //    BusManufacturerId = busManufacturerId;
        //    Type = type;
        //    SeatCapacity = seatCapacity;
        //    HasToilet = hasToilet;
        //}
        public int Id { get; set; }
        public string Name { get; set; }
        public int BusManufacturerId { get; set; }
        public BusType Type { get; set; }
        public int SeatCapacity { get; set; }
        public bool HasToilet { get; set; }
    }
}
