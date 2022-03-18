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
    public partial class Teams : Form
    {
        public Teams()
        {
            InitializeComponent();
        }

        public void Form3_Load(object sender, EventArgs e)
        {
            Teams[] teams = new Teams[5];
            for (int i = 0; i < 5; i++)
            {
                this.Controls["label1" + i].Text = teams[i].Name;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
