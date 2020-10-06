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

        public override int Attack
        {
            get
            {
                return Axe.Attack;
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
                return Shield.Defense + Helmet.Defense;
            }
            set
            {
                Defense = value;
            }
            
        }
    }
}