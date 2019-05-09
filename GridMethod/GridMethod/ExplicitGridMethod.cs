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
    public class ExplicitGridMethod : IDiffusionNumMethod
    {
        public delegate double Func2(double x, double t);

        public ExplicitGridMethod(
            double a,
            Func2 f, 
		    Func<double, double> f0, 
            Func<double, double> f1, 
		    double l1,
            Func<double, double> u0,
		    double dt,
            int tn,
            int xn
            )
        {
            this.a = a;
            this.f = f;
            this.f0 = f0;
            this.f1 = f1;
            this.l0 = 0d;
            this.l1 = l1;
            this.u0 = u0;
            this.dt = dt;
            this.xn = xn;
            this.tn = tn;
            this.dx = (l1 - l0) / xn;
        }

        int IDiffusionNumMethod.getTimeLayersNum() {
            return tn;
        }

        void IDiffusionNumMethod.calculate() {
            double[,] grid = new double[xn,tn];

            //fill start values by start conditions
            for (int i = 0; i < xn; i++)
                grid[i, 0] = u0(getOffset(i));
            for (int j = 0; j < tn; j++)
            {
                grid[0, j] = f0(getTime(j));
                grid[xn-1, j] = f1(getTime(j));
            }

            for (int j = 1; j < tn; j++)
            {
                for (int i = 1; i < xn - 1; i++)
                {
                    double u_i_j = grid[i, j - 1] + ((a * a * dt) / (dx * dx)) * (grid[i - 1, j - 1] - (2 * grid[i, j - 1]) + grid[i + 1, j - 1] + f(getOffset(i), getTime(j - 1)));
                    grid[i, j] = u_i_j;
                    if (Double.IsNaN(u_i_j) || Double.IsNegativeInfinity(u_i_j) || Double.IsPositiveInfinity(u_i_j) || u_i_j > 20)
                        grid[i, j] = 0;
                }
            }

            this.grid = grid;
        }

        private double getTime(int j) {
            return 0 + j * dt;
        }

        private double getOffset(int i)
        {
            return 0 + i * dx;
        }

        List<PointD> IDiffusionNumMethod.getTimeLayer(int j) {
            List<PointD> layer = new List<PointD>();
            for (int i=0; i < xn; i++) 
                layer.Add(new PointD(getOffset(i), grid[i, j]));
            return layer;
        }

        private double a;
        private Func2 f;
        private Func<double, double> f0;
        private double l0;
        private Func<double, double> f1;
        private double l1;
        private Func<double, double> u0;
        private double dt;
        private double dx;
        private int tn;
        private int xn;

        public double[,] grid;
    }
}
