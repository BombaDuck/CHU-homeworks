using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace B10302044_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 600;
            timer1.Enabled = false;
            
        }
        int p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0, p6 = 0, p7 = 0, p8 = 0, p9 = 0, p10 = 0, p11 = 0, p12 = 0;
        int found1 = 0, found2 = 0, found3 = 0, found4 = 0, found5 = 0, found6 = 0, found7 = 0, found8 = 0, found9 = 0, found10 = 0, found11 = 0, found12 = 0;
        int started = 0,started2=0;
        
        int[] cardss = new int[12] { 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7 };
        int[] cardspic = new int[12] { 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7} ;
        int timer = 0, picked1 = 7, picked2 = 8,picked3 = 0;
        int count=0;
        Random cards = new Random();

        private void 重新遊戲ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            started = 1;
            timer = 0;
            picked1 = 7;
            picked2 = 8;
            picked3 = 0;
            count = 0;
            timer1.Enabled = false;
            found1 = 0;
            found2 = 0;
            found3 = 0;
            found4 = 0;
            found5 = 0;
            found6 = 0;
            found7 = 0;
            found8 = 0;
            found9 = 0;
            found10 = 0;
            found11 = 0;
            found12 = 0;

            for (int i = 0; i < 12;i++ )
            {
                cardspic[i] = 7;
            }
                pictureBox1.Image = (Image)
                (Properties.Resources.ResourceManager.GetObject(string.Format("7")));
            pictureBox2.Image = (Image)
            (Properties.Resources.ResourceManager.GetObject(string.Format("7")));
            pictureBox3.Image = (Image)
            (Properties.Resources.ResourceManager.GetObject(string.Format("7")));
            pictureBox4.Image = (Image)
            (Properties.Resources.ResourceManager.GetObject(string.Format("7")));
            pictureBox5.Image = (Image)
            (Properties.Resources.ResourceManager.GetObject(string.Format("7")));
            pictureBox6.Image = (Image)
            (Properties.Resources.ResourceManager.GetObject(string.Format("7")));
            pictureBox7.Image = (Image)
            (Properties.Resources.ResourceManager.GetObject(string.Format("7")));
            pictureBox8.Image = (Image)
            (Properties.Resources.ResourceManager.GetObject(string.Format("7")));
            pictureBox9.Image = (Image)
            (Properties.Resources.ResourceManager.GetObject(string.Format("7")));
            pictureBox10.Image = (Image)
            (Properties.Resources.ResourceManager.GetObject(string.Format("7")));
            pictureBox11.Image = (Image)
            (Properties.Resources.ResourceManager.GetObject(string.Format("7")));
            pictureBox12.Image = (Image)
            (Properties.Resources.ResourceManager.GetObject(string.Format("7")));

            for (int i = 0; i < 12; i++)
            {
                cardss[i] = cards.Next(0, 12);
                for (int j = 0; j < i; j++)
                {
                    if (cardss[i] == cardss[j])
                    {
                        i = i - 1;
                        j = i;
                    }
                }
            }

            for (int i = 0; i < 12; i++)
            {
                if (cardss[i] == 6)
                    cardss[i] = 0;
                else if (cardss[i] == 7)
                    cardss[i] = 1;
                else if (cardss[i] == 8)
                    cardss[i] = 2;
                else if (cardss[i] == 9)
                    cardss[i] = 3;
                else if (cardss[i] == 10)
                    cardss[i] = 4;
                else if (cardss[i] == 11)
                    cardss[i] = 5;
            }
            p1 = cardss[0];
            p2 = cardss[1];
            p3 = cardss[2];
            p4 = cardss[3];
            p5 = cardss[4];
            p6 = cardss[5];
            p7 = cardss[6];
            p8 = cardss[7];
            p9 = cardss[8];
            p10 = cardss[9];
            p11 = cardss[10];
            p12 = cardss[11];
            
        }
        private void 開始遊戲ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (started2 == 0)
            {
                started2 = 1;
                if (started == 0)
                {
                    started = 1;
                    pictureBox1.Image = (Image)
                    (Properties.Resources.ResourceManager.GetObject(string.Format("7")));
                    pictureBox2.Image = (Image)
                    (Properties.Resources.ResourceManager.GetObject(string.Format("7")));
                    pictureBox3.Image = (Image)
                    (Properties.Resources.ResourceManager.GetObject(string.Format("7")));
                    pictureBox4.Image = (Image)
                    (Properties.Resources.ResourceManager.GetObject(string.Format("7")));
                    pictureBox5.Image = (Image)
                    (Properties.Resources.ResourceManager.GetObject(string.Format("7")));
                    pictureBox6.Image = (Image)
                    (Properties.Resources.ResourceManager.GetObject(string.Format("7")));
                    pictureBox7.Image = (Image)
                    (Properties.Resources.ResourceManager.GetObject(string.Format("7")));
                    pictureBox8.Image = (Image)
                    (Properties.Resources.ResourceManager.GetObject(string.Format("7")));
                    pictureBox9.Image = (Image)
                    (Properties.Resources.ResourceManager.GetObject(string.Format("7")));
                    pictureBox10.Image = (Image)
                    (Properties.Resources.ResourceManager.GetObject(string.Format("7")));
                    pictureBox11.Image = (Image)
                    (Properties.Resources.ResourceManager.GetObject(string.Format("7")));
                    pictureBox12.Image = (Image)
                    (Properties.Resources.ResourceManager.GetObject(string.Format("7")));
                }

                

                for (int i = 0; i < 12; i++)
                {
                    cardss[i] = cards.Next(0, 12);
                    for (int j = 0; j < i; j++)
                    {
                        if (cardss[i] == cardss[j])
                        {
                            i = i - 1;
                            j = i;
                        }
                    }
                }

                for (int i = 0; i < 12; i++)
                {
                    if (cardss[i] == 6)
                        cardss[i] = 0;
                    else if (cardss[i] == 7)
                        cardss[i] = 1;
                    else if (cardss[i] == 8)
                        cardss[i] = 2;
                    else if (cardss[i] == 9)
                        cardss[i] = 3;
                    else if (cardss[i] == 10)
                        cardss[i] = 4;
                    else if (cardss[i] == 11)
                        cardss[i] = 5;
                }
                p1 = cardss[0];
                p2 = cardss[1];
                p3 = cardss[2];
                p4 = cardss[3];
                p5 = cardss[4];
                p6 = cardss[5];
                p7 = cardss[6];
                p8 = cardss[7];
                p9 = cardss[8];
                p10 = cardss[9];
                p11 = cardss[10];
                p12 = cardss[11];
            }
        }

        public void founder()
        {

            if (p1 == picked1)
            {
                cardspic[0] = p1;
                found1 = 1;
            }
            if (p2 == picked1)
            {
                cardspic[1] = p2;
                found2 = 1;
            }
            if (p3 == picked1)
            {
                cardspic[2] = p3;
                found3 = 1;
            }
            if (p4 == picked1)
            {
                cardspic[3] = p4;
                found4 = 1;
            }
            if (p5== picked1)
            {
                cardspic[4] = p5;
                found5 = 1;
            }
            if (p6 == picked1)
            {
                cardspic[5] = p6;
                found6 = 1;
            }
            if (p7 == picked1)
            {
                cardspic[6] = p7;
                found7 = 1;
            }
            if (p8 == picked1)
            {
                cardspic[7] = p8;
                found8 = 1;
            }
            if (p9 == picked1)
            {
                cardspic[8] = p9;
                found9= 1;
            }
            if (p10 == picked1)
            {
                cardspic[9] = p10;
                found10 = 1;
            }
            if (p11 == picked1)
            {
                cardspic[10] = p11;
                found11 = 1;
            }
            if (p12 == picked1)
            {
                cardspic[11] = p12;
                found12 = 1;
            } 
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
           
            if (started == 1 && picked3 != 1 && found1 ==0)
            {
                pictureBox1.Image = (Image)
                    (Properties.Resources.ResourceManager.GetObject(string.Format("{0}", p1)));
                
                if (timer == 0)
                {
                    timer++;
                    picked1 = p1;
                    picked3 = 1;
                }
                else if(timer == 1)
                {
                    timer = 2;
                    picked2 = p1;
                    picked3 = 0;
                    if(picked1 == picked2)
                    {
                        founder();
                    }
                    else if(picked1 != picked2)
                    {
                        picked1 = 7;
                        picked2 = 8;
                        timer = 2;
                    }
                }
                if(timer == 2)
                {
                    started = 0;
                    timer = 0;
                    timer1.Enabled = true;
                }
            }
            
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (started == 1 && picked3 != 2 && found2 ==0)
            {
                pictureBox2.Image = (Image)
                    (Properties.Resources.ResourceManager.GetObject(string.Format("{0}", p2)));

                if (timer == 0)
                {
                    timer++;
                    picked1 = p2;
                    picked3 = 2;
                }
                else if (timer == 1)
                {
                    timer = 2;
                    picked2 = p2;
                    picked3 = 0;
                    if (picked1 == picked2)
                    {
                        founder();
                    }
                    else if (picked1 != picked2)
                    {
                        picked1 = 7;
                        picked2 = 8;
                        timer = 2;
                        
                    }
                }
                if (timer == 2)
                {
                    started = 0;
                    timer = 0;
                    timer1.Enabled = true;
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (started == 1 && picked3 != 3 && found3 == 0)
            {
                pictureBox3.Image = (Image)
                    (Properties.Resources.ResourceManager.GetObject(string.Format("{0}", p3)));
                
                if (timer == 0)
                {
                    timer++;
                    picked1 = p3;
                    picked3 = 3;
                }
                else if (timer == 1)
                {
                    timer = 2;
                    picked2 = p3;
                    picked3 = 0;

                    if (picked1 == picked2)
                    {
                        founder();
                    }
                    else if (picked1 != picked2)
                    {
                        picked1 = 7;
                        picked2 = 8;
                        timer = 2;
                       
                    }
                }
                if (timer == 2)
                {
                    started = 0;
                    timer = 0;
                    timer1.Enabled = true;
                }
            }
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (started == 1 && picked3 != 4 && found4 == 0)
            {
                pictureBox4.Image = (Image)
                    (Properties.Resources.ResourceManager.GetObject(string.Format("{0}", p4)));

                if (timer == 0)
                {
                    timer++;
                    picked1 = p4;
                    picked3 = 4;
                }
                else if(timer == 1)
                {
                    timer = 2;
                    picked2 = p4;
                    picked3 = 0;
                    
                    if(picked1 == picked2)
                    {
                        founder();
                    }
                    else if(picked1 != picked2)
                    {
                        picked1 = 7;
                        picked2 = 8;
                        timer = 2;
                        
                    }
                }
                if(timer == 2)
                {
                    started = 0;
                    timer = 0;
                    timer1.Enabled = true;
                }
            }
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (started == 1 && picked3 != 5 && found5 == 0)
            {
                pictureBox5.Image = (Image)
                    (Properties.Resources.ResourceManager.GetObject(string.Format("{0}", p5)));
                if (timer == 0)
                {
                    timer++;
                    picked1 = p5;
                    picked3 = 5;

                }
                else if (timer == 1)
                {
                    timer = 2;
                    picked2 = p5;
                    picked3 = 0;

                    if (picked1 == picked2)
                    {
                        founder();
                    }
                    else if (picked1 != picked2)
                    {
                        picked1 = 7;
                        picked2 = 8;
                        timer = 2;
                       
                    }
                }
                if (timer == 2)
                {
                    started = 0;
                    timer = 0;
                    timer1.Enabled = true;
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (started == 1 && picked3 != 6 && found6 == 0)
            {
                pictureBox6.Image = (Image)
                    (Properties.Resources.ResourceManager.GetObject(string.Format("{0}", p6)));
                if (timer == 0)
                {
                    timer++;
                    picked1 = p6;
                    picked3 = 6;
                }
                else if (timer == 1)
                {
                    timer = 2;
                    picked2 = p6;
                    picked3 = 0;

                    if (picked1 == picked2)
                    {
                        founder();
                    }
                    else if (picked1 != picked2)
                    {
                        picked1 = 7;
                        picked2 = 8;
                        timer = 2;
                    }
                }
                if (timer == 2)
                {
                    started = 0;
                    timer = 0;
                    timer1.Enabled = true;
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (started == 1 && picked3 != 7 && found7 == 0)
            {
                pictureBox7.Image = (Image)
                    (Properties.Resources.ResourceManager.GetObject(string.Format("{0}", p7)));
                if (timer == 0)
                {
                    timer++;
                    picked1 = p7;
                    picked3 = 7;
                }
                else if (timer == 1)
                {
                    timer = 2;
                    picked2 = p7;
                    picked3 = 0;

                    if (picked1 == picked2)
                    {
                        founder();
                    }
                    else if (picked1 != picked2)
                    {
                        picked1 = 7;
                        picked2 = 8;
                        timer = 2;
                    }
                }
                if (timer == 2)
                {
                    started = 0;
                    timer = 0;
                    timer1.Enabled = true;
                }
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (started == 1 && picked3 != 8 && found8 == 0)
            {
                pictureBox8.Image = (Image)
                    (Properties.Resources.ResourceManager.GetObject(string.Format("{0}", p8)));
                if (timer == 0)
                {
                    timer++;
                    picked1 = p8;
                    picked3 = 8;
                }
                else if (timer == 1)
                {
                    timer = 2;
                    picked2 = p8;
                    picked3 = 0;

                    if (picked1 == picked2)
                    {
                        founder();
                    }
                    else if (picked1 != picked2)
                    {
                        picked1 = 7;
                        picked2 = 8;
                        timer = 2;
                    }
                }
                if (timer == 2)
                {
                    started = 0;
                    timer = 0;
                    timer1.Enabled = true;
                }
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (started == 1 && picked3 != 9 && found9 == 0)
            {
                pictureBox9.Image = (Image)
                    (Properties.Resources.ResourceManager.GetObject(string.Format("{0}", p9)));
                if (timer == 0)
                {
                    timer++;
                    picked1 = p9;
                    picked3 = 9;
                }
                else if (timer == 1)
                {
                    timer = 2;
                    picked2 = p9;
                    picked3 = 0;

                    if (picked1 == picked2)
                    {
                        founder();
                    }
                    else if (picked1 != picked2)
                    {
                        picked1 = 7;
                        picked2 = 8;
                        timer = 2;
                    }
                }
                if (timer == 2)
                {
                    started = 0;
                    timer = 0;
                    timer1.Enabled = true;
                }
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (started == 1 && picked3 != 10 && found10 == 0)
            {
                pictureBox10.Image = (Image)
                    (Properties.Resources.ResourceManager.GetObject(string.Format("{0}", p10)));
                if (timer == 0)
                {
                    timer++;
                    picked1 = p10;
                    picked3 = 10;
                }
                else if (timer == 1)
                {
                    timer = 2;
                    picked2 = p10;
                    picked3 = 0;

                    if (picked1 == picked2)
                    {
                        founder();
                    }
                    else if (picked1 != picked2)
                    {
                        picked1 = 7;
                        picked2 = 8;
                        timer = 2;
                    }
                }
                if (timer == 2)
                {
                    started = 0;
                    timer = 0;
                    timer1.Enabled = true;
                }
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (started == 1 && picked3 != 11 && found11 == 0)
            {
                pictureBox11.Image = (Image)
                    (Properties.Resources.ResourceManager.GetObject(string.Format("{0}", p11)));
                if (timer == 0)
                {
                    timer++;
                    picked1 = p11;
                    picked3 = 11;
                }
                else if (timer == 1)
                {
                    timer = 2;
                    picked2 = p11;
                    picked3 = 0;

                    if (picked1 == picked2)
                    {
                        founder();
                    }
                    else if (picked1 != picked2)
                    {
                        picked1 = 7;
                        picked2 = 8;
                        timer = 2;
                    }
                }
                if (timer == 2)
                {
                    started = 0;
                    timer = 0;
                    timer1.Enabled = true;
                }
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (started == 1 && picked3 != 12 && found12 == 0)
            {
                pictureBox12.Image = (Image)
                    (Properties.Resources.ResourceManager.GetObject(string.Format("{0}", p12)));
                if (timer == 0)
                {
                    timer++;
                    picked1 = p12;
                    picked3 = 12;
                }
                else if (timer == 1)
                {
                    timer = 2;
                    picked2 = p12;
                    picked3 = 0;

                    if (picked1 == picked2)
                    {
                        founder();
                    }
                    else if (picked1 != picked2)
                    {
                        picked1 = 7;
                        picked2 = 8;
                        timer = 2;
                    }
                }
                if (timer == 2)
                {
                    started = 0;
                    timer = 0;
                    timer1.Enabled = true;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count = count+1;
            if (cardspic[0] == p1 && cardspic[1] == p2 && cardspic[2] == p3 &&
                cardspic[3] == p4 && cardspic[4] == p5 && cardspic[5] == p6 &&
                cardspic[6] == p7 && cardspic[7] == p8 && cardspic[8] == p9 &&
                cardspic[9] == p10 && cardspic[10] == p11 && cardspic[11] == p12)
            {
                timer1.Enabled = false;
                MessageBox.Show("You have win this game!");
                
            }
            else if (count == 2)
            {
                count = 0;
                timer1.Enabled = false;
                started = 1;
                pictureBox1.Image = (Image)
                (Properties.Resources.ResourceManager.GetObject(string.Format("{0}", cardspic[0])));
                pictureBox2.Image = (Image)
                (Properties.Resources.ResourceManager.GetObject(string.Format("{0}", cardspic[1])));
                pictureBox3.Image = (Image)
                (Properties.Resources.ResourceManager.GetObject(string.Format("{0}", cardspic[2])));
                pictureBox4.Image = (Image)
                (Properties.Resources.ResourceManager.GetObject(string.Format("{0}", cardspic[3])));
                pictureBox5.Image = (Image)
                (Properties.Resources.ResourceManager.GetObject(string.Format("{0}", cardspic[4])));
                pictureBox6.Image = (Image)
                (Properties.Resources.ResourceManager.GetObject(string.Format("{0}", cardspic[5])));
                pictureBox7.Image = (Image)
                (Properties.Resources.ResourceManager.GetObject(string.Format("{0}", cardspic[6])));
                pictureBox8.Image = (Image)
                (Properties.Resources.ResourceManager.GetObject(string.Format("{0}", cardspic[7])));
                pictureBox9.Image = (Image)
                (Properties.Resources.ResourceManager.GetObject(string.Format("{0}", cardspic[8])));
                pictureBox10.Image = (Image)
                (Properties.Resources.ResourceManager.GetObject(string.Format("{0}", cardspic[9])));
                pictureBox11.Image = (Image)
                (Properties.Resources.ResourceManager.GetObject(string.Format("{0}", cardspic[10])));
                pictureBox12.Image = (Image)
                (Properties.Resources.ResourceManager.GetObject(string.Format("{0}", cardspic[11])));
            }
            
          
        }

        

        

        

        

    }
}
