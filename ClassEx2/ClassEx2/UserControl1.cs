using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassEx2;
namespace ClassEx2
{
    public partial class UserControl1 : UserControl
    {
        private string _title;
        private string  _price;
        private string _count;

        public string Count
        {
            get { return _count; }
            set { _count = value; label4.Text = value; }
        }

        public string  Price
        {
            get { return _price; }
            set { _price = value; label3.Text = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; label2.Text = value; }
        }


        public UserControl1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
