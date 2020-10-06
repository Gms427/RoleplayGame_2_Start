namespace RoleplayGame
{
    public class Bow : IAttackItem
    {
        public int Attack { get; set; }
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