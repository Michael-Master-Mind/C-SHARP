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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Iteam t = new Iteam();
            t.Number = textBox1.Text;
            t.date = dateTimePicker1.Value;
            t.inventory_number = textBox3.Text;
            t.object_name = textBox4.Text;
            t.count =textBox5.Text;
            t.price = textBox6.Text;
            t.save();
            MessageBox.Show("Iteam added successfully!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
