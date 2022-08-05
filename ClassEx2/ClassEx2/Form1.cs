using System;
using System.Text.RegularExpressions;
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
            Item t = new Item();
            t.Number = num.Text;
            t.date = dateTimePicker1.Value;
            t.inventory_number = Invento.Text;
            t.object_name = Obj.Text;
            t.count =count.Text;
            t.price = price.Text;
            


            Regex re = new Regex(@"^[a-z]||[A_Z] {10}$");
            Regex nu = new Regex(@"[0-9]{4}$");
            Regex nm = new Regex(@"[0-9]");

            if (string.IsNullOrEmpty(num.Text))
            {

                errorProvider1.SetError(num, "Number must be provided!!!  ");
            }
            else if (!nu.IsMatch(num.Text))
            {
                errorProvider1.SetError(num, "Number must be 0-9 (4 Digits)!!! ");
            }
            else
            {
                errorProvider1.Clear();
            }

            if (string.IsNullOrEmpty(Invento.Text))
            {
                errorProvider1.SetError(Invento, "Inventory Number must be provided!!! ");
            }
            else if (!nu.IsMatch(Invento.Text))
            {

                errorProvider1.SetError(Invento, "Number must be 0-9 (4 Digits)!!! ");
            }
            else
            {
                errorProvider1.Clear();
            }
            if (string.IsNullOrEmpty(Obj.Text))
            {
                errorProvider1.SetError(Obj, "Object Name must be provided!!! ");

            }

            else if (!re.IsMatch(Obj.Text))
            {
                errorProvider1.SetError(Obj, "Letter must be a-z or A-Z (10 characters )!!!  ");
            }
            else
            {
                errorProvider1.Clear();
            }
            if (string.IsNullOrEmpty(count.Text))
            {
                errorProvider1.SetError(count, "Count must be provided!!!  ");

            }
            else if (!nm.IsMatch(count.Text))
            {

                errorProvider1.SetError(count, "Number must be 0-9 !!!  ");
            }
            try
            {
                if (string.IsNullOrEmpty(price.Text))
                {

                    errorProvider1.SetError(price, "Price must be provided!!!  ");
                }
                else if (!nm.IsMatch(price.Text))
                {

                    errorProvider1.SetError(price, "Number must be 0-9 !!!  ");
                }
                else
                {
                    errorProvider1.Clear();
                    t.save();
                    MessageBox.Show("Added successfully ");
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = Item.get_add_products();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("invalid price !!!");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string message = "";
            foreach (var item in checkedListBox.CheckedItems)
            {
                message += item.ToString();
            }
            MessageBox.Show(message);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("Simple");

            }
            else if (radioButton2.Checked)
            {
                MessageBox.Show("Variable");
            }
        }

        private void isavaliable_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
