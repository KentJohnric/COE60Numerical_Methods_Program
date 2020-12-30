using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineProblem4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MachineProblem4.SimpsonsCalc form = new MachineProblem4.SimpsonsCalc();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MachineProblem4.CenteredFiniteCalc form = new MachineProblem4.CenteredFiniteCalc();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MachineProblem4.LinearRegressionClac form = new MachineProblem4.LinearRegressionClac();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MachineProblem4.NewtonInterpolationCalc form = new MachineProblem4.NewtonInterpolationCalc();
            form.ShowDialog();
        }
    }
}
