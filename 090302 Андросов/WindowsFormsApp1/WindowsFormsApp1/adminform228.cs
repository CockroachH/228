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
    public partial class adminform228 : Form
    {
        public adminform228()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form TABLICA = new TABLICA();
            TABLICA.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void adminform228_Load(object sender, EventArgs e)
        {

        }
    }
}
