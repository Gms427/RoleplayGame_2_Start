
namespace RoleplayGame
{
    public class AtackItem : IItem
    {
        int Atack { get; set; }

        public void AddPower(Character character)
        {
            character.AttackValue += this.Atack;
        }
    }
}
