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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            this.BTCChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.HourBtn = new System.Windows.Forms.Button();
            this.DayBtn = new System.Windows.Forms.Button();
            this.FullDayBtn = new System.Windows.Forms.Button();
            this.WeekPlusBtn = new System.Windows.Forms.Button();
            this.GraphUpperLeft = new System.Windows.Forms.Button();
            this.GraphUpperRight = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BTCChart)).BeginInit();
            this.SuspendLayout();
            // 
            // BTCChart
            // 
            chartArea11.Name = "ChartArea1";
            chartArea12.Name = "ChartArea2";
            this.BTCChart.ChartAreas.Add(chartArea11);
            this.BTCChart.ChartAreas.Add(chartArea12);
            legend6.Name = "Legend1";
            this.BTCChart.Legends.Add(legend6);
            this.BTCChart.Location = new System.Drawing.Point(93, 12);
            this.BTCChart.Name = "BTCChart";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Legend = "Legend1";
            series11.Name = "Bittrex Min. Low";
            series11.Points.Add(dataPoint11);
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Legend = "Legend1";
            series12.Name = "Bittrex Min. High";
            series12.Points.Add(dataPoint12);
            this.BTCChart.Series.Add(series11);
            this.BTCChart.Series.Add(series12);
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
            this.HourBtn.BackColor = System.Drawing.Color.White;
            this.HourBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HourBtn.Location = new System.Drawing.Point(12, 29);
            this.HourBtn.Name = "HourBtn";
            this.HourBtn.Size = new System.Drawing.Size(75, 23);
            this.HourBtn.TabIndex = 1;
            this.HourBtn.Text = "1 Hour";
            this.HourBtn.UseVisualStyleBackColor = false;
            this.HourBtn.Click += new System.EventHandler(this.HourBtn_Click);
            // 
            // DayBtn
            // 
            this.DayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.FullDayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.WeekPlusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.GraphUpperLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.GraphUpperRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GraphUpperRight.Location = new System.Drawing.Point(721, 208);
            this.GraphUpperRight.Name = "GraphUpperRight";
            this.GraphUpperRight.Size = new System.Drawing.Size(75, 23);
            this.GraphUpperRight.TabIndex = 6;
            this.GraphUpperRight.Text = "Right";
            this.GraphUpperRight.UseVisualStyleBackColor = true;
            this.GraphUpperRight.Click += new System.EventHandler(this.GraphUpperRight_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(737, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "BTC Price ($US)";
            // 
            // ChartGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(899, 541);
            this.Controls.Add(this.label1);
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
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
    }
}

