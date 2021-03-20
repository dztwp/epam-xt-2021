using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2
{
    class Skeleton : Enemy
    {
        public Skeleton(Point pos) : base(pos)
        {
            NumOfSteps = 1;
        }

        public override void Move(Point newPos)
        {
            Position = newPos;
        }
        public override void DoDamage(Player pl)
        {
            base.DoDamage(pl);
        }
        public override string ToString()
        {
            return "Created skeleton" + Environment.NewLine +
                "Damage - " + Damage + Environment.NewLine +
                "Number Of Steps - " + NumOfSteps;
        }
    }
}
