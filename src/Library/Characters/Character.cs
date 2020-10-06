using System.Collections.Generic;

namespace RoleplayGame
{
    /// <summary>
    /// Clase padre de todos los Personajes:
    /// Tiene los atributos y métodos comunes a todos los personajes, para que ellos puedan heredarlos
    /// </summary>
    public abstract class Character
    {
        string Name { get; set; }
        private int health = 100;
        public int Health 
        {
            get
            {
                return this.health;
            }
            set
            {
                this.health = value < 0 ? 0 : value;
            }
        }
        
        List<IItem> items { get; set; } = new List<IItem>();


        public abstract int Attack { get; set; }
        public abstract int Defense { get; set; }

        public Character(string name)
        {
            this.Name = name;
        }
        
        /// <summary>
        /// Dado un item, lo añade a la lista de items del personaje
        /// </summary>
        public void AddItem(IItem item)
        {
            if(!ExistItem(item))
            {
                this.items.Add(item);
                /*
                    El método AddPower de la interfaz IItem me ahorra tener que estar preguntando acá si el item es de ataque o de defensa
                    De esa manera evitamos romper varios principios:
                    LSP: Ya que ahí hago alguna sistitución entre los tipos podría generar un comportamiento inesperado
                    OCP: Ya que si agrego un tipo de item nuevo tengo que agregar un nuevo bloque que pregunte por ese nuevo tipo
                    Polimorfismo: Ya que tendría un bloque de código dedicado a cada tipo
                */
                item.AddPower(this);
            }
        }

        /// <summary>
        /// Dado un item, lo busca en la lista de items del personaje, y si lo encuentra lo elimina
        /// </summary>
        public void DeleteItem(IItem item)
        {
            this.items.ForEach(it => {
                if(it == item)
                {
                    this.items.Remove(it);
                }
            });
        }

        /// <summary>
        /// Dado un item, retorna true si el personaje ya lo tiene, y false en caso contrario
        /// </summary>
        public bool ExistItem(IItem newItem)
        {
            return this.items.Contains(newItem);
        }


        /// <summary>
        /// Resta a la vidal del personaje el valor recibido menos su defensa
        /// </summary>
        public void ReceiveAttack(int power)
        {
            if (this.Defense < power)
            {
                this.Health -= power - this.Defense;
            }
        }
        
        /// <summary>
        /// Reestablece la vida del personaje
        /// </summary>
        public void Cure()
        {
            this.Health = 100;
        }
    }
}
