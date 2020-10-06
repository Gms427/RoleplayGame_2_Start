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

        public override int Attack
        {
            get
            {
                return SpellsBook.Attack + this.Attack;
            }
            set
            {
                if(value >= 0)
                {
                    Attack = value;
                }
            }
        }

        public override int Defense
        {
            get
            {
                return SpellsBook.Defense + this.Defense;
            }
            set
            {
                Defense = value;
            }
        }
    }
}