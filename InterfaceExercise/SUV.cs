using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public bool ThirdRowSeating { get; set; } = true;
        public int TowCapacity { get; set; } = 3000;
        public int NumberOfWheels { get; set; } = 4;
        public int NumberOfDoors { get; set; } = 4;
        public string PaintColor { get; set; } = "Red";
        public string DriveType { get; set; } = "4x4";
        public string CompanyName { get; set; } = "General Motors";
        public string CompanyLogo { get; set; } = "GMC";
    }
}
