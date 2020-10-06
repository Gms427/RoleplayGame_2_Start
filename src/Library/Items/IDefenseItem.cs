namespace RoleplayGame
{

    /// <summary>
    /// Interfaz que implementan los items de defensa, de esta manera permitimos tener varios tipos de objetos de defensa mientras que implementen la interfaz
    /// En principio pensamos esto como una clase y que los items de defensa heredaran de ella, pero si fuera asi los items que son tanto de ataque
    /// como de defensa no podrían heredar de ambas clases (AttackItem y DefenseItem), asi que decidimos dejarlas como interfaces
    /// </summary>
    public interface IDefenseItem : IItem
    {
        int Defense { get; set; }
    }
}