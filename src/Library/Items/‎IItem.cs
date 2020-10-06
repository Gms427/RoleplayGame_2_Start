namespace RoleplayGame
{
    /// <summary>
    /// Interfaz que implementan todos los items, de esta manera generamos una abstracción que engloba todos los items
    /// </summary>
    public interface IItem 
    {
        /// <summary>
        /// Este método es implementado por cada item, la idea es que dicha implementación le agregue al personaje dueño del item, sus poderes
        /// Los items de ataque añaden su ataque al personaje (Por ej: Axe)
        /// Los items de defensa añaden su defensa al personaje (Por ej: Armor)
        /// Los items que son tanto de defensa como de ataque, añaden ambas cosas (Por ej: Staff)
        /// </summary>
        /// <param name="character"></param>
        void AddPower(Character character);
    }
}