using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridMethod
{
    public interface IDiffusionNumMethod
    {
        void calculate();
        int getTimeLayersNum();
        List<PointD> getTimeLayer(int j);
    }
}
