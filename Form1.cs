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
    public partial class Form1 : Form
    {
        TreeView tree;
        Button btn;
        Label lbl;
        PictureBox pbox;
        public Form1()
        {
            this.Height = 500;
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
            btn.Text = "Vajuta siia";
            btn.Location = new Point(150, 20);
            btn.Height = 30;
            btn.Width = 70;
            btn.Click += Btn_Click;
            //label
            lbl = new Label();
            lbl.Text = "Elementide loomine c# abil";
            lbl.Size = new Size(200,15);
            lbl.Location = new Point(150, 5);
            lbl.MouseHover += Lbl_MouseHover;
            lbl.MouseLeave += Lbl_MouseLeave;
            tree.Nodes.Add(th);
            this.Controls.Add(tree);
            //picturebox
            pbox = new PictureBox();
            pbox.Image =Image.FromFile(@"../../img/cat.png");
            pbox.Location = new Point(150, 40);
            pbox.Size = new Size(150,129);
            pbox.SizeMode = PictureBoxSizeMode.StretchImage;
            pbox.MouseDoubleClick += Pbox_MouseDoubleClick;
            pbox.MouseLeave += Pbox_MouseLeave;
        }

        private void Pbox_MouseLeave(object sender, EventArgs e)
        {
            pbox.Image = Image.FromFile(@"../../img/nothehe.png");
        }

        private void Pbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pbox.Image = Image.FromFile(@"../../img/hehe.png");
            pbox.Image = Image.FromFile(@"../../img/hehe1.png");
            pbox.Image = Image.FromFile(@"../../img/hehe2.png");
            pbox.Image = Image.FromFile(@"../../img/hehe3.png");

                
        }

        private void Lbl_MouseLeave(object sender, EventArgs e)
        {
            lbl.BackColor = Color.Transparent;
        }

        private void Lbl_MouseHover(object sender, EventArgs e)
        {
            lbl.BackColor = Color.FromArgb(200, 100, 200);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            btn.Text = "ha-ha";
        }

        private void Tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text=="button")
            {
                this.Controls.Add(btn);
            }
            else if (e.Node.Text=="label")
            {
                this.Controls.Add(lbl);
            }
            else if (e.Node.Text == "picturebox")
            {
                this.Controls.Add(pbox);
            }
        }
    }
}
