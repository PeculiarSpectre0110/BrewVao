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
    public partial class HomePage : Form
    {
        private Stack<UserControl> navigationStack = new Stack<UserControl>();
        static HomePage _obj;

        public static HomePage Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new HomePage();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }

        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            _obj = this;

            foreach (Control control in PnlContainer.Controls.OfType<UserControl>())
            {
                control.Hide();
            }
            
            Login login = new Login();
            login.Dock = DockStyle.Fill;
            HomePage.Instance.PnlContainer.Controls.Add(login);
            login.BringToFront();
            
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            _obj = this;

            foreach (Control control in PnlContainer.Controls.OfType<UserControl>())
            {
                control.Hide();
            }

            SignUp signUp = new SignUp();
            signUp.Dock = DockStyle.Fill;
            HomePage.Instance.PnlContainer.Controls.Add(signUp);
            signUp.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
