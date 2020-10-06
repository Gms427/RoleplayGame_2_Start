
namespace RoleplayGame
{
    public class DefenseItem : IItem
    {
        int Defense { get; set; }

        public void AddPower(Character character)
        {
            character.DefenseValue += this.Defense;
        }
    }
}
