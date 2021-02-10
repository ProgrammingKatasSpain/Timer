namespace IMoreno.Timer
{
    public class Timer : ITimer<float>
    {
        public float Time { get; private set; }

        public float Add(float _amount) => Time = _amount;
    }
}