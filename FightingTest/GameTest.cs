using FightingTurnByTurn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FightingTest
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void StartGame_ShouldHaveCorrectInitialObject_WihoutAnyPlayers()
        {
            Game game = new Game();


            Assert.AreEqual(0, game.Players.Count);
            Assert.IsFalse(game.IsStarted);
            Assert.AreEqual(1, game.CurrentTurn);
            Assert.IsNull(game.Winner);

        }
        // - Instancier un objet Game puis ajouter un joueur donne un compte de joueur à 1

        [TestMethod]
        public void StartGame_ShouldHaveCorrectAddObject_ToPlayeurOne()
            {
            
            }
    }
}
