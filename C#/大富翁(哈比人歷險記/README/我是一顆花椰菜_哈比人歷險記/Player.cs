using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace 我是一顆花椰菜_哈比人歷險記
{
    class Player
    {
        private Point location;
        private Bitmap image;
        private int hp;
        private int ap;
        private PlayerState state;
        private int power;
        private int overap;
        private int block_index;
        private int player_index;
        private bool is_attacked;
        public Point map_location;

        public Player()
        {
            HP = Constants.MAX_HP;
            AP = Constants.MAX_AP;
            State = PlayerState.Normal;
            Power = 4;
            BlockIndex = 0;
            PlayerIndex = 0;
            IsAttacked = false;
        }

        public Player(string path, int index)
        {
            HP = Constants.MAX_HP;
            AP = Constants.MAX_AP;
            State = PlayerState.Normal;
            Power = 4;
            BlockIndex = 0;
            PlayerIndex = index;
            IsAttacked = false;
            image = new Bitmap(path);
        }

        public Point Location
        {
            get { return location; }
            set
            {
                location = value;
            }
        }

        public Bitmap Image
        {
            get { return image; }
        }


        public int HP
        {
            get { return hp; }
            set
            {
                hp = value;
                hp = Math.Max(0, Math.Min(25, hp));
            }
        }
        public int AP
        {
            get { return ap; }
            set
            {
                ap = value;
                ap = Math.Max(0, Math.Min(6, ap));
            }
        }
        public PlayerState State
        {
            get { return state; }
            set { state = value; }
        }

        public int Power
        {
            get { return power; }
            set { power = value; }
        }

        public int BlockIndex
        {
            get { return block_index; }
            set { block_index = value; }
        }

        public int PlayerIndex
        {
            get { return player_index; }
            set { player_index = value; }
        }

        public bool IsAttacked
        {
            get { return is_attacked; }
            set { is_attacked = value; }
        }


        public void Attack(Player target)
        {
                overap = target.AP - power;
                target.AP -= power;
                if (target.AP < 0)
                    target.AP = 0;
                if (overap < 0)
                    target.HP += overap;

            IsAttacked = true;
        }
    }
}
