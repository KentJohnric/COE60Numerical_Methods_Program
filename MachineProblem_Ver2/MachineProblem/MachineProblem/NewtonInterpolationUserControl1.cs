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
    public partial class NewtonInterpolationUserControl1 : UserControl
    {
        public NewtonInterpolationUserControl1()
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
                double f1x1, f1x2, f1x3, f1x4, f2x1, f2x2, f2x3, f3x1, f3x2, f4x1, b0, b1, b2, b3, b4 = 0;
                f1x1 = Math.Round((fx2 - fx1) / (x2 - x1), 4);
                f1x2 = Math.Round((fx3 - fx2) / (x3 - x2), 4);
                f1x3 = Math.Round((fx4 - fx3) / (x4 - x3), 4);
                f1x4 = Math.Round((fx5 - fx4) / (x5 - x4), 4);
                f2x1 = Math.Round((f1x2 - f1x1) / (x3 - x1), 4);
                f2x2 = Math.Round((f1x3 - f1x2) / (x4 - x2), 4);
                f2x3 = Math.Round((f1x4 - f1x3) / (x5 - x3), 4);
                f3x1 = Math.Round((f2x2 - f2x1) / (x4 - x1), 4);
                f3x2 = Math.Round((f2x3 - f2x2) / (x5 - x1), 4);
                f4x1 = Math.Round((f3x2 - f3x1) / (x5 - x1), 4);
                b0 = fx1; b1 = f1x1; b2 = f2x1; b3 = f3x1;
                b4 = f4x1;
                double x = double.Parse(txtX.Text);
                double answer;
                /*  label5.Visible = true; 
                  label6.Visible = true;
                  label7.Visible = true; 
                  label8.Visible = true;
                  label9.Visible = true; 
                  label10.Visible = true;*/
                listBox1.Items.Add(x1 + "\t" + fx1 + "\t" + f1x1 + "\t" + f2x1 + "\t" + f3x1 + "\t" + f4x1);
                listBox1.Items.Add(x2 + "\t" + fx2 + "\t" + f1x2 + "\t" + f2x2 + "\t" + f3x2);
                listBox1.Items.Add(x3 + "\t" + fx3 + "\t" + f1x3 + "\t" + f2x3);
                listBox1.Items.Add(x4 + "\t" + fx4 + "\t" + f1x4);
                listBox1.Items.Add(x5 + "\t" + fx5);
                answer = Math.Round((b0 + (b1 * (x - x1)) + (b2 * (x - x1) * (x - x2)) + (b3 * (x - x1) * (x - x2) * (x - x3)) + (b4 * (x - x1) * (x - x2) * (x - x3) * (x - x4))), 4);
                listBox1.Items.Add("");
                listBox1.Items.Add("==============================================================================");
                listBox1.Items.Add("f(" + x.ToString() + ") =" + answer.ToString());
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
            txtX.Text = "";
            /* label5.Visible = false; 
             label6.Visible = false;
             label7.Visible = false; 
             label8.Visible = false; 
             label9.Visible = false;
             label10.Visible = false;*/
        }
    }
}
