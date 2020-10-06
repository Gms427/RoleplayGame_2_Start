namespace RoleplayGame
{
    public class Spell
    {
        public string Name { get; set; }
        private int attack;
        private int defense;
         public Spell(string name,int attack, int defense)
        {
            this.Name = name;
            this.AttackValue=attack;
            this.DefenseValue=defense;
        }
        public int AttackValue 
        {
            get
            {
                return this.AttackValue;
            }
            set
            {
                this.AttackValue=value;
            } 
        }

        public int DefenseValue
        {
            get
            {
                return this.DefenseValue;
            }
            set
            {
                this.AttackValue=value;
            }
        }
    }
}