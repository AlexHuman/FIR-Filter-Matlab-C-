using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR2_VSIKOI
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Инициализация графиков
            chart1.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorY.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
            chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;

            chart2.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart2.ChartAreas[0].CursorY.IsUserEnabled = true;
            chart2.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart2.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chart2.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart2.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart2.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
            chart2.ChartAreas[0].AxisY.ScaleView.Zoomable = true;

            chart3.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart3.ChartAreas[0].CursorY.IsUserEnabled = true;
            chart3.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart3.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chart3.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart3.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart3.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
            chart3.ChartAreas[0].AxisY.ScaleView.Zoomable = true;


            chart4.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart4.ChartAreas[0].CursorY.IsUserEnabled = true;
            chart4.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart4.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chart4.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart4.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart4.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
            chart4.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
        }

        //Отрисовка графика по точкам
        private void PrepareGraphic(System.Windows.Forms.DataVisualization.Charting.Chart chart, List<double> dataXAxis, List<double> dataYAxis)
        {
            chart.Series[0].Points.Clear();
            for (int i = 0; i < dataXAxis.Count; i++)
            {
                chart.Series[0].Points.AddXY(dataXAxis[i], dataYAxis[i]);
            }
            chart.ChartAreas[0].AxisX.ScaleView.Zoom(0, dataXAxis.Max());
        }


        //Выбор типа графика
        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int[] massA = new int[] { 9, 11, 15, 17, 21, 29, 35 };
            int[] massF = new int[] { 10, 11, 12, 13, 15, 20, 25 };

            double[] massH = new double[]
            {
              -1.25937288E-0002,
              -2.68906576E-0002,
               7.24777621E-0002,
              -1.01029481E-0001,
               6.35336599E-0002,
               5.55492140E-0002,
              -2.12490481E-0001,
               3.24046289E-0001,

              -3.24046289E-0001,
               2.12490481E-0001,
              -5.55492140E-0002,
              -6.35336599E-0002,
               1.01029481E-0001,
              -7.24777621E-0002,
               2.68906576E-0002,
               1.25937288E-0002
            };

            double period = Convert.ToDouble(PeriodTextBox.Text);
            //определение периода по теореме Котельникова 
            //частота дискретизации должна быть в 2 раза больше максимальной частоты исходного сигнала
            if (AutoPeriodCheckBox.Checked)
            {
                period = 1 / (double)(massF.Max() * 2 * Math.PI); 
            }

            int countOfMeasures = Convert.ToInt32(CountOfMeasuresTextBox.Text);

            List<double> timeValuesList = new List<double>();
            List<double> sourceValuesList = new List<double>();
            List<double> filteredValuesList = new List<double>();

            //Расчет исходных значений
            double timeMoment = 0;
            for (int i = 1; i < countOfMeasures; i++)
            {

                double X = 0;
                for (int j = 0; j < massA.Length; j++)
                {
                    X += massA[j] * Math.Sin(2 * Math.PI * massF[j] * timeMoment);
                }

                timeValuesList.Add(timeMoment);
                sourceValuesList.Add(X);
                timeMoment += period;
            }


            filteredValuesList = KIHFilter(sourceValuesList, massH);

            List<double> normF = new List<double>();
            for (double i = 0; i < 0.6f; i += 0.1f)
            {
                normF.Add(i);
            }

            List<double> valuesFCH = getFCH(normF, massH);
            List<double> valuesACH = getACH(normF, massH);


            PrepareGraphic(chart1, timeValuesList, sourceValuesList);
            PrepareGraphic(chart2, timeValuesList, filteredValuesList);

            PrepareGraphic(chart3, normF, valuesFCH);
            PrepareGraphic(chart4, normF, valuesACH);


        }

        //Расчет ФЧХ
        private List<double> getFCH(List<double> normFList, double[] filterValues)
        {
            List<double> resultList = new List<double>();
            int m = 0;
            for (int i = 0; i < normFList.Count; i++)
            {
                double fi = -1 * Math.PI * normFList[i] * filterValues.Length + Math.PI / 2 + Math.PI * m;
                resultList.Add(fi);
            }

            return resultList;
        }

        //Расчет АЧХ
        private List<double> getACH(List<double> normFList, double[] filterValues)
        {
            List<double> resultList = new List<double>();

            for (int i = 0; i < normFList.Count; i++)
            {
                double ampl = 0;
                for (int j = 1; j < (filterValues.Length - 1); j++)
                {
                    double cKoef = filterValues[(filterValues.Length - 1) / 2] - j;
                    ampl += cKoef * Math.Sin(2 * Math.PI * normFList[i] * j);
                }
                ampl = Math.Abs(ampl);
                resultList.Add(ampl);
            }

            return resultList;
        }

        //КИХ-фильтрация
        private List<double> KIHFilter(List<double> sourceList, double[] filterValues)
        {
            List<double> resultList = new List<double>();

            for (int i = 0; i < sourceList.Count; i++)
            {
                List<double> interimY = new List<double>();
                for (int j = 0; j < filterValues.Length; j++)
                    interimY.Add(0);

                for (int j = 0; j < filterValues.Length; j++)
                {
                    try
                    {
                        interimY[j] = sourceList[i-j] * filterValues[j];
                    }
                    catch
                    {
                        interimY[j] = 0;
                    }
                }
                resultList.Add(interimY.Sum());
            }
            return resultList;    
        }

        private void PeriodTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
