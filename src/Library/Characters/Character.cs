using System.Collections.Generic;

namespace RoleplayGame
{
    public abstract class Character
    {
        string Name { get; set; }
        
        int Health { get; set; }
        
        List<IItem> items { get; set; }

        public abstract int AttackValue { get; set; }
        public abstract int DefenseValue { get; set; }

        public Character(string name){
            this.Name = name;
        }
        
        public void AddItem(IItem item)
        {
            if(!this.items.Contains(item))
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

        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }
        
        public void Cure()
        {
            this.Health = 100;
        }
    }
}
