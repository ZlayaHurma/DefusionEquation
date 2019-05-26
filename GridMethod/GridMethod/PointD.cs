using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GridMethod
{
    public struct PointD
    {
        public double X;
        public double Y;

        public PointD(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Point ToPoint()
        {
            return new Point((int)X, (int)Y);
        }

        public override bool Equals(object obj)
        {
            return obj is PointD && this == (PointD)obj;
        }
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }
        public static bool operator ==(PointD a, PointD b)
        {
            return a.X == b.X && a.Y == b.Y;
        }
        public static bool operator !=(PointD a, PointD b)
        {
            return !(a == b);
        }
        public bool isValid()
        {
            return !Double.IsInfinity(X) &&
                   !Double.IsInfinity(Y) &&
                   !Double.IsNaN(X) &&
                   !Double.IsNaN(Y) &&
                    Math.Abs(X) < 1e+16 &&
                    Math.Abs(Y) < 1e+16;
        }
    }
}
