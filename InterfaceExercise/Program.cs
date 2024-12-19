using System;
using System.Collections.Generic;
using System.IO;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: public int NumberOfWheels { get; set; }
                 */
            

            //In ICompany: 
            
                /* Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 * Example: public string Logo { get; set; }
                 */

            //In each of your Car, Truck, and SUV classes

                /* Create 2 members that are specific to each class
                 * Example for Car: public bool HasTrunk { get; set; }
                 * Example for SUV: public int NumberOfSeats { get; set; }
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values

            var car1 = new Car() {NumberOfWheels = 4, NumberOfDoors = 2, PaintColor = "Black", DriveType = "4x2", CompanyName = "BMW", CompanyLogo = "BMW Circle", HasSpoiler = true, TrunkCapacity = 15};
            var truck1 = new Truck() {NumberOfWheels = 4, NumberOfDoors = 4, PaintColor = "Blue", DriveType = "4x4", CompanyName = "Ford", CompanyLogo ="Blue Oval", HasPlow = true, TuckBedLength = 8};
            var SUV1 = new SUV() {NumberOfWheels = 4, NumberOfDoors = 4, PaintColor = "Red", DriveType = "4x4", CompanyName = "GMC", CompanyLogo = "GMC", ThirdRowSeating = true, TowCapacity = 3000};

            var vehicles = new List<IVehicle>() { car1, truck1, SUV1 };

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
                Console.WriteLine($"Number of Wheels: {vehicle.NumberOfWheels}");
                Console.WriteLine($"Number of Doors: {vehicle.NumberOfDoors}");
                Console.WriteLine($"Paint Color: {vehicle.PaintColor}");
                Console.WriteLine($"Drive Type: {vehicle.DriveType}");
                Console.WriteLine();
            }
            
            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.
            
        }
    }
}
