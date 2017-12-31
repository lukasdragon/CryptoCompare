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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BTCChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BTCChart)).BeginInit();
            this.SuspendLayout();
            // 
            // BTCChart
            // 
            chartArea4.Name = "ChartArea1";
            chartArea5.Name = "ChartArea2";
            chartArea6.Name = "ChartArea3";
            this.BTCChart.ChartAreas.Add(chartArea4);
            this.BTCChart.ChartAreas.Add(chartArea5);
            this.BTCChart.ChartAreas.Add(chartArea6);
            legend2.Name = "Legend1";
            this.BTCChart.Legends.Add(legend2);
            this.BTCChart.Location = new System.Drawing.Point(22, 12);
            this.BTCChart.Name = "BTCChart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Ask";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.LabelBorderWidth = 2;
            series5.Legend = "Legend1";
            series5.Name = "Bid";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Last";
            this.BTCChart.Series.Add(series4);
            this.BTCChart.Series.Add(series5);
            this.BTCChart.Series.Add(series6);
            this.BTCChart.Size = new System.Drawing.Size(355, 517);
            this.BTCChart.TabIndex = 0;
            this.BTCChart.Text = "Bittrex";
            this.BTCChart.Click += new System.EventHandler(this.BTCChart_Click);
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

