using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2
{
    class Obstacle:MapObject
    {
        public List<Point> listOfObstacleParts;
        public Obstacle(Point pos)
        {
            Position = pos;
        }
    }
}
