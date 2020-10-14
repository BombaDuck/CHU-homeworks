using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace 我是一顆花椰菜_哈比人歷險記
{
    class EquipsBlock: Block
    {
        private int armor;

        public EquipsBlock(Point loc)
            : base(loc)
        {
            armor = 4;
        }

        public override void ExcecuteAction(Player p)
        {
            p.AP += armor;
        }
    }
}
