using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordBasic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtPassword.Tag.ToString())
            {
                MessageBox.Show("Password Correct", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult response = MessageBox.Show("Password Incorrect.", "Access Denied.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (response == DialogResult.Retry)
                {
                    txtPassword.SelectionStart = 0;
                    txtPassword.SelectionLength = txtPassword.Text.Length;
                    txtPassword.Focus();
                }
                else
                {
                    Close();
                }
            }
        }
    }
}
