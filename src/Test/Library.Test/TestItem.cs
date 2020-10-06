using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class TestItem
    {
        private IDefenseItem itemDefensa;
        private IAttackItem itemAtaque;

        [SetUp]
        public void Setup()
        {
            itemDefensa= new Armor(5);
            itemAtaque = new Axe(33);
        }

        [Test]
        public void defenseNegativo()
        {
            const int expected = 5;
            itemDefensa.Defense = -5;
            Assert.AreEqual(expected, itemDefensa.Defense);
        }

        [Test]
        public void attackNegativo()
        {
            const int expected = 33;
            itemAtaque.Attack = -32;
            Assert.AreEqual(expected, itemAtaque.Attack);
        }
    }
}
  