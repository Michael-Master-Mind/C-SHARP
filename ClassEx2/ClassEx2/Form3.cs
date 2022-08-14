using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassEx2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void indicator_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            indicator.Top = 87;
            panel2.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            indicator.Top = 140;
            panel2.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            indicator.Top = 197;
            panel2.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            indicator.Top = 250;
            panel2.Visible = false;
        }
    }
}
