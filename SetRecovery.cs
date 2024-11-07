using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrewVao
{
    public partial class SetRecovery : UserControl
    {
        public SetRecovery()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in HomePage.Instance.PnlContainer.Controls.OfType<UserControl>())
            {
                control.Hide();
            }
        }
    }
}
