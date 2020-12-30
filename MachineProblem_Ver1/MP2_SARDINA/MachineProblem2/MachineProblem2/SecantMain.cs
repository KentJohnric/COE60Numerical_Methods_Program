using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineProblem2
{
    public partial class SecantWindow : Form
    {
        public SecantWindow()
        {
            InitializeComponent();
        }

        private void SecantButton_Click(object sender, EventArgs e)
        {
            MachineProblem2.frmSecant form = new MachineProblem2.frmSecant();
            form.ShowDialog();
        }
    }
}
