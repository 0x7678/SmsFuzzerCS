namespace SmsFuzzerCS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.combo_serial_ports = new System.Windows.Forms.ComboBox();
            this.combo_sms_type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_target = new System.Windows.Forms.TextBox();
            this.text_sms = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_delreport = new System.Windows.Forms.CheckBox();
            this.btnpdumode = new System.Windows.Forms.Button();
            this.btn2g = new System.Windows.Forms.Button();
            this.btnsend = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.text_debug = new System.Windows.Forms.TextBox();
            this.btnopen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Com Port";
            // 
            // combo_serial_ports
            // 
            this.combo_serial_ports.FormattingEnabled = true;
            this.combo_serial_ports.Location = new System.Drawing.Point(54, 4);
            this.combo_serial_ports.Name = "combo_serial_ports";
            this.combo_serial_ports.Size = new System.Drawing.Size(121, 21);
            this.combo_serial_ports.TabIndex = 1;
            // 
            // combo_sms_type
            // 
            this.combo_sms_type.FormattingEnabled = true;
            this.combo_sms_type.Items.AddRange(new object[] {
            "NORMAL",
            "FLASH",
            "SILENT",
            "VOICEMAIL"});
            this.combo_sms_type.Location = new System.Drawing.Point(54, 54);
            this.combo_sms_type.Name = "combo_sms_type";
            this.combo_sms_type.Size = new System.Drawing.Size(121, 21);
            this.combo_sms_type.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sms type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Target";
            // 
            // text_target
            // 
            this.text_target.Location = new System.Drawing.Point(54, 77);
            this.text_target.Name = "text_target";
            this.text_target.Size = new System.Drawing.Size(121, 20);
            this.text_target.TabIndex = 5;
            this.text_target.Text = "123456789012";
            // 
            // text_sms
            // 
            this.text_sms.Location = new System.Drawing.Point(54, 100);
            this.text_sms.Multiline = true;
            this.text_sms.Name = "text_sms";
            this.text_sms.Size = new System.Drawing.Size(121, 72);
            this.text_sms.TabIndex = 7;
            this.text_sms.Text = "hello";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sms Msg";
            // 
            // checkBox_delreport
            // 
            this.checkBox_delreport.AutoSize = true;
            this.checkBox_delreport.Location = new System.Drawing.Point(6, 132);
            this.checkBox_delreport.Name = "checkBox_delreport";
            this.checkBox_delreport.Size = new System.Drawing.Size(42, 17);
            this.checkBox_delreport.TabIndex = 8;
            this.checkBox_delreport.Text = "Del";
            this.checkBox_delreport.UseVisualStyleBackColor = true;
            // 
            // btnpdumode
            // 
            this.btnpdumode.Location = new System.Drawing.Point(4, 176);
            this.btnpdumode.Name = "btnpdumode";
            this.btnpdumode.Size = new System.Drawing.Size(68, 23);
            this.btnpdumode.TabIndex = 9;
            this.btnpdumode.Text = "Pdu Mode";
            this.btnpdumode.UseVisualStyleBackColor = true;
            this.btnpdumode.Click += new System.EventHandler(this.btnpdumode_Click);
            // 
            // btn2g
            // 
            this.btn2g.Location = new System.Drawing.Point(75, 176);
            this.btn2g.Name = "btn2g";
            this.btn2g.Size = new System.Drawing.Size(52, 23);
            this.btn2g.TabIndex = 10;
            this.btn2g.Text = "Set 2G";
            this.btn2g.UseVisualStyleBackColor = true;
            this.btn2g.Click += new System.EventHandler(this.btn2g_Click);
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(131, 176);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(45, 24);
            this.btnsend.TabIndex = 11;
            this.btnsend.Text = "Send";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Debug Data";
            // 
            // text_debug
            // 
            this.text_debug.Location = new System.Drawing.Point(4, 220);
            this.text_debug.Multiline = true;
            this.text_debug.Name = "text_debug";
            this.text_debug.Size = new System.Drawing.Size(172, 75);
            this.text_debug.TabIndex = 13;
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(53, 28);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(45, 24);
            this.btnopen.TabIndex = 14;
            this.btnopen.Text = "Open";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 300);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.text_debug);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.btn2g);
            this.Controls.Add(this.btnpdumode);
            this.Controls.Add(this.checkBox_delreport);
            this.Controls.Add(this.text_sms);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_target);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combo_sms_type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combo_serial_ports);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "SmsFuzzer C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_serial_ports;
        private System.Windows.Forms.ComboBox combo_sms_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_target;
        private System.Windows.Forms.TextBox text_sms;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_delreport;
        private System.Windows.Forms.Button btnpdumode;
        private System.Windows.Forms.Button btn2g;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_debug;
        private System.Windows.Forms.Button btnopen;
    }
}

