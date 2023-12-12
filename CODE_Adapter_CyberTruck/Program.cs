namespace CODE_Adapter_CyberTruck
{
    internal class Program
    {
        static void Main()
        {
            IVehicle car = new Car();
            IVehicle cyberTruck = new CyberTruckAdapter();
            
            IVehicle[] vehicleList = new IVehicle[] { car, cyberTruck };
            foreach (IVehicle vehicle in vehicleList)
            {
                vehicle.SpeedKpH = 100; // km/h
                vehicle.Move(3600); // seconds
                vehicle.Log();
            }
            Console.ReadKey();
        }
    }
}