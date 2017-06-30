namespace POWER
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.UsbToBoard = new System.Windows.Forms.Button();
            this.UsbToPc = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.USBDisk = new System.Windows.Forms.TextBox();
            this.sUSBSwitchCom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SVNUpdate = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-2, -2);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(122, 219);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.UsbToBoard);
            this.tabPage1.Controls.Add(this.UsbToPc);
            this.tabPage1.Location = new System.Drawing.Point(22, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(96, 211);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "文件果实";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 104);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 47);
            this.button4.TabIndex = 3;
            this.button4.Text = "ClearUsb";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ClearUsbFiles);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 47);
            this.button3.TabIndex = 2;
            this.button3.Text = "TO SOS";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ChangeUpgradeFileToSOS);
            // 
            // UsbToBoard
            // 
            this.UsbToBoard.Location = new System.Drawing.Point(6, 53);
            this.UsbToBoard.Name = "UsbToBoard";
            this.UsbToBoard.Size = new System.Drawing.Size(84, 47);
            this.UsbToBoard.TabIndex = 1;
            this.UsbToBoard.Text = "Usb2Board";
            this.UsbToBoard.UseVisualStyleBackColor = true;
            this.UsbToBoard.Click += new System.EventHandler(this.UsbToBoard_Click);
            // 
            // UsbToPc
            // 
            this.UsbToPc.Location = new System.Drawing.Point(6, 2);
            this.UsbToPc.Name = "UsbToPc";
            this.UsbToPc.Size = new System.Drawing.Size(84, 47);
            this.UsbToPc.TabIndex = 0;
            this.UsbToPc.Text = "Usb2Pc";
            this.UsbToPc.UseVisualStyleBackColor = true;
            this.UsbToPc.Click += new System.EventHandler(this.UsbToPc_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SVNUpdate);
            this.tabPage2.Location = new System.Drawing.Point(22, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(96, 211);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "电脑果实";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.USBDisk);
            this.tabPage3.Controls.Add(this.sUSBSwitchCom);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(22, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(96, 211);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "seting";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // USBDisk
            // 
            this.USBDisk.Location = new System.Drawing.Point(6, 21);
            this.USBDisk.Name = "USBDisk";
            this.USBDisk.Size = new System.Drawing.Size(73, 21);
            this.USBDisk.TabIndex = 3;
            this.USBDisk.TextChanged += new System.EventHandler(this.USBDisk_TextChanged);
            // 
            // sUSBSwitchCom
            // 
            this.sUSBSwitchCom.FormattingEnabled = true;
            this.sUSBSwitchCom.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.sUSBSwitchCom.Location = new System.Drawing.Point(9, 60);
            this.sUSBSwitchCom.Name = "sUSBSwitchCom";
            this.sUSBSwitchCom.Size = new System.Drawing.Size(70, 20);
            this.sUSBSwitchCom.TabIndex = 2;
            this.sUSBSwitchCom.TextChanged += new System.EventHandler(this.USBSwitchCom_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "U盘切换串口";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "清除目标U盘";
            // 
            // SVNUpdate
            // 
            this.SVNUpdate.Location = new System.Drawing.Point(1, 3);
            this.SVNUpdate.Name = "SVNUpdate";
            this.SVNUpdate.Size = new System.Drawing.Size(94, 21);
            this.SVNUpdate.TabIndex = 0;
            this.SVNUpdate.Text = "CVTAT代码更新";
            this.SVNUpdate.UseVisualStyleBackColor = true;
            this.SVNUpdate.Click += new System.EventHandler(this.SVNUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(121, 217);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "能力者";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button UsbToBoard;
        private System.Windows.Forms.Button UsbToPc;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox USBDisk;
        private System.Windows.Forms.ComboBox sUSBSwitchCom;
        private System.Windows.Forms.Button SVNUpdate;
    }
}

