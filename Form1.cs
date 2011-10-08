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
    public struct Point
    {
        public int x;
        public double y;
        public Point(int p1, double p2)
        {
            x = p1;
            y = p2;
        }
    }

    public enum State { Run, Stop };

    public partial class Form1 : Form
    {
        private
//            Int32 x = 0;//, Y;
            Int32 sps = 0;
         //   Random Rand;
            List<int> arr_y_t;
            List<Point> arr_n_y;
            List<string> arr_s;
//            Double Mean, Mean2, Disp, Sigma;
           // Int64 foo, bar;
           // bool _continue;
            bool msgRecieved = false;
           // Thread readThread;
         //   string message;
  //          Double Interval = 8000000;
    //        Double Mean_ = 8000000;

            State state = State.Stop;
            int num;
            double mean, sum;

            double currentValue;
            Int32 chartWidth = 200;
        public Form1()
        {
            InitializeComponent();
          //  Rand = new Random();
            
            arr_y_t = new List<int>();
            arr_n_y = new List<Point>();
            arr_s = new List<string>();

            //_continue = false;
          //  readThread = new Thread(Read);
        }
/*
        public void Read()
        {
            byte[] buf = new byte[16]; 
            while (_continue)
            {
                try
                {
                  //  message = serialPort1.ReadLine();
                    if (serialPort1.BytesToRead >= 9)
                    {
                        serialPort1.Read(buf, 0, 9);
                        curr_val = (buf[6] << 16) + (buf[3] << 8) + buf[4];
                        msg_recieved = true;
                    };
                }
                catch (TimeoutException) { }
            }
        }
        */

        private void FillHistogram(double currentValue)
        {
            // find in the my_arr the point with value y
          bool point_is_present = false;
          int n = 0;
          int y;

          y = (int)(currentValue / 32) * 32;
            for (int i = 0; i < arr_n_y.Count; i++)
            {
                if (y == arr_n_y[i].x)
                {
                    n = (int)arr_n_y[i].y;
                    n++;
                    arr_n_y.Remove(arr_n_y[i]);
                    arr_n_y.Add(new Point(y, n)); 

                    point_is_present = true;
                    break;
                };
            };
            if (!point_is_present)
            {
                arr_n_y.Add(new Point(y, 1));
                n = 1;
            };

            chart2.Series[0].Points.Clear();
            foreach (Point p in arr_n_y)
                chart2.Series[0].Points.AddXY(p.x, p.y);
            
            chart2.Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

//            Int32 Y;
        //    byte[] buff;

            Int32 chartCount;

            byte[] buff3 = { 0x01, 0x03, 0x01, 0xc8, 0x00, 0x02, 0x44, 0x09 }; //1-й канал АЦП 3
            byte[] buff2 = { 0x01, 0x03, 0x01, 0xc6, 0x00, 0x02, 0x25, 0xca }; //1-й канал АЦП 2
            byte[] buff1 = { 0x01, 0x03, 0x01, 0xc4, 0x00, 0x02, 0x84, 0x0a }; //1-й канал АЦП 1
            byte[] buff0 = { 0x01, 0x03, 0x01, 0xc2, 0x00, 0x02, 0x64, 0x0b }; //1-й канал АЦП 0

            byte[] buff4 = { 0x01, 0x03, 0x01, 0xce, 0x00, 0x02, 0xa4, 0x08 }; //1-й канал АЦП 0

        //    buff = buff0;
/*
            switch(comboBox1.SelectedIndex)
            {
                case 0: buff = buff0; break;
                case 1: buff = buff1; break;
                case 2: buff = buff2; break;
                case 3: buff = buff3; break;
            };*/
            // byte[] buff = {0x01, 0x03, 0x01, 0x66, 0x00, 0x02, 0x25, 0xe8}; //2-й канал АЦП 0
           // byte[] buff = { 0x01, 0x03, 0x01, 0x6a, 0x00, 0x02, 0xe5, 0xeb }; //2-й канал АЦП 2
            
            //recieve message from port




                // Generate point info
                serialPort1.Write(buff4, 0, 8);
                /*
                try
                {
                      //do not acquire values below zero  
                //    temp = Convert.ToInt32(message);
               //   if ((temp > (Mean_ - Interval)) && (temp < (Mean_ + Interval))) 
                    Y = curr_val;
                }
                catch{};
             //   Y = (1 << 23) + Rand.Next(100);
                */
                //???
                
                arr_y_t.Add((int)currentValue);                                                                                  //???

                chartCount = chart1.Series[0].Points.Count;

                chart1.Series[0].Points.AddXY(num, msgRecieved ? currentValue : 0);
                chart1.Series[0].Points[chartCount].MarkerStyle = msgRecieved ? (Dundas.Charting.WinControl.MarkerStyle.None) : (Dundas.Charting.WinControl.MarkerStyle.Cross);
                chart1.Series[0].Color = Color.Green;
                chart1.Series[0].Points[chartCount].MarkerColor = msgRecieved ? Color.Green : Color.Red;
                if (chart1.Series[0].Points.Count > chartWidth)
                {
                    chart1.Series[0].Points.RemoveAt(0);
                    chart1.ChartAreas["Default"].AxisX.Minimum = num - chartWidth;
                    chart1.ChartAreas["Default"].AxisX.Maximum = num;
                };
                chart1.Invalidate();

                FillHistogram(currentValue);

                num++;
                sum += currentValue;
                mean = sum / num;
                sps++;

                if (msgRecieved)
                {
                    msgRecieved = false;
                }
/*
            if (X == 10)
            {
                Interval = 8 * Sigma;
                Mean_ = Mean;
            }
  */
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            double foo = 0;//, bar = 0;
            Double /*Mean, Mean2,*/ disp, sigma;
            string[] tempArray = { "", "", "", "", "", "", "" };
            tempArray[0] = String.Format("SPS = {0}", sps);
            /*
           // foo = bar = 0;
            foreach (int y in arr_y_t)
            {
                foo += y;
                bar += (Int64)y * (Int64)y;
            };
            Mean = (Double)foo / (arr_y_t.Count);
            Mean2 = (Double)bar / (arr_y_t.Count);
            Disp = Math.Abs(Mean2 - Mean * Mean);*/
            foo = 0;
            foreach (double y in arr_y_t)
            {
                foo += Math.Pow(y - mean, 2.0);
            };
            disp = foo / num;
            sigma = Math.Sqrt(disp);

            tempArray[1] = String.Format("N1 = {0}", arr_y_t.Count);
            tempArray[2] = String.Format("N2 = {0}", num);
            tempArray[3] = String.Format("M = {0}", mean);
            tempArray[4] = String.Format("Disp = {0}", disp);
            tempArray[5] = String.Format("Sigma = {0}", sigma);
            tempArray[6] = String.Format("{0}", currentValue);

            textBox2.Lines = tempArray;
            sps = 0;
         //   serialPort1.WriteLine("123 fg4");
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Red;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.DarkRed;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Lime ;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Green;
        }

        private void ClosePort()
        {
            if (state == State.Run)
            {
                state = State.Stop;
                serialPort1.Close();
            };
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
          ClosePort();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            byte[] buf = new byte[16];
            if (state == State.Run)
            {
                try
                {
                    //  message = serialPort1.ReadLine();
                    if (serialPort1.BytesToRead >= 9)
                    {
                        serialPort1.Read(buf, 0, 9);
                        currentValue = (buf[6] << 16) + (buf[3] << 8) + buf[4];
                        msgRecieved = true;
                    };
                }
                catch (TimeoutException) { }
            }
        }

        private void buttonStartClick(object sender, EventArgs e)
        {
            if (state == State.Stop)
            {
              
                num = 0;
                sum = 0.0;
                //  Interval = 8000000;
                //  Mean_ = 8000000;
                arr_y_t.Clear();
                arr_n_y.Clear();
                chart1.Series[0].Points.Clear();
                chart1.ChartAreas["Default"].AxisX.Minimum = double.NaN;  //NaN = Auto mode
                chart1.ChartAreas["Default"].AxisX.Maximum = double.NaN;
                chart1.ChartAreas["Default"].AxisY.Minimum = double.NaN;  //NaN = Auto mode
                chart1.ChartAreas["Default"].AxisY.Maximum = double.NaN;
                chart1.Invalidate();

                chart2.Series[0].Points.Clear();
                chart2.ChartAreas["Default"].AxisX.Minimum = double.NaN;
                chart2.ChartAreas["Default"].AxisX.Maximum = double.NaN;
                chart2.Invalidate();
                //-----------------------
                try
                {
                    serialPort1.Open();
                    state = State.Run;
                    timer1.Enabled = true;
                    timer2.Enabled = true;
                }
                catch { };
            }
        }

        private void buttonStopClick(object sender, EventArgs e) //Stop button
        {
            ClosePort();
            timer1.Enabled = false;
            timer2.Enabled = false;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            try
            {
                Int16 b;
                //ByteConverter bc = new ByteConverter();
                b = Convert.ToInt16(textBox1.Text);
                textBox1.Text = b.ToString();
             //   textBox1.Font.
            }
            catch 
            {
                System.Media.SystemSounds.Beep.Play();
            };
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // textBox1.Font.Bold = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedIndex.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedIndex.ToString();
        }
    }
}
