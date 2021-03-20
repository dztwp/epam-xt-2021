using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2
{
    class Tree : Obstacle
    {
        public Tree(Point pos):base(pos)
        {
            listOfObstacleParts.Add(pos);
        }
    }
}
