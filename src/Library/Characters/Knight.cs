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
        private int attack;
        private int defense;
        public override int Attack
        {
            get
            {
                if(this.Sword != null && this.Sword.Attack > 0)
                {
                    return this.attack + Sword.Attack;
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
                if(this.Armor != null && this.Armor.Defense > 0)
                {
                    return this.defense + Armor.Defense;
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