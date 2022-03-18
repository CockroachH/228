using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        String[] imglist = new String[]
            {"0.jpg","1.jpg","2.jpg","3.jpg","4.jpg","5.jpg","6.jpg","7.jpg","8.jpg","9.jpg",};
            int index = 0;
        public Form1()
        {
            InitializeComponent();
            pictureBox2.Load("../../pictures/" + imglist[0]);
            pictureBox4.Load("../../pictures/" + imglist[1]);
            pictureBox3.Load("../../pictures/" + imglist[2]);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form adminform228 = new adminform228();
            adminform228.Show();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (index <= 0) {index = imglist.Length; }else
            pictureBox2.Load("../../pictures/" + imglist[index - 0]);
            pictureBox4.Load("../../pictures/" + imglist[index - 1]);
            pictureBox3.Load("../../pictures/" + imglist[index - 2]);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            index = index + 1;
            if (index + 2 >= imglist.Length) index = 0;
            pictureBox2.Load("../../pictures/" + imglist[index+0]);
            pictureBox4.Load("../../pictures/" + imglist[index+1]);
            pictureBox3.Load("../../pictures/" + imglist[index+2]);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}