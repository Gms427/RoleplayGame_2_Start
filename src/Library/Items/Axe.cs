namespace RoleplayGame
{
    public class Axe : IAttackItem
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
        public Axe(int attack)
        {
            this.Attack = attack;
        }
        public void AddPower (Character character)
        {
            character.Attack += this.Attack;
        }
    }
}