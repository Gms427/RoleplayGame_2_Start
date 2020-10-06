namespace RoleplayGame
{
    public class Staff: IAttackItem, IDefenseItem
    {
        public int Attack{get; set;}
        public int Defense { get; set;}
        public void AddPower(Character character)
        {
            character.Attack += this.Attack;
            character.Defense += this.Defense;
        }
    }
}