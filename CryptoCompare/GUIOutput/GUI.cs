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
        }
        
        public void MinuteLow()
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
        }

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
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            MinuteLow();
            MinuteHigh();
        }
    }
}
