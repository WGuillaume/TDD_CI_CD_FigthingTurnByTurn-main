using FightingTurnByTurn;
using static System.Net.Mime.MediaTypeNames;


namespace FightingTest
{
    [TestClass]
    public class MageTest
    {

        [TestMethod]
        public void Mage_ShouldHaveCorrectInitialValues()
        {

            Mage mage = new Mage();

            Assert.AreEqual(24, mage.LifePoint);
            Assert.AreEqual(6, mage.Power);
            Assert.AreEqual(5, mage.Speed);
            Assert.AreEqual(2, mage.Cooldown);

        }
        [TestMethod]
        public void Mage_ToString_ShouldReturnCorrectString()
        {
            Mage mage = new Mage();

            string result = mage.ToString();

            Assert.AreEqual("Mage", result);
        }


    }
}

