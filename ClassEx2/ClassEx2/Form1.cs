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
        

        public Form1(string user)
        {
            InitializeComponent();
            label9.Text = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Item t = new Item();
            t.Number = textBox1.Text;
            t.date = dateTimePicker1.Value;
            t.inventory_number = textBox3.Text;
            t.object_name = textBox4.Text;
            t.count =textBox5.Text;
            t.price = textBox6.Text;
            


            Regex re = new Regex(@"^[a-z]||[A_Z] {10}$");
            Regex nu = new Regex(@"[0-9]{4}$");
            Regex nm = new Regex(@"[0-9]");

            if (string.IsNullOrEmpty(textBox1.Text))
            {

                errorProvider1.SetError(textBox1, "Number must be provided!!!  ");
            }
            else if (!nu.IsMatch(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Number must be 0-9 (4 Digits)!!! ");
            }
            else
            {
                errorProvider1.Clear();
            }

            if (string.IsNullOrEmpty(textBox3.Text))
            {
                errorProvider1.SetError(textBox3, "Inventory Number must be provided!!! ");
            }
            else if (!nu.IsMatch(textBox3.Text))
            {

                errorProvider1.SetError(textBox3, "Number must be 0-9 (4 Digits)!!! ");
            }
            else
            {
                errorProvider1.Clear();
            }
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                errorProvider1.SetError(textBox4, "Object Name must be provided!!! ");

            }

            else if (!re.IsMatch(textBox4.Text))
            {
                errorProvider1.SetError(textBox4, "Letter must be a-z or A-Z (10 characters )!!!  ");
            }
            else
            {
                errorProvider1.Clear();
            }
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                errorProvider1.SetError(textBox5, "Count must be provided!!!  ");

            }
            else if (!nm.IsMatch(textBox5.Text))
            {

                errorProvider1.SetError(textBox5, "Number must be 0-9 !!!  ");
            }
            try
            {
                if (string.IsNullOrEmpty(textBox6.Text))
                {

                    errorProvider1.SetError(textBox6, "Price must be provided!!!  ");
                }
                else if (!nm.IsMatch(textBox6.Text))
                {

                    errorProvider1.SetError(textBox6, "Number must be 0-9 !!!  ");
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
