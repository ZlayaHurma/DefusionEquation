using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            Form visualizationForm = new GridForm(
            (double)a_box.Value,
            delegate(double x, double t) { return x + t; },
            delegate (double t) { return t; },
            delegate (double t) { return t; },
            (double)l_box.Value,
            delegate (double x) { return Math.Sin(x); },
            (double)dt_box.Value,
            (int)Nt_box.Value,
            (int)Nx_box.Value
                );
            visualizationForm.Show();
        }
    }
}
