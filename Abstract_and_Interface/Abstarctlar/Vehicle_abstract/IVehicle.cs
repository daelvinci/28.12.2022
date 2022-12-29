using System;
using System.Collections.Generic;
using System.Text;

namespace Abstarctlar.Vehicle_abstract
{
    internal interface IVehicle
    {
        public string Name { get; }
        public string Model { get; }
        public int Millage { get; }
        public int Year { get; }
        public int MilePerHour { get; }
        public int Destination { get; }
        public int ArriveTimeByHour { get;  }
       

        public int Mph();

    }
}
