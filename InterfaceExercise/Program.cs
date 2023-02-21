using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            Car car1 = new Car() 
            {
                Year = 2023,
                Make = "Lamborghini", 
                Model = "Huracan", 
                EngineInFront = "No", 
                NumberOfHorsePower = 631, 
                TrunkSpace = "4 cubic feet", 
                Logo = "Bull", 
                Slogan = "We are not supercars. We are Lamborghini." 
            };
            Truck truck1 = new Truck()
            {
                Year = 2023,
                Make = "Toyota",
                Model = "Tacoma TRD",
                NumberOfHorsePower = 278,
                SizeOfBed = "60.5 inches",
                ExtendedCab = "Yes",
                Logo = "Combonation of three ovals",
                Slogan = "Let's go places"
            };
            SUV suv1 = new SUV()
            { 
                Year = 2023, 
                Make = "Dodge", 
                Model = "Durango SRT Hellcat", 
                NumberOfHorsePower = 710, 
                ExtraRowOfSeats = "Yes", 
                CargoHoldSize = "17.2 cubic feet", 
                Logo = "Ram", 
                Slogan = "Born Dodge" 
            };

            List<IVehicle> vehicleList = new List<IVehicle>
            {
                car1, truck1, suv1,
            };
            //Creatively display and organize their values
            foreach (var vehicle in vehicleList)
            {
                vehicle.Specs();
            }
        }
    }
}
