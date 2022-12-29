using System;
using Abstarctlar.Vehicle_abstract;

namespace Abstarctlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Vehicle abstract
            //Airplane boeing = new Airplane()
            //{
            //    Millage = 170000,
            //    Destination = 500,
            //    ArriveTimeByHour = 3
            //};
            //boeing.Mph();
            //Console.WriteLine(boeing.MilePerHour);
            #endregion

            #region IVehicle Interface
            Train suretQatari = new Train(3,300);                     
            Console.WriteLine(suretQatari.Mph()); 
            #endregion

        }
    }
}
