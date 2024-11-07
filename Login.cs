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
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (HomePage.Instance.PnlContainer.Controls.ContainsKey("MainMenu"))
            {
                Control existingMainMenu = HomePage.Instance.PnlContainer.Controls["MainMenu"];
                HomePage.Instance.PnlContainer.Controls.Remove(existingMainMenu);
                existingMainMenu.Dispose(); // Dispose the old instance to free resources
            }

            // Create and add a fresh instance
            MainMenu mainmenu = new MainMenu();
            mainmenu.Dock = DockStyle.Fill;
            HomePage.Instance.PnlContainer.Controls.Add(mainmenu);
            mainmenu.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in HomePage.Instance.PnlContainer.Controls.OfType<UserControl>())
            {
                control.Hide();
            }
        }

        private void recoverButton_Click_1(object sender, EventArgs e)
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

        private void adminButton_Click_1(object sender, EventArgs e)
        {
            if (HomePage.Instance.PnlContainer.Controls.ContainsKey("LoginAdmin"))
            {
                Control existingLoginAdmin = HomePage.Instance.PnlContainer.Controls["LoginAdmin"];
                HomePage.Instance.PnlContainer.Controls.Remove(existingLoginAdmin);
                existingLoginAdmin.Dispose(); // Dispose the old instance to free resources
            }

            // Create and add a fresh instance
            LoginAdmin admin = new LoginAdmin();
            admin.Dock = DockStyle.Fill;
            HomePage.Instance.PnlContainer.Controls.Add(admin);
            admin.BringToFront();
        }
    }
}
