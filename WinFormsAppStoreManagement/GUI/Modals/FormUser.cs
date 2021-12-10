using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WinFormsAppStoreManagement.BLL;
using WinFormsAppStoreManagement.DAL;

namespace WinFormsAppStoreManagement.UserInterface.Modals
{
    public partial class FormUser : Form
    {
        #region Private system method

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #endregion

        #region Fields
        private Account currentAccount = new Account();
        public Account CurrentAccount { get => currentAccount; set => currentAccount = value; }
        #endregion

        #region Constructors
        public FormUser(bool theme)
        {
            InitializeComponent();
            Customize(theme);
            lblTitle.Text = "Thêm tài khoản mới";
            pnlSaveAndQuitButton.Visible = true;
        }
        public FormUser(bool theme, Account account)
        {
            InitializeComponent();
            Customize(theme);
            LoadData(account);
            pnlRemoveButton.Visible = true;
            pnlModifyButton.Visible = true;
        }
        #endregion

        #region UI methods
        private void Customize(bool darkmode)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            btnCancel.TextAlign = ContentAlignment.BottomCenter;
            btnCancel.Padding = new Padding(0, 0, 0, 5);
            btnModify.TextAlign = ContentAlignment.BottomCenter;
            btnModify.Padding = new Padding(0, 0, 0, 5);
            btnDiscard.TextAlign = ContentAlignment.BottomCenter;
            btnDiscard.Padding = new Padding(0, 0, 0, 5);
            btnSaveAndQuit.TextAlign = ContentAlignment.BottomCenter;
            btnSaveAndQuit.Padding = new Padding(0, 0, 0, 5);
            btnChangeAvatar.TextAlign = ContentAlignment.BottomCenter;
            btnChangeAvatar.Padding = new Padding(0, 0, 0, 5);
            btnConfirmChangePassword.TextAlign = ContentAlignment.BottomCenter;
            btnConfirmChangePassword.Padding = new Padding(0, 0, 0, 5);
            btnConfirmChangeDisplayName.TextAlign = ContentAlignment.BottomCenter;
            btnConfirmChangeDisplayName.Padding = new Padding(0, 0, 0, 5);
            if (darkmode == true)
            {
                DarkMode();
            }
            else
            {
                LightMode();
            }
        }
        private void DarkMode()
        {
            pnlHeader.BackColor = HtmlColor.dark2;
            pnlFooter.BackColor = pnlHeader.BackColor;
            pnlContainer.BackColor = HtmlColor.dark1;
            pnlLeft.FillColor = pnlContainer.BackColor;
            pnlLeft.RectColor = HtmlColor.border1;

            pnlContainer.ForeColor = HtmlColor.light1;
            lblTitle.ForeColor = pnlContainer.ForeColor;
            pnlChangePassword.ForeColor = pnlContainer.ForeColor;
            pnlChangeDisplayName.ForeColor = pnlContainer.ForeColor;

            txtNewDisplayName.ForeColor = HtmlColor.light1;
            txtCurrentPassword.ForeColor = txtNewDisplayName.ForeColor;
            txtNewPassword.ForeColor = txtNewDisplayName.ForeColor;
            txtConfirmPassword.ForeColor = txtNewDisplayName.ForeColor;

            txtNewDisplayName.FillColor = HtmlColor.dark3;
            txtCurrentPassword.FillColor = txtNewDisplayName.FillColor;
            txtNewPassword.FillColor = txtNewDisplayName.FillColor;
            txtConfirmPassword.FillColor = txtNewDisplayName.FillColor;

            btnQuit.BackgroundImage = Properties.Resources.white_exit_32;
            btnChangeDisplayName.FlatAppearance.MouseOverBackColor = pnlContainer.BackColor;
            btnChangeDisplayName.FlatAppearance.MouseDownBackColor = pnlContainer.BackColor;
            btnChangeDisplayName.Image = Properties.Resources.white_down_16;
            btnChangePassword.FlatAppearance.MouseOverBackColor = pnlContainer.BackColor;
            btnChangePassword.FlatAppearance.MouseDownBackColor = pnlContainer.BackColor;
            btnChangePassword.Image = Properties.Resources.white_down_16;
        }
        private void LightMode()
        {
            pnlHeader.BackColor = HtmlColor.white;
            pnlFooter.BackColor = pnlHeader.BackColor;
            pnlContainer.BackColor = HtmlColor.light3;
            pnlLeft.FillColor = pnlContainer.BackColor;
            pnlLeft.RectColor = HtmlColor.border2;

            pnlContainer.ForeColor = HtmlColor.dark1;
            lblTitle.ForeColor = pnlContainer.ForeColor;
            pnlChangePassword.ForeColor = pnlContainer.ForeColor;
            pnlChangeDisplayName.ForeColor = pnlContainer.ForeColor;

            txtNewDisplayName.ForeColor = HtmlColor.dark1;
            txtCurrentPassword.ForeColor = txtNewDisplayName.ForeColor;
            txtNewPassword.ForeColor = txtNewDisplayName.ForeColor;
            txtConfirmPassword.ForeColor = txtNewDisplayName.ForeColor;

            txtNewDisplayName.FillColor = HtmlColor.white;
            txtCurrentPassword.FillColor = txtNewDisplayName.FillColor;
            txtNewPassword.FillColor = txtNewDisplayName.FillColor;
            txtConfirmPassword.FillColor = txtNewDisplayName.FillColor;

            btnQuit.BackgroundImage = Properties.Resources.black_exit_32;
            btnChangeDisplayName.FlatAppearance.MouseOverBackColor = pnlContainer.BackColor;
            btnChangeDisplayName.FlatAppearance.MouseDownBackColor = pnlContainer.BackColor;
            btnChangeDisplayName.Image = Properties.Resources.black_down_16;
            btnChangePassword.FlatAppearance.MouseOverBackColor = pnlContainer.BackColor;
            btnChangePassword.FlatAppearance.MouseDownBackColor = pnlContainer.BackColor;
            btnChangePassword.Image = Properties.Resources.black_down_16;
        }
        #endregion

