using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;

namespace GridMethod
{
    public partial class StartDataForm : Form
    {
        public StartDataForm()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            Function f =  new Function("f(x,t) = " + f_box.Text);
            Function f0 = new Function("f0(t) = " + f0_box.Text);
            Function f1 = new Function("f1(t) = " + f1_box.Text);
            Function u0 = new Function("u0(x) = " + u0_box.Text);

            Form visualizationForm = new GridForm(
                (double)a_box.Value,
                delegate(double x, double t) { return f.calculate(x,t); },
                delegate (double t) { return f0.calculate(t); },
                delegate (double t) { return f1.calculate(t); },
                (double)l_box.Value,
                delegate (double x) { return u0.calculate(x); },
                (double)dt_box.Value,
                (int)Nt_box.Value,
                (int)Nx_box.Value
                    );
            visualizationForm.Show();
        }
    }
}
