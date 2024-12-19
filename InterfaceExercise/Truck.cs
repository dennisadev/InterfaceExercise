using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public int TuckBedLength { get; set; } = 8;
        public bool HasPlow { get; set; } = false;
        public int NumberOfWheels { get; set; } = 4;
        public int NumberOfDoors { get; set; } = 4;
        public string PaintColor { get; set; } = "Blue";
        public string DriveType { get; set; } = "4x4";
        public string CompanyName { get; set; } = "Ford";
        public string CompanyLogo { get; set; } = "Ford Oval";
    }
}
