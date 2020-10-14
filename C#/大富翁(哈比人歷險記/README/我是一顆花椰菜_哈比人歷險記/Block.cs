using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace 我是一顆花椰菜_哈比人歷險記
{
    class Block
    {
        private Point location;

        public Block()
        {
            Location = new Point(0, 0);
        }

        public Block(Point loc)
        {
            Location = loc;
        }

        public Point Location
        {
            get { return location; }
            set { location = value; }
        }

        public virtual void ExcecuteAction(Player p)
        {

        }
    }
}
