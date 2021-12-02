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
        PictureBox pb;
        PictureBox pb1;
        Label lbl;
        Label tittle;
        Label author;
        Button btn;
        Button btn1;
        RadioButton rbt1;
        RadioButton rbt2;
        RadioButton rbt3;
        RadioButton rbt4;
        RadioButton rbt5;
        RadioButton rbt6;
        TreeView menu;
        public int player = 0;

        public Form2()
        {
            this.Height = 700;
            this.Width = 700;
            this.Text = "RockPaperSicers";
            menu = new TreeView();
            menu.Dock = DockStyle.Top;
            menu.AfterSelect += Menu_AfterSelect;
            TreeNode th = new TreeNode("Rock Paper Sicers - players");
            th.Nodes.Add(new TreeNode("Singale player"));
            th.Nodes.Add(new TreeNode("Two players"));
            menu.Nodes.Add(th);
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
            if (player==0)
            {
                MessageBox.Show("Please Choose the players mode", "<:O");
            }
            else if (player==1)
            {
                tittle.Visible = false;
                author.Visible = false;
                btn.Visible = false;
            }
            else if (player == 2)
            {
                tittle.Visible = false;
                author.Visible = false;
                btn.Visible = false;
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
