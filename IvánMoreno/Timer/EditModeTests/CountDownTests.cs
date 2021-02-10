using NUnit.Framework;
using IMoreno.Timer;

namespace Tests
{
    public class CountDownTests
    {
        [Test]
        [TestCase(1)]
        [TestCase(3)]
        [TestCase(15)]
        public void CountDown_Callback_Is_Call_When_Timer_Reach_Goal(float _amount)
        {
            bool countDownIsFinished = false;

            Countdown countDown = new Countdown(new Timer(), _amount);
            countDown.OnCountDownFinished = () => countDownIsFinished = true;

            countDown.Add(_amount);

            Assert.IsTrue(countDownIsFinished);
        }
    }
}