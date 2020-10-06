namespace RoleplayGame
{
    public class Helmet : IDefenseItem
    {
        public int Defense { get; set; }
        public Helmet(int defense)
        {
            this.Defense = defense;
        }
        public void AddPower (Character character)
        {
            character.Defense += this.Defense;
        }
    }
}