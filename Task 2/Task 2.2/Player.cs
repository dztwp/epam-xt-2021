using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2
{
    class Player : MoveableObject
    {
        
        public int Health { get; set; }
        public int ScrollCounter { get; set; }
        public override void Move(Point newPos)
        {
            Position=newPos;
        }
        public Player(Point pos,int health,int numOfSteps):base(pos)
        {
            Health = health;
            NumOfSteps = numOfSteps;
        }
        public override string ToString()
        {
            return "This is player" + Environment.NewLine +
                "Health - " + Health + Environment.NewLine +
                "Number of steps - " + NumOfSteps;
        }
    }
}
