namespace RoleplayGame
{
    public class Staff: IAttackItem, IDefenseItem
    {
        private int attack;
        public int Attack
        {
            get
            {
                return this.attack;
            }
            set
            {
                if(value >= 0)
                {
                   this.attack = value;
                }
            }
        }
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
        public void AddPower(Character character)
        {
            character.Attack += this.Attack;
            character.Defense += this.Defense;
        }
    }
}