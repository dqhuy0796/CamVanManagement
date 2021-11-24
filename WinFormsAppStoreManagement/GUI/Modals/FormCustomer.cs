using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WinFormsAppStoreManagement.Controller;
using WinFormsAppStoreManagement.Database;

namespace WinFormsAppStoreManagement.UserInterface.Modals
{
    public partial class FormCustomer : Form
    {
        #region private system method

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #endregion

        #region Fields
        private Customer baseCustomer;
        #endregion

        #region Constructors
        public FormCustomer()
        {
            InitializeComponent();
        }
        public FormCustomer(bool theme)
        {
            InitializeComponent();
            Customize(theme);
            lblTitle.Text = "Thêm khách hàng mới";
            pnlSaveAndQuitButton.Visible = true;
        }
        public FormCustomer(bool theme, Customer customer)
        {
            InitializeComponent();
            Customize(theme);
            lblTitle.Text = "Thông tin khách hàng";
            LoadData(customer);
            baseCustomer = customer;
            pnlModifyButton.Visible = true;
            pnlRemoveButton.Visible = true;
        }
        #endregion

        #region UI Methods
        private void Customize(bool darkmode)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            btnCancel.TextAlign = ContentAlignment.BottomCenter;
            btnCancel.Padding = new Padding(0, 0, 0, 6);
            btnSaveAndQuit.TextAlign = ContentAlignment.BottomCenter;
            btnSaveAndQuit.Padding = new Padding(0, 0, 0, 6);

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

            lblTitle.ForeColor = HtmlColor.light1;
            lblAddress.ForeColor = lblTitle.ForeColor;
            lblBirth.ForeColor = lblTitle.ForeColor;
            lblCIC.ForeColor = lblTitle.ForeColor;
            lblDescription.ForeColor = lblTitle.ForeColor;
            lblGender.ForeColor = lblTitle.ForeColor;
            lblId.ForeColor = lblTitle.ForeColor;
            lblName.ForeColor = lblTitle.ForeColor;
            lblTel.ForeColor = lblTitle.ForeColor;
            lblLevel.ForeColor = lblTitle.ForeColor;
            lblPoint.ForeColor = lblTitle.ForeColor;

            txtAddress.ForeColor = HtmlColor.light1;
            txtCIC.ForeColor = txtAddress.ForeColor;
            txtDescription.ForeColor = txtAddress.ForeColor;
            txtId.ForeColor = txtAddress.ForeColor;
            txtName.ForeColor = txtAddress.ForeColor;
            txtTel.ForeColor = txtAddress.ForeColor;
            txtLevel.ForeColor = txtAddress.ForeColor;
            txtPoint.ForeColor = txtAddress.ForeColor;

            txtAddress.FillColor = HtmlColor.dark3;
            txtCIC.FillColor = txtAddress.FillColor;
            txtDescription.FillColor = txtAddress.FillColor;
            txtId.FillColor = txtAddress.FillColor;
            txtName.FillColor = txtAddress.FillColor;
            txtTel.FillColor = txtAddress.FillColor;
            txtLevel.FillColor = txtAddress.FillColor;
            txtPoint.FillColor = txtAddress.FillColor;

            rdoOther.ForeColor = HtmlColor.light1;
            rdoMale.ForeColor = rdoOther.ForeColor;
            rdoFemale.ForeColor = rdoOther.ForeColor;

            btnQuit.BackgroundImage = Properties.Resources.white_exit_32;
        }
        private void LightMode()
        {
            pnlHeader.BackColor = HtmlColor.white;
            pnlFooter.BackColor = pnlHeader.BackColor;
            pnlContainer.BackColor = HtmlColor.light3;

            lblTitle.ForeColor = HtmlColor.dark1;
            lblAddress.ForeColor = lblTitle.ForeColor;
            lblBirth.ForeColor = lblTitle.ForeColor;
            lblCIC.ForeColor = lblTitle.ForeColor;
            lblDescription.ForeColor = lblTitle.ForeColor;
            lblGender.ForeColor = lblTitle.ForeColor;
            lblId.ForeColor = lblTitle.ForeColor;
            lblName.ForeColor = lblTitle.ForeColor;
            lblTel.ForeColor = lblTitle.ForeColor;
            lblLevel.ForeColor = lblTitle.ForeColor;
            lblPoint.ForeColor = lblTitle.ForeColor;

            txtAddress.ForeColor = HtmlColor.dark1;
            txtCIC.ForeColor = txtAddress.ForeColor;
            txtDescription.ForeColor = txtAddress.ForeColor;
            txtId.ForeColor = txtAddress.ForeColor;
            txtName.ForeColor = txtAddress.ForeColor;
            txtTel.ForeColor = txtAddress.ForeColor;
            txtLevel.ForeColor = txtAddress.ForeColor;
            txtPoint.ForeColor = txtAddress.ForeColor;

            txtAddress.FillColor = HtmlColor.white;
            txtCIC.FillColor = txtAddress.FillColor;
            txtDescription.FillColor = txtAddress.FillColor;
            txtId.FillColor = txtAddress.FillColor;
            txtName.FillColor = txtAddress.FillColor;
            txtTel.FillColor = txtAddress.FillColor;
            txtLevel.FillColor = txtAddress.FillColor;
            txtPoint.FillColor = txtAddress.FillColor;

            rdoOther.ForeColor = HtmlColor.dark1;
            rdoMale.ForeColor = rdoOther.ForeColor;
            rdoFemale.ForeColor = rdoOther.ForeColor;

            btnQuit.BackgroundImage = Properties.Resources.black_exit_32;
        }
        #endregion

