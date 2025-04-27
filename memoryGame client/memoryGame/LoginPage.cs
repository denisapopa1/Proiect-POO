using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memoryGame
{
    public partial class LoginPage : Form
    {
        FirstForm firstForm;
        GameArea area;
        public LoginPage(FirstForm f)
        {
            InitializeComponent();
            firstForm = f;
            area = new GameArea();
            HelloThing.Anchor = AnchorStyles.None; 
            HelloThing.Location = new Point((this.ClientSize.Width - HelloThing.Width)/2, (this.ClientSize.Height - HelloThing.Height)/4);
            YourName.Anchor = AnchorStyles.None;
            btnLog.Anchor = AnchorStyles.None;
            textBox1.Anchor = AnchorStyles.None;
        }


        private void btnLog_Click(object sender, EventArgs e)
        {
            this.Close();
            if (area.Created == false || area.IsDisposed)
            {
                area = new GameArea();
            }
            area.Show();
        }
    }
}
