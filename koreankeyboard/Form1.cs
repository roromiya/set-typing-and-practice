using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace koreankeyboard
{
    public partial class Form1 : Form
    {
        string savefilePath = "./file.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Stbtn_Click(object sender, EventArgs e)
        {
            if((Numtxt.Text.Length == 0)&&(int.Parse(Numtxt.Text) == 0))
            {
                MessageBox.Show("값이 입력되지 않았습니다");
                return;
            }

            Form2 frm2 = new Form2();
            frm2.Passvalue = Numtxt.Text;
            frm2.ShowDialog();
            this.Close();
        }

        private void Clbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] words;

            if (System.IO.File.Exists(savefilePath))
            {
                words = System.IO.File.ReadAllLines(savefilePath,Encoding.Default);
                Form3 frm3 = new Form3(words);
                frm3.ShowDialog();
                this.Close();
            }
        }
    }
}
