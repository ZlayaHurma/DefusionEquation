using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extreme.Mathematics;
using Bytescout.Spreadsheet;
using System.Diagnostics;
using System.IO;

namespace GridMethod
{
    class ImplicitGridMethod : IDiffusionGrid
    {
        public ImplicitGridMethod(
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

            //fill matrix LES
            double A = -(a * a * dt) / (dx * dx);
            double B = (1 + (2 * a * a * dt) / (dx * dx));
            double C = A;

            var m = Matrix.Create(xn - 2, xn - 2, new double[(xn-2)*(xn-2)], MatrixElementOrder.RowMajor);
            for (int i = 0; i < xn-2; i++) {
                m[i, i] = B;
                if (i + 1 <= xn - 3) {
                    m[i + 1, i] = C;
                    m[i, i + 1] = A;
                }                   
            }
            
            for (int j = 0; j < tn-1; j++) {
                //m[0, 0]       = f0(getTime(j + 1));
                //m[xn-3, xn-3] = f1(getTime(j + 1));
                double[] v = new double[xn - 2];
                for (int i = 0; i < xn - 2; i++)
                    v[i] = grid[i + 1, j] + (-A) * f(getOffset(i+1), getTime(j));
                var vec = Vector.Create(v);
                var solve = m.Solve(vec, false);
                for (int i = 1; i < xn - 1; i++)
                    grid[i, j + 1] = solve[i-1];
            }
            this.grid = grid;
        }

        void IDiffusionGrid.writeResult(Spreadsheet document)
        {
            // add new worksheet
            Worksheet Sheet = document.Workbook.Worksheets.Add("ImplicitGridMethodResult");

            for (int i = 0; i < xn; i++) {
                Sheet[0, i+1].Value = getOffset(i);
            }

            for (int j = 0; j < tn; j++)
            {
                Sheet[j+1, 0].Value = getTime(j);
            }

            for (int j = 0; j < tn; j++)
                for (int i = 0; i < xn; i++)
                    Sheet[j+1, i+1].Value = grid[i, j];
        }

        List<PointD> IDiffusionGrid.getTimeLayer(int j)
        {
            List<PointD> layer = new List<PointD>();
            for (int i = 0; i < xn; i++)
                layer.Add(new PointD(getOffset(i), grid[i, j]));
            return layer;
        }

        private double getTime(int j)
        {
            return 0 + j * dt;
        }

        private double getOffset(int i)
        {
            return 0 + i * dx;
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
