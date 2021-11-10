using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubNetCalc
{
    public partial class Form1 : Form
    {
        string ipS1Value;
        string separator = ".";
        string[] ipS2Value;
        int[] ipIValue, subnetId;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            FirstOctetRangeTextBox.Text = "1 - 126";
            IPAddressTextBox.Text = "10.0.0.1";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            FirstOctetRangeTextBox.Text = "128 - 191";
            IPAddressTextBox.Text = "172.16.0.1";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            FirstOctetRangeTextBox.Text = "192 - 223";
            IPAddressTextBox.Text = "192.168.0.1";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IPAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ipS1Value = IPAddressTextBox.Text;
            ipS2Value = ipS1Value.Split('.');
            ipIValue = Array.ConvertAll(ipS2Value, int.Parse);

            if (radioButton1.Checked == true)
            {
                subnetId = ipIValue;
                subnetId[1] = 0;
                subnetId[2] = 0;
                subnetId[3] = 0;
                SubnetIDTextBox.Text = string.Join(separator, subnetId).ToString();
            }
            else if(radioButton2.Checked == true)
            {
                
            }
            else
            {
                
            }
        }
    }
}
