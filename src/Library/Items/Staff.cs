namespace RoleplayGame
{
    public class Staff: IAtackItem, IDefenseItem
    {
        public int Attack{get; set;}
        public int Defense { get; set;}
        public void AddPower(Character character)
        {
            character.AttackValue+= this.Attack;
            character.DefenseValue+= this.Defense;
        }
    }
}