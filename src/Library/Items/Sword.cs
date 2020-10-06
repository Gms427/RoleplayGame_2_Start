namespace RoleplayGame
{
    public class Sword : IAttackItem
    {
        public int Attack { get; set; }
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