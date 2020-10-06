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
        public int Attack 
        {
            get
            {
                return this.Attack;
            }
            set
            {
                this.Attack = value;
            } 
        }

        public int Defense
        {
            get
            {
                return this.Defense;
            }
            set
            {
                this.Defense = value;
            }
        }
    }
}