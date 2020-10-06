namespace RoleplayGame
{
    public class Knight: Character
    {
        private int health = 100;

        public Knight(string name): base(name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public Sword Sword { get; set; }

        public Shield Shield { get; set; }

        public Armor Armor { get; set; }

        public override int AttackValue
        {
            get
            {
                return Sword.AttackValue;
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
                return Armor.DefenseValue + Shield.DefenseValue;
            }
            set
            {
                DefenseValue=value;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value < 0 ? 0 : value;
            }
        }
    }
}