using FightingTurnByTurn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FightingTest
{
    [TestClass]
    public class CharactereTest
    {
        [TestMethod]
        public void CharacterHeal_ShouldHaveCorrectInitialValues()
        {

            Character character = new Healer();

            Assert.IsFalse(character.HasAlreadyAttack);
            Assert.IsTrue(character.Alive);
            Assert.IsFalse(character.IsOnCooldown);
            Assert.AreEqual(0, character.NumberOfTimePlayedSinceSpecial);
            Assert.IsFalse(character.HasShield);
        }
        [TestMethod]
        public void CharacterMagel_ShouldHaveCorrectInitialValues()
        {
            Character character = new Mage();

            Assert.IsFalse(character.HasAlreadyAttack);
            Assert.IsTrue(character.Alive);
            Assert.IsFalse(character.IsOnCooldown);
            Assert.AreEqual(0, character.NumberOfTimePlayedSinceSpecial);
            Assert.IsFalse(character.HasShield);
        }
        [TestMethod]
        public void CharacterWarrior_ShouldHaveCorrectInitialValues()
        {
            Character character = new Warrior();


            Assert.IsFalse(character.HasAlreadyAttack);
            Assert.IsTrue(character.Alive);
            Assert.IsFalse(character.IsOnCooldown);
            Assert.AreEqual(0, character.NumberOfTimePlayedSinceSpecial);
            Assert.IsFalse(character.HasShield);
        }

    }

}
