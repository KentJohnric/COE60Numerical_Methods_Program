using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineProblem
{
    public partial class LinearRegressionUserControl1 : UserControl
    {
        public LinearRegressionUserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x1, x2, x3, x4, x5, fx1, fx2, fx3, fx4, fx5 = 0;
            try
            {
                x1 = double.Parse(txtx1.Text);
                x2 = double.Parse(txtx2.Text);
                x3 = double.Parse(txtx3.Text);
                x4 = double.Parse(txtx4.Text);
                x5 = double.Parse(txtx5.Text);
                fx1 = double.Parse(txtfx1.Text);
                fx2 = double.Parse(txtfx2.Text);
                fx3 = double.Parse(txtfx3.Text);
                fx4 = double.Parse(txtfx4.Text);
                fx5 = double.Parse(txtfx5.Text);
                //summation of xi^2
                double sxi2 = 0; sxi2 = ((x1 * x1) + (x2 * x2) + (x3 * x3) + (x4 * x4) + (x5 * x5));
                //summation of xi
                double sxi; sxi = x1 + x2 + x3 + x4 + x5;
                //summation of fxi
                double fxi; fxi = fx1 + fx2 + fx3 + fx4 + fx5;
                //summation of xiyi
                double sxy; sxy = (x1 + fx1) + (x2 + fx2) + (x3 * fx3) + (x4 * fx4) + (x5 * fx5);
                double a1; a1 = Math.Round((((5 * sxy) - (sxi * fxi)) / ((5 * sxi2) - (sxi * sxi))), 4);
                double x, y = 0; x = sxi / 5; y = fxi / 5;
                double a0; a0 = Math.Round((y - (x * a1)), 4);
                string answer; answer = "MODEL FUNCTION: f(X) = " + a0 + " + " + a1 + " x"; listBox1.Items.Add(answer);
            }
            catch (SystemException exa) { MessageBox.Show(exa.Message); }
        }

        private void btnRegula_clear_Click(object sender, EventArgs e)
        {
            txtx1.Text = "";
            txtfx1.Text = "";
            txtx2.Text = "";
            txtfx2.Text = "";
            txtx3.Text = "";
            txtfx3.Text = "";
            txtx4.Text = "";
            txtfx4.Text = "";
            txtx5.Text = "";
            txtfx5.Text = "";
            listBox1.Items.Clear();
        }
    }
}
