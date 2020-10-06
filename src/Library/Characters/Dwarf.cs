namespace RoleplayGame
{
    public class Dwarf: Character
    {
        public Dwarf(string name): base(name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public Axe Axe { get; set; }

        public Shield Shield { get; set; }

        public Helmet Helmet { get; set; }
        private int attack;
        private int defense;
        public override int Attack
        {
            get
            {
                if(this.Axe != null && this.Axe.Attack > 0)
                {
                    return this.attack + Axe.Attack;
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
                if(this.Shield != null && this.Shield.Defense > 0)
                {
                    return this.defense + Shield.Defense;
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