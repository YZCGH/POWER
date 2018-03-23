using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace POWER
{
    class FileClass
    {

        //发送指令到串口
        public void WriteDataToSerialPort(string com, byte[] ByteArr)
        {
            SerialPort Com = new SerialPort();
            Com.WriteTimeout = 5000;
            Com.PortName = com;
            Com.BaudRate = 115200;
            Com.Parity = Parity.None;
            Com.Open();
            Com.Write(ByteArr, 0, ByteArr.Length);

            Com.Close();
        }

        //读取文件中的内容
        public string TxtRead(string path)
        {
            StreamReader txt = new StreamReader(path, Encoding.Default);
            String line;
            String Contents = "";
            while ((line = txt.ReadLine()) != null)
            {
                Contents = Contents + line.ToString() + "\r\n";
            }
            txt.Close();
            return Contents;
        }


        //写入contents内容到path中, true就持续增加，false会覆盖掉第一次的
        public void TxtWrite(string path, string contents, bool b)
        {
            using (StreamWriter txt = new StreamWriter(path, b, Encoding.Default))
            {
                txt.Flush();
                txt.WriteLine(contents);
                txt.Close();
            }
        }

    }
}
