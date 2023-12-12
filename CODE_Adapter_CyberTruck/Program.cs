namespace CODE_Adapter_CyberTruck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.SpeedKpH = 120;
            car.Move(45);
            car.Log();
            Console.ReadKey();
        }
    }
}