namespace RoleplayGame
{

    /// <summary>
    /// Interfaz que implementan los items de ataque, de esta manera permitimos tener varios tipos de objetos de ataque mientras que implementen la interfaz
    /// En principio pensamos esto como una clase y que los items de ataque heredaran de ella, pero si fuera asi los items que son tanto de ataque
    /// como de defensa no podrían heredar de ambas clases (AttackItem y DefenseItem), asi que decidimos dejarlas como interfaces
    /// </summary>
    public interface IAttackItem : IItem
    {
        int Attack { get; set; } 
    }
}
