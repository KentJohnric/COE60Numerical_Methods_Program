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
    public partial class GsUserControl1 : UserControl
    {

        double[] first = new double[10];
        double[] second = new double[10];
        double[] third = new double[10];
        double epsilon;
        double v1 = 0, v2 = 0, v3 = 0, temp1, temp2, temp3, tempf1, tempf2, tempf3;

        private void croutsUserControl11_Load(object sender, EventArgs e)
        {

        }

        private void btnGS_func3_Click(object sender, EventArgs e)
        {
            third[0] = double.Parse(textBox9.Text);
            third[1] = double.Parse(textBox10.Text);
            third[2] = double.Parse(textBox11.Text);
            third[3] = double.Parse(textBox12.Text);

            if (third[2] < third[0] || third[2] < third[1])
            {
                MessageBox.Show("X1 must have the Largest Value");
                for (int i = 0; i < 4; i++)
                {
                    third[i] = 0;
                }
            }
            else
            {
                flag3 = true;
            }
        }

        private void btnGS_func2_Click(object sender, EventArgs e)
        {
            second[0] = double.Parse(textBox5.Text);
            second[1] = double.Parse(textBox6.Text);
            second[2] = double.Parse(textBox7.Text);
            second[3] = double.Parse(textBox8.Text);

            if (second[1] < second[0] || second[1] < second[2])
            {
                MessageBox.Show("X2 must have the Largest Value");
                for (int i = 0; i < 4; i++)
                {
                    second[i] = 0;
                }

            }
            else
            {
                flag2 = true;
            }
        }

        private void btnGS_func1_Click(object sender, EventArgs e)
        {
            first[0] = double.Parse(textBox1.Text);
            first[1] = double.Parse(textBox2.Text);
            first[2] = double.Parse(textBox3.Text);
            first[3] = double.Parse(textBox4.Text);

            if (first[0] < first[1] || first[0] < first[2])
            {
                MessageBox.Show("X3 must have the Largest Value");
                for (int i = 0; i < 4; i++)
                {
                    first[i] = 0;
                }

            }
            else
            {
                flag1 = true;
            }
        }

        int iter = 0;
        bool flag1 = false, flag2 = false, flag3 = false;

        public GsUserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((flag1 && flag2 && flag3) == true)
            {
                epsilon = double.Parse(textBox20.Text);

                do
                {
                    temp1 = v1;
                    temp2 = v2;
                    temp3 = v3;

                    iter++;
                    v1 = (first[3] + (-1 * first[1] * v2) + (-1 * first[2] * v3)) / first[0];
                    v2 = (second[3] + (-1 * second[0] * v1) + (-1 * second[2] * v3)) / second[1];
                    v3 = (third[3] + (-1 * third[0] * v1) + (-1 * third[1] * v2)) / third[2];

                    listBox1.Items.Add(iter);
                    listBox2.Items.Add(v1.ToString("F4"));
                    listBox3.Items.Add(v2.ToString("F4"));
                    listBox4.Items.Add(v3.ToString("F4"));

                    tempf1 = Math.Abs(temp1 - v1);
                    tempf2 = Math.Abs(temp2 - v2);
                    tempf3 = Math.Abs(temp3 - v3);
                } while (tempf1 > epsilon && tempf2 > epsilon && tempf3 > epsilon);

                txtBoxGS_val1.Text = Convert.ToString(Math.Round(v1, 4));
                txtBoxGS_val2.Text = Convert.ToString(Math.Round(v2, 4));
                txtBoxGS_val3.Text = Convert.ToString(Math.Round(v3, 4));
            }
            else
            {
                MessageBox.Show("You must click ALL the 'DO' button first.");
            }
        }

        private void btnRegula_clear_Click(object sender, EventArgs e)
        {
            txtBoxGS_val1.Text = "";
            txtBoxGS_val2.Text = "";
            txtBoxGS_val3.Text = "";
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
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
            textBox20.Text = "";
        }
    }
}
