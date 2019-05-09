using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridMethod
{
    public delegate double Func2(double x, double t);

    public interface IDiffusionGrid
    {
        void calculate();
        int getTimeLayersNum();
        List<PointD> getTimeLayer(int j);
    }
}
