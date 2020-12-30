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
    public partial class MP3UserControl1 : UserControl
    {
        public MP3UserControl1()
        {
            InitializeComponent();
            mullersUserControl11.Hide();
            gsUserControl11.Hide();
            croutsUserControl11.Hide();
        }
        private void back_Click(object sender, EventArgs e)
        {
            mullersUserControl11.Hide();
            gsUserControl11.Hide();
            croutsUserControl11.Hide();
        }

        private void muller_Click(object sender, EventArgs e)
        {
            mullersUserControl11.Show();
            mullersUserControl11.BringToFront();
        }

        private void gaussseidel_Click(object sender, EventArgs e)
        {
            gsUserControl11.Show();
            gsUserControl11.BringToFront();
        }

        private void crouts_Click(object sender, EventArgs e)
        {
            croutsUserControl11.Show();
            croutsUserControl11.BringToFront();
        }
    }
}
