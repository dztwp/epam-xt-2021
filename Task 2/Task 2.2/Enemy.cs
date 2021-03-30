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
        }
// Add moveToPlayer

        public virtual void DoDamage(Player pl)
        {
            pl.Health -= Damage;
        }
        public Enemy(Point pos):base(pos)
        {           
        }
    }
}
