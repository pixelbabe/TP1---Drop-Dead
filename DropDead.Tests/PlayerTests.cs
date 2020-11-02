using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP1___Drop_Dead.Model;

namespace DropDead.Tests
{
    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        public void NameGivenToPlayerIsNotNull_IdNotNull()
        {
            //Arrenge
            Player p1 = new Player("");
            //Act
            p1.Name = "Jake";

            //Assert
            Assert.IsNotNull(p1.Id);
            Assert.IsNotNull(p1);
            Assert.AreEqual(p1.Name, "Jake");
        }

        [TestMethod]
        public void SettingNewIdToPlayer()
        {
            //Arrenge
            Player p1 = new Player("Dandan");
            //Act
            p1.Id = 6;

            //Assert
            Assert.AreEqual(p1.Id, 6);
        }

        [TestMethod]
        public void AddingPlayerGameScore_NotZero()
        {
            //Arrenge
            Player p1 = new Player("Dandan");
            //Act
            int added_score = 10;
            p1.Game_score += added_score;
            //Assert
            Assert.AreNotEqual(p1.Game_score, 0);
        }
        [TestMethod]
        public void PlayerStartingGameScoreIsZero()
        {
            //Arrenge
            Player p1 = new Player("Dandan");
            //Act
            int starting_game_score = p1.Game_score;

            //Assert
            Assert.AreEqual(starting_game_score, 0);
        }

        [TestMethod]
        public void ToStringWritesNameGiven_NotNull()
        {
            //Arrenge
            Player p1 = new Player("Dandan");
            //Act
            string player_string = p1.ToString();

            //Assert
            Assert.IsNotNull(player_string);
            Assert.AreEqual(player_string, "Player: Dandan, Score : 0");
        }


    }
}
