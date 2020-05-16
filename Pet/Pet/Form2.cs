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
    
    public partial class Form2 : Form
    {
        int total = 0;

        public Form2()
        {
            InitializeComponent();
            
        }
        

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }


       
        

        private void button1_Click(object sender, EventArgs e)
        {
            
            int jumlah = int.Parse(comboBoxHewan.Text);
            for (int i = 0; i <= 5; i++) ;
            jumlah = jumlah * 120000;

            label2.Text = jumlah.ToString();

            

            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string jumlah = label2.Text;
            string Pemilik = label15.Text;
            string telp = label16.Text;
            string date1 = label17.Text;
            string date2 = label18.Text;
            string hewan = textBox2.Text;

            MessageBox.Show("Struk Pemesanan : "
                + Environment.NewLine
                + "Nama : " + Pemilik.ToUpper().ToString()
                + Environment.NewLine
                + "No Telepon : " + telp.ToUpper().ToString()
                + Environment.NewLine
                + "Tanggal : " + date1.ToUpper().ToString() + date2.ToUpper().ToString()
                + Environment.NewLine
                + "hewan : " + hewan.ToUpper().ToString()
                + Environment.NewLine
                + "total biaya : " + jumlah.ToUpper().ToString()
                + "", "CONFIRM BIODATA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
            Application.Exit();
        }

       

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label15.Text = Form1.SetValueForText1;
            label16.Text = Form1.SetValueForText3;
            label17.Text = Form1.SetValueForDate1;
            label18.Text = Form1.SetValueForDate2;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
