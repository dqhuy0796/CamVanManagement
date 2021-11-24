using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WinFormsAppStoreManagement.Controller;
using WinFormsAppStoreManagement.DAL;

namespace WinFormsAppStoreManagement.UserInterface.MainForms
{
    public partial class FormLogin : Form
    {
        #region Drag form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #endregion

        #region Fields
        private Account loginAccount;
        public Account LoginAccount { get => loginAccount; set => loginAccount = value; }
        #endregion

        #region Constructor
        public FormLogin()
        {
            InitializeComponent();
            Customize();
        }
        #endregion

        #region UI Methods
        private void Customize()
        {
            // nothing here - Lmao
        }
        #endregion

        #region Data Methods
        private void AuthenticatePassword()
        {
            DataTable data = AccountBLL.Instance.Authentication(txtUsername.Text, txtPassword.Text);
            if (data.Rows.Count > 0)
            {
                /*None = 0, OK = 1, Cancel = 2, Abort = 3, Retry = 4, Ignore = 5, Yes = 6, No = 7*/
                LoginAccount = new Account(data.Rows[0]);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                txtPassword.Text = string.Empty;
                lblIncorrect.Text = string.Empty;
                lblIncorrect.Text = "Tài khoản hoặc mật khẩu không đúng!";
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    txtUsername.Focus();
                }
                else
                {
                    txtPassword.Focus();
                }
            }
        }
        #endregion

        #region Events
        private void pnlRight_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            FormConfirm frmConfirm = new FormConfirm("Bạn thực sự muốn thoát?", "Chắc chắn thoát", "Huỷ");
            if (frmConfirm.ShowDialog() == DialogResult.OK)
            {
                this.Close();
            }
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            AuthenticatePassword();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }

        private void txtUsername_DoEnter(object sender, EventArgs e)
        {
            txtPassword.Focus();
        }

        private void txtPassword_DoEnter(object sender, EventArgs e)
        {
            AuthenticatePassword();
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            lblIncorrect.ForeColor = HtmlColor.red;
            lblIncorrect.Text = string.Empty;
            lblIncorrect.Text = "Quên rồi thì gặp anh quản lý để xin lại nhé ☺";
        }
        #endregion
    }
}
