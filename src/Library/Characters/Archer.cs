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

        public override int Attack
        {
            get
            {
                return Bow.Attack;
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
                return Helmet.Defense;
            }
            set
            {
                Defense = value;
            }
        }
    }
}