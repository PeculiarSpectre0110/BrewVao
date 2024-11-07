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
    public partial class LoginAdmin : UserControl
    {
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void recoverButton_Click(object sender, EventArgs e)
        {
            if (HomePage.Instance.PnlContainer.Controls.ContainsKey("Recovery"))
            {
                Control existingRecovery = HomePage.Instance.PnlContainer.Controls["Recovery"];
                HomePage.Instance.PnlContainer.Controls.Remove(existingRecovery);
                existingRecovery.Dispose(); // Dispose the old instance to free resources
            }

            // Create and add a fresh instance
            Recovery recovery = new Recovery();
            recovery.Dock = DockStyle.Fill;
            HomePage.Instance.PnlContainer.Controls.Add(recovery);
            recovery.BringToFront();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in HomePage.Instance.PnlContainer.Controls.OfType<UserControl>())
            {
                control.Hide();
            }
        }
    }
}
