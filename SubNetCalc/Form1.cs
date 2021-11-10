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
        int goodIp = 0;
        string[] ipS2Value = new string[4];
        int[] ipIValue = new int[4];
        int[] subnetId, broadcast;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void workOnChange()
        {
            ipS1Value = textBoxIpAdress.Text;
            ipS2Value = ipS1Value.Split('.');
            for(int i=0; i<4; i++)
            {
                if(int.TryParse(ipS2Value[i], out _))
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    goodIp++;
                }
            }
            
            if(goodIp > 0)
            {
                radioButton1.Checked = true;
            }
            else
            {
                ipIValue = Array.ConvertAll(ipS2Value, int.Parse);
            }
            
            if (radioButton1.Checked == true)
            {
                if (ipIValue[0] >= 1 && ipIValue[0] <= 126 && ipIValue[1] >=0 && ipIValue[1] <=255 && ipIValue[2] >=0 && ipIValue[2] <=255 && ipIValue[3] >=0 && ipIValue[3] <=255)
                {
                    subnetId = ipIValue;
                    subnetId[1] = 0;
                    subnetId[2] = 0;
                    subnetId[3] = 0;
                    textBoxSubnetID.Text = string.Join(separator, subnetId).ToString();
                    broadcast = ipIValue;
                    broadcast[1] = 255;
                    broadcast[2] = 255;
                    broadcast[3] = 255;
                    textBoxBroadcastAddress.Text = string.Join(separator, broadcast).ToString();
                }
                else
                {
                    radioButton1.Checked = true;
                }
            }
            else if (radioButton2.Checked == true)
            {

            }
            else
            {

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxFirstOctetRange.Text = "1 - 126";
            textBoxIpAdress.Text = "10.0.0.1";
            workOnChange();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBoxFirstOctetRange.Text = "128 - 191";
            textBoxIpAdress.Text = "172.16.0.1";
            workOnChange();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBoxFirstOctetRange.Text = "192 - 223";
            textBoxIpAdress.Text = "192.168.0.1";
            workOnChange();
        }

        private void textBoxIpAdress_TextChanged(object sender, EventArgs e)
        {
            workOnChange();
        }
    }
}
