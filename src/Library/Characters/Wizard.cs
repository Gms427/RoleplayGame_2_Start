namespace RoleplayGame
{
    public class Wizard: Character
    {
        public Wizard(string name): base(name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public SpellsBook SpellsBook { get; set; }

        public Staff Staff { get; set; }

        public override int AttackValue
        {
            get
            {
                return SpellsBook.AttackValue + this.AttackValue;
            }
            set
            {
                AttackValue=value;
            }
        }

        public override int DefenseValue
        {
            get
            {
                return SpellsBook.DefenseValue + this.DefenseValue;
            }
            set
            {
                DefenseValue=value;
            }
        }
    }
}