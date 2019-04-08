using System;

namespace CrimeAnalyzer
{

    internal class CrimeData
    {
        // this contains the list of crimes committed
        public int Year { get; set; }
        public int Population { get; set; }
        public int ViolentCrime { get; set; }
        public int Murder { get; set; }
        public int Rape { get; set; }
        public int Robbery { get; set; }
        public int AggravatedAssault { get; set; }
        public int PropertyCrime { get; set; }
        public int Burglary { get; set; }
        public int Theft { get; set; }
        public int MotorVehicleTheft { get; set; }
        public CrimeData()
        {
        }
    }
}