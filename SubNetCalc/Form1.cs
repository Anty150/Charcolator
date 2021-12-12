using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace SubNetCalc
{
    public partial class Form1 : Form
    {
        string ipS1Value;
        string wildcardS1Mask;

        string[] ipS2Value = new string[4];
        string[] subnetIdCopy = new string[4];
        string[] broadcastCopy = new string[4];
        string[] addressRange1Copy = new string[4];
        string[] addressRange2Copy = new string[4];
        string[] wildcardS2Mask = new string[4];
        string[] wildcardMaskCopy = new string[4];
        int[] ipIValue = new int[4];
        int[] subnetId = new int[4];
        int[] broadcast = new int[4];
        int[] addressRange1 = new int[4];
        int[] addressRange2 = new int[4];
        int[] wildcardIMask = new int[4];
        int[] wildcardIMask1 = new int[] { 255, 255, 255, 255 };
        int[] wildcardIMask2 = new int[4];
        int HexValue;
        string HexText;
        string bitmap;

        bool isLoaded = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            isLoaded = true;
            onUpdateOperation();
        }
        
        #region [CreatingAndClearingComboBoxes Funtions]
        //Funtions used to create and Clear Comboboxes when radio button is pressed
        public void createAndClearComboBoxes(int radioButtonNumber, ref bool isLoaded)
        {
            //Function used to clear and then create all comboBoxes

            //Clearing Comboboxes
            clearSubnetBitsCombobox();
            clearSubnetMaskCombobox();
            clearMinimumSubnetsCombobox();
            clearMaskBitsCombobox();
            clearHostsPerSubnetComboBox();

            //Adding Options to Comboboxes
            createSubnetBitsOptions(radioButtonNumber);
            createSubnetMaskOptions(radioButtonNumber);
            createMinimumSubnetsOptions(radioButtonNumber);
            createMaskBitsOptions(radioButtonNumber);
            createHostsPerSubnetOptions(radioButtonNumber);

            //Informing that Comboboxes were succesfully created
            isLoaded = true;
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
        public void clearMaskBitsCombobox()
        {
            //Clears MaskBitsCombobox when new radio button is pressed
            comboBoxMaskBits.Items.Clear();
        }
        public void clearHostsPerSubnetComboBox()
        {
            //Clears HostsPerSubnetComboBox when new radio button is pressed
            comboBoxHostsPerSubnet.Items.Clear();
        }
        #endregion

        #region Creating Functions
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
            switch (radioButtonNumber)
            {
                case 1:
                    #region subnetComboBitsAddOptionsRadio1
                    //Adding options to subnetBitsComboBox when Radio 1 pressed
                    for (int i = 0; i <= 22; i++)
                    {
                        comboBoxSubnetBits.Items.Add(i);
                    }
                    #endregion
                    break;
                case 2:
                    #region subnetComboBitsAddOptionsRadio2
                    //Adding options to subnetBitsComboBox when Radio 2 pressed
                    for (int i = 0; i <= 14; i++)
                    {
                        comboBoxSubnetBits.Items.Add(i);
                    }
                    #endregion
                    break;
                case 3:
                    #region subnetComboBitsAddOptionsRadio3
                    //Adding options to subnetBitsComboBox when Radio 3 pressed
                    for (int i = 0; i <= 6; i++)
                    {
                        comboBoxSubnetBits.Items.Add(i);
                    }
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
                    for (int i = 0; i <= 22; i++)
                    {
                        comboBoxMinimumSubnets.Items.Add(Math.Pow(2, i));
                    }
                    #endregion
                    break;
                case 2:
                    #region minimumComboSubnetsAddOptionsRadio2
                    //Adding options to minimumSubnetsComboBox when Radio 1 pressed
                    for (int i = 0; i <= 14; i++)
                    {
                        comboBoxMinimumSubnets.Items.Add(Math.Pow(2, i));
                    }
                    #endregion
                    break;
                case 3:
                    #region minimumComboSubnetsAddOptionsRadio3
                    //Adding options to minimumSubnetsComboBox when Radio 3 pressed
                    for (int i = 0; i <= 6; i++)
                    {
                        comboBoxMinimumSubnets.Items.Add(Math.Pow(2, i));
                    }
                    #endregion
                    break;
            }
            comboBoxMinimumSubnets.SelectedIndex = 0;
        }

        public void createMaskBitsOptions(int radioButtonNumber)
        {
            switch (radioButtonNumber)
            {
                case 1:
                    #region MaskBitsOptionsRadio1
                    //Adding options to comboBoxMaskBits when Radio 1 pressed
                    for (int i = 0; i <= 22; i++)
                    {
                        comboBoxMaskBits.Items.Add(i + 8);
                    }
                    comboBoxMinimumSubnets.SelectedIndex = 0;
                    #endregion
                    break;
                case 2:
                    #region MaskBitsOptionsRadio2
                    //Adding options to comboBoxMaskBits when Radio 1 pressed
                    for (int i = 0; i <= 14; i++)
                    {
                        comboBoxMaskBits.Items.Add(i + 16);
                    }
                    #endregion
                    break;
                case 3:
                    #region MaskBitsOptionsRadio3
                    //Adding options to comboBoxMaskBits when Radio 3 pressed
                    for (int i = 0; i <= 6; i++)
                    {
                        comboBoxMaskBits.Items.Add(i + 24);
                    }
                    #endregion
                    break;
            }
            comboBoxMaskBits.SelectedIndex = 0;
        }

        public void createHostsPerSubnetOptions(int radioButtonNumber)
        {
            switch (radioButtonNumber)
            {
                case 1:
                    #region HostsperSubnetRadio1
                    //Adding options to comboBoxHostsPerSubnet when Radio 1 pressed
                    for (int i = 24; i >= 2; i--)
                    {
                        comboBoxHostsPerSubnet.Items.Add(Math.Pow(2, i) - 2);
                    }
                    #endregion
                    break;
                case 2:
                    #region HostsperSubnetRadio2
                    //Adding options to comboBoxHostsPerSubnet when Radio 1 pressed
                    for (int i = 16; i >= 2; i--)
                    {
                        comboBoxHostsPerSubnet.Items.Add(Math.Pow(2, i) - 2);
                    }
                    #endregion
                    break;
                case 3:
                    #region HostsperSubnetRadio3
                    //Adding options to comboBoxHostsPerSubnet when Radio 3 pressed
                    for (int i = 8; i >= 2; i--)
                    {
                        comboBoxHostsPerSubnet.Items.Add(Math.Pow(2, i) - 2);
                    }
                    #endregion
                    break;
            }
            comboBoxHostsPerSubnet.SelectedIndex = 0;
        }
        #endregion
        #endregion
        #region [FuntionsChangingComboBoxesIndexesOnIndexChange]
        //Functions to make all comboBoxesIndexes same

        #region SelectedIndexChanged functions
        private void comboBoxSubnetBits_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBoxSubnetBits.SelectedIndex;
            changeComboBoxIndex(selectedIndex);

            onUpdateOperation();
        }

        private void comboBoxSubnetMask_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBoxSubnetMask.SelectedIndex;
            changeComboBoxIndex(selectedIndex);

            onUpdateOperation();
        }

        private void comboBoxMinimumSubnets_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBoxMinimumSubnets.SelectedIndex;
            changeComboBoxIndex(selectedIndex);

            onUpdateOperation();
        }

        private void comboBoxMaskBits_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBoxMaskBits.SelectedIndex;
            changeComboBoxIndex(selectedIndex);

            onUpdateOperation();
        }

        private void comboBoxHostsPerSubnet_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBoxHostsPerSubnet.SelectedIndex;
            changeComboBoxIndex(selectedIndex);

            onUpdateOperation();
        }
        #endregion

        public void changeComboBoxIndex(int selectedIndex)
        {
            if(isLoaded)
            {
                comboBoxSubnetBits.SelectedIndex = selectedIndex;
                comboBoxSubnetMask.SelectedIndex = selectedIndex;
                comboBoxMinimumSubnets.SelectedIndex = selectedIndex;
                comboBoxMaskBits.SelectedIndex = selectedIndex;
                comboBoxHostsPerSubnet.SelectedIndex = selectedIndex;
            }
        }
        #endregion
        #region [radioButtonChangeValues]
        //Funtions that change radioButtonValues
        public void radioButtonChangeValues(int radioButtonNumber)
        {
            switch (radioButtonNumber)
            {
                case 1:
                    textBoxFirstOctetRange.Text = "1 - 126";
                    textBoxIpAdress.Text = "10.0.0.1";
                    textBoxHostAddressRange.Text = "10.0.0.1 - 10.255.255.254";
                    textBoxSubnetID.Text = "10.0.0.0";
                    textBoxBroadcastAddress.Text = "10.255.255.255";
                    break;
                case 2:
                    textBoxFirstOctetRange.Text = "128 - 191";
                    textBoxIpAdress.Text = "172.16.0.1";
                    textBoxHostAddressRange.Text = "172.16.0.1 - 172.16.255.254";
                    textBoxSubnetID.Text = "172.16.0.0";
                    textBoxBroadcastAddress.Text = "172.16.255.255";
                    break;
                case 3:
                    textBoxFirstOctetRange.Text = "192 - 223";
                    textBoxIpAdress.Text = "192.168.0.1";
                    textBoxHostAddressRange.Text = "192.168.0.1 - 192.168.0.254";
                    textBoxSubnetID.Text = "192.168.0.0";
                    textBoxBroadcastAddress.Text = "192.168.0.255";
                    break;
            }
        }
        public bool isIpOk()
        {
            int iCheck;
            ipS1Value = textBoxIpAdress.Text;
            ipS2Value = ipS1Value.Split('.');
            if (ipS2Value.Length != 4)
            {
                return false;
            }
            else if (ipS2Value[3].Length == 0)
            {
                return false;
            }
            for (int i = 0; i < ipS2Value.Length; i++)
            {
                if (int.TryParse(ipS2Value[i], out iCheck))
                {
                    if (iCheck > 255)
                    {
                        if (radioButton1.Checked)
                        {
                            radioButtonChangeValues(1);
                        }
                        else if (radioButton2.Checked)
                        {
                            radioButtonChangeValues(2);
                        }
                        else
                        {
                            radioButtonChangeValues(3);
                        }
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        #endregion
        #region [operationFunctions]
        //Functions doing something like changing values etc.

        private void subnetBitmap()
        {
            if (radioButton1.Checked == true)
            {
                string sBitmap = "0";
                bitmap = "";
                
                for (int i = 0; i < 7; i++)
                {
                    sBitmap += "n";

                }
                
                for (int i = 0; i <= comboBoxSubnetBits.SelectedIndex - 1; i++)
                {
                    sBitmap += "s";                   
                    
                }
                
                for (int i = 22; i >= comboBoxHostsPerSubnet.SelectedIndex - 1; i--)
                {
                    sBitmap += "h";
                }

                for(int i = 0; i < 32; i++)
                {
                    bitmap += sBitmap[i];
                    if(i == 7 || i == 15 || i == 23)
                    {
                        bitmap += ".";
                    }
                }
            }
            else if(radioButton2.Checked == true)
            {
                string sBitmap = "10";
                bitmap = "";

                for (int i = 0; i < 14; i++)
                {
                    sBitmap += "n";

                }

                for (int i = 0; i <= comboBoxSubnetBits.SelectedIndex - 1; i++)
                {
                    sBitmap += "s";

                }

                for (int i = 22; i >= comboBoxHostsPerSubnet.SelectedIndex - 1; i--)
                {
                    sBitmap += "h";
                }

                for (int i = 0; i < 32; i++)
                {
                    bitmap += sBitmap[i];
                    if (i == 7 || i == 15 || i == 23)
                    {
                        bitmap += ".";
                    }
                }
            }
            else
            {
                string sBitmap = "110";
                bitmap = "";

                for (int i = 0; i < 21; i++)
                {
                    sBitmap += "n";

                }

                for (int i = 0; i <= comboBoxSubnetBits.SelectedIndex - 1; i++)
                {
                    sBitmap += "s";

                }

                for (int i = 22; i >= comboBoxHostsPerSubnet.SelectedIndex - 1; i--)
                {
                    sBitmap += "h";
                }

                for (int i = 0; i < 32; i++)
                {
                    bitmap += sBitmap[i];
                    if (i == 7 || i == 15 || i == 23)
                    {
                        bitmap += ".";
                    }
                }
            }
            textBoxSubnetBitmap.Text = bitmap;
        }

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
                if (i != 3)
                {
                    str += HexText + ".";
                }
                else
                {
                    str += HexText;
                }
            }
            textBoxHexIPAddress.Text = str;
        }
        private void maskToWildcard()
        {
            if(isLoaded)
            {
                wildcardS1Mask = comboBoxSubnetMask.Text;
                wildcardS2Mask = wildcardS1Mask.Split('.');
                wildcardIMask = Array.ConvertAll(wildcardS2Mask, s => int.Parse(s));
                for (int i = 0; i < 4; i++)
                {
                    wildcardIMask2[i] = wildcardIMask1[i] - wildcardIMask[i];
                }
                wildcardMaskCopy = wildcardIMask2.Select(x => x.ToString()).ToArray();
                textBoxWildcardMask.Text = String.Join(".", wildcardMaskCopy);
            }
        }

        public void onUpdateOperation()
        {
            ipS1Value = textBoxIpAdress.Text;
            ipS2Value = ipS1Value.Split('.');

            if (!isIpOk())
                return;
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

                    subnetIdCopy = subnetId.Select(x => x.ToString()).ToArray();

                    addressRange1 = subnetId;
                    addressRange1[3] += 1;

                    addressRange1Copy = addressRange1.Select(x => x.ToString()).ToArray();

                    broadcast[1] = 255;
                    broadcast[2] = 255;
                    broadcast[3] = wildcardIMask2[3];

                    broadcastCopy = broadcast.Select(x => x.ToString()).ToArray();

                    addressRange2 = broadcast;
                    addressRange1[3] -= 1;

                    addressRange2Copy = addressRange2.Select(x => x.ToString()).ToArray();

                    textBoxSubnetID.Text = String.Join(".", subnetIdCopy);
                    textBoxBroadcastAddress.Text = String.Join(".", broadcastCopy);
                    textBoxHostAddressRange.Text = String.Join(".", addressRange1Copy) + " - " + String.Join(".", addressRange2Copy);

                    maskToWildcard();
                    IpToHex();
                }
                else
                {
                    radioButtonChangeValues(1);
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
                    broadcast[3] = wildcardIMask2[3];

                    broadcastCopy = broadcast.Select(x => x.ToString()).ToArray();

                    addressRange2 = broadcast;
                    addressRange1[3] -= 1;

                    addressRange2Copy = addressRange2.Select(x => x.ToString()).ToArray();

                    textBoxSubnetID.Text = String.Join(".", subnetIdCopy);
                    textBoxBroadcastAddress.Text = String.Join(".", broadcastCopy);
                    textBoxHostAddressRange.Text = String.Join(".", addressRange1Copy) + " - " + String.Join(".", addressRange2Copy);

                    maskToWildcard();
                    IpToHex();
                }
                else
                {
                    radioButtonChangeValues(2);
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

                    broadcast[3] = wildcardIMask2[3];

                    broadcastCopy = broadcast.Select(x => x.ToString()).ToArray();

                    addressRange2 = broadcast;
                    addressRange1[3] -= 1;

                    addressRange2Copy = addressRange2.Select(x => x.ToString()).ToArray();

                    textBoxSubnetID.Text = String.Join(".", subnetIdCopy);
                    textBoxBroadcastAddress.Text = String.Join(".", broadcastCopy);
                    textBoxHostAddressRange.Text = String.Join(".", addressRange1Copy) + " - " + String.Join(".", addressRange2Copy);

                    maskToWildcard();
                    IpToHex();
                }
                else
                {
                    radioButtonChangeValues(3);
                    radioButton3.Checked = true;
                }
            }
            subnetBitmap();
        }
        #endregion
        #region [miscFunctions]
        //Unused funtions that can't be deleted
        #endregion
        #region [valueChangedFunctions]
        //Most of the xChanged functions, if xChanged function is not here it's because it's in it's respectable region
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonChangeValues(1);
            isLoaded = false;
            createAndClearComboBoxes(1, ref isLoaded);
            onUpdateOperation();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonChangeValues(2);
            isLoaded = false;
            createAndClearComboBoxes(2, ref isLoaded);
            onUpdateOperation();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonChangeValues(3);
            isLoaded = false;
            createAndClearComboBoxes(3, ref isLoaded);
            onUpdateOperation();
        }

        private void textBoxIpAdress_TextChanged(object sender,EventArgs e)
        {
            if(isIpOk())
            {
                onUpdateOperation();
            }
        }
        #endregion

    }


}
