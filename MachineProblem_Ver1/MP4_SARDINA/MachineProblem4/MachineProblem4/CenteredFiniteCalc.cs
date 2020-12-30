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
    public partial class CenteredFiniteCalc : Form
    {
        public CenteredFiniteCalc()
        {
            InitializeComponent();
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
            txth1.Text = "";
            txth2.Text = "";
            txtxi.Text = "";
            txtC.Text = "";
            txtx1.Text = "";
            txtx2.Text = "";
            txtx3.Text = "";
            txtx4.Text = "";
            listBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double xi, h1, h2, low, big, fxi1, fxip1, fpxi1, xip1, fpxi2, xip2, fxip2, fxi2, xim1, xim2, dxim1, fxim2, fxim1, D;
            xi = double.Parse(txtxi.Text);
            h1 = double.Parse(txth1.Text);
            h2 = double.Parse(txth2.Text);
            if (h1 < h2)
            {
                low = h1; big = h2; //1
                fxi1 = fx(xi); xip1 = xi + (1 * low);
                xim1 = xi - (1 * low);
                fxip1 = fx(xip1);
                fxim1 = fx(xim1);
                fpxi1 = (fxip1 - fxim1) / (2 * low);
                //2
                fxi2 = fx(xi); xip2 = xi + (1 * big);
                xim2 = xi - (1 * big);
                fxip2 = fx(xip2);
                fxim2 = fx(xim2); fpxi2 = (fxip2 - fxim2) / (2 * big);
                D = fpxi1 + ((1 / (Math.Pow(2, 2) - 1)) * (fpxi1 - fpxi2));
                listBox1.Items.Add("CENTERED FINITE DIVIDED DIFFERENCE");
                listBox1.Items.Add("f(xi) =" + Math.Round(fxi2, 4));
                listBox1.Items.Add("f'(h1) = " + Math.Round(fpxi1, 4));
                listBox1.Items.Add("f'(h2) = " + Math.Round(fpxi2, 4));
                listBox1.Items.Add("");
                listBox1.Items.Add("===============================================================================");
                listBox1.Items.Add("D(a) = " + Math.Round(D, 4));
            }
            else
            {
                low = h2;
                big = h1;
                fxi1 = fx(xi);
                xip1 = xi + (1 * low);
                xim1 = xi - (1 * low);
                fxip1 = fx(xip1);
                fxim1 = fx(xim1);
                fpxi1 = (fxip1 - fxim1) / (2 * low);
                //2 
                fxi2 = fx(xi); xip2 = xi + (1 * big);
                xim2 = xi - (1 * big);
                fxip2 = fx(xip2);
                fxim2 = fx(xim2);
                fpxi2 = (fxip2 - fxim2) / (2 * big);
                D = fpxi1 + ((1 / (Math.Pow(2, 2) - 1)) * (fpxi1 - fpxi2));
                listBox1.Items.Add("CENTERED FINITE DIVIDED DIFFERENCE");
                listBox1.Items.Add("f(xi) =" + Math.Round(fxi2, 4));
                listBox1.Items.Add("f'(h1) = " + Math.Round(fpxi2, 4));
                listBox1.Items.Add("f'(h2) = " + Math.Round(fpxi1, 4));
                listBox1.Items.Add("");
                listBox1.Items.Add("===============================================================================");
                listBox1.Items.Add("D(a) = " + Math.Round(D, 4));
            }
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
