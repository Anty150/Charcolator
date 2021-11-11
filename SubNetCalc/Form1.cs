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
        string[] IPs = new string[4];
        int HexValue;
        string HexText;

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

        private void IpToHex()
        {
            string str = "";
            for (int i = 0; i < 4; i++)
            {
                HexValue = Convert.ToInt32(ipS2Value[i]);
                HexText = Convert.ToString(HexValue, 16).ToUpper();
                if (HexText.Length < 2)
                {
                    HexText = "0" + HexText;
                }
                Console.WriteLine(ipS2Value[i] + " " + HexText);
                if (i != 3)
                {
                    str += HexText + ".";
                }
                else
                {
                    str += HexText;
                }
            }
            textBoxHexIPAddress.Text = string.Join(".", str);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            createAndClearComboBoxes(1);
            textBoxFirstOctetRange.Text = "1 - 126";
            textBoxIpAdress.Text = "10.0.0.1";
            textBoxHostAddressRange.Text = "10.0.0.1 - 10.255.255.254";
            textBoxSubnetID.Text = "10.0.0.0";
            textBoxBroadcastAddress.Text = "10.255.255.255";
            //workOnChange();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            createAndClearComboBoxes(2);
            textBoxFirstOctetRange.Text = "128 - 191";
            textBoxIpAdress.Text = "172.16.0.1";
            textBoxHostAddressRange.Text = "172.16.0.1 - 172.16.255.254";
            textBoxSubnetID.Text = "172.16.0.0";
            textBoxBroadcastAddress.Text = "172.16.255.255";
            //workOnChange();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            createAndClearComboBoxes(3);
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
                    IPs = ipS2Value;

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

                    IpToHex();
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

                    IpToHex();
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

                    IpToHex();
                }
                else
                {
                    radioButton3.Checked = true;
                }
            }
        }
        #region CreatingAndClearingComboBoxes Funtions
        //Funtions used to create and Clear Comboboxes when radio button is pressed
        public void createAndClearComboBoxes(int radioButtonNumber)
        {
            //Function used to clear and then create all comboBoxes

            //Clearing Comboboxes
            clearSubnetBitsCombobox();
            clearSubnetMaskCombobox();
            clearMinimumSubnetsCombobox();

            //Adding Options to Comboboxes
            createSubnetBitsOptions(radioButtonNumber);
            createSubnetMaskOptions(radioButtonNumber);
            createMinimumSubnetsOptions(radioButtonNumber);
        }

        #region Clearing Funtions
        public void clearSubnetMaskCombobox()
        {
            //Clears SubnetMaskCombobox when new radio button is pressed
            comboBoxSubnetMask.Items.Clear();
        }
        public void clearSubnetBitsCombobox()
        {
            //Clears SubnetMaskCombobox when new radio button is pressed
            comboBoxSubnetBits.Items.Clear();
        }
        public void clearMinimumSubnetsCombobox()
        {
            //Clears SubnetMaskCombobox when new radio button is pressed
            comboBoxMinimumSubnets.Items.Clear();
        }
        #endregion

        #region Options creating funtions
        public void createSubnetMaskOptions(int radioButtonNumber)
        {
            switch (radioButtonNumber)
            {
                case 1:
                    #region subnetComboMaskAddOptionsRadio1
                    //Adding options to subnetMaskComboBox when Radio 1 pressed
                    comboBoxSubnetMask.Items.Add("255.0.0.0");
                    comboBoxSubnetMask.Items.Add("255.128.0.0");
                    comboBoxSubnetMask.Items.Add("255.192.0.0");
                    comboBoxSubnetMask.Items.Add("255.224.0.0");
                    comboBoxSubnetMask.Items.Add("255.240.0.0");
                    comboBoxSubnetMask.Items.Add("255.248.0.0");
                    comboBoxSubnetMask.Items.Add("255.252.0.0");
                    comboBoxSubnetMask.Items.Add("255.254.0.0");
                    comboBoxSubnetMask.Items.Add("255.255.0.0");
                    comboBoxSubnetMask.Items.Add("255.255.128.0");
                    comboBoxSubnetMask.Items.Add("255.255.192.0");
                    comboBoxSubnetMask.Items.Add("255.255.224.0");
                    comboBoxSubnetMask.Items.Add("255.255.240.0");
                    comboBoxSubnetMask.Items.Add("255.255.248.0");
                    comboBoxSubnetMask.Items.Add("255.255.252.0");
                    comboBoxSubnetMask.Items.Add("255.255.254.0");
                    comboBoxSubnetMask.Items.Add("255.255.255.0");
                    comboBoxSubnetMask.Items.Add("255.255.255.128");
                    comboBoxSubnetMask.Items.Add("255.255.255.192");
                    comboBoxSubnetMask.Items.Add("255.255.255.224");
                    comboBoxSubnetMask.Items.Add("255.255.255.240");
                    comboBoxSubnetMask.Items.Add("255.255.255.248");
                    comboBoxSubnetMask.Items.Add("255.255.255.252");
                    #endregion
                    break;
                case 2:
                    #region subnetComboMaskAddOptionsRadio2
                    //Adding options to subnetMaskComboBox when Radio 2 pressed
                    comboBoxSubnetMask.Items.Add("255.255.0.0");
                    comboBoxSubnetMask.Items.Add("255.255.128.0");
                    comboBoxSubnetMask.Items.Add("255.255.192.0");
                    comboBoxSubnetMask.Items.Add("255.255.224.0");
                    comboBoxSubnetMask.Items.Add("255.255.240.0");
                    comboBoxSubnetMask.Items.Add("255.255.248.0");
                    comboBoxSubnetMask.Items.Add("255.255.252.0");
                    comboBoxSubnetMask.Items.Add("255.255.254.0");
                    comboBoxSubnetMask.Items.Add("255.255.255.0");
                    comboBoxSubnetMask.Items.Add("255.255.255.128");
                    comboBoxSubnetMask.Items.Add("255.255.255.192");
                    comboBoxSubnetMask.Items.Add("255.255.255.224");
                    comboBoxSubnetMask.Items.Add("255.255.255.240");
                    comboBoxSubnetMask.Items.Add("255.255.255.248");
                    comboBoxSubnetMask.Items.Add("255.255.255.252");
                    #endregion
                    break;
                case 3:
                    #region subnetComboMaskAddOptionsRadio3
                    //Adding options to subnetMaskComboBox when Radio 3 pressed                   
                    comboBoxSubnetMask.Items.Add("255.255.255.0");
                    comboBoxSubnetMask.Items.Add("255.255.255.128");
                    comboBoxSubnetMask.Items.Add("255.255.255.192");
                    comboBoxSubnetMask.Items.Add("255.255.255.224");
                    comboBoxSubnetMask.Items.Add("255.255.255.240");
                    comboBoxSubnetMask.Items.Add("255.255.255.248");
                    comboBoxSubnetMask.Items.Add("255.255.255.252");
                    #endregion
                    break;

            }
            comboBoxSubnetMask.SelectedIndex = 0;
        }
        public void createSubnetBitsOptions(int radioButtonNumber)
        {
            switch(radioButtonNumber)
            {
                case 1:
                    #region subnetComboBitsAddOptionsRadio1
                    //Adding options to subnetBitsComboBox when Radio 1 pressed
                    comboBoxSubnetBits.Items.Add("0");
                    comboBoxSubnetBits.Items.Add("1");
                    comboBoxSubnetBits.Items.Add("2");
                    comboBoxSubnetBits.Items.Add("3");
                    comboBoxSubnetBits.Items.Add("4");
                    comboBoxSubnetBits.Items.Add("5");
                    comboBoxSubnetBits.Items.Add("6");
                    comboBoxSubnetBits.Items.Add("7");
                    comboBoxSubnetBits.Items.Add("8");
                    comboBoxSubnetBits.Items.Add("9");
                    comboBoxSubnetBits.Items.Add("10");
                    comboBoxSubnetBits.Items.Add("11");
                    comboBoxSubnetBits.Items.Add("12");
                    comboBoxSubnetBits.Items.Add("13");
                    comboBoxSubnetBits.Items.Add("14");
                    comboBoxSubnetBits.Items.Add("15");
                    comboBoxSubnetBits.Items.Add("16");
                    comboBoxSubnetBits.Items.Add("17");
                    comboBoxSubnetBits.Items.Add("18");
                    comboBoxSubnetBits.Items.Add("19");
                    comboBoxSubnetBits.Items.Add("20");
                    comboBoxSubnetBits.Items.Add("21");
                    comboBoxSubnetBits.Items.Add("22");
                    #endregion
                    break;
                case 2:
                    #region subnetComboBitsAddOptionsRadio2
                    //Adding options to subnetBitsComboBox when Radio 2 pressed
                    comboBoxSubnetBits.Items.Add("0");
                    comboBoxSubnetBits.Items.Add("1");
                    comboBoxSubnetBits.Items.Add("2");
                    comboBoxSubnetBits.Items.Add("3");
                    comboBoxSubnetBits.Items.Add("4");
                    comboBoxSubnetBits.Items.Add("5");
                    comboBoxSubnetBits.Items.Add("6");
                    comboBoxSubnetBits.Items.Add("7");
                    comboBoxSubnetBits.Items.Add("8");
                    comboBoxSubnetBits.Items.Add("9");
                    comboBoxSubnetBits.Items.Add("10");
                    comboBoxSubnetBits.Items.Add("11");
                    comboBoxSubnetBits.Items.Add("12");
                    comboBoxSubnetBits.Items.Add("13");
                    comboBoxSubnetBits.Items.Add("14");
                    #endregion
                    break;
                case 3:
                    #region subnetComboBitsAddOptionsRadio3
                    //Adding options to subnetBitsComboBox when Radio 3 pressed
                    comboBoxSubnetBits.Items.Add("0");
                    comboBoxSubnetBits.Items.Add("1");
                    comboBoxSubnetBits.Items.Add("2");
                    comboBoxSubnetBits.Items.Add("3");
                    comboBoxSubnetBits.Items.Add("4");
                    comboBoxSubnetBits.Items.Add("5");
                    comboBoxSubnetBits.Items.Add("6");                   
                    #endregion
                    break;
            }
            comboBoxSubnetBits.SelectedIndex = 0;
        }
        public void createMinimumSubnetsOptions(int radioButtonNumber)
        {
            switch(radioButtonNumber)
            {
                case 1:
                    #region minimumComboSubnetsAddOptionsRadio1
                    //Adding options to minimumSubnetsComboBox when Radio 1 pressed
                    comboBoxMinimumSubnets.Items.Add("1");
                    comboBoxMinimumSubnets.Items.Add("2");
                    comboBoxMinimumSubnets.Items.Add("4");
                    comboBoxMinimumSubnets.Items.Add("8");
                    comboBoxMinimumSubnets.Items.Add("16");
                    comboBoxMinimumSubnets.Items.Add("32");
                    comboBoxMinimumSubnets.Items.Add("64");
                    comboBoxMinimumSubnets.Items.Add("128");
                    comboBoxMinimumSubnets.Items.Add("256");
                    comboBoxMinimumSubnets.Items.Add("512");
                    comboBoxMinimumSubnets.Items.Add("1024");
                    comboBoxMinimumSubnets.Items.Add("2048");
                    comboBoxMinimumSubnets.Items.Add("4096");
                    comboBoxMinimumSubnets.Items.Add("8192");
                    comboBoxMinimumSubnets.Items.Add("16384");
                    comboBoxMinimumSubnets.Items.Add("32768");
                    comboBoxMinimumSubnets.Items.Add("65536");
                    comboBoxMinimumSubnets.Items.Add("131072");
                    comboBoxMinimumSubnets.Items.Add("262144");
                    comboBoxMinimumSubnets.Items.Add("524288");
                    comboBoxMinimumSubnets.Items.Add("1048576");
                    comboBoxMinimumSubnets.Items.Add("2097152");
                    comboBoxMinimumSubnets.Items.Add("4194304");
                    #endregion
                    break;
                case 2:
                    #region minimumComboSubnetsAddOptionsRadio2
                    //Adding options to minimumSubnetsComboBox when Radio 1 pressed
                    comboBoxMinimumSubnets.Items.Add("1");
                    comboBoxMinimumSubnets.Items.Add("2");
                    comboBoxMinimumSubnets.Items.Add("4");
                    comboBoxMinimumSubnets.Items.Add("8");
                    comboBoxMinimumSubnets.Items.Add("16");
                    comboBoxMinimumSubnets.Items.Add("32");
                    comboBoxMinimumSubnets.Items.Add("64");
                    comboBoxMinimumSubnets.Items.Add("128");
                    comboBoxMinimumSubnets.Items.Add("256");
                    comboBoxMinimumSubnets.Items.Add("512");
                    comboBoxMinimumSubnets.Items.Add("1024");
                    comboBoxMinimumSubnets.Items.Add("2048");
                    comboBoxMinimumSubnets.Items.Add("4096");
                    comboBoxMinimumSubnets.Items.Add("8192");
                    comboBoxMinimumSubnets.Items.Add("16384");
                    #endregion
                    break;
                case 3:
                    #region minimumComboSubnetsAddOptionsRadio3
                    //Adding options to minimumSubnetsComboBox when Radio 3 pressed
                    comboBoxMinimumSubnets.Items.Add("1");
                    comboBoxMinimumSubnets.Items.Add("2");
                    comboBoxMinimumSubnets.Items.Add("4");
                    comboBoxMinimumSubnets.Items.Add("8");
                    comboBoxMinimumSubnets.Items.Add("16");
                    comboBoxMinimumSubnets.Items.Add("32");
                    comboBoxMinimumSubnets.Items.Add("64");
                    #endregion
                    break;
            }
            comboBoxMinimumSubnets.SelectedIndex = 0;
        }
        #endregion
        #endregion
        private void comboBoxSubnetBits_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
