namespace RoleplayGame
{
    public class Armor : IDefenseItem
    {
        public int Defense { get; set; }
        public Armor(int defense)
        {
            this.Defense = defense;
        }
        public void AddPower (Character character)
        {
            character.Defense += this.Defense;
        }
    }
}