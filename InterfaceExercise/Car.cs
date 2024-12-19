using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public int TrunkCapacity { get; set; }
        public bool HasSpoiler { get; set; }
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public string PaintColor { get; set; }
        public string DriveType { get; set; }
        public string CompanyName { get; set; }
        public string CompanyLogo { get; set; }
    }
}
