namespace ECS.Legacy
{
    public interface IHeater
    {
        public void TurnOff();

        public void TurnOn();

        public bool RunSelfTest();
    }
}