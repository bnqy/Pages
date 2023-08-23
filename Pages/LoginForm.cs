using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pages
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.passBox.AutoSize = false;
            this.passBox.Size = new Size(this.passBox.Size.Width, 35);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeLabel_MouseEnter(object sender, EventArgs e)
        {
            closeLabel.ForeColor = Color.White;
        }

        private void closeLabel_MouseLeave(object sender, EventArgs e)
        {
            closeLabel.ForeColor = Color.Black;
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
