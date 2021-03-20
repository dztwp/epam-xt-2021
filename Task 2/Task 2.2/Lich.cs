using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2
{
    class Lich : Enemy
    {
        public override void Move(Point newPos)
        {
            return;
        }
        public Lich(Point pos):base(pos)
        {
            Position = pos;
            NumOfSteps = 0;
        }
        public Skeleton CreateSkeleton()
        {
            return new Skeleton(new Point(Position.X+1, Position.Y+1));
        }
        public override void DoDamage(Player pl)
        {
            pl.Health = 0;
        }
    }
}
