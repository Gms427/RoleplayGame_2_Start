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

        public override int AttackValue
        {
            get
            {
                return Bow.Attack;
            }
            set
            {
                AttackValue=value;
            }
        }

        public override int DefenseValue
        {
            get
            {
                return Helmet.DefenseValue;
            }
            set
            {
                DefenseValue=value;
            }
        }
    }
}