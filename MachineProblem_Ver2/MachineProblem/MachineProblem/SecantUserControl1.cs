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
    public partial class SecantUserControl1 : UserControl
    {
        int i = 0, count = 0, bandila = 0;

        double eps = 0.0001;

        double[] coeff = new double[10];
        double x0, x1, x2 = 0;
        double fx0 = 0, fx1 = 0, fx2 = 0, temp = 0;
        private void btnRegula_clear_Click(object sender, EventArgs e)
        {
            txtBoxSecant_int1.Text = "";
            txtBoxSecant_int2.Text = "";
            txtBoxSecant_x3.Text = "";
            txtBoxSecant_x2.Text = "";
            txtBoxSecant_x1.Text = "";
            txtBoxSecant_k.Text = "";
            lBoxSecant_fx1.Items.Clear();
            lBoxSecant_fx0.Items.Clear();
            lBoxSecant_fx2.Items.Clear();
            lBoxSecant_x1.Items.Clear();
            lBoxSecant_x2.Items.Clear();
            lBoxSecant_x0.Items.Clear();
        }

        int test = 0;

        public SecantUserControl1()
        {
            InitializeComponent();
        }

        public int check()
        {

            x0 = double.Parse(txtBoxSecant_int1.Text);
            x1 = double.Parse(txtBoxSecant_int2.Text);

            fx0 = fx1 = fx2 = 0;

            for (i = 3; i >= 1; i--)
            {

                fx0 += coeff[i] * (Math.Pow(x0, i));
                fx1 += coeff[i] * (Math.Pow(x1, i));

            }

            fx0 += coeff[0];
            fx1 += coeff[0];

            if (fx0 == fx1)
            {

                MessageBox.Show("Initial Values are not meant to be!!");
                return (1);

            }
            return (0);

        }

        private void btnRegula_solve_Click(object sender, EventArgs e)
        {
            coeff[0] = double.Parse(txtBoxSecant_k.Text);
            coeff[1] = double.Parse(txtBoxSecant_x1.Text);
            coeff[2] = double.Parse(txtBoxSecant_x2.Text);
            coeff[3] = double.Parse(txtBoxSecant_x3.Text);

            do
            {
                test = check();
                if (test != 0)
                {
                    
                    break;
                }
            } while (check() != 0);
            bandila = 1;

            if (bandila == 1)
            {

                do
                {

                    count++;
                    fx0 = fx1 = fx2 = 0;

                    lBoxSecant_x0.Items.Add(Math.Round(x0, 4));
                    lBoxSecant_x1.Items.Add(Math.Round(x1, 4));

                    for (i = 3; i >= 1; i--)
                    {

                        fx0 += coeff[i] * (Math.Pow(x0, i));
                        fx1 += coeff[i] * (Math.Pow(x1, i));

                    }

                    fx0 += coeff[0];
                    lBoxSecant_fx0.Items.Add(Math.Round(fx0, 4));

                    fx1 += coeff[0];
                    lBoxSecant_fx1.Items.Add(Math.Round(fx1, 4));

                    temp = x2;

                    x2 = x0 - ((fx0) * ((x1 - x0) / (fx1 - fx0)));
                    lBoxSecant_x2.Items.Add(Math.Round(x2, 4));

                    for (i = 3; i >= 1; i--)
                    {

                        fx2 += coeff[i] * (Math.Pow(x2, i));

                    }
                    fx2 += coeff[0];
                    lBoxSecant_fx2.Items.Add(Math.Round(fx2, 4));

                    x0 = x1;
                    x1 = x2;
                    fx2 = 0;

                } while ((Math.Abs(temp - x2)) >= eps);

                MessageBox.Show("The root of the function is " + Math.Round(x2, 4), "Answer");
            }
        }
    }
}
