using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace 我是一顆花椰菜_哈比人歷險記
{
    class RestBlock: Block
    {
        private int rest;

        public RestBlock(Point loc)
            : base(loc)
        {
            rest = 5;
        }

        public override void ExcecuteAction(Player p)
        {
            p.HP += rest;
        }
    
    }
}
