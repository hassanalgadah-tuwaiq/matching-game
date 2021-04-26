using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Matching_Game
{
    public partial class Form1 : Form
    {
        List<boxpic> match;
        List<Label> allboxes;
        List<Label> allpics;
        public Form1()
        {
            match = new List<boxpic>();
            InitializeComponent();
            allboxes = new List<Label>() { box1, box2, box3, box4 };
            allpics = new List<Label>() { pic1, pic2, pic3, pic4 };

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void box1_Click(object sender, EventArgs e)
        {
            box1.Visible = false;
            pic1.Visible = true;
            match.Add(new boxpic(box1, pic1));
            if (match.Count == 2)
            {
                ismatch();
               
            }


        }

        private void box2_Click(object sender, EventArgs e)
        {
            box2.Visible = false;
            pic2.Visible = true;
            match.Add(new boxpic(box2, pic2));
            if (match.Count == 2)
            {
                ismatch();

            }

        }

        private void box3_Click(object sender, EventArgs e)
        {
            box4.Visible = false;
            pic4.Visible = true;
            match.Add(new boxpic(box4, pic4));
            if (match.Count == 2)
            {
                ismatch();

            }

        }

        private void box4_Click(object sender, EventArgs e)
        {
            box3.Visible = false;
            pic3.Visible = true;
            match.Add(new boxpic(box3, pic3));
            if (match.Count == 2)
            {
                ismatch();

            }

        }
        private async void ismatch()
        {
            await Task.Delay(1000);
            if (match[0].pic.Text != match[1].pic.Text)
            {
                match[0].box.Visible = true;
                match[1].box.Visible = true;
                match[0].pic.Visible = false;
                match[1].pic.Visible = false;
            }

            match.Clear();
            checkWin();

        }
        void checkWin()
        {
            foreach (var item in allboxes)
            {
                if (item.Visible == true)
                {
                    return;
                }
            }
            foreach (var item in allboxes)
            {
                item.Visible = true;
            }
            foreach (var item in allpics)
            {
                item.Visible = false;
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pic3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
    class boxpic
    {
        public Label box;
        public Label pic;
        public boxpic(Label box, Label pic)
        {
            this.box = box;
            this.pic = pic;
        }
    }

}
