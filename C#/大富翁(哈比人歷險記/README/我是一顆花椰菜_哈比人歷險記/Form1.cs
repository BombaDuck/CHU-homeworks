using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 我是一顆花椰菜_哈比人歷險記
{
    public partial class Form1 : Form
    {
        Label[] Label_Player_HPBar;
        Label[] Label_Player_HPText;
        Label[] Label_Player_APBar;
        Label[] Label_Player_APText;
        GroupBox[] GroupBox_Player_Area;
        Player[] players;
        Random random;
        int now_player;
        int step;
        int[] chars = new int[4];
        Block[] blocks;
        GameState now_state;
        Bitmap map;
        int playercount = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button_Test.Enabled = false;

            Start_button.Hide();

            map = new Bitmap("map.png");
            PictureBox_MiniMap.Load("map.png");
            PictureBox_MiniMap.SizeMode = PictureBoxSizeMode.StretchImage;
            Start_button.Enabled = false;

            Label_Player_HPBar = new Label[Constants.PLAYER_NUMBER];
            Label_Player_APBar = new Label[Constants.PLAYER_NUMBER];
            Label_Player_HPText = new Label[Constants.PLAYER_NUMBER];
            Label_Player_APText = new Label[Constants.PLAYER_NUMBER];
            GroupBox_Player_Area = new GroupBox[Constants.PLAYER_NUMBER];
            players = new Player[Constants.PLAYER_NUMBER];
            
            random = new Random();

            now_player = 0;
            step = 0;

            blocks = new Block[Constants.BLOCK_NUMBER];
            blocks[0] = new StartBlock(new Point(0, 0));
            blocks[1] = new RestBlock(new Point(100, 0));
            blocks[2] = new ArmorBlock(new Point(200, 0));
            blocks[3] = new ArmorBlock(new Point(300, 0));
            blocks[4] = new ArmorBlock(new Point(400, 0));
            blocks[5] = new EquipsBlock(new Point(500, 0));
            blocks[6] = new ArmorBlock(new Point(600, 0));
            blocks[7] = new RestBlock(new Point(700, 0));
            blocks[8] = new ArmorBlock(new Point(800, 0));
            blocks[9] = new ArmorBlock(new Point(900, 0));
            blocks[10] = new MagicSpellBlock(new Point(900, 100));
            blocks[11] = new EquipsBlock(new Point(900, 200));
            blocks[12] = new TrapBlock(new Point(900, 300));
            blocks[13] = new ArmorBlock(new Point(900, 400));
            blocks[14] = new MagicSpellBlock(new Point(900, 500));
            blocks[15] = new ArmorBlock(new Point(1000, 500));
            blocks[16] = new ArmorBlock(new Point(1100, 500));
            blocks[17] = new ArmorBlock(new Point(1200, 500));
            blocks[18] = new ArmorBlock(new Point(1300, 500));
            blocks[19] = new DeadLandsBlock(new Point(1300, 600));
            blocks[20] = new DragonBlock(new Point(1300, 700));
            blocks[21] = new LonelyMountainBlock(new Point(1300, 800));
            blocks[22] = new RestBlock(new Point(1200, 800));
            blocks[23] = new ArmorBlock(new Point(1100, 800));
            blocks[24] = new ArmorBlock(new Point(1000, 800));
            blocks[25] = new ArmorBlock(new Point(900, 800));
            blocks[26] = new TrapBlock(new Point(900, 700));
            blocks[27] = new DeadLandsBlock(new Point(800, 700));
            blocks[28] = new EquipsBlock(new Point(700, 700));
            blocks[29] = new ArmorBlock(new Point(600, 700));
            blocks[30] = new MagicSpellBlock(new Point(500, 700));
            blocks[31] = new ArmorBlock(new Point(400, 700));
            blocks[32] = new ArmorBlock(new Point(300, 700));
            blocks[33] = new RestBlock(new Point(200, 700));
            blocks[34] = new ArmorBlock(new Point(100, 700));
            blocks[35] = new ArmorBlock(new Point(0, 700));
            blocks[36] = new TrapBlock(new Point(0, 600));
            blocks[37] = new ArmorBlock(new Point(0, 500));
            blocks[38] = new ArmorBlock(new Point(0, 400));
            blocks[39] = new EquipsBlock(new Point(0, 300));
            blocks[40] = new ArmorBlock(new Point(0, 200));
            blocks[41] = new ArmorBlock(new Point(0, 100));

            now_state = GameState.Initial;
            UpdateUI();
        }

        private void Button_Dice_Click(object sender, EventArgs e)
        {
            Label_DiceNumber.ForeColor = Color.Black;
            Label_DiceNumber.BackColor = Color.White;
            Label_DiceNumber.Font = new Font("新細明體", 24, FontStyle.Regular);

            

            if (chars[now_player] == 3)
                step = random.Next(Constants.DICE_NUMBER + 2) + 1;
            else
                step = random.Next(Constants.DICE_NUMBER) + 1;
            //        step = 38;
            Label_DiceNumber.Text = step.ToString();
            now_state = GameState.Walking;
            UpdateUI();
        }

        private void Button_Attack_Click(object sender, EventArgs e)
        {
            int now_index = (players[now_player].BlockIndex + 1) % Constants.BLOCK_NUMBER;
            bool attacked = false;
            int power = 4;

            if (chars[now_player] == 2 || chars[now_player] == 3)
                power = 3;
            players[now_player].Power = power;

            while (!attacked)
            {
                for (int i = 0; i < Constants.PLAYER_NUMBER; ++i)
                    if (i != players[now_player].PlayerIndex && players[i].State != PlayerState.Dead && players[i].BlockIndex == now_index)
                    {
                        players[now_player].Attack(players[i]);
                        UpdateHP();
                        attacked = true;
                        break;
                    }

                Label_DiceNumber.ForeColor = Color.Red;
                Label_DiceNumber.Text = players[now_player].Power.ToString();

                now_index = (now_index + 1) % Constants.BLOCK_NUMBER;

            }

            Button_Attack.Enabled = false;
        }

        private bool IsAttackable()
        {
            int now_index = (players[now_player].BlockIndex + 1) % Constants.BLOCK_NUMBER, count = 0;
            bool attackable = false;
            
            if(chars[now_player]==2)
               while (!attackable && count < Constants.ATTACK_RANGE+2)
               {
                   for (int i = 0; i < Constants.PLAYER_NUMBER; ++i)
                       if (i != players[now_player].PlayerIndex && players[i].State != PlayerState.Dead && players[i].BlockIndex == now_index)
                       {
                          attackable = true;
                          break;
                       }

                   ++count;
                   now_index = (now_index + 1) % Constants.BLOCK_NUMBER;
             }
            else 
                while (!attackable && count < Constants.ATTACK_RANGE)
                {
                    for (int i = 0; i < Constants.PLAYER_NUMBER; ++i)
                        if (i != players[now_player].PlayerIndex && players[i].State != PlayerState.Dead && players[i].BlockIndex == now_index)
                        {
                            attackable = true;
                            break;
                        }

                    ++count;
                    now_index = (now_index + 1) % Constants.BLOCK_NUMBER;
                }

            return attackable;
        }

        private void Button_End_Click(object sender, EventArgs e)
        {
            Label_DiceNumber.ForeColor = Color.Black;
            Label_DiceNumber.BackColor = Color.White;
            Label_DiceNumber.Font = new Font("新細明體", 24, FontStyle.Regular);

            now_player = (now_player + 1) % Constants.PLAYER_NUMBER;
            while (players[now_player].State == PlayerState.Dead)
                now_player = (now_player + 1) % Constants.PLAYER_NUMBER;
            Label_DiceNumber.ForeColor = Color.Black;
            now_state = GameState.Initial;
            UpdateUI();

            PictureBox_Map.Refresh();
            PictureBox_MiniMap.Refresh();
        }

        private void Button_Test_Click(object sender, EventArgs e)
        {
            Label_DiceNumber.ForeColor = Color.Black;
            Label_DiceNumber.BackColor = Color.White;
            Label_DiceNumber.Font = new Font("新細明體", 24, FontStyle.Regular);

            step = 38;
            Label_DiceNumber.Text = step.ToString();
            now_state = GameState.Walking;
            UpdateUI();
        }

        private void Timer_Process_Tick(object sender, EventArgs e)
        {
            int counter = 0;
                

            if (step != 0)
            {
                if (PlayerMove())
                {
                    players[now_player].BlockIndex = (players[now_player].BlockIndex + 1) % Constants.BLOCK_NUMBER;
                    --step;

                    if (blocks[players[now_player].BlockIndex] is StartBlock)
                    {
                        blocks[players[now_player].BlockIndex].ExcecuteAction(players[now_player]);
                        UpdateHP();
                    }

                    if (step == 0)
                    {
                        if (blocks[players[now_player].BlockIndex] is ArmorBlock)
                        {
                            blocks[players[now_player].BlockIndex].ExcecuteAction(players[now_player]);
                            UpdateHP();
                        }
                        else if (blocks[players[now_player].BlockIndex] is TrapBlock)
                        {
                            blocks[players[now_player].BlockIndex].ExcecuteAction(players[now_player]);
                            UpdateHP();
                        }
                        else if (blocks[players[now_player].BlockIndex] is RestBlock)
                        {
                            blocks[players[now_player].BlockIndex].ExcecuteAction(players[now_player]);
                            UpdateHP();
                        }
                        else if (blocks[players[now_player].BlockIndex] is EquipsBlock)
                        {
                            blocks[players[now_player].BlockIndex].ExcecuteAction(players[now_player]);
                            UpdateHP();
                        }
                        else if (blocks[players[now_player].BlockIndex] is LonelyMountainBlock)
                        {
                            blocks[players[now_player].BlockIndex].ExcecuteAction(players[now_player]);
                            UpdateHP();
                        }
                        else if (blocks[players[now_player].BlockIndex] is DeadLandsBlock)
                        {
                            blocks[players[now_player].BlockIndex].ExcecuteAction(players[now_player]);
                            UpdateHP();
                        }
                        else if (blocks[players[now_player].BlockIndex] is DragonBlock)
                        {
                            blocks[players[now_player].BlockIndex].ExcecuteAction(players[now_player]);
                            UpdateHP();
                        }
                        else if (blocks[players[now_player].BlockIndex] is MagicSpellBlock)
                        {
                            for (counter = 0; counter < 4;counter++ )
                                players[counter].HP -= 4;
                            players[now_player].HP += 4;
                            UpdateHP();
                        }


                        

                        now_state = GameState.Stopped;
                        UpdateUI();
                    }
                }
                
                PictureBox_Map.Refresh();
                PictureBox_MiniMap.Refresh();

            }
        }

        private void PictureBox_Map_Paint(object sender, PaintEventArgs e)
        {
            Point now_loc = players[now_player].Location;
            int left = Math.Max(0, Math.Min(1400, now_loc.X - 0));
            int top = Math.Max(0, Math.Min(900, now_loc.Y - 0));
            if (left + 700 > 1400)
                left = 700;
            if (top + 450 > 900)
                top = 450;
            Rectangle map_region = new Rectangle(left, top, 700, 490);

            Graphics g = e.Graphics;

            // Draw background map
            g.DrawImage(map, new Rectangle(0, 0, PictureBox_Map.Width, PictureBox_Map.Height), map_region, GraphicsUnit.Pixel);

            // Draw player
            Rectangle player_region;
            for (int i = 0; i < Constants.PLAYER_NUMBER; ++i)
            {
                player_region = new Rectangle(players[i].Location.X + 10, players[i].Location.Y + 10, 160, 160);
                if (i != now_player && map_region.IntersectsWith(player_region))
                    g.DrawImage(players[i].Image, new Rectangle((players[i].Location.X + 10 - left) * (PictureBox_Map.Width / 700), (players[i].Location.Y + 10 - top) * 2, 160, 160), new Rectangle(0, 0, players[i].Image.Width, players[i].Image.Height), GraphicsUnit.Pixel);
            }

            player_region = new Rectangle(players[now_player].Location.X + 10, players[now_player].Location.Y + 10, 160, 160);
            g.DrawImage(players[now_player].Image, new Rectangle((players[now_player].Location.X + 10 - left) * 2, (players[now_player].Location.Y + 10 - top) * 2, 160, 160), new Rectangle(0, 0, players[now_player].Image.Width, players[now_player].Image.Height), GraphicsUnit.Pixel);
      
        }

        private void PictureBox_MiniMap_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Rectangle player_region;
            for (int i = 0; i < Constants.PLAYER_NUMBER; ++i)
            {
                player_region = new Rectangle(players[i].Location.X + 10, players[i].Location.Y + 10, 160, 160);
                g.DrawImage(players[i].Image, new Rectangle((int)((players[i].Location.X + 10) * 0.25), (int)((players[i].Location.Y + 10) * 0.275), 20, 20), new Rectangle(0, 0, players[i].Image.Width, players[i].Image.Height), GraphicsUnit.Pixel);
            }

            player_region = new Rectangle(players[now_player].Location.X + 10, players[now_player].Location.Y + 10, 160, 160);
            g.DrawImage(players[now_player].Image, new Rectangle((int)((players[now_player].Location.X + 10) * 0.25), (int)((players[now_player].Location.Y + 10) * 0.275), 20, 20), new Rectangle(0, 0, players[now_player].Image.Width, players[now_player].Image.Height), GraphicsUnit.Pixel);
    
        }

        private bool PlayerMove()
        {
            int now_index = players[now_player].BlockIndex;
            int next_index = (now_index + 1) % Constants.BLOCK_NUMBER;
            int dx = (blocks[next_index].Location.X - blocks[now_index].Location.X) / Constants.STEPS_PER_BLOCK;
            int dy = (blocks[next_index].Location.Y - blocks[now_index].Location.Y) / Constants.STEPS_PER_BLOCK;

            players[now_player].Location = new Point(players[now_player].Location.X + dx, players[now_player].Location.Y + dy);

            if (players[now_player].Location.X == blocks[next_index].Location.X &&
                 players[now_player].Location.Y == blocks[next_index].Location.Y)
                return true;
            return false;
        }

        private void UpdateUI()
        {
            switch (now_state)
            {
                case GameState.Initial:
                    for (int i = 0; i < Constants.PLAYER_NUMBER; ++i)
                    {
                        if (players[i].State == PlayerState.Normal)
                        {
                            if (i != now_player)
                                GroupBox_Player_Area[i].Enabled = false;
                            else
                            {
                                GroupBox_Player_Area[i].Enabled = true;
                                players[i].IsAttacked = false;
                            }
                        }
                    }

                    Label_DiceNumber.Text = "";
                    Button_End.Enabled = false;
                    Button_Dice.Enabled = true;
                    Button_Attack.Enabled = IsAttackable();
                  break;

                case GameState.Walking:
                    Button_Dice.Enabled = false;
                    Button_Attack.Enabled = false;
                    Button_Test.Enabled = false;
                    Button_End.Enabled = false;
                    break;

                case GameState.Stopped:
                    Button_Dice.Enabled = false;
                    Button_Attack.Enabled = (players[now_player].IsAttacked == false ? IsAttackable() : false);
                    Button_Test.Enabled = false;
                    Button_End.Enabled = true;
                    break;
            }
        }

        private void UpdateHP()
        {
            int count = 0, survive = 0;
            for (int i = 0; i < Constants.PLAYER_NUMBER; ++i)
            {
                Label_Player_APBar[i].Size = new Size(players[i].AP * 25, 25);
                Label_Player_APText[i].Text = players[i].AP.ToString() + "/" + Constants.MAX_AP;
                Label_Player_HPBar[i].Size = new Size(players[i].HP * 6, 25);
                Label_Player_HPText[i].Text = players[i].HP.ToString() + "/" + Constants.MAX_HP;

                if (players[i].HP == 0)
                {
                    players[i] = new Player("RIP.jpg", 0);
                    players[i].HP = 0;
                    players[i].State = PlayerState.Dead;
                    GroupBox_Player_Area[i].Visible = false;
                    
                    ++count;
                }
                else
                    survive = i;
            }

            if (count == Constants.PLAYER_NUMBER - 1)
            {
                MessageBox.Show("Player " + (survive + 1).ToString() + " win!");
                Close();
            }
        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            UpdateUI();
            panel1.Hide();
            GroupBox_Player_Area[1].Enabled = false;
            GroupBox_Player_Area[2].Enabled = false;
            GroupBox_Player_Area[3].Enabled = false;
        }

        private void Char1_Click(object sender, EventArgs e)
        {
            if(playercount == 1)
            {
                players[0] = new Player("player1.jpg", 0);
                players[0].Location = new Point(0, 0);
                Label_Player_HPBar[0] = Label_HPBar1;
                Label_Player_APBar[0] = Label_APBar1;
                Label_Player_HPText[0] = Label_HPText1;
                Label_Player_APText[0] = Label_APText1;
                GroupBox_Player_Area[0] = GroupBox_Player1;
                GroupBox_Player1.Text = "索林‧橡木盾";
                chars[0] = 1;
            }
            else if (playercount == 2)
            {
                players[1] = new Player("player1.jpg", 1);
                players[1].Location = new Point(0, 0);
                Label_Player_HPBar[1] = Label_HPBar2;
                Label_Player_APBar[1] = Label_APBar2;
                Label_Player_HPText[1] = Label_HPText2;
                Label_Player_APText[1] = Label_APText2;
                GroupBox_Player_Area[1] = GroupBox_Player2;
                GroupBox_Player2.Text = "索林‧橡木盾";
                chars[1] = 1;
            }
            else if (playercount == 3)
            {
                players[2] = new Player("player1.jpg", 2);
                players[2].Location = new Point(0, 0);
                Label_Player_HPBar[2] = Label_HPBar3;
                Label_Player_APBar[2] = Label_APBar3;
                Label_Player_HPText[2] = Label_HPText3;
                Label_Player_APText[2] = Label_APText3;
                GroupBox_Player_Area[2] = GroupBox_Player3;
                GroupBox_Player3.Text = "索林‧橡木盾";
                chars[2] = 1;
            }
            else if (playercount == 4)
            {
                players[3] = new Player("player1.jpg", 3);
                players[3].Location = new Point(0, 0);
                Label_Player_HPBar[3] = Label_HPBar4;
                Label_Player_APBar[3] = Label_APBar4;
                Label_Player_HPText[3] = Label_HPText4;
                Label_Player_APText[2] = Label_APText3;
                Label_Player_APText[3] = Label_APText4;
                GroupBox_Player_Area[3] = GroupBox_Player4;
                GroupBox_Player4.Text = "索林‧橡木盾";
                Start_button.Enabled = true;
                Start_button.Show();
                chars[3] = 1;
            }
            playercount++;
            Char1.Enabled = false;
            if (playercount <= 4)
                playercount_label.Text = "玩家" + playercount + "選擇腳色";

            
        }

        private void Char2_Click(object sender, EventArgs e)
        {
            if (playercount == 1)
            {
                players[0] = new Player("player2.jpg", 0);
                players[0].Location = new Point(0, 0);
                Label_Player_HPBar[0] = Label_HPBar1;
                Label_Player_APBar[0] = Label_APBar1;
                Label_Player_HPText[0] = Label_HPText1;
                Label_Player_APText[0] = Label_APText1;
                GroupBox_Player_Area[0] = GroupBox_Player1;
                GroupBox_Player1.Text = "泰瑞爾";
                chars[0] = 2;
            }
            else if (playercount == 2)
            {
                players[1] = new Player("player2.jpg", 1);
                players[1].Location = new Point(0, 0);
                Label_Player_HPBar[1] = Label_HPBar2;
                Label_Player_APBar[1] = Label_APBar2;
                Label_Player_HPText[1] = Label_HPText2;
                Label_Player_APText[1] = Label_APText2;
                GroupBox_Player_Area[1] = GroupBox_Player2;
                GroupBox_Player2.Text = "泰瑞爾";
                chars[1] = 2;
            }
            else if (playercount == 3)
            {
                players[2] = new Player("player2.jpg", 2);
                players[2].Location = new Point(0, 0);
                Label_Player_HPBar[2] = Label_HPBar3;
                Label_Player_APBar[2] = Label_APBar3;
                Label_Player_HPText[2] = Label_HPText3;
                Label_Player_APText[2] = Label_APText3;
                GroupBox_Player_Area[2] = GroupBox_Player3;
                GroupBox_Player3.Text = "泰瑞爾";
                chars[2] = 2;
            }
            else if (playercount == 4)
            {
                players[3] = new Player("player2.jpg", 3);
                players[3].Location = new Point(0, 0);
                Label_Player_HPBar[3] = Label_HPBar4;
                Label_Player_APBar[3] = Label_APBar4;
                Label_Player_HPText[3] = Label_HPText4;
                Label_Player_APText[2] = Label_APText3;
                Label_Player_APText[3] = Label_APText4;
                GroupBox_Player_Area[3] = GroupBox_Player4;
                GroupBox_Player4.Text = "泰瑞爾";
                Start_button.Enabled = true;
                Start_button.Show();
                chars[3] = 2;
            }
            playercount++;
            Char2.Enabled = false;
            if (playercount <= 4)
                playercount_label.Text = "玩家" + playercount + "選擇腳色";
        }

        private void Char3_Click(object sender, EventArgs e)
        {
            if (playercount == 1)
            {
                players[0] = new Player("player3.jpg", 0);
                players[0].Location = new Point(0, 0);
                Label_Player_HPBar[0] = Label_HPBar1;
                Label_Player_APBar[0] = Label_APBar1;
                Label_Player_HPText[0] = Label_HPText1;
                Label_Player_APText[0] = Label_APText1;
                GroupBox_Player_Area[0] = GroupBox_Player1;
                GroupBox_Player1.Text = "巴德";
                chars[0] = 1;
            }
            else if (playercount == 2)
            {
                players[1] = new Player("player3.jpg", 1);
                players[1].Location = new Point(0, 0);
                Label_Player_HPBar[1] = Label_HPBar2;
                Label_Player_APBar[1] = Label_APBar2;
                Label_Player_HPText[1] = Label_HPText2;
                Label_Player_APText[1] = Label_APText2;
                GroupBox_Player_Area[1] = GroupBox_Player2;
                GroupBox_Player2.Text = "巴德";
                chars[1] = 1;
            }
            else if (playercount == 3)
            {
                players[2] = new Player("player3.jpg", 2);
                players[2].Location = new Point(0, 0);
                Label_Player_HPBar[2] = Label_HPBar3;
                Label_Player_APBar[2] = Label_APBar3;
                Label_Player_HPText[2] = Label_HPText3;
                Label_Player_APText[2] = Label_APText3;
                GroupBox_Player_Area[2] = GroupBox_Player3;
                GroupBox_Player3.Text = "巴德";
                chars[2] = 1;
            }
            else if (playercount == 4)
            {
                players[3] = new Player("player3.jpg", 3);
                players[3].Location = new Point(0, 0);
                Label_Player_HPBar[3] = Label_HPBar4;
                Label_Player_APBar[3] = Label_APBar4;
                Label_Player_HPText[3] = Label_HPText4;
                Label_Player_APText[2] = Label_APText3;
                Label_Player_APText[3] = Label_APText4;
                GroupBox_Player_Area[3] = GroupBox_Player4;
                GroupBox_Player4.Text = "巴德";
                Start_button.Enabled = true;
                Start_button.Show();
                chars[3] = 1;
            }
            playercount++;
            Char3.Enabled = false;
            if (playercount <= 4)
                playercount_label.Text = "玩家" + playercount + "選擇腳色";
        }

        private void Char4_Click(object sender, EventArgs e)
        {
            if (playercount == 1)
            {
                players[0] = new Player("player4.jpg", 0);
                players[0].Location = new Point(0, 0);
                Label_Player_HPBar[0] = Label_HPBar1;
                Label_Player_APBar[0] = Label_APBar1;
                Label_Player_HPText[0] = Label_HPText1;
                Label_Player_APText[0] = Label_APText1;
                GroupBox_Player_Area[0] = GroupBox_Player1;
                GroupBox_Player1.Text = "比爾博‧巴金斯";
                chars[0] = 3;
            }
            else if (playercount == 2)
            {
                players[1] = new Player("player4.jpg", 1);
                players[1].Location = new Point(0, 0);
                Label_Player_HPBar[1] = Label_HPBar2;
                Label_Player_APBar[1] = Label_APBar2;
                Label_Player_HPText[1] = Label_HPText2;
                Label_Player_APText[1] = Label_APText2;
                GroupBox_Player_Area[1] = GroupBox_Player2;
                GroupBox_Player2.Text = "比爾博‧巴金斯";
                chars[1] = 3;
            }
            else if (playercount == 3)
            {
                players[2] = new Player("player4.jpg", 2);
                players[2].Location = new Point(0, 0);
                Label_Player_HPBar[2] = Label_HPBar3;
                Label_Player_APBar[2] = Label_APBar3;
                Label_Player_HPText[2] = Label_HPText3;
                Label_Player_APText[2] = Label_APText3;
                GroupBox_Player_Area[2] = GroupBox_Player3;
                GroupBox_Player3.Text = "比爾博‧巴金斯";
                chars[2] = 3;
            }
            else if (playercount == 4)
            {
                players[3] = new Player("player4.jpg", 3);
                players[3].Location = new Point(0, 0);
                Label_Player_HPBar[3] = Label_HPBar4;
                Label_Player_APBar[3] = Label_APBar4;
                Label_Player_HPText[3] = Label_HPText4;
                Label_Player_APText[2] = Label_APText3;
                Label_Player_APText[3] = Label_APText4;
                GroupBox_Player_Area[3] = GroupBox_Player4;
                GroupBox_Player4.Text = "比爾博‧巴金斯";
                Start_button.Enabled = true;
                Start_button.Show();
                chars[3] = 3;
            }
            playercount++;
            Char4.Enabled = false;
            if (playercount <= 4)
                playercount_label.Text = "玩家" + playercount + "選擇腳色";
        }
        
    }
}
