namespace RoleplayGame
{
    public class Bow : IAttackItem
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
        public Bow (int attack)
        {
            this.Attack = attack;
        }
        public void AddPower (Character character)
        {
            character.Attack += this.Attack;
        }
    }
}