using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public string SizeOfBed { get; set; }
        public string ExtendedCab { get; set; }
        public string Slogan { get; set; }
        public string Logo { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int NumberOfHorsePower { get; set; }

        public void Specs()
        {
            Console.WriteLine($"Truck year: {Year}\n" +
                 $"Make: {Make}\n" +
                 $"Model: {Model}\n" +
                 $"Extended cab: {ExtendedCab}\n" +
                 $"Truck makers slogan: {Slogan}");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
