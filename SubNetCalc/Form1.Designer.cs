
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
            this.A = new System.Windows.Forms.RadioButton();
            this.B = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IPAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SubnetMask = new System.Windows.Forms.ComboBox();
            this.SubnetBits = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MinimumSubnet = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.HostPerSubnet = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.MaskBits = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.WildcartMask = new System.Windows.Forms.TextBox();
            this.HexIPAddress = new System.Windows.Forms.TextBox();
            this.FirstOctetRange = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.SubnetID = new System.Windows.Forms.TextBox();
            this.BroadcastAddress = new System.Windows.Forms.TextBox();
            this.HostAddresRange = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.HostAddressRange = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Location = new System.Drawing.Point(35, 59);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(14, 13);
            this.A.TabIndex = 0;
            this.A.TabStop = true;
            this.A.UseVisualStyleBackColor = true;
            this.A.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Location = new System.Drawing.Point(73, 59);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(14, 13);
            this.B.TabIndex = 1;
            this.B.TabStop = true;
            this.B.UseVisualStyleBackColor = true;
            this.B.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Network Class";
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Location = new System.Drawing.Point(113, 59);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(14, 13);
            this.C.TabIndex = 3;
            this.C.TabStop = true;
            this.C.UseVisualStyleBackColor = true;
            this.C.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "A";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "C";
            // 
            // IPAddress
            // 
            this.IPAddress.Location = new System.Drawing.Point(18, 107);
            this.IPAddress.Name = "IPAddress";
            this.IPAddress.Size = new System.Drawing.Size(190, 20);
            this.IPAddress.TabIndex = 7;
            this.IPAddress.TextChanged += new System.EventHandler(this.IPAddress_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "IP Adress";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Subnet Mask";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // SubnetMask
            // 
            this.SubnetMask.FormattingEnabled = true;
            this.SubnetMask.Location = new System.Drawing.Point(18, 159);
            this.SubnetMask.Name = "SubnetMask";
            this.SubnetMask.Size = new System.Drawing.Size(190, 21);
            this.SubnetMask.TabIndex = 10;
            this.SubnetMask.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // SubnetBits
            // 
            this.SubnetBits.FormattingEnabled = true;
            this.SubnetBits.Location = new System.Drawing.Point(16, 216);
            this.SubnetBits.Name = "SubnetBits";
            this.SubnetBits.Size = new System.Drawing.Size(190, 21);
            this.SubnetBits.TabIndex = 12;
            this.SubnetBits.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Subnet Bits";
            // 
            // MinimumSubnet
            // 
            this.MinimumSubnet.FormattingEnabled = true;
            this.MinimumSubnet.Location = new System.Drawing.Point(16, 270);
            this.MinimumSubnet.Name = "MinimumSubnet";
            this.MinimumSubnet.Size = new System.Drawing.Size(190, 21);
            this.MinimumSubnet.TabIndex = 14;
            this.MinimumSubnet.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Minimum Subnet";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(267, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "First Octet Range";
            // 
            // HostPerSubnet
            // 
            this.HostPerSubnet.FormattingEnabled = true;
            this.HostPerSubnet.Location = new System.Drawing.Point(270, 270);
            this.HostPerSubnet.Name = "HostPerSubnet";
            this.HostPerSubnet.Size = new System.Drawing.Size(190, 21);
            this.HostPerSubnet.TabIndex = 18;
            this.HostPerSubnet.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(269, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Hosts per Subnet";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(267, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Hex IP Address";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(269, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Wildcard Mask";
            // 
            // MaskBits
            // 
            this.MaskBits.FormattingEnabled = true;
            this.MaskBits.Location = new System.Drawing.Point(270, 216);
            this.MaskBits.Name = "MaskBits";
            this.MaskBits.Size = new System.Drawing.Size(190, 21);
            this.MaskBits.TabIndex = 24;
            this.MaskBits.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(269, 200);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Mask Bits";
            // 
            // WildcartMask
            // 
            this.WildcartMask.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.WildcartMask.Location = new System.Drawing.Point(270, 160);
            this.WildcartMask.Name = "WildcartMask";
            this.WildcartMask.Size = new System.Drawing.Size(190, 20);
            this.WildcartMask.TabIndex = 25;
            this.WildcartMask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WildcartMask.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // HexIPAddress
            // 
            this.HexIPAddress.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.HexIPAddress.Location = new System.Drawing.Point(270, 107);
            this.HexIPAddress.Name = "HexIPAddress";
            this.HexIPAddress.Size = new System.Drawing.Size(190, 20);
            this.HexIPAddress.TabIndex = 26;
            this.HexIPAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HexIPAddress.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // FirstOctetRange
            // 
            this.FirstOctetRange.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.FirstOctetRange.Location = new System.Drawing.Point(270, 56);
            this.FirstOctetRange.Name = "FirstOctetRange";
            this.FirstOctetRange.Size = new System.Drawing.Size(190, 20);
            this.FirstOctetRange.TabIndex = 27;
            this.FirstOctetRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FirstOctetRange.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(269, 361);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Broadcast Address";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 361);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Subnet ID";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 307);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "Host Address Range";
            // 
            // SubnetID
            // 
            this.SubnetID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.SubnetID.Location = new System.Drawing.Point(16, 377);
            this.SubnetID.Name = "SubnetID";
            this.SubnetID.Size = new System.Drawing.Size(190, 20);
            this.SubnetID.TabIndex = 33;
            this.SubnetID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SubnetID.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // BroadcastAddress
            // 
            this.BroadcastAddress.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BroadcastAddress.Location = new System.Drawing.Point(270, 377);
            this.BroadcastAddress.Name = "BroadcastAddress";
            this.BroadcastAddress.Size = new System.Drawing.Size(190, 20);
            this.BroadcastAddress.TabIndex = 34;
            this.BroadcastAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BroadcastAddress.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // HostAddresRange
            // 
            this.HostAddresRange.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.HostAddresRange.Location = new System.Drawing.Point(16, 323);
            this.HostAddresRange.Name = "HostAddresRange";
            this.HostAddresRange.Size = new System.Drawing.Size(444, 20);
            this.HostAddresRange.TabIndex = 35;
            this.HostAddresRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HostAddresRange.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 412);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "Host Address Range";
            // 
            // HostAddressRange
            // 
            this.HostAddressRange.Location = new System.Drawing.Point(12, 428);
            this.HostAddressRange.Name = "HostAddressRange";
            this.HostAddressRange.Size = new System.Drawing.Size(448, 20);
            this.HostAddressRange.TabIndex = 37;
            this.HostAddressRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HostAddressRange.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(117, 487);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(240, 13);
            this.label18.TabIndex = 38;
            this.label18.Text = "BY: Igor Kiełbus Kacper Kachel Marcin Majborski";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(517, 509);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.HostAddressRange);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.HostAddresRange);
            this.Controls.Add(this.BroadcastAddress);
            this.Controls.Add(this.SubnetID);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.FirstOctetRange);
            this.Controls.Add(this.HexIPAddress);
            this.Controls.Add(this.WildcartMask);
            this.Controls.Add(this.MaskBits);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.HostPerSubnet);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.MinimumSubnet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SubnetBits);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SubnetMask);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IPAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.C);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Name = "Form1";
            this.Text = "Subnet Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton A;
        private System.Windows.Forms.RadioButton B;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton C;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IPAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox SubnetMask;
        private System.Windows.Forms.ComboBox SubnetBits;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox MinimumSubnet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox HostPerSubnet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox MaskBits;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox WildcartMask;
        private System.Windows.Forms.TextBox HexIPAddress;
        private System.Windows.Forms.TextBox FirstOctetRange;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox SubnetID;
        private System.Windows.Forms.TextBox BroadcastAddress;
        private System.Windows.Forms.TextBox HostAddresRange;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox HostAddressRange;
        private System.Windows.Forms.Label label18;
    }
}

