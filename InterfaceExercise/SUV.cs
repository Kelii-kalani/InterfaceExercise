using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public string ExtraRowOfSeats { get; set; }
        public string CargoHoldSize { get; set; }
        public string Slogan { get; set; }
        public string Logo { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int NumberOfHorsePower { get; set; }

        public void Specs()
        {
            Console.WriteLine($"SUV year: {Year}\n" +
                $"Make: {Make}\n" +
                $"Model: {Model}\n" +
                $"Extra row of seats: {ExtraRowOfSeats}\n" +
                $"SUV makers slogan: {Slogan}");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
