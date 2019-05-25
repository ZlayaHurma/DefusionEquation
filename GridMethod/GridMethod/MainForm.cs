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
using Bytescout.Spreadsheet;
using System.Diagnostics;
using System.IO;

namespace GridMethod
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            setChart();
            double l = 5;
            double a = 1;
            Func2 f = delegate (double x, double t) { return x*Math.Cos(t) + 3*t*t*x*x*x+2*t-1*6*x*t*t*t; };
            Func<double, double> f0 = delegate (double t) { return t*t; };
            Func<double, double> f1 = delegate (double t) { return l*Math.Sin(t)+l*l*l*t*t*t+l+t*t; };
            Func<double, double> u0 = delegate (double x)
            {
                //return -(x) * (x) + 1;
                return x;
                //return Math.Sin(x)/2;
            };
            double dt = 0.0001;
            int tn = 5;
            int xn = 5;

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
            if (!explicitMethod.checkStability())
                throw new Exception("Explicit method is unstable!");
            implicitMethod.calculate();
            explicitMethod.calculate();
            solution.calculate();

            Spreadsheet doc = new Spreadsheet();
            implicitMethod.writeResult(doc);
            explicitMethod.writeResult(doc);
            solution.writeResult(doc);
            doc.SaveAs("Output.xls");
            doc.Close();

            //Process.Start("Output.xls");

            timer1.Start();
        }

        public void setChart()
        {
            chart.Parent = this;
            chart.Dock = DockStyle.None;
        }

        public void draw(List<PointD> p, string name, Color color)
        {
            Series series = chart.Series.FindByName(name);
            if (series == null)
            {
                series = new Series(name);
                series.ChartType = SeriesChartType.Line;
                series.ChartArea = "ChartArea1";
                series.Color = color;
                chart.Series.Add(series);
            }
            series.Points.Clear();
            for (int i = 0; i < p.Count; i++)
                series.Points.AddXY(p[i].X, p[i].Y);          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLayer < implicitMethod.getTimeLayersNum())
            { 
                draw(implicitMethod.getTimeLayer(timeLayer), "implicitMethod", Color.Black);
                draw(explicitMethod.getTimeLayer(timeLayer), "explicitMethod", Color.Blue);
                draw(solution.getTimeLayer(timeLayer), "solution", Color.Green);
                timeLayer++;
            }
        }

        public IDiffusionGridMethod implicitMethod;
        public IDiffusionGridMethod explicitMethod;
        public IDiffusionGridMethod solution;
        public int timeLayer = 0;
    }
}
