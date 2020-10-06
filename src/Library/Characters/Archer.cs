namespace RoleplayGame
{
    public class Archer: Character
    {
        public Archer(string name): base(name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
        
        public Bow Bow { get; set; }

        public Helmet Helmet { get; set; }

        private int attack;
        private int defense;
        public override int Attack
        {
            get
            {
                if(this.Bow != null && this.Bow.Attack > 0)
                {
                    return this.attack + Bow.Attack;
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

        public override int Defense
        {
            get
            {
                if(this.Helmet != null && this.Helmet.Defense > 0)
                {
                    return this.defense + Helmet.Defense;
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