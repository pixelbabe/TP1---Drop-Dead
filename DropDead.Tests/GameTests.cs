using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP1___Drop_Dead.Model;

namespace DropDead.Tests
{
    [TestClass]
    public class GameTests
    {

        [TestMethod]
        public void GameCreation_StartingParameters()
        {
            //Arrenge

            //Act
            Game g = new Game();
            
            //Assert
            Assert.IsTrue(g.Players.Count == 0);
            Assert.IsTrue(g.Dice_set.Count == 5);

        }
        [TestMethod]
        public void AddingPlayersToGame_CheckingExistingPlayers()
        {
            //Arrenge
            Game g = new Game();
            Player p1 = new Player("Mathieu");
            Player p2 = new Player("Chha");
            //Act
            g.AddPlayer(p1);
            g.AddPlayer(p2);
            //Assert
            Assert.IsNotNull(g.Players);
            Assert.IsTrue(g.Players.Count == 2);
            Assert.IsTrue(g.Players.Contains(p1));

        }
    }
}
