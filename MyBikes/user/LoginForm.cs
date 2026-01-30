using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBikes.user
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (this.textBoxUser.Text == "user1" && this.textBoxPassword.Text == "123")
            {
                Form1 MyMainForm = new Form1();

                this.Hide(); //To hide when the principal form is opened.

                MyMainForm.ShowDialog();

                this.Dispose(); //Important to type!
            }

            else
            {
                MessageBox.Show("Invalid Input (user or password are not correct)");
                this.textBoxUser.Clear();
                this.textBoxPassword.Clear();

                this.textBoxUser.Focus();
            }
        }
    }
}