using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace POWER
{
    public partial class Form1 : Form
    {
        LuaClass lua = new LuaClass(); //实例化lua类
        FileClass file = new FileClass();//实例化FileClass类

        string sUsbSwitchSerialPort;//usb切换  串口端口变量
        string sUsbDisk;//清除目标U盘，U盘在电脑端显示的盘符
        string sUsbSerial;//U盘切换开关串口端口
        string sSetConfigContents = "";//设置页面，内容字符串
        string sSetingConfigPath = "..//..//lua//setingconfig.lua";
        string sStar = "\"";
        string sEnd = "\";\n";

        public Form1()
        {
            InitializeComponent();
            int x = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Size.Width - 140;
            int y = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Size.Height - 600;
            this.SetDesktopLocation(x, y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            string sTemp;

            sTemp = file.TxtRead(sSetingConfigPath);
            if (sTemp != "")
            {
                USBDisk.Text = sTemp.Substring(12, 1);
                sUSBSwitchCom.Text = sTemp.Substring(32, 4);
            }
        }


        private void UsbToPc_Click(object sender, EventArgs e)
        {
            if (sUsbSerial != null)
            {
                try
                {
                    Byte[] tUsbToPcCode = new Byte[4];
                    tUsbToPcCode[0] = 0xA7;
                    tUsbToPcCode[1] = 0x3A;
                    tUsbToPcCode[2] = 0x3C;
                    tUsbToPcCode[3] = 0x01;

                    //获取comboBox1的串口端口，发送数据
                    sUsbSwitchSerialPort = sUSBSwitchCom.Text;
                    file.WriteDataToSerialPort(sUsbSwitchSerialPort, tUsbToPcCode);

                    //改变button1的颜色为绿色
                    UsbToPc.BackColor = Color.Green;
                    UsbToBoard.BackColor = Color.Gray;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show("需输入U盘切换开关的串口");
            }

         
        }

        private void UsbToBoard_Click(object sender, EventArgs e)
        {
            if (sUsbSerial != null)
            {
                try
                {
                    byte[] tUsbToBoardCode = new byte[4];
                    tUsbToBoardCode[0] = 0xA7;
                    tUsbToBoardCode[1] = 0x3A;
                    tUsbToBoardCode[2] = 0x3B;
                    tUsbToBoardCode[3] = 0x01;

                    //获取comboBox1串口端口，发送数据
                    sUsbSwitchSerialPort = sUSBSwitchCom.Text;
                    file.WriteDataToSerialPort(sUsbSwitchSerialPort, tUsbToBoardCode);

                    //改变button2 的颜色为绿色
                    UsbToBoard.BackColor = Color.Green;
                    UsbToPc.BackColor = Color.Gray;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show("需输入U盘切换开关的串口");
            }

        
        }

        //清除U盘文件，除了文件夹
        private void ClearUsbFiles(object sender, EventArgs e)
        {
        
            if (sUsbDisk == null)
            {
                 MessageBox.Show("需输入操作U盘盘符");
            }
            else
            {
                object[] objs = lua.LuaRun(1); 
            }        

        }


        //更改升级文件为sos命名
        private void ChangeUpgradeFileToSOS(object sender, EventArgs e)
        {
            //object[] objs = lua.LuaRun();

            //foreach (object obj in objs)
            //{
            //    MessageBox.Show(obj.ToString());
            //}
            MessageBox.Show("开发中，敬请期待");
        }


        //获取需要清除U盘的盘符
        public void USBDisk_TextChanged(object sender, EventArgs e)
        {
           sUsbDisk = USBDisk.Text;
           sSetConfigContents = "sUsbDisk = " + sStar + sUsbDisk + sEnd + "sUsbSerialCom = " + sStar + sUsbSerial + sEnd;
           file.TxtWrite(sSetingConfigPath, sSetConfigContents, false);
        }

        //获取需要切换U盘工具串口端口
        private void USBSwitchCom_TextChanged(object sender, EventArgs e)
        {
            sUsbSerial = sUSBSwitchCom.Text;
            sSetConfigContents = "sUsbDisk = " + sStar + sUsbDisk + sEnd + "sUsbSerialCom = " + sStar + sUsbSerial + sEnd;
            file.TxtWrite(sSetingConfigPath, sSetConfigContents, false);
        }

        private void SVNUpdate_Click(object sender, EventArgs e)
        {
            object[] objs = lua.LuaRun(2); 
        }


    }

}
