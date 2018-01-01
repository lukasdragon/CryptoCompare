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
                float addedValue = BTCValue + 750;
                BTCChart.ChartAreas[0].AxisX.Maximum = addedValue;
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
            BTCChart.ChartAreas[0].AxisX.Minimum = 14360;
            BTCChart.ChartAreas[0].AxisX.Interval = 6;
        }

        private void DayBtn_Click(object sender, EventArgs e)
        {
            BTCChart.ChartAreas[0].AxisX.Minimum = 13680;
            BTCChart.ChartAreas[0].AxisX.Interval = 72;
        }

        private void FullDayBtn_Click(object sender, EventArgs e)
        {
            BTCChart.ChartAreas[0].AxisX.Minimum = 12960;
            BTCChart.ChartAreas[0].AxisX.Interval = 144;
        }

        private void WeekPlusBtn_Click(object sender, EventArgs e)
        {
            BTCChart.ChartAreas[0].AxisX.Minimum = 0;
            BTCChart.ChartAreas[0].AxisX.Interval = 1440;
        }

        private void GraphUpperLeft_Click(object sender, EventArgs e)
        {
            if
        }

        private void GraphUpperRight_Click(object sender, EventArgs e)
        {

        }
    }
}
