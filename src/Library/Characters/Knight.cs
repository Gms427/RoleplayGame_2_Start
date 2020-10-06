namespace RoleplayGame
{
    public class Knight: Character
    {
        public Knight(string name): base(name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public Sword Sword { get; set; }

        public Shield Shield { get; set; }

        public Armor Armor { get; set; }

        public override int Attack
        {
            get
            {
                return Sword.Attack;
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
                return Armor.Defense + Shield.Defense;
            }
            set
            {
                Defense = value;
            }
        }
    }
}