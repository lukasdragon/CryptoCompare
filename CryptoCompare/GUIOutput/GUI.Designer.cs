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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            this.BTCChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BTCChart)).BeginInit();
            this.SuspendLayout();
            // 
            // BTCChart
            // 
            chartArea1.Name = "ChartArea1";
            chartArea2.Name = "ChartArea2";
            chartArea3.Name = "ChartArea3";
            this.BTCChart.ChartAreas.Add(chartArea1);
            this.BTCChart.ChartAreas.Add(chartArea2);
            this.BTCChart.ChartAreas.Add(chartArea3);
            legend1.Name = "Legend1";
            this.BTCChart.Legends.Add(legend1);
            this.BTCChart.Location = new System.Drawing.Point(22, 12);
            this.BTCChart.Name = "BTCChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "BTC";
            series1.Points.Add(dataPoint1);
            this.BTCChart.Series.Add(series1);
            this.BTCChart.Size = new System.Drawing.Size(355, 517);
            this.BTCChart.TabIndex = 0;
            this.BTCChart.Text = "Bittrex";
            this.BTCChart.Click += new System.EventHandler(this.BTCChart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
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

