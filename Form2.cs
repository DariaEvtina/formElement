﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formElements
{
    public partial class Form2 : Form
    {
        private bool t;
        string[] RPS = { "rock","papper","sicers" };
        public string text;
        PictureBox pb;
        PictureBox pb1;
        Label lbl;
        Label tittle;
        Label author;
        Button btn;
        Button btn1;
        TreeView menu;
        ListBox listBox;
        public int player = 0;


        public Form2()
        {
            this.Height = 700;
            this.Width = 700;
            this.Text = "RockPaperSicers";
            menu = new TreeView();
            menu.Dock = DockStyle.Bottom;
            menu.AfterSelect += Menu_AfterSelect;
            TreeNode th = new TreeNode("Rock Paper Sicers - players");
            th.Nodes.Add(new TreeNode("Singale player"));
            th.Nodes.Add(new TreeNode("Two players"));
            menu.Nodes.Add(th);
            TreeNode th1 = new TreeNode("Rock Paper Sicers - about");
            menu.Nodes.Add(th1);
            TreeNode th2 = new TreeNode("Rock Paper Sicers - style");
            menu.Nodes.Add(th2);
            this.Controls.Add(menu);
            //Tittle
            tittle = new Label
            {
                Text = "Rock Paper Sicers game",
                Location = new Point(150, 120),
                Size = new Size(600, 40),
                Font = new Font("Calibri", 26, FontStyle.Bold)
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
                    text = Interaction.InputBox("Enter youre user nmae", "InputBox", "text");
                    if (MessageBox.Show("Do you want to save your user name?", "Text save", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        MessageBox.Show($"thanks {text}", ":3");
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
                    /*rbt1 = new RadioButton
                    {
                        Text = "Rock",
                        ForeColor = Color.FromArgb(70, 108, 110),
                        Location = new Point(530, 200),
                        Size = new Size(60, 30)
                    };
                    rbt1.CheckedChanged += new EventHandler(Rb1_CheckedChanged);
                    rbt2 = new RadioButton
                    {
                        Text = "Sicers",
                        ForeColor = Color.FromArgb(70, 108, 110),
                        Location = new Point(530, 240),
                        Size = new Size(60, 30)
                    };
                    rbt2.CheckedChanged += new EventHandler(Rb1_CheckedChanged);
                    rbt3 = new RadioButton
                    {
                        Text = "Paper",
                        ForeColor = Color.FromArgb(70, 108, 110),
                        Location = new Point(530, 270),
                        Size = new Size(60, 30)
                    };
                    rbt3.CheckedChanged += new EventHandler(Rb1_CheckedChanged);
                    this.Controls.Add(rbt1);
                    this.Controls.Add(rbt2);
                    this.Controls.Add(rbt3);*/
                    this.Controls.Add(btn1);
                }
            }

            else if (player == 2)
            {
                var answer1 = MessageBox.Show("Want enter youre user name?", "?????", MessageBoxButtons.YesNo);
                if (answer1 == DialogResult.Yes)
                {
                    text = Interaction.InputBox("Enter youre user nmae", "InputBox", "text");
                    if (MessageBox.Show("Do you want to save your user name?", "Text save", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        MessageBox.Show($"thanks {text}", ":3");
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
                    listBox = new ListBox();
                    listBox.Items.Add("green");
                    listBox.Items.Add("yellow");
                    listBox.Items.Add("blue");
                    this.Controls.Add(pb1);
                }
                
                /*rbt1 = new RadioButton
                {
                    Text = "Rock",
                    ForeColor = Color.FromArgb(70, 108, 110),
                    Location = new Point(530, 200),
                    Size = new Size(60, 30)
                };
                rbt1.CheckedChanged += new EventHandler(Rb1_CheckedChanged);
                rbt2 = new RadioButton
                {
                    Text = "Sicers",
                    ForeColor = Color.FromArgb(70, 108, 110),
                    Location = new Point(530, 240),
                    Size = new Size(60, 30)
                };
                rbt2.CheckedChanged += new EventHandler(Rb1_CheckedChanged);
                rbt3 = new RadioButton
                {
                    Text = "Paper",
                    ForeColor = Color.FromArgb(70, 108, 110),
                    Location = new Point(530, 270),
                    Size = new Size(60, 30)
                };
                rbt3.CheckedChanged += new EventHandler(Rb1_CheckedChanged);
                rbt4 = new RadioButton
                {
                    Text = "Rock",
                    ForeColor = Color.FromArgb(70, 108, 110),
                    Location = new Point(70, 200),
                    Size = new Size(60, 30)
                };
                rbt4.CheckedChanged += new EventHandler(Rb1_CheckedChanged);
                rbt5 = new RadioButton
                {
                    Text = "Sicers",
                    ForeColor = Color.FromArgb(70, 108, 110),
                    Location = new Point(70, 240),
                    Size = new Size(60, 30)
                };
                rbt5.CheckedChanged += new EventHandler(Rb1_CheckedChanged);
                rbt6 = new RadioButton
                {
                    Text = "Paper",
                    ForeColor = Color.FromArgb(70, 108, 110),
                    Location = new Point(70, 270),
                    Size = new Size(60, 30)
                };
                rbt6.CheckedChanged += new EventHandler(Rb1_CheckedChanged);*/
                lbl = new Label
                {
                    Text = "change player",
                    ForeColor = Color.FromArgb(200, 248, 250),
                    BackColor = Color.FromArgb(60, 138, 150),
                    Font = new Font("Calibri", 10, FontStyle.Bold),
                    Bounds = new Rectangle(280, 290, 90, 50)
                };
                
                lbl.Click += Lbl_Click;
                lbl.DoubleClick += Lbl_DoubleClick;
                this.Controls.Add(btn1);
                this.Controls.Add(lbl);

            

            }
        }
                

        private void Lbl_DoubleClick(object sender, EventArgs e)
        {
            pb.Visible = true;
           
            player = 2;
        }

        private void Lbl_Click(object sender, EventArgs e)
        {
            
            pb.Visible = false;
            pb1.Visible = true;
            player = 3;
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            
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
