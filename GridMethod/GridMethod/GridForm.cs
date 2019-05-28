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
    public partial class GridForm : Form
    {

        public GridForm(
            double a,
            Func2 f,
            Func<double, double> f0,
            Func<double, double> f1,
            double l,
            Func<double, double> u0,
            double dt,
            int tn,
            int xn,
            double delay
            )
        {
            InitializeComponent();
            setChart();
            timer1.Interval = (int)delay;
           
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
            //if (!explicitMethod.checkStability())
            //throw new Exception("Explicit method is unstable!");
            try
            {
                implicitMethod.calculate();
                explicitMethod.calculate();
                if (!explicitMethod.checkStability()) {
                    MessageBox.Show("Explicit method is unstable on this data!");
                }
            }
            catch (Exception ex) {
                
            }

            Spreadsheet doc = new Spreadsheet();
            implicitMethod.writeResult(doc);
            explicitMethod.writeResult(doc);
            doc.SaveAs("Output.xls");
            doc.Close();

            //Process.Start("Output.xls");

            timer1.Start();
        }

        public void setChart()
        {
            chart.Parent = this;
            chart.Dock = DockStyle.None;
            chart.ChartAreas["ChartArea1"].AxisX.Title = "X";
            chart.ChartAreas["ChartArea1"].AxisY.Title = "T";
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
            {
                if (!p[i].isValid())
                    Close();
                series.Points.AddXY(p[i].X, p[i].Y);
            }
            chart.ChartAreas["ChartArea1"].AxisY.Maximum = chart.ChartAreas["ChartArea1"].AxisY.Maximum;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLayer < implicitMethod.getTimeLayersNum())
            {
                try
                {
                    draw(implicitMethod.getTimeLayer(timeLayer), "Implicit grid method", Color.Black);
                    draw(explicitMethod.getTimeLayer(timeLayer), "Explicit grid method", Color.Blue);
                }
                catch (Exception ex)
                {

                }
                timeLayer++;
            }
        }

        public IDiffusionGridMethod implicitMethod;
        public IDiffusionGridMethod explicitMethod;
        public int timeLayer = 0;
    }
}
