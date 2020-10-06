namespace RoleplayGame
{
    public class Spell
    {
        public string Name { get; set; }
         public Spell(string name, int attack, int defense)
        {
            this.Name = name;
            this.Attack = attack;
            this.Defense = defense;
        }
        private int attack;
        public int Attack 
        {
            get
            {
                return this.attack;
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
        public int Defense
        {
            get
            {
                return this.defense;
            }
            set
            {
                if(value >= 0)
                {
                    this.defense = value;
                }
            }
        }
    }
}