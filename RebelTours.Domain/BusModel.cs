using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelTours.Domain
{
    public class BusModel
    {
        public BusModel(int id, string name, int busManufacturerId, BusType type, int seatCapacity, bool hasToilet)
        {
            Id = id;
            Name = name;
            BusManufacturerId = busManufacturerId;
            Type = type;
            SeatCapacity = seatCapacity;
            HasToilet = hasToilet;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int BusManufacturerId { get; }
        public BusType Type { get; }
        public int SeatCapacity {get; }
        public bool HasToilet { get; }

        public BusManufacturer BusManufacturer { get; }
    }
}
