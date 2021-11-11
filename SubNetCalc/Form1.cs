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
        string[] ipS2Value = new string[4];
        string[] subnetIdCopy = new string[4];
        string[] broadcastCopy = new string[4];
        string[] addressRange1Copy = new string[4];
        string[] addressRange2Copy = new string[4];
        int[] ipIValue = new int[4];
        int[] subnetId = new int[4];
        int[] broadcast = new int[4];
        int[] addressRange1 = new int[4];
        int[] addressRange2 = new int[4];

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        /*private void workOnChange()
        {
            ipS1Value = textBoxIpAdress.Text;
            ipS2Value = ipS1Value.Split('.');
            ipIValue = Array.ConvertAll(ipS2Value, s => int.Parse(s));
            if (radioButton1.Checked == true)
            {
                if (ipIValue[0] >= 1 && ipIValue[0] <= 126 && ipIValue[1] >= 0 && ipIValue[1] <= 255 && ipIValue[2] >= 0 && ipIValue[2] <= 255 && ipIValue[3] >= 0 && ipIValue[3] <= 255)
                {
                    subnetId = ipIValue;
                    broadcast = ipIValue;

                    subnetId[1] = 0;
                    subnetId[2] = 0;
                    subnetId[3] = 0;

                    subnetIdCopy = subnetId.Select(x=>x.ToString()).ToArray();

                    addressRange1 = subnetId;
                    addressRange1[3] += 1;

                    addressRange1Copy = addressRange1.Select(x => x.ToString()).ToArray();

                    broadcast[1] = 255;
                    broadcast[2] = 255;
                    broadcast[3] = 255;

                    broadcastCopy = broadcast.Select(x => x.ToString()).ToArray();

                    addressRange2 = broadcast;
                    addressRange1[3] -= 1;

                    addressRange2Copy = addressRange2.Select(x => x.ToString()).ToArray();

                    textBoxSubnetID.Text = String.Join(".", subnetIdCopy);
                    textBoxBroadcastAddress.Text = String.Join(".", broadcastCopy);
                    textBoxHostAddressRange.Text = String.Join(".", addressRange1Copy) + " - " + String.Join(".", addressRange2Copy);

                }
                else
                {
                    radioButton1.Checked = true;
                }
            }
            else if (radioButton2.Checked == true)
            {
                if (ipIValue[0] >= 128 && ipIValue[0] <= 191 && ipIValue[1] >= 0 && ipIValue[1] <= 255 && ipIValue[2] >= 0 && ipIValue[2] <= 255 && ipIValue[3] >= 0 && ipIValue[3] <= 255)
                {
                    subnetId = ipIValue;
                    broadcast = ipIValue;

                    subnetId[2] = 0;
                    subnetId[3] = 0;

                    subnetIdCopy = subnetId.Select(x => x.ToString()).ToArray();

                    addressRange1 = subnetId;
                    addressRange1[3] += 1;

                    addressRange1Copy = addressRange1.Select(x => x.ToString()).ToArray();

                    broadcast[2] = 255;
                    broadcast[3] = 255;

                    broadcastCopy = broadcast.Select(x => x.ToString()).ToArray();

                    addressRange2 = broadcast;
                    addressRange1[3] -= 1;

                    addressRange2Copy = addressRange2.Select(x => x.ToString()).ToArray();

                    textBoxSubnetID.Text = String.Join(".", subnetIdCopy);
                    textBoxBroadcastAddress.Text = String.Join(".", broadcastCopy);
                    textBoxHostAddressRange.Text = String.Join(".", addressRange1Copy) + " - " + String.Join(".", addressRange2Copy);
                }
                else
                {
                    radioButton2.Checked = true;
                }
            }
            else
            {
                if (ipIValue[0] >= 192 && ipIValue[0] <= 223 && ipIValue[1] >= 0 && ipIValue[1] <= 255 && ipIValue[2] >= 0 && ipIValue[2] <= 255 && ipIValue[3] >= 0 && ipIValue[3] <= 255)
                {
                    subnetId = ipIValue;
                    broadcast = ipIValue;

                    subnetId[3] = 0;

                    subnetIdCopy = subnetId.Select(x => x.ToString()).ToArray();

                    addressRange1 = subnetId;
                    addressRange1[3] += 1;

                    addressRange1Copy = addressRange1.Select(x => x.ToString()).ToArray();

                    broadcast[3] = 255;

                    broadcastCopy = broadcast.Select(x => x.ToString()).ToArray();

                    addressRange2 = broadcast;
                    addressRange1[3] -= 1;

                    addressRange2Copy = addressRange2.Select(x => x.ToString()).ToArray();

                    textBoxSubnetID.Text = String.Join(".", subnetIdCopy);
                    textBoxBroadcastAddress.Text = String.Join(".", broadcastCopy);
                    textBoxHostAddressRange.Text = String.Join(".", addressRange1Copy) + " - " + String.Join(".", addressRange2Copy);
                }
                else
                {
                    radioButton3.Checked = true;
                }
            }
        }*/

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxFirstOctetRange.Text = "1 - 126";
            textBoxIpAdress.Text = "10.0.0.1";
            textBoxHostAddressRange.Text = "10.0.0.1 - 10.255.255.254";
            textBoxSubnetID.Text = "10.0.0.0";
            textBoxBroadcastAddress.Text = "10.255.255.255";
            //workOnChange();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBoxFirstOctetRange.Text = "128 - 191";
            textBoxIpAdress.Text = "172.16.0.1";
            textBoxHostAddressRange.Text = "172.16.0.1 - 172.16.255.254";
            textBoxSubnetID.Text = "172.16.0.0";
            textBoxBroadcastAddress.Text = "172.16.255.255";
            //workOnChange();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBoxFirstOctetRange.Text = "192 - 223";
            textBoxIpAdress.Text = "192.168.0.1";
            textBoxHostAddressRange.Text = "192.168.0.1 - 192.168.0.254";
            textBoxSubnetID.Text = "192.168.0.0";
            textBoxBroadcastAddress.Text = "192.168.0.255";
            //workOnChange();
        }

        private void textBoxIpAdress_TextChanged(object sender, EventArgs e)
        {
            //workOnChange();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ipS1Value = textBoxIpAdress.Text;
            ipS2Value = ipS1Value.Split('.');
            ipIValue = Array.ConvertAll(ipS2Value, s => int.Parse(s));
            if (radioButton1.Checked == true)
            {
                if (ipIValue[0] >= 1 && ipIValue[0] <= 126 && ipIValue[1] >= 0 && ipIValue[1] <= 255 && ipIValue[2] >= 0 && ipIValue[2] <= 255 && ipIValue[3] >= 0 && ipIValue[3] <= 255)
                {
                    subnetId = ipIValue;
                    broadcast = ipIValue;

                    subnetId[1] = 0;
                    subnetId[2] = 0;
                    subnetId[3] = 0;

                    subnetIdCopy = subnetId.Select(x=>x.ToString()).ToArray();

                    addressRange1 = subnetId;
                    addressRange1[3] += 1;

                    addressRange1Copy = addressRange1.Select(x => x.ToString()).ToArray();

                    broadcast[1] = 255;
                    broadcast[2] = 255;
                    broadcast[3] = 255;

                    broadcastCopy = broadcast.Select(x => x.ToString()).ToArray();

                    addressRange2 = broadcast;
                    addressRange1[3] -= 1;

                    addressRange2Copy = addressRange2.Select(x => x.ToString()).ToArray();

                    textBoxSubnetID.Text = String.Join(".", subnetIdCopy);
                    textBoxBroadcastAddress.Text = String.Join(".", broadcastCopy);
                    textBoxHostAddressRange.Text = String.Join(".", addressRange1Copy) + " - " + String.Join(".", addressRange2Copy);

                }
                else
                {
                    radioButton1.Checked = true;
                }
            }
            else if (radioButton2.Checked == true)
            {
                if (ipIValue[0] >= 128 && ipIValue[0] <= 191 && ipIValue[1] >= 0 && ipIValue[1] <= 255 && ipIValue[2] >= 0 && ipIValue[2] <= 255 && ipIValue[3] >= 0 && ipIValue[3] <= 255)
                {
                    subnetId = ipIValue;
                    broadcast = ipIValue;

                    subnetId[2] = 0;
                    subnetId[3] = 0;

                    subnetIdCopy = subnetId.Select(x => x.ToString()).ToArray();

                    addressRange1 = subnetId;
                    addressRange1[3] += 1;

                    addressRange1Copy = addressRange1.Select(x => x.ToString()).ToArray();

                    broadcast[2] = 255;
                    broadcast[3] = 255;

                    broadcastCopy = broadcast.Select(x => x.ToString()).ToArray();

                    addressRange2 = broadcast;
                    addressRange1[3] -= 1;

                    addressRange2Copy = addressRange2.Select(x => x.ToString()).ToArray();

                    textBoxSubnetID.Text = String.Join(".", subnetIdCopy);
                    textBoxBroadcastAddress.Text = String.Join(".", broadcastCopy);
                    textBoxHostAddressRange.Text = String.Join(".", addressRange1Copy) + " - " + String.Join(".", addressRange2Copy);
                }
                else
                {
                    radioButton2.Checked = true;
                }
            }
            else
            {
                if (ipIValue[0] >= 192 && ipIValue[0] <= 223 && ipIValue[1] >= 0 && ipIValue[1] <= 255 && ipIValue[2] >= 0 && ipIValue[2] <= 255 && ipIValue[3] >= 0 && ipIValue[3] <= 255)
                {
                    subnetId = ipIValue;
                    broadcast = ipIValue;

                    subnetId[3] = 0;

                    subnetIdCopy = subnetId.Select(x => x.ToString()).ToArray();

                    addressRange1 = subnetId;
                    addressRange1[3] += 1;

                    addressRange1Copy = addressRange1.Select(x => x.ToString()).ToArray();

                    broadcast[3] = 255;

                    broadcastCopy = broadcast.Select(x => x.ToString()).ToArray();

                    addressRange2 = broadcast;
                    addressRange1[3] -= 1;

                    addressRange2Copy = addressRange2.Select(x => x.ToString()).ToArray();

                    textBoxSubnetID.Text = String.Join(".", subnetIdCopy);
                    textBoxBroadcastAddress.Text = String.Join(".", broadcastCopy);
                    textBoxHostAddressRange.Text = String.Join(".", addressRange1Copy) + " - " + String.Join(".", addressRange2Copy);
                }
                else
                {
                    radioButton3.Checked = true;
                }
            }
        }
    }
}
