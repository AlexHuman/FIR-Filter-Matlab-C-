namespace LR2_VSIKOI
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SetTypeStepLinesButton = new System.Windows.Forms.Button();
            this.SetTypeFastLinesButton = new System.Windows.Forms.Button();
            this.SetTypeSplinesButton = new System.Windows.Forms.Button();
            this.SetTypeLinesButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.CountOfMeasuresTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PeriodTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AutoPeriodCheckBox = new System.Windows.Forms.CheckBox();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Исходный сигнал";
            series1.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1125, 381);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Name = "График исходной функции";
            this.chart1.Titles.Add(title1);
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(12, 416);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Фильтрованный";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(1125, 422);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart1";
            title2.Name = "Параллельная фильтрация";
            this.chart2.Titles.Add(title2);
            this.chart2.Click += new System.EventHandler(this.chart1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SetTypeStepLinesButton);
            this.groupBox1.Controls.Add(this.SetTypeFastLinesButton);
            this.groupBox1.Controls.Add(this.SetTypeSplinesButton);
            this.groupBox1.Controls.Add(this.SetTypeLinesButton);
            this.groupBox1.Location = new System.Drawing.Point(1178, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 140);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип графика";
            // 
            // SetTypeStepLinesButton
            // 
            this.SetTypeStepLinesButton.Location = new System.Drawing.Point(6, 107);
            this.SetTypeStepLinesButton.Name = "SetTypeStepLinesButton";
            this.SetTypeStepLinesButton.Size = new System.Drawing.Size(172, 23);
            this.SetTypeStepLinesButton.TabIndex = 0;
            this.SetTypeStepLinesButton.Text = "StepLines";
            this.SetTypeStepLinesButton.UseVisualStyleBackColor = true;
            this.SetTypeStepLinesButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // SetTypeFastLinesButton
            // 
            this.SetTypeFastLinesButton.Location = new System.Drawing.Point(7, 78);
            this.SetTypeFastLinesButton.Name = "SetTypeFastLinesButton";
            this.SetTypeFastLinesButton.Size = new System.Drawing.Size(172, 23);
            this.SetTypeFastLinesButton.TabIndex = 0;
            this.SetTypeFastLinesButton.Text = "FastLines";
            this.SetTypeFastLinesButton.UseVisualStyleBackColor = true;
            this.SetTypeFastLinesButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // SetTypeSplinesButton
            // 
            this.SetTypeSplinesButton.Location = new System.Drawing.Point(7, 49);
            this.SetTypeSplinesButton.Name = "SetTypeSplinesButton";
            this.SetTypeSplinesButton.Size = new System.Drawing.Size(172, 23);
            this.SetTypeSplinesButton.TabIndex = 0;
            this.SetTypeSplinesButton.Text = "Splines";
            this.SetTypeSplinesButton.UseVisualStyleBackColor = true;
            this.SetTypeSplinesButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // SetTypeLinesButton
            // 
            this.SetTypeLinesButton.Location = new System.Drawing.Point(7, 20);
            this.SetTypeLinesButton.Name = "SetTypeLinesButton";
            this.SetTypeLinesButton.Size = new System.Drawing.Size(172, 23);
            this.SetTypeLinesButton.TabIndex = 0;
            this.SetTypeLinesButton.Text = "Lines";
            this.SetTypeLinesButton.UseVisualStyleBackColor = true;
            this.SetTypeLinesButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(1374, 136);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(172, 23);
            this.CalculateButton.TabIndex = 3;
            this.CalculateButton.Text = "Расчет";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // CountOfMeasuresTextBox
            // 
            this.CountOfMeasuresTextBox.Location = new System.Drawing.Point(1374, 31);
            this.CountOfMeasuresTextBox.Name = "CountOfMeasuresTextBox";
            this.CountOfMeasuresTextBox.Size = new System.Drawing.Size(171, 20);
            this.CountOfMeasuresTextBox.TabIndex = 4;
            this.CountOfMeasuresTextBox.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1375, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Количество отчетов";
            // 
            // PeriodTextBox
            // 
            this.PeriodTextBox.Location = new System.Drawing.Point(1375, 81);
            this.PeriodTextBox.Name = "PeriodTextBox";
            this.PeriodTextBox.Size = new System.Drawing.Size(171, 20);
            this.PeriodTextBox.TabIndex = 4;
            this.PeriodTextBox.Text = "0,1";
            this.PeriodTextBox.TextChanged += new System.EventHandler(this.PeriodTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1376, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Период дискретизации";
            // 
            // AutoPeriodCheckBox
            // 
            this.AutoPeriodCheckBox.AutoSize = true;
            this.AutoPeriodCheckBox.Location = new System.Drawing.Point(1374, 108);
            this.AutoPeriodCheckBox.Name = "AutoPeriodCheckBox";
            this.AutoPeriodCheckBox.Size = new System.Drawing.Size(129, 17);
            this.AutoPeriodCheckBox.TabIndex = 6;
            this.AutoPeriodCheckBox.Text = "Авторасчет периода";
            this.AutoPeriodCheckBox.UseVisualStyleBackColor = true;
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(1155, 190);
            this.chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "ФЧХ";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(391, 266);
            this.chart3.TabIndex = 7;
            this.chart3.Text = "chart1";
            title3.Name = "Параллельная фильтрация";
            this.chart3.Titles.Add(title3);
            // 
            // chart4
            // 
            chartArea4.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart4.Legends.Add(legend4);
            this.chart4.Location = new System.Drawing.Point(1154, 488);
            this.chart4.Name = "chart4";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "АЧХ";
            this.chart4.Series.Add(series4);
            this.chart4.Size = new System.Drawing.Size(391, 270);
            this.chart4.TabIndex = 8;
            this.chart4.Text = "chart1";
            title4.Name = "Параллельная фильтрация";
            this.chart4.Titles.Add(title4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1583, 861);
            this.Controls.Add(this.chart4);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.AutoPeriodCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PeriodTextBox);
            this.Controls.Add(this.CountOfMeasuresTextBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LR2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SetTypeStepLinesButton;
        private System.Windows.Forms.Button SetTypeFastLinesButton;
        private System.Windows.Forms.Button SetTypeSplinesButton;
        private System.Windows.Forms.Button SetTypeLinesButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox CountOfMeasuresTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PeriodTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox AutoPeriodCheckBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
    }
}

