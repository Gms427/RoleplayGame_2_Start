using System.Collections.Generic;

namespace RoleplayGame
{
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
        
        List<IItem> items { get; set; }

        public abstract int Attack { get; set; }
        public abstract int Defense { get; set; }

        public Character(string name){
            this.Name = name;
        }
        
        public void AddItem(IItem item)
        {
            if(!ExistItem(item))
            {
                this.items.Add(item);
                item.AddPower(this);
            }
        }

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


        public void ReceiveAttack(int power)
        {
            if (this.Defense < power)
            {
                this.Health -= power - this.Defense;
            }
        }
        
        public void Cure()
        {
            this.Health = 100;
        }
    }
}
