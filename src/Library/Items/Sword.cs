namespace RoleplayGame
{
    public class Sword : IAttackItem
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
        public Sword(int attackValue)
        {
            this.Attack = attackValue;
        }
        public void AddPower (Character character)
        {
            character.Attack += this.Attack;
        }
    }
}