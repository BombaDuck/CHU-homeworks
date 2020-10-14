using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace 我是一顆花椰菜_哈比人歷險記
{
    class LonelyMountainBlock : Block
    {   
        private int feed;
        private int armor;

        public LonelyMountainBlock(Point loc)
            : base(loc)
        {
            feed = 5;
            armor = 4;
        }

        public override void ExcecuteAction(Player p)
        {
            p.AP += armor;
            p.HP += feed;   
        }
    }
}
