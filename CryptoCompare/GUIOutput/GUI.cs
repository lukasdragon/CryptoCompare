using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            timer1.Start();
        }

        private void BTCChart_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Bittrex bittrex = new Bittrex();
            var values = bittrex.GetUSDMinuteLow("BTC");
            foreach (var results in values)
            {
                string resultstr = results.ToString();
                string[] btcValuesArray = resultstr.Split(',');
                string resultDT = btcValuesArray.First();
                string resultValue = btcValuesArray.Last();
                float resultValueFloat = float.Parse(resultValue);
                float AddedValue = resultValueFloat + 500;
                BTCChart.ChartAreas[0].AxisX.Maximum = AddedValue;
                BTCChart.ChartAreas[0].AxisX.Minimum = 0;
                BTCChart.ChartAreas[0].AxisX.Interval = 1000;
                BTCChart.Series[0].Points.AddY(resultValueFloat);
                timer1.Start();
            }
        }
    }
}
