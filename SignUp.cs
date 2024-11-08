﻿using System;
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
    public partial class SignUp : UserControl
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
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

        private void backButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in HomePage.Instance.PnlContainer.Controls.OfType<UserControl>())
            {
                control.Hide();
            }
        }
    }
}
