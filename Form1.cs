using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows;
using System.Threading;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public delegate void MessageRecievedDelegate();

        private Bitmap image;  
        const int msg_size = 1024;
        byte[] buf = new byte[msg_size]; 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            #region принимаем сообщение
            try
            {
                if (serialPort1.BytesToRead >= msg_size)
                {
                    serialPort1.Read(buf, 0, msg_size);
                    BeginInvoke(new MessageRecievedDelegate(messageRecieved));
                };
            }
            catch (TimeoutException)
            {
                serialPort1.Close();
            }
            #endregion
        }

        private void buttonSaveClick(object sender, EventArgs e)
        {
            if(saveBitmap.ShowDialog() == DialogResult.OK)
                try
                {
                    if (image == null)
                        MessageBox.Show("Нет изображения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    image.Save(saveBitmap.FileName, System.Drawing.Imaging.ImageFormat.Png);
                }
                catch { };
        }

        private void buttonRecieve_Click(object sender, EventArgs e)
        {
            byte[] buff = { 0x01, 0xFF, 0x40, 0x60 }; //запрос на выдачу изображения
            try
            {
                if (!serialPort1.IsOpen)
                    serialPort1.Open();

                serialPort1.Write(buff, 0, 4);
            }
            catch { };
        }

        public void messageRecieved()
        {
            #region формируем изображение
            image = new Bitmap(128, 64);
            for (int x = 0; x < image.Width; ++x)
                for (int y = 0; y < image.Height / 8; ++y)
                    for (int z = 0; z < 8; ++z)
                        image.SetPixel(x, y * 8 + z, ((buf[x * image.Height / 8 + y] & (1 << z)) != 0) ? Color.Black : Color.White);
            pictureBox.Image = image;
            #endregion

            serialPort1.Close();
        }
    }
}
