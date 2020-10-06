using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Character character = new Archer("Test Archer");

            character.Attack = -100;
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell("Hechizo 1", 50, 10) };

            Wizard gandalf = new Wizard("Gandalf");
            gandalf.Staff = new Staff();
            gandalf.SpellsBook = book;

            Dwarf gimli = new Dwarf("Gimli");
            gimli.Axe = new Axe(32);
            gimli.Helmet = new Helmet(12);
            gimli.Shield = new Shield(21);

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
            Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.Attack}");

            gimli.ReceiveAttack(gandalf.Attack);

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

            gimli.Cure();

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
        }
    }
}
