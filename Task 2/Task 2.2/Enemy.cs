using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2
{
    abstract class Enemy:MoveableObject
    {
        private int damage;

        public int Damage
        {
            get { return damage; }
            set 
            {
                
                damage =(damage>0)? value:throw new ArgumentException("Damage must be positive");
            }
        }


        public virtual void DoDamage(Player pl)
        {
            pl.Health -= Damage;
        }
        public Enemy(Point pos):base(pos)
        {           
        }
    }
}
