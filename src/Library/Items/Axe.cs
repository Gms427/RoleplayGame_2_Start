namespace RoleplayGame
{
    public class Axe : IAttackItem
    {
        public int Attack { get; set; }
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