
namespace SubNetCalc
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelRadioButtons = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.labelToWildcardMask = new System.Windows.Forms.Label();
            this.textBoxWildcardMask = new System.Windows.Forms.TextBox();
            this.labelToSubnetMask = new System.Windows.Forms.Label();
            this.labelToSubnetBits = new System.Windows.Forms.Label();
            this.comboBoxSubnetMask = new System.Windows.Forms.ComboBox();
            this.comboBoxSubnetBits = new System.Windows.Forms.ComboBox();
            this.labelToMinimumSubnets = new System.Windows.Forms.Label();
            this.comboBoxMinimumSubnets = new System.Windows.Forms.ComboBox();
            this.labelHostAddressRange = new System.Windows.Forms.Label();
            this.textBoxHostAddressRange = new System.Windows.Forms.TextBox();
            this.labelToSubnetID = new System.Windows.Forms.Label();
            this.textBoxSubnetID = new System.Windows.Forms.TextBox();
            this.labelToSubnetBitmap = new System.Windows.Forms.Label();
            this.textBoxSubnetBitmap = new System.Windows.Forms.TextBox();
            this.comboBoxHostsPerSubnet = new System.Windows.Forms.ComboBox();
            this.labelToHostsPerSubnet = new System.Windows.Forms.Label();
            this.comboBoxMaskBits = new System.Windows.Forms.ComboBox();
            this.labelToMaskBits = new System.Windows.Forms.Label();
            this.textBoxIpAdress = new System.Windows.Forms.TextBox();
            this.labelToIPAddress = new System.Windows.Forms.Label();
            this.textBoxHexIPAddress = new System.Windows.Forms.TextBox();
            this.labelToHexIPAddress = new System.Windows.Forms.Label();
            this.textBoxFirstOctetRange = new System.Windows.Forms.TextBox();
            this.labelToFirstOctetRange = new System.Windows.Forms.Label();
            this.textBoxBroadcastAddress = new System.Windows.Forms.TextBox();
            this.labelToBroadcastAddress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelRadioButtons
            // 
            this.labelRadioButtons.AutoSize = true;
            this.labelRadioButtons.Location = new System.Drawing.Point(12, 19);
            this.labelRadioButtons.Name = "labelRadioButtons";
            this.labelRadioButtons.Size = new System.Drawing.Size(75, 13);
            this.labelRadioButtons.TabIndex = 0;
            this.labelRadioButtons.Text = "Network Class";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 35);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(32, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "A";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(51, 35);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(32, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "B";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(90, 35);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(32, 17);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "C";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // labelToWildcardMask
            // 
            this.labelToWildcardMask.AutoSize = true;
            this.labelToWildcardMask.Location = new System.Drawing.Point(290, 128);
            this.labelToWildcardMask.Name = "labelToWildcardMask";
            this.labelToWildcardMask.Size = new System.Drawing.Size(78, 13);
            this.labelToWildcardMask.TabIndex = 4;
            this.labelToWildcardMask.Text = "Wildcard Mask";
            // 
            // textBoxWildcardMask
            // 
            this.textBoxWildcardMask.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBoxWildcardMask.Location = new System.Drawing.Point(290, 144);
            this.textBoxWildcardMask.Name = "textBoxWildcardMask";
            this.textBoxWildcardMask.ReadOnly = true;
            this.textBoxWildcardMask.Size = new System.Drawing.Size(207, 20);
            this.textBoxWildcardMask.TabIndex = 5;
            // 
            // labelToSubnetMask
            // 
            this.labelToSubnetMask.AutoSize = true;
            this.labelToSubnetMask.Location = new System.Drawing.Point(12, 128);
            this.labelToSubnetMask.Name = "labelToSubnetMask";
            this.labelToSubnetMask.Size = new System.Drawing.Size(70, 13);
            this.labelToSubnetMask.TabIndex = 8;
            this.labelToSubnetMask.Text = "Subnet Mask";
            // 
            // labelToSubnetBits
            // 
            this.labelToSubnetBits.AutoSize = true;
            this.labelToSubnetBits.Location = new System.Drawing.Point(12, 181);
            this.labelToSubnetBits.Name = "labelToSubnetBits";
            this.labelToSubnetBits.Size = new System.Drawing.Size(61, 13);
            this.labelToSubnetBits.TabIndex = 9;
            this.labelToSubnetBits.Text = "Subnet Bits";
            // 
            // comboBoxSubnetMask
            // 
            this.comboBoxSubnetMask.FormattingEnabled = true;
            this.comboBoxSubnetMask.Location = new System.Drawing.Point(12, 144);
            this.comboBoxSubnetMask.Name = "comboBoxSubnetMask";
            this.comboBoxSubnetMask.Size = new System.Drawing.Size(207, 21);
            this.comboBoxSubnetMask.TabIndex = 10;
            // 
            // comboBoxSubnetBits
            // 
            this.comboBoxSubnetBits.FormattingEnabled = true;
            this.comboBoxSubnetBits.Location = new System.Drawing.Point(12, 197);
            this.comboBoxSubnetBits.Name = "comboBoxSubnetBits";
            this.comboBoxSubnetBits.Size = new System.Drawing.Size(207, 21);
            this.comboBoxSubnetBits.TabIndex = 11;
            // 
            // labelToMinimumSubnets
            // 
            this.labelToMinimumSubnets.AutoSize = true;
            this.labelToMinimumSubnets.Location = new System.Drawing.Point(12, 234);
            this.labelToMinimumSubnets.Name = "labelToMinimumSubnets";
            this.labelToMinimumSubnets.Size = new System.Drawing.Size(90, 13);
            this.labelToMinimumSubnets.TabIndex = 12;
            this.labelToMinimumSubnets.Text = "Minimum Subnets";
            // 
            // comboBoxMinimumSubnets
            // 
            this.comboBoxMinimumSubnets.FormattingEnabled = true;
            this.comboBoxMinimumSubnets.Location = new System.Drawing.Point(12, 250);
            this.comboBoxMinimumSubnets.Name = "comboBoxMinimumSubnets";
            this.comboBoxMinimumSubnets.Size = new System.Drawing.Size(207, 21);
            this.comboBoxMinimumSubnets.TabIndex = 13;
            // 
            // labelHostAddressRange
            // 
            this.labelHostAddressRange.AutoSize = true;
            this.labelHostAddressRange.Location = new System.Drawing.Point(12, 289);
            this.labelHostAddressRange.Name = "labelHostAddressRange";
            this.labelHostAddressRange.Size = new System.Drawing.Size(105, 13);
            this.labelHostAddressRange.TabIndex = 14;
            this.labelHostAddressRange.Text = "Host Address Range";
            // 
            // textBoxHostAddressRange
            // 
            this.textBoxHostAddressRange.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBoxHostAddressRange.Location = new System.Drawing.Point(12, 305);
            this.textBoxHostAddressRange.Name = "textBoxHostAddressRange";
            this.textBoxHostAddressRange.ReadOnly = true;
            this.textBoxHostAddressRange.Size = new System.Drawing.Size(485, 20);
            this.textBoxHostAddressRange.TabIndex = 15;
            // 
            // labelToSubnetID
            // 
            this.labelToSubnetID.AutoSize = true;
            this.labelToSubnetID.Location = new System.Drawing.Point(12, 342);
            this.labelToSubnetID.Name = "labelToSubnetID";
            this.labelToSubnetID.Size = new System.Drawing.Size(55, 13);
            this.labelToSubnetID.TabIndex = 16;
            this.labelToSubnetID.Text = "Subnet ID";
            // 
            // textBoxSubnetID
            // 
            this.textBoxSubnetID.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBoxSubnetID.Location = new System.Drawing.Point(12, 358);
            this.textBoxSubnetID.Name = "textBoxSubnetID";
            this.textBoxSubnetID.ReadOnly = true;
            this.textBoxSubnetID.Size = new System.Drawing.Size(207, 20);
            this.textBoxSubnetID.TabIndex = 17;
            // 
            // labelToSubnetBitmap
            // 
            this.labelToSubnetBitmap.AutoSize = true;
            this.labelToSubnetBitmap.Location = new System.Drawing.Point(12, 393);
            this.labelToSubnetBitmap.Name = "labelToSubnetBitmap";
            this.labelToSubnetBitmap.Size = new System.Drawing.Size(76, 13);
            this.labelToSubnetBitmap.TabIndex = 18;
            this.labelToSubnetBitmap.Text = "Subnet Bitmap";
            // 
            // textBoxSubnetBitmap
            // 
            this.textBoxSubnetBitmap.Location = new System.Drawing.Point(12, 409);
            this.textBoxSubnetBitmap.Name = "textBoxSubnetBitmap";
            this.textBoxSubnetBitmap.ReadOnly = true;
            this.textBoxSubnetBitmap.Size = new System.Drawing.Size(485, 20);
            this.textBoxSubnetBitmap.TabIndex = 19;
            // 
            // comboBoxHostsPerSubnet
            // 
            this.comboBoxHostsPerSubnet.FormattingEnabled = true;
            this.comboBoxHostsPerSubnet.Location = new System.Drawing.Point(290, 250);
            this.comboBoxHostsPerSubnet.Name = "comboBoxHostsPerSubnet";
            this.comboBoxHostsPerSubnet.Size = new System.Drawing.Size(207, 21);
            this.comboBoxHostsPerSubnet.TabIndex = 23;
            // 
            // labelToHostsPerSubnet
            // 
            this.labelToHostsPerSubnet.AutoSize = true;
            this.labelToHostsPerSubnet.Location = new System.Drawing.Point(290, 234);
            this.labelToHostsPerSubnet.Name = "labelToHostsPerSubnet";
            this.labelToHostsPerSubnet.Size = new System.Drawing.Size(89, 13);
            this.labelToHostsPerSubnet.TabIndex = 22;
            this.labelToHostsPerSubnet.Text = "Hosts per Subnet";
            // 
            // comboBoxMaskBits
            // 
            this.comboBoxMaskBits.FormattingEnabled = true;
            this.comboBoxMaskBits.Location = new System.Drawing.Point(290, 197);
            this.comboBoxMaskBits.Name = "comboBoxMaskBits";
            this.comboBoxMaskBits.Size = new System.Drawing.Size(207, 21);
            this.comboBoxMaskBits.TabIndex = 21;
            // 
            // labelToMaskBits
            // 
            this.labelToMaskBits.AutoSize = true;
            this.labelToMaskBits.Location = new System.Drawing.Point(290, 181);
            this.labelToMaskBits.Name = "labelToMaskBits";
            this.labelToMaskBits.Size = new System.Drawing.Size(53, 13);
            this.labelToMaskBits.TabIndex = 20;
            this.labelToMaskBits.Text = "Mask Bits";
            // 
            // textBoxIpAdress
            // 
            this.textBoxIpAdress.Location = new System.Drawing.Point(12, 85);
            this.textBoxIpAdress.Name = "textBoxIpAdress";
            this.textBoxIpAdress.Size = new System.Drawing.Size(207, 20);
            this.textBoxIpAdress.TabIndex = 25;
            this.textBoxIpAdress.TextChanged += new System.EventHandler(this.textBoxIpAdress_TextChanged);
            // 
            // labelToIPAddress
            // 
            this.labelToIPAddress.AutoSize = true;
            this.labelToIPAddress.Location = new System.Drawing.Point(12, 69);
            this.labelToIPAddress.Name = "labelToIPAddress";
            this.labelToIPAddress.Size = new System.Drawing.Size(58, 13);
            this.labelToIPAddress.TabIndex = 24;
            this.labelToIPAddress.Text = "IP Address";
            // 
            // textBoxHexIPAddress
            // 
            this.textBoxHexIPAddress.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBoxHexIPAddress.Location = new System.Drawing.Point(290, 85);
            this.textBoxHexIPAddress.Name = "textBoxHexIPAddress";
            this.textBoxHexIPAddress.ReadOnly = true;
            this.textBoxHexIPAddress.Size = new System.Drawing.Size(207, 20);
            this.textBoxHexIPAddress.TabIndex = 27;
            // 
            // labelToHexIPAddress
            // 
            this.labelToHexIPAddress.AutoSize = true;
            this.labelToHexIPAddress.Location = new System.Drawing.Point(290, 69);
            this.labelToHexIPAddress.Name = "labelToHexIPAddress";
            this.labelToHexIPAddress.Size = new System.Drawing.Size(80, 13);
            this.labelToHexIPAddress.TabIndex = 26;
            this.labelToHexIPAddress.Text = "Hex IP Address";
            // 
            // textBoxFirstOctetRange
            // 
            this.textBoxFirstOctetRange.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBoxFirstOctetRange.Location = new System.Drawing.Point(290, 34);
            this.textBoxFirstOctetRange.Name = "textBoxFirstOctetRange";
            this.textBoxFirstOctetRange.ReadOnly = true;
            this.textBoxFirstOctetRange.Size = new System.Drawing.Size(207, 20);
            this.textBoxFirstOctetRange.TabIndex = 29;
            this.textBoxFirstOctetRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelToFirstOctetRange
            // 
            this.labelToFirstOctetRange.AutoSize = true;
            this.labelToFirstOctetRange.Location = new System.Drawing.Point(290, 18);
            this.labelToFirstOctetRange.Name = "labelToFirstOctetRange";
            this.labelToFirstOctetRange.Size = new System.Drawing.Size(90, 13);
            this.labelToFirstOctetRange.TabIndex = 28;
            this.labelToFirstOctetRange.Text = "First Octet Range";
            // 
            // textBoxBroadcastAddress
            // 
            this.textBoxBroadcastAddress.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBoxBroadcastAddress.Location = new System.Drawing.Point(290, 358);
            this.textBoxBroadcastAddress.Name = "textBoxBroadcastAddress";
            this.textBoxBroadcastAddress.ReadOnly = true;
            this.textBoxBroadcastAddress.Size = new System.Drawing.Size(207, 20);
            this.textBoxBroadcastAddress.TabIndex = 31;
            // 
            // labelToBroadcastAddress
            // 
            this.labelToBroadcastAddress.AutoSize = true;
            this.labelToBroadcastAddress.Location = new System.Drawing.Point(290, 342);
            this.labelToBroadcastAddress.Name = "labelToBroadcastAddress";
            this.labelToBroadcastAddress.Size = new System.Drawing.Size(96, 13);
            this.labelToBroadcastAddress.TabIndex = 30;
            this.labelToBroadcastAddress.Text = "Broadcast Address";
            // 
            // Form1
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(509, 644);
            this.Controls.Add(this.textBoxBroadcastAddress);
            this.Controls.Add(this.labelToBroadcastAddress);
            this.Controls.Add(this.textBoxFirstOctetRange);
            this.Controls.Add(this.labelToFirstOctetRange);
            this.Controls.Add(this.textBoxHexIPAddress);
            this.Controls.Add(this.labelToHexIPAddress);
            this.Controls.Add(this.textBoxIpAdress);
            this.Controls.Add(this.labelToIPAddress);
            this.Controls.Add(this.comboBoxHostsPerSubnet);
            this.Controls.Add(this.labelToHostsPerSubnet);
            this.Controls.Add(this.comboBoxMaskBits);
            this.Controls.Add(this.labelToMaskBits);
            this.Controls.Add(this.textBoxSubnetBitmap);
            this.Controls.Add(this.labelToSubnetBitmap);
            this.Controls.Add(this.textBoxSubnetID);
            this.Controls.Add(this.labelToSubnetID);
            this.Controls.Add(this.textBoxHostAddressRange);
            this.Controls.Add(this.labelHostAddressRange);
            this.Controls.Add(this.comboBoxMinimumSubnets);
            this.Controls.Add(this.labelToMinimumSubnets);
            this.Controls.Add(this.comboBoxSubnetBits);
            this.Controls.Add(this.comboBoxSubnetMask);
            this.Controls.Add(this.labelToSubnetBits);
            this.Controls.Add(this.labelToSubnetMask);
            this.Controls.Add(this.textBoxWildcardMask);
            this.Controls.Add(this.labelToWildcardMask);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.labelRadioButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subnet Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRadioButtons;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label labelToWildcardMask;
        private System.Windows.Forms.TextBox textBoxWildcardMask;
        private System.Windows.Forms.Label labelToSubnetMask;
        private System.Windows.Forms.Label labelToSubnetBits;
        private System.Windows.Forms.ComboBox comboBoxSubnetMask;
        private System.Windows.Forms.ComboBox comboBoxSubnetBits;
        private System.Windows.Forms.Label labelToMinimumSubnets;
        private System.Windows.Forms.ComboBox comboBoxMinimumSubnets;
        private System.Windows.Forms.Label labelHostAddressRange;
        private System.Windows.Forms.TextBox textBoxHostAddressRange;
        private System.Windows.Forms.Label labelToSubnetID;
        private System.Windows.Forms.TextBox textBoxSubnetID;
        private System.Windows.Forms.Label labelToSubnetBitmap;
        private System.Windows.Forms.TextBox textBoxSubnetBitmap;
        private System.Windows.Forms.ComboBox comboBoxHostsPerSubnet;
        private System.Windows.Forms.Label labelToHostsPerSubnet;
        private System.Windows.Forms.ComboBox comboBoxMaskBits;
        private System.Windows.Forms.Label labelToMaskBits;
        private System.Windows.Forms.TextBox textBoxIpAdress;
        private System.Windows.Forms.Label labelToIPAddress;
        private System.Windows.Forms.TextBox textBoxHexIPAddress;
        private System.Windows.Forms.Label labelToHexIPAddress;
        private System.Windows.Forms.TextBox textBoxFirstOctetRange;
        private System.Windows.Forms.Label labelToFirstOctetRange;
        private System.Windows.Forms.TextBox textBoxBroadcastAddress;
        private System.Windows.Forms.Label labelToBroadcastAddress;
    }
}

