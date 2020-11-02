using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP1___Drop_Dead.Model;

namespace DropDead.Tests
{
    [TestClass]
    public class DiceTests
    {
        [TestMethod]
        public void GivenDiceSidesAtDiceCreation()
        {
            //Arrenge
            //Act
            Dice d = new Dice(20);
            //Assert
            Assert.AreEqual(d.Nb_sides, 20);

        }
        [TestMethod]
        public void SettingNewDiceSides()
        {
            //Arrenge
            Dice d = new Dice(20);
            //Act
            d.Nb_sides = 10;
            //Assert
            Assert.AreEqual(d.Nb_sides, 10);

        }
        [TestMethod]
        public void CurrentDiceSideReturnsValidIntValue()
        {
            //Arrenge
            Dice d = new Dice(6);
            //Act
            int side_value = d.Current;
            //Assert
            Assert.IsInstanceOfType(side_value, typeof(int));
           
        }
        [TestMethod]
        public void SettingCurrentSide()
        {
            //Arrenge
            Dice d = new Dice(6);
            //Act
            d.Current = 5;
            //Assert
            Assert.AreEqual(d.Current, 5);

        }

        [TestMethod]
        public void RollingDiceGivesValidIntInASpecificRange()
        {
            //Arrenge
            Dice d = new Dice(6);
            //Act
            d.Roll_dice();
            int v = d.Current;
            //Assert
            Assert.IsTrue(v == 1 || v == 2 || v == 3 || v == 4 || v == 5 ||v == 6);
        }




    }
}
