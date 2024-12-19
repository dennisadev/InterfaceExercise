using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        //* Create 4 members that Car, Truck, & SUV all have in common.
        public int NumberOfWheels { get; set; }
        public  int NumberOfDoors { get; set; }
        public string PaintColor { get; set; }
        public  string DriveType { get; set; }
    }
}
