using System;
using System.Collections.Generic;
using System.Text;

namespace Abstarctlar.Vehicle_abstract
{
    internal class Train : IVehicle
    {
      
        public string Name { get => Name; }
        public string Model { get => Model; }
        public int Millage { get => Millage; }
        public int Year { get => Year; }
        public int MilePerHour { get => _milePerHour; }
        private int _milePerHour;
        public int ArriveTimeByHour { get; set; }
        


        public int Destination { get; set; }
       

        public Train(int arrive,int desti)
        {
            ArriveTimeByHour = arrive;
            Destination = desti;
        }
     
    

        public int Mph()
        {

            _milePerHour = Destination / ArriveTimeByHour;
            return _milePerHour;
        }

    }
}
