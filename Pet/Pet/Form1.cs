using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet
{ 

    public partial class Form1 : Form
    {
        public static string SetValueForText1 = "";
        public static string SetValueForText3 = "";
        public static string SetValueForDate1 = "";
        public static string SetValueForDate2 = "";



        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void next1_Click(object sender, EventArgs e)
        {
            SetValueForText1 = textBox1.Text;
            SetValueForText3 = textBox3.Text;
            SetValueForDate1 = dateTimePicker1.Text;
            SetValueForDate2 = dateTimePicker2.Text;

            
            if (textBox1.Text == "")
            {
                MessageBox.Show("Nama harap diisi!");
                textBox1.Focus();
                return;
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Alamat Harap diisi!");
                textBox2.Focus();
                return;
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("No Telp Harap diisi!");
                textBox3.Focus();
                return;
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("email Harap diisi!");
                textBox4.Focus();
                return;
            }
            

            if (this.comboBox1.SelectedItem == null || this.comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("harap pilih waktu check-in");
                return;
            }
            else if (this.comboBox2.SelectedItem == null || this.comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("harap pilih waktu check-out");
                return;
            }
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
