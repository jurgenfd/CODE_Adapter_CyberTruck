namespace CODE_Adapter_CyberTruck
{
    interface IVehicle
    {
        int XLocation { get; }
        int SpeedKpH { get; set; }
        void Log();
        void Move(int deltaSeconds);
    }
}
