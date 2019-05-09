using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace GridMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            setChart();
            gridMethod = new ImplicitGridMethod(
                4,
                delegate (double x, double t) { return 0; },
                delegate (double t) { return 0; },
                delegate (double t) { return 0; },
                Math.PI,
                delegate (double x) {
                    //return -(x) * (x) + 1;
                    return Math.Sin(x);
                },
                0.001,
                100,
                10
                );
            gridMethod.calculate();
            timer1.Start();
        }

        public void setChart()
        {
            chart.Parent = this;
            chart.Dock = DockStyle.None;
        }

        public void draw(List<PointD> p, string name, Color color)
        {
            Series series = new Series(name);
            series.ChartType = SeriesChartType.Line;
            series.ChartArea = "ChartArea1";
            series.Color = color;
            for (int i = 0; i < p.Count; i++)
                series.Points.AddXY(p[i].X, p[i].Y);
            
            chart.Series.Clear();
            chart.Series.Add(series);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLayer < gridMethod.getTimeLayersNum())
            {
                draw(gridMethod.getTimeLayer(timeLayer), timeLayer.ToString(), Color.Black);
                timeLayer++;
            }
        }

        public IDiffusionGrid gridMethod;
        public int timeLayer = 0;
    }
}