        #region Data Methods
        private void ConvertGenderToRadio(string gender)
        {
            switch (gender)
            {
                case "Nam":
                    rdoMale.Checked = true;
                    rdoFemale.Checked = false;
                    rdoOther.Checked = false;
                    break;
                case "Nữ":
                    rdoMale.Checked = false;
                    rdoFemale.Checked = true;
                    rdoOther.Checked = false;
                    break;
                case "Khác":
                    rdoMale.Checked = false;
                    rdoFemale.Checked = false;
                    rdoOther.Checked = true;
                    break;
                default:
                    rdoMale.Checked = false;
                    rdoFemale.Checked = false;
                    rdoOther.Checked = false;
                    break;
            }
        }
        private string ConvertRadioToGender()
        {
            if (rdoMale.Checked == true && rdoFemale.Checked == false && rdoOther.Checked == false)
            {
                return "Nam";
            }
            if (rdoMale.Checked == false && rdoFemale.Checked == true && rdoOther.Checked == false)
            {
                return "Nữ";
            }
            if (rdoMale.Checked == false && rdoFemale.Checked == false && rdoOther.Checked == true)
            {
                return "Khác";
            }
            return "Khác";
        }
        private void LoadData(Customer customer)
        {
            txtId.Text = customer.CustomerId.ToString();
            txtName.Text = customer.CustomerName.ToString();
            txtLevel.Text = customer.CustomerLevel.ToString();
            txtPoint.Text = customer.CustomerPoint.ToString();
            ConvertGenderToRadio(customer.GenderName);
            txtTel.Text = customer.CustomerTel.ToString();
            txtCIC.Text = customer.CustomerCIC.ToString();
            dtpBirth.Value = customer.CustomerBirth;
            txtAddress.Text = customer.CustomerAddress.ToString();
            txtDescription.Text = customer.CustomerDescription.ToString();
        }
        private bool isValid()
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text)
                && !string.IsNullOrWhiteSpace(txtAddress.Text)
                && !string.IsNullOrWhiteSpace(txtTel.Text)
                && char.IsDigit(txtTel.Text.ToString(), txtTel.Text.Length - 1)
                && char.IsDigit(txtPoint.Text, txtPoint.Text.Length - 1)
                )
            {
                return true;
            }
            return false;
        }
        private Customer GetAllData()
        {
            return new Customer(
                    txtId.Text,
                    txtName.Text,
                    ConvertRadioToGender(),
                    txtCIC.Text,
                    (DateTime)dtpBirth.Value,
                    txtTel.Text,
                    txtAddress.Text,
                    txtLevel.Text,
                    Convert.ToInt32(txtPoint.Text),
                    txtDescription.Text
                );
        }
        private int SaveCustomer()
        {
            if (isValid())
            {
                return CustomerBLL.Instance.AddCustomerToDatabase(GetAllData());
            }
            return 0;
        }
        private int ModifyCustomer()
        {
            if (isValid())
            {
                return CustomerBLL.Instance.ModifyCustomerInDatabase(GetAllData());
            }
            return 0;
        }
        private int RemoveCustomer()
        {
            if (isValid())
            {
                return CustomerBLL.Instance.RemoveCustomerFromDatabase(txtId.Text);
            }
            return 0;
        }
        #endregion

        #region Events
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveAndQuit_Click(object sender, EventArgs e)
        {
            if (SaveCustomer() != 0)
                this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (RemoveCustomer() != 0)
                this.Close();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (ModifyCustomer() != 0)
                this.Close();
        }
        private void txtPoint_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPoint.Text))
            {
                if (char.IsDigit(txtPoint.Text, txtPoint.Text.Length - 1))
                {
                    if (Convert.ToInt32(txtPoint.Text) >= 5000)
                    {
                        txtLevel.Text = "Vàng";
                    }
                    else if (Convert.ToInt32(txtPoint.Text) < 5000 && Convert.ToInt32(txtPoint.Text) >= 2000)
                    {
                        txtLevel.Text = "Bạc";
                    }
                    else if (Convert.ToInt32(txtPoint.Text) < 2000 && Convert.ToInt32(txtPoint.Text) > 0)
                    {
                        txtLevel.Text = "Đồng";
                    }
                    else
                    {
                        txtLevel.Text = "Không";
                    }
                }
            }
            else
            {
                txtLevel.Text = "Không";
            }
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}
