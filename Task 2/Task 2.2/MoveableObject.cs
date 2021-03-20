using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2
{
     abstract class MoveableObject:MapObject
    {
        public int NumOfSteps { get; set; }
        public abstract void Move(Point newPos);
        public override string ToString()
        {
            return base.ToString();
        }
        public MoveableObject(Point pos)
        {
            Position = pos;
        }
    }
}
