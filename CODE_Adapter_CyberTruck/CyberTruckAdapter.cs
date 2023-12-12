using CODE_Adapter_CyberTruckDll;

namespace CODE_Adapter_CyberTruck
{
    class CyberTruckAdapter : IVehicle
    {
        private CyberTruck adaptee;
        private double conversionFactor = 1.609344;
        private double conversionFactorKm2m = 1_000.0;
        private double conversionFactorH2m = 60.0;
        public CyberTruckAdapter()
        {
            this.adaptee = new CyberTruck();
        }

        public int XLocation => (int)(adaptee.XLocationInMiles * 
            conversionFactor * conversionFactorKm2m);

        public int SpeedKpH
        {
            get => (int)(adaptee.MilesPerHour * conversionFactor);
            set => adaptee.MilesPerHour = value / conversionFactor;
        }

        public void Log()
        {
            Console.WriteLine("CyberTruck XLocaton = {0} meters", XLocation);
        }

        public void Move(int deltaSeconds)
        {
            adaptee.Move((int) (deltaSeconds/conversionFactorH2m)); // to whole minutes
        }
    }
}
