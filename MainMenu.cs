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
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Interface1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void recoveryButton_Click(object sender, EventArgs e)
        {
            if (HomePage.Instance.PnlContainer.Controls.ContainsKey("SetRecovery"))
            {
                Control existingSetRecovery = HomePage.Instance.PnlContainer.Controls["SetRecovery"];
                HomePage.Instance.PnlContainer.Controls.Remove(existingSetRecovery);
                existingSetRecovery.Dispose(); // Dispose the old instance to free resources
            }

            // Create and add a fresh instance
            SetRecovery setrecovery = new SetRecovery();
            setrecovery.Dock = DockStyle.Fill;
            HomePage.Instance.PnlContainer.Controls.Add(setrecovery);
            setrecovery.BringToFront();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in HomePage.Instance.PnlContainer.Controls.OfType<UserControl>())
            {
                control.Hide();
            }
        }

        private void suggestButton_Click(object sender, EventArgs e)
        {
            if (HomePage.Instance.PnlContainer.Controls.ContainsKey("Suggestion"))
            {
                Control existingSuggestion = HomePage.Instance.PnlContainer.Controls["Suggestion"];
                HomePage.Instance.PnlContainer.Controls.Remove(existingSuggestion);
                existingSuggestion.Dispose(); // Dispose the old instance to free resources
            }

            // Create and add a fresh instance
            Suggestion suggestion = new Suggestion();
            suggestion.Dock = DockStyle.Fill;
            HomePage.Instance.PnlContainer.Controls.Add(suggestion);
            suggestion.BringToFront();
        }

        private void discoverButton_Click(object sender, EventArgs e)
        {
            if (HomePage.Instance.PnlContainer.Controls.ContainsKey("ShopOverview"))
            {
                Control existingShopOverview = HomePage.Instance.PnlContainer.Controls["ShopOverview"];
                HomePage.Instance.PnlContainer.Controls.Remove(existingShopOverview);
                existingShopOverview.Dispose(); // Dispose the old instance to free resources
            }

            // Create and add a fresh instance
            ShopOverview shopoverview = new ShopOverview();
            shopoverview.Dock = DockStyle.Fill;
            HomePage.Instance.PnlContainer.Controls.Add(shopoverview);
            shopoverview.BringToFront();
        }
    }
}
