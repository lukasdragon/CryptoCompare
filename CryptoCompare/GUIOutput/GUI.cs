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
            RefreshBTCChart();
        }

        private void BTCChart_Click(object sender, EventArgs e)
        {

        }

        private void RefreshBTCChart()
        {
            Bittrex bittrex = new Bittrex();
            float bxBTCAsk = bittrex.GetUSDAsk("BTC");
            float bxBTCBid = bittrex.GetUSDBid("BTC");
            float bxBTCLast = bittrex.GetUSDLast("BTC");
            float bxBTCChartMax = (bxBTCAsk + 750);
            BTCChart.ChartAreas[0].AxisX.Maximum = bxBTCChartMax;
            BTCChart.ChartAreas[0].AxisX.Minimum = 0;
            BTCChart.ChartAreas[0].AxisX.Interval = 1000;

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random Rand_Value = new Random();
            int ValueToAdd = Rand_Value.Next(1, 100);
            BTCChart.Series[0].Points.AddY(ValueToAdd);
        }
    }
}
