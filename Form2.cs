using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formElements
{
    public partial class Form2 : Form
    {
        private bool t;
        public int v1=0;
        public int v2 = 0;
        public string name1;
        public string name2;
        PictureBox pb;
        PictureBox pb1;
        int round=1;
        Label lbl;
        Label tittle;
        int points = 0;
        int points2 = 0;
        Label author;
        Button btn;
        Button btn1;
        TreeView menu;
        ListBox num;
        ListBox listBox;
        ListBox listBox1;
        public int player = 0;
        public int playedNow=1;
        /*      
                StreamWriter file = new StreamWriter(@"..\..\score.txt", true);
                file.WriteLine("Player1: " + name1 + "Score:: " + points);
                file.Close();

                StreamWriter file = new StreamWriter(@"..\..\score.txt", true);
                file.WriteLine("Player1: " + name1 + " Score: " + points + "\nPlayer2: " + name2 + " Score: " + points2);
                file.Close();

                points = 0;
                points2 = 0;
                v1 = 0;
                v2 = 0;
                pb.Image = Image.FromFile(@"../../img/rpsIMG/choose.png");
                pb1.Image = Image.FromFile(@"../../img/rpsIMG/choose.png");
                if (MessageBox.Show("Restart-Yes, Back to menu-No", "?????", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    bcMenu();
                }
        */
        public void imgChangeWin()
        {
            imgChange1();
            imgChange2();
            pb.Visible = true;
            pb1.Visible = true;
        }
        public void bcMenu()
        {
            btn1.Visible = false;
            tittle.Visible = true;
            author.Visible = true;
            btn.Visible = true;
            num.Visible = false;
            tittle.Text = "Rock Paper Sicers game";
            listBox.Visible = false;
            if (player==2)
            {
                if (playedNow==2)
                {
                    listBox1.Visible = false;
                }
                lbl.Visible = false;
            }
            pb.Visible = false;
            pb1.Visible = false;
            

        }
        public void imgChange1()
        {
            if (v1 == 1)
            {
                pb.Image = Image.FromFile(@"../../img/rpsIMG/rock.png");
                pb.Visible = true;
            }
            else if (v1 == 2)
            {
                pb.Image = Image.FromFile(@"../../img/rpsIMG/paper.png");
                pb.Visible = true;
            }
            else if (v1 == 3)
            {
                pb.Image = Image.FromFile(@"../../img/rpsIMG/sicers.png");
                pb.Visible = true;
            }
        }
        public void imgChange2() 
        {

                if (v2 == 1)
                {
                    pb1.Image = Image.FromFile(@"../../img/rpsIMG/rock.png");
                    pb1.Visible = true;
                }
                else if (v2 == 2)
                {
                    pb1.Image = Image.FromFile(@"../../img/rpsIMG/paper.png");
                    pb1.Visible = true;
                }
                else if (v2 == 3)
                {
                    pb1.Image = Image.FromFile(@"../../img/rpsIMG/sicers.png");
                    pb1.Visible = true;
                }
        }

        public Form2()
        {
            this.Height = 700;
            this.Width = 700;
            this.Text = "Rock-Paper-Sicers";
            menu = new TreeView();
            menu.Dock = DockStyle.Bottom;
            menu.AfterSelect +=Menu_AfterSelect;
            TreeNode ex = new TreeNode("back to menu");
            TreeNode th = new TreeNode("Rock Paper Sicers - players");
            th.Nodes.Add(new TreeNode("Singale player"));
            th.Nodes.Add(new TreeNode("Two players"));
            menu.Nodes.Add(th);
            TreeNode th1 = new TreeNode("Rock Paper Sicers - about");
            menu.Nodes.Add(th1);
            TreeNode th2 = new TreeNode("Rock Paper Sicers - style");
            menu.Nodes.Add(th2);
            menu.Nodes.Add(ex);
            this.Controls.Add(menu);
            //Tittle
            tittle = new Label
            {
                Text = "Rock Paper Sicers game",
                Location = new Point(150, 120),
                Size = new Size(700, 40),
                Font = new Font("Calibri", 23, FontStyle.Bold)
            };
            this.BackColor= Color.FromArgb(120, 178, 180);
            menu.BackColor = Color.FromArgb(60, 138, 150);
            menu.ForeColor = Color.FromArgb(20, 88, 90);
            tittle.ForeColor= Color.FromArgb(70, 108, 110);
            this.Controls.Add(tittle);
            author = new Label
            {
                Text = "By Daria Evtina",
                Location = new Point(250, 170),
                Size = new Size(200, 30),
                Font = new Font("Calibri", 16, FontStyle.Regular),
                ForeColor = Color.FromArgb(70, 108, 110)
            };
            this.Controls.Add(author);
            btn = new Button
            {
                Text = "PLAY",
                ForeColor = Color.FromArgb(200, 248, 250),
                BackColor = Color.FromArgb(60, 138, 150),
                Bounds = new Rectangle(280, 200, 90, 50)
            };
            btn.Click += Btn_Click;
            this.Controls.Add(btn);

        }

        private void Btn_Click(object sender, EventArgs e)
        {

            if (player == 0)
            {
                MessageBox.Show("Please Choose the players mode", "<:O");
            }
            else if (player == 1)
            {
                var answer = MessageBox.Show("Want enter youre user name?", "?????", MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)
                {
                    name1 = Interaction.InputBox("Enter youre user name", "InputBox", "player1");
                    if (MessageBox.Show($"Your user name: {name1}?", "Text save", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        MessageBox.Show($"thanks {name1}", ":3");
                        t = true;
                    }
                    else
                    {
                        MessageBox.Show("fine", ":/");
                        t = false;
                    }
                }
                else
                {
                    MessageBox.Show("OK, bb", ":|");
                    t = false;
                }
                if (t == true)
                {
                    num = new ListBox();
                    num.Location = new Point(280, 270);
                    num.Size = new Size(50, 30);
                    num.Items.Add("1 round");
                    num.Items.Add("5 round");
                    num.Items.Add("10 round");
                    num.Items.Add("15 round");
                    num.Items.Add("50 round");
                    num.Items.Add("100 round");
                    num.Items.Add("∞ round");
                    num.SelectedIndexChanged += new EventHandler(Num_SelectedIndexChanged);
                    this.Controls.Add(num);
                    tittle.Visible = false;
                    author.Visible = false;
                    btn.Visible = false;
                    btn1 = new Button
                    {
                        Text = "round",
                        ForeColor = Color.FromArgb(200, 248, 250),
                        BackColor = Color.FromArgb(60, 138, 150),
                        Bounds = new Rectangle(280, 200, 90, 50)
                    };
                    btn1.Click += Btn1_Click;
                    pb = new PictureBox
                    {
                        Image = Image.FromFile(@"../../img/rpsIMG/choose.png"),
                        Location = new Point(380, 200),
                        Size = new Size(150, 129),
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    this.Controls.Add(pb);
                    pb1 = new PictureBox
                    {
                        Image = Image.FromFile(@"../../img/rpsIMG/choose.png"),
                        Location = new Point(120, 200),
                        Size = new Size(150, 129),
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    this.Controls.Add(pb1);
                    this.Controls.Add(btn1);
                    listBox = new ListBox();
                    listBox.Items.Add("Rock");
                    listBox.Items.Add("Paper");
                    listBox.Items.Add("Sicers");
                    listBox.Location = new Point(530, 200);
                    listBox.Size = new Size(60, 70);
                    this.Controls.Add(listBox);
                    listBox.SelectedIndexChanged += new EventHandler (ListBox_SelectedIndexChanged);
                    listBox.Visible = true;
                    pb.Visible = true;
                    pb1.Visible = true;
                    num.Visible = true;
                }
            }

            else if (player == 2)
            {
                var answer1 = MessageBox.Show("Want enter youres users names?", "?????", MessageBoxButtons.YesNo);
                if (answer1 == DialogResult.Yes)
                {
                    name1 = Interaction.InputBox("First player enter youre user name", "InputBox", "player1");
                    name2 = Interaction.InputBox("Second player enter youre user name", "InputBox", "player2");
                    if (MessageBox.Show($"First player: {name1}\n Second player: {name2}?", "Text save", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        MessageBox.Show($"thanks {name1}", ":3");
                        t = true;
                    }
                    else
                    {
                        MessageBox.Show("fine", ":/");
                        t = false;
                    }
                }
                else
                {
                    MessageBox.Show("OK, bb", ":|");
                    t = false;
                }
                if (t==true)
                {
                    num = new ListBox();
                    num.Location = new Point(280, 270);
                    num.Size = new Size(100, 50);
                    num.Items.Add("1 round");
                    num.Items.Add("5 round");
                    num.Items.Add("10 round");
                    num.Items.Add("15 round");
                    num.Items.Add("50 round");
                    num.Items.Add("100 round");
                    num.Items.Add("∞ round");
                    num.SelectedIndexChanged += new EventHandler(Num_SelectedIndexChanged);
                    this.Controls.Add(num);
                    tittle.Visible = false;
                    author.Visible = false;
                    btn.Visible = false;
                    btn1 = new Button
                    {
                        Text = "round",
                        ForeColor = Color.FromArgb(200, 248, 250),
                        BackColor = Color.FromArgb(60, 138, 150),
                        Bounds = new Rectangle(280, 200, 90, 50)
                    };
                    btn1.Click += Btn1_Click;
                    pb = new PictureBox
                    {
                        Image = Image.FromFile(@"../../img/rpsIMG/choose.png"),
                        Location = new Point(380, 200),
                        Size = new Size(150, 129),
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    this.Controls.Add(pb);
                    pb1 = new PictureBox
                    {
                        Image = Image.FromFile(@"../../img/rpsIMG/choose.png"),
                        Location = new Point(120, 200),
                        Size = new Size(150, 129),
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    this.Controls.Add(btn1);
                    listBox = new ListBox();
                    listBox.Items.Add("Rock");
                    listBox.Items.Add("Paper");
                    listBox.Items.Add("Sicers");
                    listBox.Location = new Point(530, 200);
                    listBox.Size = new Size(60, 70);
                    this.Controls.Add(listBox);
                    listBox.SelectedIndexChanged += new EventHandler(ListBox_SelectedIndexChanged);
                    listBox1 = new ListBox();
                    listBox1.Items.Add("Rock");
                    listBox1.Items.Add("Paper");
                    listBox1.Items.Add("Sicers");
                    listBox1.Location = new Point(50, 200);
                    listBox1.Size = new Size(60, 70);
                    this.Controls.Add(listBox1);
                    listBox1.Visible = false;
                    this.Controls.Add(pb1);
                    listBox1.SelectedIndexChanged += new EventHandler(ListBox_SelectedIndexChanged);
                    lbl = new Label
                    {
                        Text = "change player",
                        ForeColor = Color.FromArgb(200, 248, 250),
                        BackColor = Color.FromArgb(60, 138, 150),
                        Font = new Font("Calibri", 10, FontStyle.Bold),
                        Bounds = new Rectangle(280, 390, 90, 50)
                    };

                    lbl.Click += Lbl_Click;
                    lbl.DoubleClick += Lbl_DoubleClick;
                    this.Controls.Add(btn1);
                    this.Controls.Add(lbl);
                    listBox.Visible = true;
                    pb.Visible = true;
                    pb1.Visible = true;
                    lbl.Visible = true;
                    num.Visible = true;

                }
                
            }
        }

        private void Num_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (num.SelectedItem.ToString())
            {
                case ("1 round"):round = 1; break;
                case ("5 round"): round = 5; break;
                case ("10 round"): round = 10; break;
                case ("15 round"): round = 15; break;
                case ("50 round"): round = 50; break;
                case ("100 round"): round = 100; break;
                case ("∞ round"): round = 0; break;
            }
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (player==1)
            {
                switch (listBox.SelectedItem.ToString())
                {
                    case ("Rock"): v1 = 1; Random rnd = new Random(); v2 = rnd.Next(1, 4); break;
                    case ("Paper"): v1 = 2; Random rnd1 = new Random(); v2 = rnd1.Next(1, 4); break;
                    case ("Sicers"): v1 = 3; Random rnd2 = new Random(); v2 = rnd2.Next(1, 4); break;
                }
                imgChange1();
            }
            else if (player==2)
            {
                
                if (playedNow == 2)
                {
                    switch (listBox1.SelectedItem.ToString())
                    {
                        case ("Rock"): v2 = 1; break;
                        case ("Paper"): v2 = 2; break;
                        case ("Sicers"): v2 = 3; break;
                    }
                    imgChange2();
                }
                else if(playedNow == 1)
                {
                    switch (listBox.SelectedItem.ToString())
                    {
                        case ("Rock"): v1 = 1; break;
                        case ("Paper"): v1 = 2; break;
                        case ("Sicers"): v1 = 3; break;
                    }
                    imgChange1();
                }
                
            }
        }
        private void Lbl_DoubleClick(object sender, EventArgs e)
        {
            pb.Visible = true;
            listBox.Visible = true;
            player = 2;
            pb1.Visible = false;
            listBox1.Visible = false;
            playedNow = 1;
        }

        private void Lbl_Click(object sender, EventArgs e)
        {
            
            pb.Visible = false;
            listBox.Visible = false;
            listBox1.Visible = true;
            pb1.Visible = true;
            playedNow = 2;
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
                if (player == 1)
                {
                        if (v1 == 1 && v2 == 2 || v1 == 3 && v2 == 1 || v1 == 2 && v2 == 3)
                        {
                            tittle.Text = $"round {round} YOU LOSE";
                            tittle.Visible = true;
                            imgChangeWin();
                        }
                        else if (v1 == 2 && v2 == 1 || v1 == 1 && v2 == 3 || v1 == 3 && v2 == 2)
                        {
                            tittle.Text = $"round {round} YOU WIN";
                            tittle.Visible = true;
                            points++;
                            imgChangeWin();
                        }
                        else if (v1 == 2 && v2 == 2 || v1 == 1 && v2 == 1 || v1 == 3 && v2 == 3)
                        {
                            tittle.Text = $"round {round} DRAW";
                            tittle.Visible = true;
                            points++;
                            imgChangeWin();
                        }

                }
                else if (player == 2)
                {
                    for (int i = 0; i < round + 1; i++)
                    {
                        if (playedNow == 1)
                        {
                            if (v1 == 1 && v2 == 2 || v1 == 3 && v2 == 1 || v1 == 2 && v2 == 3)
                            {
                                tittle.Text = $"round {round} YOU LOSE {name1}";
                                tittle.Visible = true;
                                imgChangeWin();
                            }
                            else if (v1 == 2 && v2 == 1 || v1 == 1 && v2 == 3 || v1 == 3 && v2 == 2)
                            {
                                tittle.Text = $"round {round} YOU WIN {name1}";
                                tittle.Visible = true;
                                points++;
                                imgChangeWin();
                            }
                            else if (v1 == 2 && v2 == 2 || v1 == 1 && v2 == 1 || v1 == 3 && v2 == 3)
                            {
                                tittle.Text = $"round {round} DRAW ";
                                tittle.Visible = true;
                                points++;
                                imgChangeWin();
                            }
                        }
                    
                        if (playedNow==2)
                        {
                            if (v2 == 1 && v1 == 2 || v2 == 3 && v1 == 1 || v2 == 2 && v1 == 3)
                            {
                                tittle.Text = $"round {round} YOU LOSE {name2}";
                                tittle.Visible = true;
                                imgChangeWin();
                            }
                            else if (v2 == 2 && v1 == 1 || v2 == 1 && v1 == 3 || v2 == 3 && v1 == 2)
                            {
                                tittle.Text = $"round {round} YOU WIN {name2}";
                                tittle.Visible = true;
                                points2++;
                                imgChangeWin();

                            }
                            else if (v2 == 2 && v1 == 2 || v2 == 1 && v1 == 1 || v2 == 3 && v1 == 3)
                            {
                                tittle.Text = $"round {round} DRAW";
                                tittle.Visible = true;
                                points2++;
                                imgChangeWin();


                            }
                        }
                    }
                }
                 

        }


        private void Menu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "Singale player")
            {
                player = 1;
            }
            else if (e.Node.Text == "Two players")
            {

                player = 2;
            }
            else if (e.Node.Text == "back to menu")
            { bcMenu(); }
            else if (e.Node.Text == "Rock Paper Sicers - about")
            {
                about abt = new about();
                abt.Show();
            }
            else
            {
                player = 0;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
