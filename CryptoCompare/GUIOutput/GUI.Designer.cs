namespace GUIOutput
{
    partial class ChartGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            this.BTCChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BTCChart)).BeginInit();
            this.SuspendLayout();
            // 
            // BTCChart
            // 
            chartArea3.Name = "ChartArea1";
            chartArea4.Name = "ChartArea2";
            this.BTCChart.ChartAreas.Add(chartArea3);
            this.BTCChart.ChartAreas.Add(chartArea4);
            legend2.Name = "Legend1";
            this.BTCChart.Legends.Add(legend2);
            this.BTCChart.Location = new System.Drawing.Point(12, 12);
            this.BTCChart.Name = "BTCChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "BTC ($US)";
            series2.Points.Add(dataPoint2);
            this.BTCChart.Series.Add(series2);
            this.BTCChart.Size = new System.Drawing.Size(454, 517);
            this.BTCChart.TabIndex = 0;
            this.BTCChart.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // ChartGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 541);
            this.Controls.Add(this.BTCChart);
            this.Name = "ChartGUI";
            this.Text = "CryptoCompare";
            ((System.ComponentModel.ISupportInitialize)(this.BTCChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart BTCChart;
        private System.Windows.Forms.Timer timer1;
    }
}

