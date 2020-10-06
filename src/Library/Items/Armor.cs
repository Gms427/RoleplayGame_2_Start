namespace RoleplayGame
{
    public class Armor : IDefenseItem
    {
        public int Defense { get; set; }
        public Armor(int defenseValue)
        {
            this.Defense = defenseValue;
        }
        public void AddPower (Character character)
        {
            character.DefenseValue += this.Defense;
        }
    }
}