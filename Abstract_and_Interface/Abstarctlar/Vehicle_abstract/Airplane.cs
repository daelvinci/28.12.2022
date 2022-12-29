using System;
using System.Collections.Generic;
using System.Text;

namespace Abstarctlar.Vehicle_abstract
{
    internal class Airplane : Vehicle
    {
        public override void Mph()
        {
            MilePerHour = Destination / ArriveTime;
        }


    }
}
