using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace formElements
{
    public partial class Form1 : Form
    {
        TreeView tree;
        Button btn;
        Button b1;
        Label lbl;
        Label l1;
        PictureBox pbox;
        CheckBox ckbox;
        CheckBox ckbox1;
        CheckBox ckbox2;
        CheckBox ckbox3;
        RadioButton rb;
        RadioButton rb1;
        RadioButton rb2;
        TextBox txt;
        TabControl tabC;



        public Form1()
        {
            this.Height = 600;
            this.Width = 800;
            this.Text = "Vorm Elemetidega";
            tree = new TreeView();
            tree.Dock = DockStyle.Left;
            tree.AfterSelect += Tree_AfterSelect;
            TreeNode th = new TreeNode("Elemendit");
            th.Nodes.Add(new TreeNode("button"));
            th.Nodes.Add(new TreeNode("label"));
            th.Nodes.Add(new TreeNode("picturebox"));
            th.Nodes.Add(new TreeNode("checkbox"));
            th.Nodes.Add(new TreeNode("radiobutton"));
            th.Nodes.Add(new TreeNode("textbox"));
            th.Nodes.Add(new TreeNode("tabcontrol"));
            th.Nodes.Add(new TreeNode("messagebox"));
            //button
            btn = new Button();
            btn.Text = "Click";
            btn.Location = new Point(150, 20);
            btn.Height = 30;
            btn.Width = 120;
            btn.Click += Btn_Click;
            btn.Leave += Btn_Leave;
            //label
            lbl = new Label();
            lbl.Text = "Elementide loomine c# abil";
            lbl.Size = new Size((lbl.Text.Length*8),15);
            lbl.Location = new Point(150, 5);
            lbl.MouseHover += Lbl_MouseHover;
            lbl.MouseLeave += Lbl_MouseLeave;
            tree.Nodes.Add(th);
            this.Controls.Add(tree);
            //picturebox
            pbox = new PictureBox();
            pbox.Image =Image.FromFile(@"../../img/cat.png");
            pbox.Location = new Point(150, 90);
            pbox.Size = new Size(150,129);
            pbox.SizeMode = PictureBoxSizeMode.StretchImage;
            pbox.MouseDoubleClick += Pbox_MouseDoubleClick;
            pbox.MouseLeave += Pbox_MouseLeave;
            pbox.BorderStyle = BorderStyle.FixedSingle;
            ///checkbox
            ckbox = new CheckBox();
            ckbox.Size = new Size(90, 30);
            ckbox.Text = "Background";
            ckbox.Location = new Point(320, 19);
            ckbox.CheckedChanged += Ckbox_CheckedChanged;
            ///
            ckbox1 = new CheckBox();
            ckbox1.Size = new Size(90, 30);
            ckbox1.Text = "Font";
            ckbox1.Location = new Point(320, 49);
            ckbox1.CheckedChanged += Ckbox1_CheckedChanged;
            ///
            ckbox2 = new CheckBox();
            ckbox2.Size = new Size(90, 30);
            ckbox2.Text = "Size";
            ckbox2.CheckedChanged += Ckbox2_CheckedChanged;
            ckbox2.Location = new Point(320, 79);
            ///
            ckbox3 = new CheckBox();
            ckbox3.Size = new Size(90, 90);
            ckbox3.Location = new Point(320, 109);
            ckbox3.Text = "cat";
            ckbox3.CheckedChanged += Ckbox3_CheckedChanged;
            //radiobutton
            rb = new RadioButton();
            rb.Size = new Size(90,30);
            rb.Location = new Point(150,400);
            rb.Text = "red";
            rb1 = new RadioButton();
            rb1.Size = new Size(90, 30);
            rb1.Location = new Point(150, 430);
            rb1.Text = "blue";
            rb2 = new RadioButton();
            rb2.Size = new Size(90, 30);
            rb2.Location = new Point(150, 370);
            rb2.Text = "Regular";
            //textbox
            l1 = new Label();
            l1.Text = "txtbox: ";
            l1.Size= new Size((l1.Text.Length * 8), 15);
            l1.Location = new Point(130,220);
            l1.BackColor = Color.Transparent;
            txt = new TextBox();
            txt.Location= new Point(170, 220);
            txt.Size = new Size(100,20);
            b1 = new Button();
            b1.Location = new Point(270, 220);
            b1.Height = 30;
            b1.Width = 50;
            b1.Text = "Send";
            b1.Click += B1_Click;
        }

        private void B1_Click(object sender, EventArgs e)
        {
            txt.Text = "nice";
            pbox.Image = Image.FromFile(@"../../img/wut.png");

        }

        private void Rb_CheckedChanged(object sender, EventArgs e)
        {
            if (rb.Checked == true)
            {
                this.BackColor = Color.FromArgb(120, 10, 10);
                lbl.ForeColor = Color.FromArgb(130,130,100);
                l1.ForeColor = Color.FromArgb(130, 130, 100);
                btn.ForeColor = Color.FromArgb(130, 130, 100);
                btn.BackColor= Color.FromArgb(150, 10, 100);
                b1.ForeColor = Color.FromArgb(130, 130, 100);
                b1.BackColor = Color.FromArgb(150, 10, 100);
                btn.Text = "REED!!";
                ckbox.ForeColor = Color.FromArgb(130, 130, 100);
                ckbox1.ForeColor = Color.FromArgb(130, 130, 100);
                ckbox2.ForeColor = Color.FromArgb(130, 130, 100);
                ckbox3.ForeColor = Color.FromArgb(130, 130, 100);
                pbox.Image = Image.FromFile(@"../../img/RED.png");
            }
            else if (rb1.Checked == true)
            {
                this.BackColor = Color.FromArgb(50, 20, 250);
                lbl.ForeColor = Color.FromArgb(200, 200, 250);
                l1.ForeColor = Color.FromArgb(200, 200, 250);
                btn.ForeColor = Color.FromArgb(200, 200, 250);
                btn.BackColor = Color.FromArgb(20, 200, 250);
                b1.ForeColor = Color.FromArgb(200, 200, 250);
                b1.BackColor = Color.FromArgb(20, 200, 250);
                btn.Text = "BLUEEES!!";
                ckbox.ForeColor = Color.FromArgb(200, 200, 250);
                ckbox1.ForeColor = Color.FromArgb(200, 200, 250);
                ckbox2.ForeColor = Color.FromArgb(200, 200, 250);
                ckbox3.ForeColor = Color.FromArgb(200, 200, 250);
                pbox.Image = Image.FromFile(@"../../img/blue.png");
            }
            else
            {
                this.BackColor = Color.FromArgb(250, 250, 250);
                lbl.ForeColor = Color.FromArgb(0, 0, 0);
                l1.ForeColor = Color.FromArgb(0, 0, 0);
                btn.ForeColor = Color.FromArgb(0, 0, 0);
                btn.BackColor = Color.Transparent;
                b1.ForeColor = Color.FromArgb(0, 0, 0);
                b1.BackColor = Color.Transparent;
                btn.Text = "click";
                ckbox.ForeColor = Color.FromArgb(0, 0, 0);
                ckbox1.ForeColor = Color.FromArgb(0, 0, 0);
                ckbox2.ForeColor = Color.FromArgb(0, 0, 0);
                ckbox3.ForeColor = Color.FromArgb(0, 0, 0);
                pbox.Image = Image.FromFile(@"../../img/cat.png");

            }
        }

        private void Btn_Leave(object sender, EventArgs e)
        {
            btn.Text = "CLICK I SAY";
        }

        private void Ckbox3_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbox3.Checked==true)
            {
                ckbox3.Text = " ";
                ckbox3.Image = Image.FromFile(@"../../img/cat1.png");
            }
            else
            {
                ckbox3.Text = "cat:D";
                ckbox3.Image = Image.FromFile(@"../../img/empty.png");
            }
            
        }

        private void Ckbox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbox1.Checked == true)
            {
                ckbox1.Font = new Font("Calibri", 16, FontStyle.Bold);
            }
            else
            {
                ckbox1.Font = new Font("Calibri", 10, FontStyle.Regular);
            }
        }

        private void Ckbox2_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbox2.Checked == true)
            {
                this.Height = 1000;
                this.Width = 900;
            }
            else
            {
                this.Height = 500;
                this.Width = 800;
            }
            
        }

        private void Ckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbox.Checked==true)
            {
                this.BackColor = Color.FromArgb(120, 100, 100);
            }
            else
            {
                this.BackColor = Color.FromArgb(250,250,250);
            }
            
        }

        private void Pbox_MouseLeave(object sender, EventArgs e)
        {
            pbox.Image = Image.FromFile(@"../../img/nothehe.png");
        }
        int click = 0;
        private void Pbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string[] images = { "cat.png", "hehe.png", "hehe1.png", "hehe2.png", "hehe3.png" };
            string fail = images[click];
            pbox.Image= Image.FromFile(@"../../img/"+fail);
            click++;
            if (click == 5) { click = 0; }

            

                
        }

        private void Lbl_MouseLeave(object sender, EventArgs e)
        {
            lbl.BackColor = Color.Transparent;
            txt.BackColor = Color.FromArgb(250, 250, 250);
        }

        private void Lbl_MouseHover(object sender, EventArgs e)
        {
            lbl.BackColor = Color.FromArgb(200, 100, 200);
            txt.BackColor = Color.FromArgb(200, 100, 200);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            btn.Text = "ha-ha";
        }

        private void Tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "button")
            {
                this.Controls.Add(btn);
            }
            else if (e.Node.Text == "label")
            {
                this.Controls.Add(lbl);
                
            }
            else if (e.Node.Text == "picturebox")
            {
                this.Controls.Add(pbox);
            }
            else if (e.Node.Text == "checkbox")
            {
                this.Controls.Add(ckbox);
                this.Controls.Add(ckbox1);
                this.Controls.Add(ckbox2);
                this.Controls.Add(ckbox3);
            }
            else if (e.Node.Text == "radiobutton")
            {
                this.Controls.Add(rb);
                this.Controls.Add(rb1);
                this.Controls.Add(rb2);
                rb.CheckedChanged += new EventHandler(Rb_CheckedChanged);
                rb1.CheckedChanged += new EventHandler(Rb_CheckedChanged);
                rb2.CheckedChanged += new EventHandler(Rb_CheckedChanged);
            }
            else if (e.Node.Text == "textbox")
            {
                this.Controls.Add(txt);
                this.Controls.Add(b1);
                this.Controls.Add(l1);


            }
            else if (e.Node.Text == "tabcontrol")
            {
                tabC = new TabControl();
                tabC.Location = new Point(450,50);
                tabC.Size = new Size(300, 400);
                TabPage tab1 = new TabPage("my web-page");
                WebBrowser wb = new WebBrowser();
                wb.Url = new Uri("https://evtina20.thkit.ee/phpLeht");
                tab1.Controls.Add(wb);
                TabPage tab2 = new TabPage("Cutcat");
                PictureBox PIC = new PictureBox();
                PIC.Image= Image.FromFile(@"../../img/a.png");
                pbox.Size = new Size(150, 129);
                pbox.SizeMode = PictureBoxSizeMode.CenterImage;
                tab2.Controls.Add(PIC);
                TabPage tab3 = new TabPage("Third");
                tab3.Click += Tab3_Click;
                tabC.DoubleClick += TabC_DoubleClick;
                tabC.Controls.Add(tab1);
                tabC.Controls.Add(tab2);
                tabC.Controls.Add(tab3);
                this.Controls.Add(tabC);


            }
            else if (e.Node.Text == "messagebox")
            {
                MessageBox.Show("Messagebox",":3");
                var answer=MessageBox.Show("Tahab inputbox?","?????",MessageBoxButtons.YesNo);
                if (answer==DialogResult.Yes)
                {
                    string text = Interaction.InputBox("Sisetaja siia mingi tekst", "InputBox", "Mingi text");
                    if (MessageBox.Show("Kas sa tahab saada tektskastisse?","Teksti salvatamine",MessageBoxButtons.OKCancel)==DialogResult.OK)
                    {
                        lbl.Text = text;
                        Controls.Add(lbl);
                    }
                    else
                    {
                        MessageBox.Show("fine...", ">:(");
                    }
                }
                else
                {
                    MessageBox.Show("there will be no turning back, bb LOSER", ">:|");
                }

            }
        }

        private void Tab3_Click(object sender, EventArgs e)
        {
            string title = "tab" + (tabC.TabCount + 1).ToString();
            TabPage tb = new TabPage(title);
            tabC.TabPages.Add(tb);
        }

        private void TabC_DoubleClick(object sender, EventArgs e)
        {
            this.tabC.TabPages.Remove(tabC.SelectedTab);
        }

    }
}
