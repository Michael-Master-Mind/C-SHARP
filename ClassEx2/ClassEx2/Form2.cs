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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string username = textBox2.Text;
            string password = textBox1.Text;
            if (username == "Michael" && password == "admin")
            {
                Main m = new Main(username);
                //this.Visible = false;
                Hide();
                m.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
            }
        } 
    }
}
