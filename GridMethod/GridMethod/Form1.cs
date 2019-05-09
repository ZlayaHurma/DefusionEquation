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
using static GridMethod.ExplicitGridMethod;

namespace GridMethod
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            setChart();
            double a = 6;
            Func2 f = delegate (double x, double y) { return 0; };
            Func<double, double> f0 = delegate (double t) { return 0; };
            Func<double, double> f1 = delegate (double t) { return 0; };
            double l = 5;
            Func<double, double> u0 = delegate (double x)
            {
                //return -(x) * (x) + 1;
                return Math.Sin(Math.Pow(x, 2));
                //return Math.Sin(x)/2;
            };
            double dt = 0.0001;
            int tn = 200;
            int xn = 50;

            implicitMethod = new ImplicitGridMethod(
                a,
                f,
                f0,
                f1,
                l,
                u0,
                dt,
                tn,
                xn
                );
            explicitMethod = new ExplicitGridMethod(
                a,
                f,
                f0,
                f1,
                l,
                u0,
                dt,
                tn,
                xn
                );
            solution = new Solution(
                a,
                f,
                f0,
                f1,
                l,
                u0,
                dt,
                tn,
                xn
                );
            implicitMethod.calculate();
            explicitMethod.calculate();
            solution.calculate();
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
            if (timeLayer < implicitMethod.getTimeLayersNum())
            {
                List<PointD> points = new List<PointD>();
                points.AddRange(implicitMethod.getTimeLayer(timeLayer));
                points.AddRange(explicitMethod.getTimeLayer(timeLayer));
                points.AddRange(solution.getTimeLayer(timeLayer));

                draw(points, timeLayer.ToString(), Color.Black);
                timeLayer++;
            }
        }

        public IDiffusionGrid implicitMethod;
        public IDiffusionGrid explicitMethod;
        public IDiffusionGrid solution;
        public int timeLayer = 0;
    }
}
