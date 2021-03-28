using AppFB.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            btnLogin.TabStop = false;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string userName = txbName.Text;
            string passWord = txbPassword.Text;
            if (Login(userName, passWord))
            {
                ResultForm f = new ResultForm();
                this.Hide();
                f.Show();

            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
            bool Login(string a, string b)
            {
                return AccountDAO.Instance.Login(a, b);
            }

        }

        private void TxbPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void TxbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxbName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txbPassword.Focus();
            }
        }

        private void TxbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                btnLogin.Focus();
            }
        }
    }
}
