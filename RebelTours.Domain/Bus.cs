using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelTours.Domain
{
    public class Bus
    {
        public Bus(int id, int busModelId, string registrationPlate, short year, SeatingType seatMapping, int distanceTraveled)
        {
            Id = id;
            BusModelId = busModelId;
            RegistrationPlate = registrationPlate;
            Year = year;
            SeatMapping = seatMapping;
            DistanceTraveled = distanceTraveled;
        }
        public int Id { get; set; }
        public int BusModelId { get; }
        public string RegistrationPlate { get; }
        public short Year { get;}
        public SeatingType SeatMapping { get; set; }
        public int SeatCount {
            get 
            {
                if (BusModel.Type == BusType.Coach)
                {
                    if (BusModel.SeatCapacity == 52)
                    {
                        if (SeatMapping == SeatingType.Standard)
                        {
                            return 52;
                        }
                        else
                        {
                            return SeatMapping == SeatingType.Deluxe ? 38 : 26;
                        }

                    }
                    else if (BusModel.SeatCapacity == 48)
                    {
                        if (SeatMapping == SeatingType.Standard)
                        {
                            return 48;
                        }
                        else
                        {
                            return SeatMapping == SeatingType.Deluxe ? 35 : 24;
                        }
                    }
                    else
                    {
                        if (SeatMapping == SeatingType.Standard)
                        {
                            return 44;
                        }
                        else
                        {
                            return SeatMapping == SeatingType.Deluxe ? 32 : 22;
                        }
                    }
                }
                else
                {
                    if (BusModel.SeatCapacity == 30)
                    {
                        if (SeatMapping == SeatingType.Standard)
                        {
                            return 30;
                        }
                        else
                        {
                            return SeatMapping == SeatingType.Deluxe ? 20 : 15;
                        }

                    }
                    else if (BusModel.SeatCapacity == 28)
                    {
                        if (SeatMapping == SeatingType.Standard)
                        {
                            return 28;
                        }
                        else
                        {
                            return SeatMapping == SeatingType.Deluxe ? 19 : 14;
                        }
                    }
                    else
                    {
                        if (SeatMapping == SeatingType.Standard)
                        {
                            return 26;
                        }
                        else
                        {
                            return SeatMapping == SeatingType.Deluxe ? 18 : 13;
                        }
                    }
                }
            }}
        public int DistanceTraveled{ get; set; }

        public BusModel BusModel { get; set; }
    }
}
