namespace RoleplayGame
{
    public class Shield : IDefenseItem
    {
        public int Defense { get; set; }
        public Shield(int defense)
        {
            this.Defense = defense;
        }
        public void AddPower (Character character)
        {
            character.Defense += this.Defense;
        }
    }
}