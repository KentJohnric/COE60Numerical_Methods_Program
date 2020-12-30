using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineProblem3
{
    public partial class MullersCalc : Form
    {
        public MullersCalc()
        {
            InitializeComponent();
        }

        void clear()
        {
            txtBoxMullers_a.Text = "";
            txtBoxMullers_b.Text = "";
            txtBoxMullers_c.Text = "";
            txtBoxMullers_d.Text = "";
            txtBoxMullers_e.Text = "";
            txtBoxMullers_x0.Text = "";
            txtBoxMullers_x1.Text = "";
            txtBoxMullers_x2.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            clear();
            radBtnMullers_c1.Checked = false;
            radBtnMullers_c2.Checked = false;
            radBtnMullers_c3.Checked = false;
            //  gBoxMullers_values.Show();
        }

        private void btnMullers_clear_Click(object sender, EventArgs e)
        {
            clear();
            radBtnMullers_c1.Checked = false;
            radBtnMullers_c2.Checked = false;
            radBtnMullers_c3.Checked = false;
            // gBoxMullers_values.Hide();
            dgvMullers.Hide();
        }

        private void radBtnMullers_c1_CheckedChanged(object sender, EventArgs e)
        {
            clear();
            //gBoxMullers_values.Hide();
            txtBoxMullers_d.Hide();
            txtBoxMullers_e.Hide();
            lbl_d.Hide();
            lbl_e.Hide();
            dgvMullers.Hide();
        }

        private void radBtnMullers_c2_CheckedChanged(object sender, EventArgs e)
        {
            clear();
            // gBoxMullers_values.Show();
            txtBoxMullers_d.Show();
            txtBoxMullers_e.Hide();
            lbl_e.Show();
            lbl_d.Hide();
            dgvMullers.Hide();
        }

        private void radBtnMullers_c3_CheckedChanged(object sender, EventArgs e)
        {
            clear();
            //  gBoxMullers_values.Show();
            txtBoxMullers_d.Show();
            txtBoxMullers_e.Show();
            lbl_e.Show();
            lbl_d.Show();
            dgvMullers.Hide();
        }

        private void btnMullers_solve_Click(object sender, EventArgs e)
        {
            double s1, s0, h1, h0, a, b, c, d, f, x1, x0, x2, x3, f0, f1, f2, error = 100, k = 0, a1, b1, c1, d1;
            double[] data = new double[5];

            DataTable table = new DataTable();
            table.Columns.Add("k", typeof(double));
            table.Columns.Add("x0", typeof(double));
            table.Columns.Add("x1", typeof(double));
            table.Columns.Add("x2", typeof(double));
            table.Columns.Add("x3", typeof(double));

            x0 = double.Parse(txtBoxMullers_x0.Text);
            x1 = double.Parse(txtBoxMullers_x1.Text);
            x2 = double.Parse(txtBoxMullers_x2.Text);
            a = double.Parse(txtBoxMullers_a.Text);
            b = double.Parse(txtBoxMullers_b.Text);
            c = double.Parse(txtBoxMullers_c.Text);

            if (radBtnMullers_c1.Checked == true)
            {
                while (error > .0001)
                {
                    f0 = (a * (x0 * x0)) + (b * x0) + c;
                    f1 = (a * (x1 * x1)) + (b * x1) + c;
                    f2 = (a * (x2 * x2)) + (b * x2) + c;
                    h0 = x1 - x0;
                    h1 = x2 - x1;
                    s0 = (f1 - f0) / h0;
                    s1 = (f2 - f1) / h1;
                    a1 = (s1 - s0) / h1 + h0;
                    b1 = (a1 * h1) + s1;
                    c1 = f2;
                    d1 = (b1 * b1) - (4 * a1 * c1);
                    if (d1 > 0)
                    {
                        d1 = Math.Sqrt(d1);
                        if (Math.Abs(b1 + d1) > Math.Abs(b1 - d1))
                        {
                            x3 = x2 + ((-2 * c1) / (b1 + d1));
                        }
                        else
                        {
                            x3 = x2 + ((-2 * c1) / (b1 - d1));
                        }
                        error = Math.Abs((x3 - x2));
                        k++;
                        table.Rows.Add(k, x0, x1, x2, x3);
                        x0 = x1;
                        x1 = x2;
                        x2 = x3;
                    }
                    else
                    {
                        MessageBox.Show("The data gives an imaginary number. Please change the coefficients of your equation.", "Error", MessageBoxButtons.OK);
                        error = 0;
                    }
                };
                dgvMullers.Visible = true;
                dgvMullers.DataSource = table;
            }
            else if (radBtnMullers_c2.Checked == true)
            {
                while (error > .0001)
                {
                    d = double.Parse(txtBoxMullers_d.Text);
                    f0 = (a * (x0 * x0 * x0)) + (b * x0 * x0) + (c * x0) + d;
                    f1 = (a * (x1 * x1 * x1)) + (b * x1 * x1) + (c * x1) + d;
                    f2 = (a * (x2 * x2 * x2)) + (b * x2 * x2) + (c * x2) + d;
                    h0 = x1 - x0;
                    h1 = x2 - x1;
                    s0 = (f1 - f0) / h0;
                    s1 = (f2 - f1) / h1;
                    a1 = (s1 - s0) / h1 + h0;
                    b1 = (a1 * h1) + s1;
                    c1 = f2;
                    d1 = (b1 * b1) - (4 * a1 * c1);
                    if (d1 > 0)
                    {
                        d1 = Math.Sqrt(d1);
                        if (Math.Abs(b1 + d1) > Math.Abs(b1 - d1))
                        {
                            x3 = x2 + ((-2 * c1) / (b1 + d1));
                        }
                        else
                        {
                            x3 = x2 + ((-2 * c1) / (b1 - d1));
                        }
                        error = Math.Abs((x3 - x2));
                        k++;
                        table.Rows.Add(k, x0, x1, x2, x3);
                        x0 = x1;
                        x1 = x2;
                        x2 = x3;
                    }
                    else
                    {
                        MessageBox.Show("The data gives an imaginary number. Please change the coefficients of your equation.", "Error", MessageBoxButtons.OK);
                        error = 0;
                    }
                };
                dgvMullers.Visible = true;
                dgvMullers.DataSource = table;
            }
            else if (radBtnMullers_c3.Checked == true)
            {

                while (error > .0001)
                {
                    d = double.Parse(txtBoxMullers_d.Text);
                    f = double.Parse(txtBoxMullers_e.Text);
                    f0 = (a * (x0 * x0 * x0 * x0)) + (b * x0 * x0 * x0) + (c * x0 * x0) + (d * x0) + f;
                    f1 = (a * (x1 * x1 * x1 * x1)) + (b * x1 * x1 * x1) + (c * x1 * x1) + (d * x1) + f;
                    f2 = (a * (x2 * x2 * x2 * x2)) + (b * x2 * x2 * x2) + (c * x2 * x2) + (d * x2) + f;
                    h0 = x1 - x0;
                    h1 = x2 - x1;
                    s0 = (f1 - f0) / h0;
                    s1 = (f2 - f1) / h1;
                    a1 = (s1 - s0) / h1 + h0;
                    b1 = (a1 * h1) + s1;
                    c1 = f2;
                    d1 = (b1 * b1) - (4 * a1 * c1);
                    if (d1 > 0)
                    {
                        d1 = Math.Sqrt(d1);
                        if (Math.Abs(b1 + d1) > Math.Abs(b1 - d1))
                        {
                            x3 = x2 + ((-2 * c1) / (b1 + d1));
                        }
                        else
                        {
                            x3 = x2 + ((-2 * c1) / (b1 - d1));
                        }
                        error = Math.Abs((x3 - x2));
                        k++;
                        table.Rows.Add(k, x0, x1, x2, x3);
                        x0 = x1;
                        x1 = x2;
                        x2 = x3;
                    }
                    else
                    {
                        MessageBox.Show("The data gives an imaginary number. Please change the coefficients of your equation.", "Error", MessageBoxButtons.OK);
                        error = 0;
                    }
                };
                dgvMullers.Visible = true;
                dgvMullers.DataSource = table;
            }
        }

        private void btnMullers_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
