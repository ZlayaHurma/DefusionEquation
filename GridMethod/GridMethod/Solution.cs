using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extreme.Mathematics.Calculus;
using Extreme.Mathematics;
using Extreme.Mathematics.Algorithms;


namespace GridMethod
{
    class Solution : IDiffusionGrid
    {
        public Solution(
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
            l0 = 0d;
            this.l1 = l1;
            this.u0 = u0;
            this.dt = dt;
            this.xn = xn;
            this.tn = tn;
            this.dx = (l1 - l0) / xn;
        }

        int IDiffusionGrid.getTimeLayersNum()
        {
            return tn;
        }

        void IDiffusionGrid.calculate()
        {
            double[,] grid = new double[xn, tn];

            //fill start values by start conditions
            for (int i = 0; i < xn; i++)
                grid[i, 0] = u0(getOffset(i));
            for (int j = 0; j < tn; j++)
            {
                grid[0, j] = f0(getTime(j));
                grid[xn - 1, j] = f1(getTime(j));
            }

            for (int j = 1; j < tn; j++)
                for (int i = 1; i < xn-1; i++)
                    grid[i, j] = getSolution(getOffset(i), getTime(j));

            this.grid = grid;
        }

        private double getTime(int j)
        {
            return 0 + j * dt;
        }

        private double getOffset(int i)
        {
            return 0 + i * dx;
        }

        List<PointD> IDiffusionGrid.getTimeLayer(int j)
        {
            List<PointD> layer = new List<PointD>();
            for (int i = 0; i < xn; i++)
                layer.Add(new PointD(getOffset(i), grid[i, j]));
            return layer;
        }

        double getSolution(double x, double t) {
            double sum = 0;
            int tol = 100;
            for (int n = 1; n < tol; n++) {
                Func<double, double> integrand = delegate (double csi) {
                    return u0(csi) * Math.Sin((Math.PI * n) / l1 * csi);
                };
                sum += (2 / l1) * getIntegral(integrand, 0, l1) * Math.Sin((Math.PI * n) / l1 * x) * Math.Exp(-a*a*Math.Pow((Math.PI * n) / l1, 2) * t);
            }
            return sum;
        }

        double getIntegral(Func<double, double> f, double a, double b) {
            NonAdaptiveGaussKronrodIntegrator simpson = new NonAdaptiveGaussKronrodIntegrator();
            simpson.ConvergenceCriterion = ConvergenceCriterion.WithinRelativeTolerance;
            return simpson.Integrate(f, a, b);
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

