using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace 我是一顆花椰菜_哈比人歷險記
{
    class DragonBlock : Block
    {
        private int hp;

        public DragonBlock(Point loc)
            : base(loc)
        {
            hp = 0;
        }

        public override void ExcecuteAction(Player p)
        {
            p.AP = 0;
            p.HP = p.HP / 2;   
        }
    }
}
