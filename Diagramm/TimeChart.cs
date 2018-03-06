using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;

namespace Diagramm
{
    public class TimeChart
    {
        public List<double> list = new List<double>();

        public Chart timechart;
        public string SeriesName;
        public int length;
        public TimeChart(Chart _timechart, string _SeriesName, int _length)
        {
            length = _length;
            timechart = _timechart;

            timechart.Series.Clear();
            timechart.Series.Add(_SeriesName);
            timechart.Series[_SeriesName].ChartType = SeriesChartType.Line;
            timechart.ChartAreas["ChartArea1"].AxisY.Maximum = 100;

            SeriesName = _SeriesName;
            for (int i = 0; i < length; i++)
            {
                list.Add(0);
            }

        }

        public void AddValue(double value)
        {


            for (int i = 0; i < length - 1; i++)
            {
                list[i] = list[i + 1];
            }
            list[length - 1] = Math.Round(value, 0);

            RefreshTimeChart();

        }
        private void RefreshTimeChart()
        {
            timechart.Series[SeriesName].Points.Clear();
            for (int i = 0; i < length - 1; i++)
            {
                timechart.Series[SeriesName].Points.AddY(list[i]);
            }
        }
    }
}
