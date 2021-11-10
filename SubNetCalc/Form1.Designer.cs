
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IPAddressTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SubnetMaskComboBox = new System.Windows.Forms.ComboBox();
            this.SubnetBitsComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MinimumSubnetComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.HostPerSubnetComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.MaskBitsComboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.WildcartMaskTextBox = new System.Windows.Forms.TextBox();
            this.HexIPAddressTextBox = new System.Windows.Forms.TextBox();
            this.FirstOctetRangeTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.SubnetIDTextBox = new System.Windows.Forms.TextBox();
            this.BroadcastAddressTextBox = new System.Windows.Forms.TextBox();
            this.HostAddresRangeTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.HostAddressRangeTextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(35, 59);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(73, 59);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
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
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(113, 59);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(14, 13);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
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
            // IPAddressTextBox
            // 
            this.IPAddressTextBox.Location = new System.Drawing.Point(18, 107);
            this.IPAddressTextBox.Name = "IPAddressTextBox";
            this.IPAddressTextBox.Size = new System.Drawing.Size(190, 20);
            this.IPAddressTextBox.TabIndex = 7;
            this.IPAddressTextBox.TextChanged += new System.EventHandler(this.IPAddress_TextChanged);
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
            // SubnetMaskComboBox
            // 
            this.SubnetMaskComboBox.FormattingEnabled = true;
            this.SubnetMaskComboBox.Location = new System.Drawing.Point(18, 159);
            this.SubnetMaskComboBox.Name = "SubnetMaskComboBox";
            this.SubnetMaskComboBox.Size = new System.Drawing.Size(190, 21);
            this.SubnetMaskComboBox.TabIndex = 10;
            this.SubnetMaskComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // SubnetBitsComboBox
            // 
            this.SubnetBitsComboBox.FormattingEnabled = true;
            this.SubnetBitsComboBox.Location = new System.Drawing.Point(16, 216);
            this.SubnetBitsComboBox.Name = "SubnetBitsComboBox";
            this.SubnetBitsComboBox.Size = new System.Drawing.Size(190, 21);
            this.SubnetBitsComboBox.TabIndex = 12;
            this.SubnetBitsComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
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
            // MinimumSubnetComboBox
            // 
            this.MinimumSubnetComboBox.FormattingEnabled = true;
            this.MinimumSubnetComboBox.Location = new System.Drawing.Point(16, 270);
            this.MinimumSubnetComboBox.Name = "MinimumSubnetComboBox";
            this.MinimumSubnetComboBox.Size = new System.Drawing.Size(190, 21);
            this.MinimumSubnetComboBox.TabIndex = 14;
            this.MinimumSubnetComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
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
            // HostPerSubnetComboBox
            // 
            this.HostPerSubnetComboBox.FormattingEnabled = true;
            this.HostPerSubnetComboBox.Location = new System.Drawing.Point(270, 270);
            this.HostPerSubnetComboBox.Name = "HostPerSubnetComboBox";
            this.HostPerSubnetComboBox.Size = new System.Drawing.Size(190, 21);
            this.HostPerSubnetComboBox.TabIndex = 18;
            this.HostPerSubnetComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
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
            // MaskBitsComboBox
            // 
            this.MaskBitsComboBox.FormattingEnabled = true;
            this.MaskBitsComboBox.Location = new System.Drawing.Point(270, 216);
            this.MaskBitsComboBox.Name = "MaskBitsComboBox";
            this.MaskBitsComboBox.Size = new System.Drawing.Size(190, 21);
            this.MaskBitsComboBox.TabIndex = 24;
            this.MaskBitsComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
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
            // WildcartMaskTextBox
            // 
            this.WildcartMaskTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.WildcartMaskTextBox.Location = new System.Drawing.Point(270, 160);
            this.WildcartMaskTextBox.Name = "WildcartMaskTextBox";
            this.WildcartMaskTextBox.ReadOnly = true;
            this.WildcartMaskTextBox.Size = new System.Drawing.Size(190, 20);
            this.WildcartMaskTextBox.TabIndex = 25;
            this.WildcartMaskTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WildcartMaskTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // HexIPAddressTextBox
            // 
            this.HexIPAddressTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.HexIPAddressTextBox.Location = new System.Drawing.Point(270, 107);
            this.HexIPAddressTextBox.Name = "HexIPAddressTextBox";
            this.HexIPAddressTextBox.ReadOnly = true;
            this.HexIPAddressTextBox.Size = new System.Drawing.Size(190, 20);
            this.HexIPAddressTextBox.TabIndex = 26;
            this.HexIPAddressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HexIPAddressTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // FirstOctetRangeTextBox
            // 
            this.FirstOctetRangeTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.FirstOctetRangeTextBox.Location = new System.Drawing.Point(270, 56);
            this.FirstOctetRangeTextBox.Name = "FirstOctetRangeTextBox";
            this.FirstOctetRangeTextBox.ReadOnly = true;
            this.FirstOctetRangeTextBox.Size = new System.Drawing.Size(190, 20);
            this.FirstOctetRangeTextBox.TabIndex = 27;
            this.FirstOctetRangeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FirstOctetRangeTextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
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
            // SubnetIDTextBox
            // 
            this.SubnetIDTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.SubnetIDTextBox.Location = new System.Drawing.Point(16, 377);
            this.SubnetIDTextBox.Name = "SubnetIDTextBox";
            this.SubnetIDTextBox.ReadOnly = true;
            this.SubnetIDTextBox.Size = new System.Drawing.Size(190, 20);
            this.SubnetIDTextBox.TabIndex = 33;
            this.SubnetIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SubnetIDTextBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // BroadcastAddressTextBox
            // 
            this.BroadcastAddressTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BroadcastAddressTextBox.Location = new System.Drawing.Point(270, 377);
            this.BroadcastAddressTextBox.Name = "BroadcastAddressTextBox";
            this.BroadcastAddressTextBox.ReadOnly = true;
            this.BroadcastAddressTextBox.Size = new System.Drawing.Size(190, 20);
            this.BroadcastAddressTextBox.TabIndex = 34;
            this.BroadcastAddressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BroadcastAddressTextBox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // HostAddresRangeTextBox
            // 
            this.HostAddresRangeTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.HostAddresRangeTextBox.Location = new System.Drawing.Point(16, 323);
            this.HostAddresRangeTextBox.Name = "HostAddresRangeTextBox";
            this.HostAddresRangeTextBox.ReadOnly = true;
            this.HostAddresRangeTextBox.Size = new System.Drawing.Size(444, 20);
            this.HostAddresRangeTextBox.TabIndex = 35;
            this.HostAddresRangeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HostAddresRangeTextBox.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
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
            // HostAddressRangeTextBox
            // 
            this.HostAddressRangeTextBox.Location = new System.Drawing.Point(12, 428);
            this.HostAddressRangeTextBox.Name = "HostAddressRangeTextBox";
            this.HostAddressRangeTextBox.ReadOnly = true;
            this.HostAddressRangeTextBox.Size = new System.Drawing.Size(448, 20);
            this.HostAddressRangeTextBox.TabIndex = 37;
            this.HostAddressRangeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HostAddressRangeTextBox.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
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
            this.Controls.Add(this.HostAddressRangeTextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.HostAddresRangeTextBox);
            this.Controls.Add(this.BroadcastAddressTextBox);
            this.Controls.Add(this.SubnetIDTextBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.FirstOctetRangeTextBox);
            this.Controls.Add(this.HexIPAddressTextBox);
            this.Controls.Add(this.WildcartMaskTextBox);
            this.Controls.Add(this.MaskBitsComboBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.HostPerSubnetComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.MinimumSubnetComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SubnetBitsComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SubnetMaskComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IPAddressTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Name = "Form1";
            this.Text = "Subnet Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IPAddressTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox SubnetMaskComboBox;
        private System.Windows.Forms.ComboBox SubnetBitsComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox MinimumSubnetComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox HostPerSubnetComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox MaskBitsComboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox WildcartMaskTextBox;
        private System.Windows.Forms.TextBox HexIPAddressTextBox;
        private System.Windows.Forms.TextBox FirstOctetRangeTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox SubnetIDTextBox;
        private System.Windows.Forms.TextBox BroadcastAddressTextBox;
        private System.Windows.Forms.TextBox HostAddresRangeTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox HostAddressRangeTextBox;
        private System.Windows.Forms.Label label18;
    }
}

