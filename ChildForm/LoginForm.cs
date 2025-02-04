using Ligga;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liga.ChildForm
{
    public partial class LoginForm : Form
    {
        private Session session;
        public LoginForm (Session session)
        {
            InitializeComponent();
            this.session = session;
        }

        public void logBtn_Click(object sender, EventArgs e)
        {
            if (LoginBox.Text == "admin" && PasswordBox.Text == "admin")
            {
                session.setStatus(true);
            }
            else
            {
                MessageBox.Show("Bledne dane logowania!");
            }
            LoginBox.Clear();
            PasswordBox.Clear();
        }
    }
}
