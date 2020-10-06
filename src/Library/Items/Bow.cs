namespace RoleplayGame
{
    public class Bow : AttackItem
    {
        public int Attack { get; set; }
        public Bow (int attackValue)
        {
            this.Attack = attackValue;
        }
        public void AddPower (Character character)
        {
            character.AttackValue += this.Attack;
        }
    }
}