namespace ECS.Legacy
{
    public interface ITempSensor
    {
        public int GetTemp();

        public bool RunSelfTest();
    }
}