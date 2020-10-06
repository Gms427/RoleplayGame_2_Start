namespace RoleplayGame
{
    public class Sword : AttackItem
    {
        public int Attack { get; set; }
        public Sword(int attackValue)
        {
            this.Attack = attackValue;
        }
        public void AddPower (Character character)
        {
            character.AttackValue += this.Attack;
        }
    }
}