namespace RoleplayGame
{
    public class Helmet : DefenseItem
    {
        public int Defense { get; set; }
        public Helmet(int defenseValue)
        {
            this.Defense = defenseValue;
        }
        public void AddPower (Character character)
        {
            character.DefenseValue += this.Defense;
        }
    }
}