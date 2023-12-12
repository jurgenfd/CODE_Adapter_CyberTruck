namespace CODE_Adapter_CyberTruck
{
    internal class Car: IVehicle
    {
        public int XLocation { get; private set; }
        public int SpeedKpH { get; set; }

        public void Log()
        {
            Console.WriteLine("Cars XLocaion = {0} meters", XLocation);
        }

        public void Move(int deltaSeconds)
        {
            XLocation += (int)(deltaSeconds * SpeedKpH / 3.6);
        }
    }
}