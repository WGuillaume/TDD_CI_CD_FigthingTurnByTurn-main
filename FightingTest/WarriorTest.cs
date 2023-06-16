using FightingTurnByTurn;

namespace FightingTest
{
    [TestClass]
    public class WarriorTest
    {

        [TestMethod]
        public void Warrior_ShouldHaveCorrectInitialValues()
        {

            Warrior warrior = new Warrior();

            Assert.AreEqual(30, warrior.LifePoint);
            Assert.AreEqual(5, warrior.Power);
            Assert.AreEqual(6, warrior.Speed);
            Assert.AreEqual(2, warrior.Cooldown);

        }
        [TestMethod]
        public void Warroir_ToString_ShouldReturnCorrectString()
        {
            Warrior warrior = new Warrior();

            string result = warrior.ToString();

            Assert.AreEqual("Warrior", result);
        }
    }
    
}
