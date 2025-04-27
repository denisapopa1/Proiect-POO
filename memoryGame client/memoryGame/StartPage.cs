using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memoryGame
{
    public partial class FirstForm : Form
    {
        LoginPage loginPage;
        public FirstForm()
        {
            InitializeComponent();
            loginPage = new LoginPage(this);
            this.BackgroundImage = Properties.Resources.fundal1; 
            this.BackgroundImageLayout = ImageLayout.Stretch;
            Titlu.Anchor = AnchorStyles.None;
            btnSart.Anchor = AnchorStyles.None;
        }

        private void btnSart_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (loginPage.Created == false)
            {
                loginPage = new LoginPage(this);
            }

            loginPage.Show();
        }

        private void FirstForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
