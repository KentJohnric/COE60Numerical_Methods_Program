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
    public partial class SimpsonsCalc : Form
    {
        public SimpsonsCalc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double b, a, h;
                b = double.Parse(txtb.Text);
                a = double.Parse(txta.Text);
                if (b <= a)
                {
                    MessageBox.Show("Please enter larger value for the upper limit b");
                    txtb.Text = "";
                }
                else
                {

                    double[] x;
                    x = new double[9];
                    double y = 0;
                    y = fx(a);
                    listBox1.Items.Add(a + "\t\t\t" + y.ToString() + "\t\t\t" + y.ToString());
                    h = (b - a) / 8;

                    double fx11 = 0;
                    double trule = 0;
                    for (int i = 1; i < 8; i++)
                    {
                        a += h; x[i] = fx(a);
                        if (i % 3 == 0) { trule = 2 * x[i]; }
                        else { trule = 3 * x[i]; }
                        fx11 += trule;
                        listBox1.Items.Add(a + "\t\t\t" + x[i].ToString() + "\t\t\t" + trule.ToString());
                    }
                    double k = 0;
                    k = fx(b);
                    label13.Visible = true;
                    label15.Visible = true;
                    label16.Visible = true;
                    listBox1.Items.Add(b + "\t\t\t" + k + "\t\t\t" + k);
                    double Efx = 0; Efx = fx11 + k + y;
                    double ansI = 0; ansI = (3 * h / 8) * Efx;
                    listBox1.Items.Add("===============================================================================");
                    listBox1.Items.Add("\t\t\tI = " + Math.Round(Efx, 4));
                }
            }
            catch (SystemException exa) { MessageBox.Show(exa.Message);
        }
        }
        private double fx(double x)
        {
            float x2, x1, x3, x4, C = 0;
            x2 = float.Parse(txtx2.Text);
            x1 = float.Parse(txtx1.Text);
            x3 = float.Parse(txtx3.Text);
            x4 = float.Parse(txtx4.Text);
            C = float.Parse(txtC.Text);
            x = Math.Round((x4 * Math.Pow(x, 4)) + (x3 * Math.Pow(x, 3)) + (x2 * Math.Pow(x, 2)) + (x1 * Math.Pow(x, 1)) + C);
            return x;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txta.Text = "";
            txtb.Text = "";
            txtC.Text = "";
            txtx1.Text = "";
            txtx2.Text = "";
            txtx3.Text = "";
            txtx4.Text = "";
            listBox1.Items.Clear();
            label13.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
