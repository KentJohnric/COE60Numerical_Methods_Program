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
    public partial class Mp4UserControl1 : UserControl
    {
        public Mp4UserControl1()
        {
            InitializeComponent();
            simpsonRuleUserControl11.Hide();
            centeredFiniteUserControl11.Hide();
            linearRegressionUserControl11.Hide();
            newtonInterpolationUserControl11.Hide();
        }

        private void muller_Click(object sender, EventArgs e)
        {
            simpsonRuleUserControl11.BringToFront();
            simpsonRuleUserControl11.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            simpsonRuleUserControl11.Hide();
            centeredFiniteUserControl11.Hide();
            linearRegressionUserControl11.Hide();
            newtonInterpolationUserControl11.Hide();
        }

        private void gaussseidel_Click(object sender, EventArgs e)
        {
            centeredFiniteUserControl11.BringToFront();
            centeredFiniteUserControl11.Show();
        }

        private void crouts_Click(object sender, EventArgs e)
        {
            linearRegressionUserControl11.BringToFront();
            linearRegressionUserControl11.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newtonInterpolationUserControl11.BringToFront();
            newtonInterpolationUserControl11.Show();
        }
    }
}
