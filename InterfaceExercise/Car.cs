using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public string TrunkSize { get; set; }
        public int SeatCount { get; set; }
        public int WheelCount { get; set; }
        public string EngineSound { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Logo { get; set; }
        public string CompanyName { get; set; }

        public void Information()
        {
            Console.WriteLine($"The {Make} {Model} has {SeatCount} seats, {WheelCount} wheels, and a {TrunkSize} size trunk. The engine makes a \"{EngineSound}\" sound.");
        }



    }
}
