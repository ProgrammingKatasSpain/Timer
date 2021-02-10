using System;

namespace IMoreno.Timer
{
    public class Countdown : ICountdown, ITimer<float>
    {
        public Action OnCountDownFinished;
        public Action<float> OnCountDownUpdated;

        private readonly ITimer<float> timer;
        private readonly float goal;

        private bool isFinished;
        private float time;

        public float Time
        {
            get => time;
            private set
            {
                if (isFinished) return;

                time += value;

                CheckIfCountDownIsDone();
                OnCountDownUpdated?.Invoke(time);
            }
        }

        public Countdown(ITimer<float> _timer, float _goal)
        {
            timer = _timer;
            goal = _goal;
        }

        public float Add(float _amount)
        {
            return Time = timer.Add(_amount);
        }

        public void CheckIfCountDownIsDone()
        {
            if (isFinished || Time < goal) return;

            isFinished = true;
            OnCountDownFinished?.Invoke();
        }
    }
}