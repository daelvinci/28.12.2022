using System;
using System.Collections.Generic;
using System.Text;

namespace Abstarctlar.Vehicle_abstract
{
    internal abstract class Vehicle
    {
        public double Millage;
        public double Destination;
        public double ArriveTime;
        public double MilePerHour;
        public abstract void Mph();

    }
}
