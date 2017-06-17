using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Microsoft.Win32;

namespace koreankeyboard
{
    public partial class Form2 : Form
    {
        int i = 0;
        string[] save; 
        string savePath = "./file.txt";
        int data;
        private string Form2_value;
        public string Passvalue
        {
            get { return this.Form2_value; }
            set { this.Form2_value = value; }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            data = int.Parse(Passvalue);
            save = new string[data];
            TextBox[] DText = new TextBox[data];

            for (int i = 0; i < DText.Length; i++)
            {
                DText[i] = new TextBox();
                DText[i].Location = new Point(0, i * 25 + 10);
                DText[i].Size = new Size(500, 10);
                DText[i].Name = "DText" + i.ToString();
                DText[i].TabIndex = i;
                grbox.Controls.Add(DText[i]);
            }

            Panel pnl = new Panel();
            pnl.AutoScroll = true;
            pnl.Top = 15;
            pnl.Left = 2;
            pnl.Height = grbox.Height - 8;
            pnl.Width = grbox.Width - 8;
            for (int i = 0; i < DText.Length; i++)
            {
                pnl.Controls.Add(DText[i]);
            }
            grbox.Controls.Add(pnl);
        }

        private void clbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void stbtn_Click(object sender, EventArgs e)
        {
            List<string> strs = new List<string>();

            foreach (Control it_a in Controls)
                if (it_a is GroupBox)
                    foreach (Control it_b in it_a.Controls)
                        if (it_b is Panel)
                            foreach (Control it in it_b.Controls)
                                if (it is TextBox)
                                {
                                    strs.Add(it.Text);
                                    save[i] = it.Text;
                                    i++;
                                }

            System.IO.File.WriteAllText(savePath, save[0], Encoding.Default);
            for(int i = 1; i < data; i++)
            {
                System.IO.File.AppendAllText(savePath, "\r\n"+save[i], Encoding.Default);
            }

            Form3 frm3 = new Form3(strs.ToArray());
            frm3.ShowDialog();
            this.Close();
        }
    }
}
