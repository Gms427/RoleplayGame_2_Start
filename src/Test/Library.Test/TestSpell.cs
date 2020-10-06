using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class TestSpell
    {
        private Spell spell;

        [SetUp]
        public void Setup() 
        {
            spell = new Spell("Test", 33, 5);
        }

        [Test]
        public void nameValido()
        {
            const string expected = "Test";
            spell.Name = expected;
            Assert.AreEqual(expected, spell.Name);
        }

        [Test]
        public void defenseNegativo()
        {
            const int expected = 5;
            spell.Defense = -5;
            Assert.AreEqual(expected, spell.Defense);
        }
        [Test]
        public void damageNegativo()
        {
            const int expected = 33;
            spell.Attack = -32;
            Assert.AreEqual(expected,spell.Attack);
        }
    }
}
  