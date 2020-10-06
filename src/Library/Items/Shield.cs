namespace RoleplayGame
{
    public class Shield : IDefenseItem
    {
        private int defense;
        public int Defense
        {
            get
            {
                return this.defense;
            }
            set
            {
                if(value >= 0)
                {
                    this.defense = value;
                }
            }
        }
        public Shield(int defense)
        {
            this.Defense = defense;
        }
        public void AddPower (Character character)
        {
            character.Defense += this.Defense;
        }
    }
}