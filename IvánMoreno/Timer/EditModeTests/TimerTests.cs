using NUnit.Framework;
using IMoreno.Timer;

namespace Tests
{
    public class TimerTests
    {
        [Test]
        [TestCase(1)]
        [TestCase(3)]
        [TestCase(15)]
        public void Timer_Returns_Correctly_When_Add_Time(float _amount)
        {
            Timer timer = new Timer();

            float currentTime = timer.Add(_amount);

            Assert.AreEqual(_amount, currentTime);
        }
    }
}