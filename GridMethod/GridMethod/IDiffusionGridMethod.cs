using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bytescout.Spreadsheet;


namespace GridMethod
{
    public delegate double Func2(double x, double t);

    public interface IDiffusionGridMethod
    {
        void calculate();

        int getTimeLayersNum();

        List<PointD> getTimeLayer(int j);

        void writeResult(Spreadsheet document);

        bool checkStability();
    }
}
