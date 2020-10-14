using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace 我是一顆花椰菜_哈比人歷險記
{
    class TrapBlock : Block
    {
        private int bonus;

        public TrapBlock(Point loc)
            : base(loc)
        {
            bonus = -3;
        }

        public override void ExcecuteAction(Player p)
        {
            p.AP += bonus;
        }
    }
}
