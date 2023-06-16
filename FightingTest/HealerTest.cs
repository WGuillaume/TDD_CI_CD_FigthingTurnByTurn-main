using FightingTurnByTurn;

namespace FightingTest
{
    [TestClass]
    public class HealerTest
    {

        [TestMethod]
        public void Healer_ShouldHaveCorrectInitialValues()
        {

            Healer healer = new Healer();

            Assert.AreEqual(20,healer.LifePoint);
            Assert.AreEqual(3, healer.Power);
            Assert.AreEqual(4, healer.Speed);
            Assert.AreEqual(3, healer.Cooldown);

        }
        [TestMethod]
        public void Healer_ToString_ShouldReturnCorrectString()
        {

            Healer healer = new Healer();

            string result = healer.ToString();

            Assert.AreEqual("Healer", result);
        }
    }
}
