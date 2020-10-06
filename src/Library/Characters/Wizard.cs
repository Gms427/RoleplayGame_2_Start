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
                if(this.SpellsBook != null && this.SpellsBook.Attack > 0)
                {
                    return this.attack + SpellsBook.Attack;
                }
                else 
                {
                    return this.attack;
                }
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
                if(this.SpellsBook != null && this.SpellsBook.Defense > 0)
                {
                    return this.defense + SpellsBook.Defense;
                }
                else
                {
                    return this.defense;
                }
            }
            set
            {
                this.defense = value;
            }
        }
    }
}