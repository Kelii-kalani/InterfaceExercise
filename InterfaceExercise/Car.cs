using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany 
    {
        public string TrunkSpace { get; set; }
        public string EngineInFront { get; set; }
        public string Slogan { get; set; }
        public string Logo { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int NumberOfHorsePower { get; set; }

        public void Specs()
        {
            Console.WriteLine($"Car year: {Year}\n" +
                $"Make: {Make}\n" +
                $"Model: {Model}\n" +
                $"Engine in front: {EngineInFront}\n" +
                $"Car makers slogan: {Slogan}");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
