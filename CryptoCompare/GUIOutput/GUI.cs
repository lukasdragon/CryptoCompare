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
            WriteFile();
        }
        
        public void WriteFile()
        {
            Bittrex bittrex = new Bittrex();
            var values = bittrex.GetUSDMinuteLow("BTC");
            foreach (var results in values)
            {
                string path = (Directory.GetCurrentDirectory() + "\\BTCValues.txt");
                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path));
                }
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(results);
                }
            }
        }
    }
}
