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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MullerBTN_Click(object sender, EventArgs e)
        {
            MachineProblem3.MullersCalc form = new MachineProblem3.MullersCalc();
            form.ShowDialog();
        }

        private void CroutsBTN_Click(object sender, EventArgs e)
        {
            MachineProblem3.CroutsCalc form = new MachineProblem3.CroutsCalc();
            form.ShowDialog();
        }

        private void GSBTN_Click(object sender, EventArgs e)
        {
            MachineProblem3.GsCalc2 form = new MachineProblem3.GsCalc2();
            form.ShowDialog();
        }
    }
}
