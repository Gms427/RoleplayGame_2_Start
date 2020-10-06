namespace RoleplayGame
{
    public class Axe : IAttackItem
    {
        public int Attack { get; set; }
        public Axe(int attackValue)
        {
            this.Attack = attackValue;
        }
        public void AddPower (Character character)
        {
            character.AttackValue += this.Attack;
        }
    }
}