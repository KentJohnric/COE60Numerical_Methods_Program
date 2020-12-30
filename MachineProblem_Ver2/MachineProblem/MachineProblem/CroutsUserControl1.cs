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
    public partial class CroutsUserControl1 : UserControl
    {
        double[,] A = new double[3, 4];
        double y1, y2, y3, x1, x2, x3;

        double[,] U = new double[3, 3];
        bool flag1 = false, flag2 = false, flag3 = false;

        private void btnCholeskys_2nd_Click(object sender, EventArgs e)
        {
            A[1, 0] = double.Parse(textBox5.Text);
            A[1, 1] = double.Parse(textBox6.Text);
            A[1, 2] = double.Parse(textBox7.Text);
            A[1, 3] = double.Parse(textBox8.Text);

            if (A[1, 1] < A[1, 0] || A[1, 1] < A[1, 2])
            {
                MessageBox.Show("Second-order coefficient should be the largest!");
                for (int i = 0; i < 4; i++)
                {
                    A[1, i] = 0;
                }

                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
            }
            else
            {
                flag2 = true;
            }
        }

        private void btnCholeskys_3rd_Click(object sender, EventArgs e)
        {
            A[2, 0] = double.Parse(textBox9.Text);
            A[2, 1] = double.Parse(textBox10.Text);
            A[2, 2] = double.Parse(textBox11.Text);
            A[2, 3] = double.Parse(textBox12.Text);

            if (A[2, 2] < A[2, 0] || A[2, 2] < A[2, 1])
            {
                MessageBox.Show("First-order coefficient should be the largest!");
                for (int i = 0; i < 4; i++)
                {
                    A[2, i] = 0;
                }

                textBox9.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";
                textBox12.Text = "";
            }
            else
            {
                flag3 = true;
            }
        }

        private void btnCholeskys_1st_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    L[i, j] = 0;
                    U[i, j] = 0;
                }
            }

            U[0, 0] = 1;
            U[1, 1] = 1;
            U[2, 2] = 1;

            A[0, 0] = double.Parse(textBox1.Text);
            A[0, 1] = double.Parse(textBox2.Text);
            A[0, 2] = double.Parse(textBox3.Text);
            A[0, 3] = double.Parse(textBox4.Text);

            if (A[0, 0] < A[0, 1] || A[0, 0] < A[0, 2])
            {
                MessageBox.Show("Third-order coefficient should be the largest!");
                for (int i = 0; i < 4; i++)
                {
                    A[0, i] = 0;
                }

            }
            else
            {
                flag1 = true;
            }
        }

        double[,] L = new double[3, 3];

        public CroutsUserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((flag1 && flag2 && flag3) == true)
            {
                for (int i = 0; i < 3; i++)
                {
                    L[i, 0] = A[i, 0];
                }
                for (int i = 1; i < 3; i++)
                {
                    U[0, i] = (A[0, i]) / (L[0, 0]);
                }
                for (int i = 1; i < 3; i++)
                {
                    L[i, 1] = A[i, 1] - (L[i, 0]) * (U[0, 1]);
                }
                U[1, 2] = (A[1, 2] - L[1, 0] * U[0, 2]) / L[1, 1];

                y1 = A[0, 3] / L[0, 0];
                y2 = (A[1, 3] + (-1 * L[1, 0] * y1)) / L[1, 1];
                y3 = ((-1 * y1 * L[2, 0]) + (-1 * L[2, 1] * y2) + A[2, 3]) / L[2, 2];


                x3 = y3;
                x2 = y2 + (x3 * -1 * U[1, 2]);
                x1 = y1 + (-1 * U[0, 1] * x2) + (-1 * U[0, 2] * x3);

                txtBoxCholeskys_x1.Text = Convert.ToString(Math.Round(x1, 4));
                txtBoxCholeskys_x2.Text = Convert.ToString(Math.Round(x2, 4));
                txtBoxCholeskys_x3.Text = Convert.ToString(Math.Round(x3, 4));
            }
            else
            {
                MessageBox.Show("You must click ALL the 'DO' button first.");
            }
        }

        private void btnRegula_clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            txtBoxCholeskys_x1.Text = "";
            txtBoxCholeskys_x2.Text = "";
            txtBoxCholeskys_x3.Text = "";
        }
    }
}