        #region Data Methods
        private void LoadData(Account account)
        {
            lblTitle.Text = $"Xin chào {account.DisplayName}";
            lblUsername.Text = account.Username;
            lblTypeAccount.Text = account.TypeAccount;
            lblDisplayName.Text = account.DisplayName;
            picAvatar.Image = account.Avatar;
            CurrentAccount = account;
        }
        private bool IsValidPasswordChanged()
        {
            if (txtCurrentPassword.Text == CurrentAccount.Password 
                && !string.IsNullOrWhiteSpace(txtNewPassword.Text)
                && !string.IsNullOrWhiteSpace(txtConfirmPassword.Text)
                && txtNewPassword.Text == txtConfirmPassword.Text)
            {
                return true;
            }
            return false;
        }
        private bool IsValidNameChanged()
        {
            if (!string.IsNullOrWhiteSpace(txtNewDisplayName.Text)
                && txtNewDisplayName.Text != CurrentAccount.DisplayName)
            {
                return true;
            }
            return false;
        }
        private Account GetAccountData()
        {
            string password = (IsValidPasswordChanged()) ? txtNewPassword.Text : CurrentAccount.Password;
            string displayname = (IsValidNameChanged()) ? txtNewDisplayName.Text : CurrentAccount.DisplayName;
            return new Account(
                lblUsername.Text,
                password,
                CurrentAccount.TypeAccount,
                displayname,
                CurrentAccount.EmployeeId,
                picAvatar.Image
                );
        }
        private int ModifyAccount()
        {
            if (IsValidNameChanged() || IsValidPasswordChanged() || picAvatar.Image != CurrentAccount.Avatar)
            {
                int result = (picAvatar.Image != CurrentAccount.Avatar)
                    ? AccountBLL.Instance.ModifyAccountInDatabaseWithImage(GetAccountData())
                    : AccountBLL.Instance.ModifyAccountInDatabaseWithoutImage(GetAccountData());
                CurrentAccount = GetAccountData();
                return result;
            }
            return 0;
        }
        #endregion

        #region Events
        private void btnChangeDisplayName_Click(object sender, EventArgs e)
        {
            if (pnlChangeDisplayName.Visible == true)
            {
                pnlChangeDisplayName.Visible = false;
            }
            else
            {
                pnlChangeDisplayName.Visible = true;
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (pnlChangePassword.Visible == true)
            {
                pnlChangePassword.Visible = false;
            }
            else
            {
                pnlChangePassword.Visible = true;
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangeAvatar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif", Multiselect = false })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picAvatar.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if(ModifyAccount()!= 0)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Nothing change");
            }
        }
        #endregion
    }
}
