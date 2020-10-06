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
        private int attack;
        public override int Attack
        {
            get
            {
                return SpellsBook.Attack + this.attack;
            }
            set
            {
                if(value >= 0)
                {
                    this.attack = value;
                }
            }
        }
        private int defense;
        public override int Defense
        {
            get
            {
                return SpellsBook.Defense + this.defense;
            }
            set
            {
                this.defense = value;
            }
        }
    }
}