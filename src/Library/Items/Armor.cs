namespace RoleplayGame
{
    public class Armor : IDefenseItem
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
        public Armor(int defense)
        {
            this.Defense = defense;
        }
        public void AddPower (Character character)
        {
            character.Defense += this.Defense;
        }
    }
}