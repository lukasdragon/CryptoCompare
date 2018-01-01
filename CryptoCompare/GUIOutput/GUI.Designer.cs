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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            this.BTCChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.HourBtn = new System.Windows.Forms.Button();
            this.DayBtn = new System.Windows.Forms.Button();
            this.FullDayBtn = new System.Windows.Forms.Button();
            this.WeekPlusBtn = new System.Windows.Forms.Button();
            this.GraphUpperLeft = new System.Windows.Forms.Button();
            this.GraphUpperRight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BTCChart)).BeginInit();
            this.SuspendLayout();
            // 
            // BTCChart
            // 
            chartArea5.Name = "ChartArea1";
            chartArea6.Name = "ChartArea2";
            this.BTCChart.ChartAreas.Add(chartArea5);
            this.BTCChart.ChartAreas.Add(chartArea6);
            legend3.Name = "Legend1";
            this.BTCChart.Legends.Add(legend3);
            this.BTCChart.Location = new System.Drawing.Point(93, 12);
            this.BTCChart.Name = "BTCChart";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "BTC Min Low ($US)";
            series5.Points.Add(dataPoint5);
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "BTC Min High ($US)";
            series6.Points.Add(dataPoint6);
            this.BTCChart.Series.Add(series5);
            this.BTCChart.Series.Add(series6);
            this.BTCChart.Size = new System.Drawing.Size(794, 517);
            this.BTCChart.TabIndex = 0;
            this.BTCChart.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // HourBtn
            // 
            this.HourBtn.Location = new System.Drawing.Point(12, 29);
            this.HourBtn.Name = "HourBtn";
            this.HourBtn.Size = new System.Drawing.Size(75, 23);
            this.HourBtn.TabIndex = 1;
            this.HourBtn.Text = "1 Hour";
            this.HourBtn.UseVisualStyleBackColor = true;
            this.HourBtn.Click += new System.EventHandler(this.HourBtn_Click);
            // 
            // DayBtn
            // 
            this.DayBtn.Location = new System.Drawing.Point(12, 58);
            this.DayBtn.Name = "DayBtn";
            this.DayBtn.Size = new System.Drawing.Size(75, 23);
            this.DayBtn.TabIndex = 2;
            this.DayBtn.Text = "12 Hours";
            this.DayBtn.UseVisualStyleBackColor = true;
            this.DayBtn.Click += new System.EventHandler(this.DayBtn_Click);
            // 
            // FullDayBtn
            // 
            this.FullDayBtn.Location = new System.Drawing.Point(12, 87);
            this.FullDayBtn.Name = "FullDayBtn";
            this.FullDayBtn.Size = new System.Drawing.Size(75, 23);
            this.FullDayBtn.TabIndex = 3;
            this.FullDayBtn.Text = "24 Hours";
            this.FullDayBtn.UseVisualStyleBackColor = true;
            this.FullDayBtn.Click += new System.EventHandler(this.FullDayBtn_Click);
            // 
            // WeekPlusBtn
            // 
            this.WeekPlusBtn.Location = new System.Drawing.Point(12, 116);
            this.WeekPlusBtn.Name = "WeekPlusBtn";
            this.WeekPlusBtn.Size = new System.Drawing.Size(75, 23);
            this.WeekPlusBtn.TabIndex = 4;
            this.WeekPlusBtn.Text = "10 Days";
            this.WeekPlusBtn.UseVisualStyleBackColor = true;
            this.WeekPlusBtn.Click += new System.EventHandler(this.WeekPlusBtn_Click);
            // 
            // GraphUpperLeft
            // 
            this.GraphUpperLeft.Location = new System.Drawing.Point(12, 208);
            this.GraphUpperLeft.Name = "GraphUpperLeft";
            this.GraphUpperLeft.Size = new System.Drawing.Size(75, 23);
            this.GraphUpperLeft.TabIndex = 5;
            this.GraphUpperLeft.Text = "Left";
            this.GraphUpperLeft.UseVisualStyleBackColor = true;
            this.GraphUpperLeft.Click += new System.EventHandler(this.GraphUpperLeft_Click);
            // 
            // GraphUpperRight
            // 
            this.GraphUpperRight.Location = new System.Drawing.Point(721, 208);
            this.GraphUpperRight.Name = "GraphUpperRight";
            this.GraphUpperRight.Size = new System.Drawing.Size(75, 23);
            this.GraphUpperRight.TabIndex = 6;
            this.GraphUpperRight.Text = "Right";
            this.GraphUpperRight.UseVisualStyleBackColor = true;
            this.GraphUpperRight.Click += new System.EventHandler(this.GraphUpperRight_Click);
            // 
            // ChartGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 541);
            this.Controls.Add(this.GraphUpperRight);
            this.Controls.Add(this.GraphUpperLeft);
            this.Controls.Add(this.WeekPlusBtn);
            this.Controls.Add(this.FullDayBtn);
            this.Controls.Add(this.DayBtn);
            this.Controls.Add(this.HourBtn);
            this.Controls.Add(this.BTCChart);
            this.Name = "ChartGUI";
            this.Text = "CryptoCompare";
            ((System.ComponentModel.ISupportInitialize)(this.BTCChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart BTCChart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button HourBtn;
        private System.Windows.Forms.Button DayBtn;
        private System.Windows.Forms.Button FullDayBtn;
        private System.Windows.Forms.Button WeekPlusBtn;
        private System.Windows.Forms.Button GraphUpperLeft;
        private System.Windows.Forms.Button GraphUpperRight;
    }
}

