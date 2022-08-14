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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            /*List<string> list = new List<string>
            { 
                "Object Name: ", "Count: ", "Price: "
            };*/
            foreach (var item in Item.get_add_products())
            {
                UserControl1 card = new UserControl1();
                card.Title = item.object_name;
                card.Count = Convert.ToString(item.count);
                card.Price = Convert.ToString(item.price);
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
