namespace statistics_app
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsize = new System.Windows.Forms.TextBox();
            this.txtlower = new System.Windows.Forms.TextBox();
            this.txtupper = new System.Windows.Forms.TextBox();
            this.lstRaw = new System.Windows.Forms.ListBox();
            this.lstSorted = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMedian = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMean = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.HistogramChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.HistogramChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Elements:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lower Limit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Upper Limit:";
            // 
            // txtsize
            // 
            this.txtsize.Location = new System.Drawing.Point(178, 25);
            this.txtsize.Name = "txtsize";
            this.txtsize.Size = new System.Drawing.Size(100, 20);
            this.txtsize.TabIndex = 3;
            // 
            // txtlower
            // 
            this.txtlower.Location = new System.Drawing.Point(178, 61);
            this.txtlower.Name = "txtlower";
            this.txtlower.Size = new System.Drawing.Size(100, 20);
            this.txtlower.TabIndex = 4;
            // 
            // txtupper
            // 
            this.txtupper.Location = new System.Drawing.Point(178, 90);
            this.txtupper.Name = "txtupper";
            this.txtupper.Size = new System.Drawing.Size(100, 20);
            this.txtupper.TabIndex = 5;
            // 
            // lstRaw
            // 
            this.lstRaw.FormattingEnabled = true;
            this.lstRaw.Location = new System.Drawing.Point(15, 253);
            this.lstRaw.Name = "lstRaw";
            this.lstRaw.Size = new System.Drawing.Size(120, 212);
            this.lstRaw.TabIndex = 6;
            // 
            // lstSorted
            // 
            this.lstSorted.FormattingEnabled = true;
            this.lstSorted.Location = new System.Drawing.Point(178, 253);
            this.lstSorted.Name = "lstSorted";
            this.lstSorted.Size = new System.Drawing.Size(120, 212);
            this.lstSorted.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Raw Data Set";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sorted Dataset";
            // 
            // txtMode
            // 
            this.txtMode.Location = new System.Drawing.Point(113, 544);
            this.txtMode.Name = "txtMode";
            this.txtMode.Size = new System.Drawing.Size(100, 20);
            this.txtMode.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 547);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mode:";
            // 
            // txtMedian
            // 
            this.txtMedian.Location = new System.Drawing.Point(113, 513);
            this.txtMedian.Name = "txtMedian";
            this.txtMedian.Size = new System.Drawing.Size(100, 20);
            this.txtMedian.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 516);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Median:";
            // 
            // txtMean
            // 
            this.txtMean.Location = new System.Drawing.Point(113, 484);
            this.txtMean.Name = "txtMean";
            this.txtMean.Size = new System.Drawing.Size(100, 20);
            this.txtMean.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 484);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Mean:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(15, 130);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(106, 39);
            this.btnGenerate.TabIndex = 16;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(178, 130);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 39);
            this.btnCalculate.TabIndex = 17;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
          
            // 
            // HistogramChart
            // 
            chartArea1.AxisX.Title = "Numbers";
            chartArea1.AxisY.Title = "Frequency";
            chartArea1.Name = "ChartArea1";
            this.HistogramChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.HistogramChart.Legends.Add(legend1);
            this.HistogramChart.Location = new System.Drawing.Point(342, 25);
            this.HistogramChart.Name = "HistogramChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar100;
            series1.Label = "Random variable";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.HistogramChart.Series.Add(series1);
            this.HistogramChart.Size = new System.Drawing.Size(778, 440);
            this.HistogramChart.TabIndex = 18;
            this.HistogramChart.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Histogram of Random Variable";
            this.HistogramChart.Titles.Add(title1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 657);
            this.Controls.Add(this.HistogramChart);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtMean);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMedian);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstSorted);
            this.Controls.Add(this.lstRaw);
            this.Controls.Add(this.txtupper);
            this.Controls.Add(this.txtlower);
            this.Controls.Add(this.txtsize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "statistics app";
            ((System.ComponentModel.ISupportInitialize)(this.HistogramChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsize;
        private System.Windows.Forms.TextBox txtlower;
        private System.Windows.Forms.TextBox txtupper;
        private System.Windows.Forms.ListBox lstRaw;
        private System.Windows.Forms.ListBox lstSorted;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMedian;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMean;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.DataVisualization.Charting.Chart HistogramChart;
    }
}

