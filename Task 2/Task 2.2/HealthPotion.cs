﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2
{
    class HealthPotion : Bonus
    {
        public override void RealiseBonus(Player pl)
        {
            pl.Health += 1 ;
        }
    }
}
