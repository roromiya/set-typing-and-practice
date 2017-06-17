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

namespace koreankeyboard
{
    public partial class Form3 : Form
    {
        int b;//랜덤함수
        Random r = new Random();

        public int NumCount
        {
            get
            {
                return words.Length;
            }
        }

        private string[] words;

        public Form3(string[] words)
        {
            InitializeComponent();

            this.words = words;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            NewString();
        }

        public void NewString()
        {
            b = r.Next(0, NumCount);
            label1.Text = words[b].Substring(0, words[b].IndexOf("-"));
        }

        private void Form3_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Valuetxt_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Valuetxt.Text.Length; ++i)
            {
                if (words[b][words[b].Substring(0, words[b].IndexOf("-")).Length+i+1] != Valuetxt.Text[i])
                {
                    Valuetxt.ForeColor = Color.Red;
                    return;
                }
            }

            Valuetxt.ForeColor = Color.Black;
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void Valuetxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Valuetxt.Text = null;
                NewString();
            }
            if(e.KeyCode == Keys.F2)
            {
                string str = "";
                if (words[b].Length > 90)
                {
                    str = words[b].Insert(90, "\n");
                }
                else
                {
                    str = words[b];
                }

                if (str.Length > 180)
                {
                    str = str.Insert(180, "\n");
                }

                if (str.Length > 270)
                {
                    str = str.Insert(270, "\n");
                }

                if (str.Length > 360)
                {
                    str = str.Insert(360, "\n");
                }

                if (str.Length > 450)
                {
                    str = str.Insert(450, "\n");
                }

                if (str.Length > 540)
                {
                    str = str.Insert(540, "\n");
                }

                if (str.Length > 630)
                {
                    str = str.Insert(630, "\n");
                }

                if (str.Length > 720)
                {
                    str = str.Insert(720, "\n");
                }

                if (str.Length > 810)
                {
                    str = str.Insert(810, "\n");
                }

                if (str.Length > 900)
                {
                    str = str.Insert(900, "\n");
                }

                    if (str.Length > 990)
                {
                    str = str.Insert(990, "\n");
                }

                if (str.Length > 1080)
                {
                    str = str.Insert(1080, "\n");
                }

                label1.Text = str;
            }

            if(e.KeyCode == Keys.F3)
                label1.Text = words[b].Substring(0, words[b].IndexOf("-"));
        }
    }
}
