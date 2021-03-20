using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2
{
    class Rock:Obstacle
    {
        public Rock(Point pos):base(pos)
        {
            listOfObstacleParts.Add(pos);
            listOfObstacleParts.Add(new Point(pos.X+1,pos.Y));
            listOfObstacleParts.Add(new Point(pos.X + 1, pos.Y+1));
            listOfObstacleParts.Add(new Point(pos.X , pos.Y+1));
        }
    }
}
