namespace RoleplayGame
{
    public class Shield : DefenseItem
    {
        public int Defense { get; set; }
        public Shield(int defenseValue)
        {
            this.Defense = defenseValue;
        }
        public void AddPower (Character character)
        {
            character.DefenseValue += this.Defense;
        }
    }
}