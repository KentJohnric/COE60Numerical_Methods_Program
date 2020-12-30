using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineProblem1
{
    public partial class frmRegula : Form
    {
        int i = 0, count = 0, flag = 0;
        double error = 0.0001;
        double[] coeff = new double[10];
        double x0, x1, x2 = 0, t = 0;

        private void btnRegula_clear_Click(object sender, EventArgs e)
        {
            txtBoxRegula_int1.Text = " ";
            txtBoxRegula_int2.Text = " ";
            txtBoxRegula_x1.Text = " ";
            txtBoxRegula_x2.Text = " ";
            txtBoxRegula_x3.Text = " ";
            txtBoxRegula_k.Text = " ";

            lBoxRegula_x0.Items.Clear();
            lBoxRegula_x1.Items.Clear();
            lBoxRegula_x2.Items.Clear();
            lBoxRegula_fx0.Items.Clear();
            lBoxRegula_fx1.Items.Clear();
            lBoxRegula_fx2.Items.Clear();
        }

        private void btnRegula_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        double fx0 = 0, fx1 = 0, fx2 = 0, temp = 0;
        int test = 0;

        public frmRegula()
        {
            InitializeComponent();
        }

        public int check()
        {

            x0 = double.Parse(txtBoxRegula_int1.Text);
            x1 = double.Parse(txtBoxRegula_int2.Text);

            fx0 = fx1 = fx2 = 0;

            for (i = 3; i >= 1; i--)
            {

                fx0 += coeff[i] * (Math.Pow(x0, i));
                fx1 += coeff[i] * (Math.Pow(x1, i));

            }

            fx0 += coeff[0];
            fx1 += coeff[0];

            if ((fx0 * fx1) > 0)
            {

                //MessageBox.Show("Input another set of initial values.");
                return (1);

            }
            return (0);

        }

        private void btnRegula_solve_Click(object sender, EventArgs e)
        {
            coeff[0] = double.Parse(txtBoxRegula_k.Text);
            coeff[1] = double.Parse(txtBoxRegula_x1.Text);
            coeff[2] = double.Parse(txtBoxRegula_x2.Text);
            coeff[3] = double.Parse(txtBoxRegula_x3.Text);

            do
            {

                test = check();

                if (test != 0)
                {

                    txtBoxRegula_int1.Text = " ";
                    txtBoxRegula_int2.Text = " ";
                    break;

                }

            } while (check() != 0);

            flag = 1;

            if (flag == 1)
            {

                do
                {

                    count++;
                    fx0 = fx1 = fx2 = 0;

                    lBoxRegula_x0.Items.Add(Math.Round(x0, 4));
                    lBoxRegula_x2.Items.Add(Math.Round(x1, 4));

                    for (i = 3; i >= 1; i--)
                    {

                        fx0 += coeff[i] * (Math.Pow(x0, i));
                        fx1 += coeff[i] * (Math.Pow(x1, i));

                    }

                    fx0 += coeff[0];
                    lBoxRegula_fx0.Items.Add(Math.Round(fx0, 4));

                    fx1 += coeff[0];
                    lBoxRegula_fx2.Items.Add(Math.Round(fx1, 4));



                    temp = x2;

                    x2 = ((x0 * fx1) - (x1 * fx0)) / (fx1 - fx0);
                    lBoxRegula_x1.Items.Add(Math.Round(x2, 4));

                    for (i = 3; i >= 1; i--)
                    {

                        fx2 += coeff[i] * (Math.Pow(x2, i));


                    }
                    fx2 += coeff[0];
                    lBoxRegula_fx1.Items.Add(Math.Round(fx2, 4));

                    t = fx0 * fx2;

                    if (t > 0)
                    {

                        x0 = x2;

                    }

                    if (t < 0)
                    {

                        x1 = x2;

                    }
                    fx2 = 0;



                } while ((Math.Abs(temp - x2)) >= error);

                MessageBox.Show("The root of the function is " + Math.Round(x2, 4), "Answer");
            }
        }
    }
}
