using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class CharacterTest
    {
        private Character character;


        [SetUp]
        public void Setup()
        {
            character = new Archer("Test Archer");
        }


        /// <summary>
        /// Test para comprobar que el daño de un enemigo no sea negativo, importante para evitar inconsistencias en el juego
        /// </summary>
        [Test]
        public void SetNegativeDamage()
        {
            character.Attack = -100;
            Assert.AreEqual(character.Attack, 0);
        }


        /// <summary>
        /// Test para comprobar que la vida de un enemigo no sea negativo, importante para evitar inconsistencias en el juego
        /// </summary>
        [Test]
        public void SetNegativeHealth()
        {
            character.Health = -100;
            Assert.AreEqual(character.Health, 0);
        }

        /// <summary>
        /// Test para comprobar que se añada correctamente un item a un personaje, es importante ya que si falla significa que los items basicamente no participan en el juego
        /// </summary>
        [Test]
        public void CheckAddItem()
        {
            IItem item = new Armor(50);
            character.AddItem(item);
            bool hasItem = character.ExistItem(item);
            Assert.IsTrue(hasItem);
        }


        /// <summary>
        /// Test para comprobar que se añada correctamente el daño de un item a un personaje, es importante ya que si falla significa que no se añade correctamente el daño de un item a los personajes
        /// </summary>
        [Test]
        public void CheckItemAddAttack()
        {
            IAttackItem item = new Bow(50);
            character.AddItem(item);
            Assert.AreEqual(item.Attack, this.character.Attack);
        }


        /// <summary>
        /// Test para comprobar que se añada correctamente la defensa de un item a un personaje, es importante ya que si falla significa que no se añade correctamente la defensa de un item a los personajes
        /// </summary>
        [Test]
        public void CheckItemAddDefense()
        {
            IDefenseItem item = new Armor(50);
            character.AddItem(item);
            Assert.AreEqual(item.Defense, this.character.Defense);
        }
    }
}