using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassEx2.Iteams;
namespace ClassEx2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        public Main(string user)
        {
            InitializeComponent();
            label11.Text = user;
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activeScreen = ActiveMdiChild;
            if(activeScreen != null)
                activeScreen.Close();
            Form1 f = new Form1();
            f.MdiParent = this;
            f.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void displayStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activeScreen = ActiveMdiChild;
            if (activeScreen != null)
                activeScreen.Close();
            DisplayAllProduct d = new DisplayAllProduct();
            
            d.MdiParent = this;
            d.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
