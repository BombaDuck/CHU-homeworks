﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace 我是一顆花椰菜_哈比人歷險記
{
    class DeadLandsBlock : Block
    {
        private int hunger=0;
        Random random;

        public DeadLandsBlock(Point loc)
            : base(loc)
        {

         
        }

        public override void ExcecuteAction(Player p)
        {
            random = new Random();
            hunger = random.Next(4) + 1;
            p.HP -= hunger;
        }
    }
}
