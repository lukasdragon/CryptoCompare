using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Exchanges;

namespace GUIOutput
{
    public partial class ChartGUI : Form
    {
        public ChartGUI()
        {
            InitializeComponent();
            MinuteLow();
            MinuteHigh();
        }//startup
        private void MinuteLow()
        {
            Bittrex bittrex = new Bittrex();
            var values = bittrex.GetUSDMinuteLow("BTC");
            foreach (var results in values)
            {
                string path = (Directory.GetCurrentDirectory() + "\\BTCValueLow.txt");
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(results);
                }

                string DT = results.Key.ToString();
                float BTCValue = results.Value;
                BTCChart.Series[0].Points.AddY(BTCValue);
            }
        }//minute-updated low value

        private void MinuteHigh()
        {
            Bittrex bittrex = new Bittrex();
            var values = bittrex.GetUSDMinuteHigh("BTC");
            foreach (var results in values)
            {
                string path = (Directory.GetCurrentDirectory() + "\\BTCValueHigh.txt");
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(results);
                }

                string DT = results.Key.ToString();
                float BTCValue = results.Value;
                BTCChart.ChartAreas[0].AxisX.Maximum = 14400;
                BTCChart.ChartAreas[0].AxisX.Minimum = 0;
                BTCChart.ChartAreas[0].AxisX.Title = "Minutes ago (0 = 10 days ago)";
                BTCChart.ChartAreas[0].AxisX.Interval = (60 * 24);
                BTCChart.ChartAreas[0].AxisY.Interval = 2000;
                BTCChart.Series[1].Points.AddY(BTCValue);

                timer1.Start();
            }
        }//minute-updated high value

        private void Timer1_Tick(object sender, EventArgs e)//timer ends
        {
            timer1.Start();
            MinuteLow();
            MinuteHigh();
        }

        private void HourBtn_Click(object sender, EventArgs e)
        {
            BTCChart.ChartAreas[0].AxisX.Maximum = 14400;
            BTCChart.ChartAreas[0].AxisX.Minimum = 14340;
            BTCChart.ChartAreas[0].AxisX.Interval = 6;
            HourBtn.BackColor = Color.DarkSlateGray;
            HourBtn.ForeColor = Color.White;
            DayBtn.BackColor = Color.White;
            DayBtn.ForeColor = Color.Black;
            FullDayBtn.BackColor = Color.White;
            FullDayBtn.ForeColor = Color.Black;
            WeekPlusBtn.BackColor = Color.White;
            WeekPlusBtn.ForeColor = Color.Black;
        }

        private void DayBtn_Click(object sender, EventArgs e)
        {
            BTCChart.ChartAreas[0].AxisX.Minimum = 13680;
            BTCChart.ChartAreas[0].AxisX.Interval = 72;
            HourBtn.BackColor = Color.White;
            DayBtn.BackColor = Color.DarkSlateGray;
            FullDayBtn.BackColor = Color.White;
            WeekPlusBtn.BackColor = Color.White;
        }

        private void FullDayBtn_Click(object sender, EventArgs e)
        {
            BTCChart.ChartAreas[0].AxisX.Minimum = 12960;
            BTCChart.ChartAreas[0].AxisX.Interval = 144;
            HourBtn.BackColor = Color.White;
            FullDayBtn.BackColor = Color.DarkSlateGray;
            DayBtn.BackColor = Color.White;
            WeekPlusBtn.BackColor = Color.White;
        }

        private void WeekPlusBtn_Click(object sender, EventArgs e)
        {
            BTCChart.ChartAreas[0].AxisX.Minimum = 0;
            BTCChart.ChartAreas[0].AxisX.Interval = 1440;
            HourBtn.BackColor = Color.White;
            WeekPlusBtn.BackColor = Color.DarkSlateGray;
            FullDayBtn.BackColor = Color.White;
            DayBtn.BackColor = Color.White;
        }

        private void GraphUpperLeft_Click(object sender, EventArgs e)
        {
            double Interval = (BTCChart.ChartAreas[0].AxisX.Interval);
            double Maximum = (BTCChart.ChartAreas[0].AxisX.Maximum);
            double Minimum = (BTCChart.ChartAreas[0].AxisX.Minimum);
            if (Interval == 6)
            {
                BTCChart.ChartAreas[0].AxisX.Maximum = Maximum - 54;
                BTCChart.ChartAreas[0].AxisX.Minimum = Minimum - 54;
            }
            else if (Interval == 72)
            {
                BTCChart.ChartAreas[0].AxisX.Maximum = Maximum - 648;
                BTCChart.ChartAreas[0].AxisX.Minimum = Minimum - 648;
            }
            else if (Interval == 144)
            {
                BTCChart.ChartAreas[0].AxisX.Maximum = Maximum - 1296;
                BTCChart.ChartAreas[0].AxisX.Minimum = Minimum - 1296;
            }
            if (Minimum <= 1296)
            {
                BTCChart.ChartAreas[0].AxisX.Minimum = 0;
                if (Interval == 6)
                {
                    BTCChart.ChartAreas[0].AxisX.Maximum = 60;
                }
                else if (Interval == 72)
                {
                    BTCChart.ChartAreas[0].AxisX.Maximum = 720;
                }
                else if (Interval == 144)
                {
                    BTCChart.ChartAreas[0].AxisX.Maximum = 1440;
                }
                else if (Interval == 1440)
                {
                    BTCChart.ChartAreas[0].AxisX.Maximum = 14400;
                }
            }
        }

        private void GraphUpperRight_Click(object sender, EventArgs e)
        {
            double Interval = (BTCChart.ChartAreas[0].AxisX.Interval);
            double Maximum = (BTCChart.ChartAreas[0].AxisX.Maximum);
            double Minimum = (BTCChart.ChartAreas[0].AxisX.Minimum);
            if (Interval == 6)
            {
                BTCChart.ChartAreas[0].AxisX.Maximum = Maximum + 54;
                BTCChart.ChartAreas[0].AxisX.Minimum = Minimum + 54;
            }
            else if (Interval == 72)
            {
                BTCChart.ChartAreas[0].AxisX.Maximum = Maximum + 648;
                BTCChart.ChartAreas[0].AxisX.Minimum = Minimum + 648;
            }
            else if (Interval == 144)
            {
                BTCChart.ChartAreas[0].AxisX.Maximum = Maximum + 1296;
                BTCChart.ChartAreas[0].AxisX.Minimum = Minimum + 1296;
            }
            if (Maximum >= 14112)
            {
                BTCChart.ChartAreas[0].AxisX.Maximum = 14400;
                if (Interval == 6)
                {
                    BTCChart.ChartAreas[0].AxisX.Minimum = 14340;
                }
                else if (Interval == 72)
                {
                    BTCChart.ChartAreas[0].AxisX.Minimum = 13680;
                }
                else if (Interval == 144)
                {
                    BTCChart.ChartAreas[0].AxisX.Minimum = 12960;
                }
                else if (Interval == 1440)
                {
                    BTCChart.ChartAreas[0].AxisX.Minimum = 0;
                }
            }
        }
    }
}
