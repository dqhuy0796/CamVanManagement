using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WinFormsAppStoreManagement.BLL;
using WinFormsAppStoreManagement.DAL;
using WinFormsAppStoreManagement.UserInterface.Modals;

namespace WinFormsAppStoreManagement.UserInterface.MainForms
{
    public partial class FormMainMenu : Form
    {
        #region Field
        private Button currentBtn;
        private Panel leftBorderBtn;
        private Form activeForm;
        private bool isDarkMode = false;
        private Account currentAccount = new Account();
        public bool isExit = true;
        public event EventHandler LogOut;
        public Account CurrentAccount { get => currentAccount; set => currentAccount = value; }
        #endregion

        #region Constructor
        public FormMainMenu(Account account)
        {
            InitializeComponent();
            Customize(false);
            Permission(AccountBLL.Instance.ConvertRoleToInt32(account.TypeAccount));
            CurrentAccount = account;
            LoadAccountData(CurrentAccount);
        }
        #endregion

        #region UI Methods
        private void DarkMode()
        {
            isDarkMode = true;

            pnlSearchbox.FillColor = HtmlColor.dark2;
            txtSearchbox.BackColor = HtmlColor.dark2;
            pnlSearchbox.RectColor = HtmlColor.border1;
            btnSearch.BackColor = HtmlColor.dark3;
            btnSearch.FlatAppearance.BorderColor = HtmlColor.border1;
            btnSearch.Image = Properties.Resources.white_search_32;

            pnlNavbar.BackColor = HtmlColor.dark2;
            pnlTitlebar.BackColor = pnlNavbar.BackColor;
            pnlContainer.BackColor = HtmlColor.dark1;
            btnNavResize.Image = Properties.Resources.white_menu_32;
            picLogo.Image = Properties.Resources.White_Rectanngle_Logo;
            foreach (Button navBtn in pnlNavbar.Controls.OfType<Button>())
            {
                navBtn.ForeColor = HtmlColor.white;
                navBtn.BackColor = pnlNavbar.BackColor;
                navBtn.FlatAppearance.BorderColor = pnlNavbar.BackColor;
                navBtn.FlatAppearance.MouseOverBackColor = HtmlColor.dark4;
                navBtn.FlatAppearance.MouseDownBackColor = HtmlColor.dark4;
                switch (navBtn.Tag.ToString().ToLower())
                {
                    case "tài khoản":
                        navBtn.Image = Properties.Resources.white_account_32;
                        break;
                    case "nhân viên":
                        navBtn.Image = Properties.Resources.white_employee_32;
                        break;
                    case "khách hàng":
                        navBtn.Image = Properties.Resources.white_customer_32;
                        break;
                    case "mặt hàng":
                        navBtn.Image = Properties.Resources.white_hamburger_32;
                        break;
                    case "đơn hàng":
                        navBtn.Image = Properties.Resources.white_price_tag_32;
                        break;
                    case "hoá đơn":
                        navBtn.Image = Properties.Resources.white_bill_32;
                        break;
                    case "ng. vật liệu":
                        navBtn.Image = Properties.Resources.white_material_32;
                        break;
                    case "xuất/nhập":
                        navBtn.Image = Properties.Resources.white_arrow_32;
                        break;
                    case "nhà c. cấp":
                        navBtn.Image = Properties.Resources.white_supplier_32;
                        break;
                    case "cài đặt":
                        navBtn.Image = Properties.Resources.white_setting_32;
                        break;
                    default:
                        break;
                }
            }

            pnlRight.FillColor = HtmlColor.dark2;
            pnlRight.ForeColor = HtmlColor.white;
            pnlRight.RectColor = HtmlColor.border1;
            picWorkedTimeInMonth.Image = Properties.Resources.white_employee_32;
            picWorkedTimeToday.Image = Properties.Resources.white_clock_32;
            picSaleInMonth.Image = Properties.Resources.white_coin_32;
            picSaleInToday.Image = Properties.Resources.white_hamburger_32;

            donutChart.ChartStyleType = Sunny.UI.UIChartStyleType.Dark;
            lineChart.ChartStyleType = Sunny.UI.UIChartStyleType.Dark;
            barChart.ChartStyleType = Sunny.UI.UIChartStyleType.Dark;
        }
        private void LightMode()
        {
            isDarkMode = false;

            pnlSearchbox.FillColor = HtmlColor.white;
            txtSearchbox.BackColor = HtmlColor.white;
            pnlSearchbox.RectColor = HtmlColor.border2;
            btnSearch.BackColor = HtmlColor.light2;
            btnSearch.FlatAppearance.BorderColor = HtmlColor.border2;
            btnSearch.Image = Properties.Resources.black_search_32;

            pnlNavbar.BackColor = HtmlColor.white;
            pnlTitlebar.BackColor = pnlNavbar.BackColor;
            pnlContainer.BackColor = HtmlColor.light2;
            btnNavResize.Image = Properties.Resources.black_menu_32;
            picLogo.Image = Properties.Resources.CamVan_Rectangle_Logo;
            foreach (Button navBtn in pnlNavbar.Controls.OfType<Button>())
            {
                navBtn.ForeColor = HtmlColor.black;
                navBtn.BackColor = pnlNavbar.BackColor;
                navBtn.FlatAppearance.BorderColor = pnlNavbar.BackColor;
                navBtn.FlatAppearance.MouseOverBackColor = HtmlColor.light2;
                navBtn.FlatAppearance.MouseDownBackColor = HtmlColor.light2;
                switch (navBtn.Tag.ToString().ToLower())
                {
                    case "tài khoản":
                        navBtn.Image = Properties.Resources.black_account_32;
                        break;
                    case "nhân viên":
                        navBtn.Image = Properties.Resources.black_employee_32;
                        break;
                    case "khách hàng":
                        navBtn.Image = Properties.Resources.black_customer_32;
                        break;
                    case "mặt hàng":
                        navBtn.Image = Properties.Resources.black_hamburger_32;
                        break;
                    case "đơn hàng":
                        navBtn.Image = Properties.Resources.black_price_tag_32;
                        break;
                    case "hoá đơn":
                        navBtn.Image = Properties.Resources.black_bill_32;
                        break;
                    case "ng. vật liệu":
                        navBtn.Image = Properties.Resources.black_material_32;
                        break;
                    case "xuất/nhập":
                        navBtn.Image = Properties.Resources.black_arrow_32;
                        break;
                    case "nhà c. cấp":
                        navBtn.Image = Properties.Resources.black_supplier_32;
                        break;
                    case "cài đặt":
                        navBtn.Image = Properties.Resources.black_setting_32;
                        break;
                    default:
                        break;
                }
            }

            pnlRight.FillColor = HtmlColor.white;
            pnlRight.ForeColor = HtmlColor.black;
            pnlRight.RectColor = HtmlColor.border2;
            picWorkedTimeInMonth.Image = Properties.Resources.black_employee_32;
            picWorkedTimeToday.Image = Properties.Resources.black_clock_32;
            picSaleInMonth.Image = Properties.Resources.black_coin_32;
            picSaleInToday.Image = Properties.Resources.black_hamburger_32;

            donutChart.ChartStyleType = Sunny.UI.UIChartStyleType.Plain;
            lineChart.ChartStyleType = Sunny.UI.UIChartStyleType.Plain;
            barChart.ChartStyleType = Sunny.UI.UIChartStyleType.Plain;
        }
        private void Customize(bool darkmode)
        {
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(10, 60);
            pnlNavbar.Controls.Add(leftBorderBtn);
            btnAddOrderInMenu.TextAlign = ContentAlignment.BottomCenter;
            btnAddOrderInMenu.Padding = new Padding(0, 0, 0, 8);
            btnUserInfo.TextAlign = ContentAlignment.BottomCenter;
            btnUserInfo.Padding = new Padding(0, 0, 0, 5);
            lblSaleInMonthTitle.Text = (Convert.ToDouble("180225000")).ToString("c0");
            if (darkmode == true)
            {
                DarkMode();
                isDarkMode = true;
            }
            else
            {
                LightMode();
                isDarkMode = false;
            }
        }
        private void NonePermission()
        {
            foreach (Button navBtn in pnlNavbar.Controls.OfType<Button>())
            {
                navBtn.Visible = false;
            }
            btnSetting.Visible = true;
        }
        private void ManagerPermission()
        {
            btnAccount.Visible = true;
            btnEmployee.Visible = true;
        }
        private void CounterStaffPermission()
        {
            btnCustomer.Visible = true;
            btnProduct.Visible = true;
            btnOrder.Visible = true;
            btnBill.Visible = true;
        }
        private void StorekeeperPermission()
        {
            btnMaterial.Visible = true;
            btnSupplier.Visible = true;
            btnInventory.Visible = true;
        }
        private void AdminPermission()
        {
            ManagerPermission();
            CounterStaffPermission();
            StorekeeperPermission();
        }
        private void Permission(int typeAccount)
        {
            switch (typeAccount)
            {
                case 0:
                    AdminPermission();
                    break;
                case 1:
                    ManagerPermission();
                    break;
                case 2:
                    CounterStaffPermission();
                    break;
                case 3:
                    StorekeeperPermission();
                    break;
                default:
                    NonePermission();
                    break;
            }
        }
        private void ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (Button)senderBtn;
                currentBtn.BackColor = (isDarkMode) ? HtmlColor.dark1 : HtmlColor.light3;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                leftBorderBtn.Visible = false;
                currentBtn.BackColor = Color.Transparent;
            }
        }
        private void OpenChildForm(Form childFrom, object senderBtn)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childFrom;
            childFrom.TopLevel = false;
            childFrom.Dock = DockStyle.Fill;
            childFrom.FormBorderStyle = FormBorderStyle.None;
            this.pnlContainer.Controls.Add(childFrom);
            this.pnlContainer.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();
        }
        private void ResizeNavbar()
        {
            if (this.pnlNavbar.Width > 100)
            {
                pnlNavbar.Width = 72;
                foreach (Button navBtn in pnlNavbar.Controls.OfType<Button>())
                {
                    navBtn.Text = string.Empty;
                }
            }
            else
            {
                pnlNavbar.Width = 200;
                foreach (Button navBtn in pnlNavbar.Controls.OfType<Button>())
                {
                    navBtn.Text = "  " + navBtn.Tag.ToString().ToUpper();
                }
            }
        }
        private void NowLoading()
        {
            FormNowLoading frmNowLoading = new FormNowLoading(isDarkMode);
            frmNowLoading.ShowDialog();
        }
        #endregion

        #region Data Methods
        private void LoadAccountData(Account account)
        {
            CurrentAccount = account;
            lblUserDisplayName.Text = account.DisplayName;
            lblUserRole.Text = account.TypeAccount;
            picAvatar.Image = avatar.Image = account.Avatar;
        }
        #endregion

        #region Events
        private void btnAccount_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, HtmlColor.purple);
            NowLoading();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, HtmlColor.pink);
            NowLoading();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, HtmlColor.red);
            NowLoading();
            OpenChildForm(new SubForms.FormCustomerManagement(isDarkMode), sender);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, HtmlColor.orange);
            NowLoading();
            OpenChildForm(new SubForms.FormProductManagement(isDarkMode), sender);

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, HtmlColor.yellow);
            NowLoading();
            OpenChildForm(new SubForms.FormOrderManagement(isDarkMode), sender);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, HtmlColor.green);
            NowLoading();
            OpenChildForm(new SubForms.FormBillManagement(isDarkMode), sender);

        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, HtmlColor.teal);
            NowLoading();

        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, HtmlColor.cyan);
            NowLoading();

        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, HtmlColor.blue);
            NowLoading();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, HtmlColor.indigo);
            NowLoading();
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            NowLoading();
            DisableButton();
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }

        private void btnNavResize_Click(object sender, EventArgs e)
        {
            ResizeNavbar();
        }

        private void btnAddOrderInMenu_Click(object sender, EventArgs e)
        {
            FormOrder frmAddProductToOder = new FormOrder(isDarkMode);
            frmAddProductToOder.Show();
        }

        private void Darkmode_Switch(object sender, bool value)
        {
            NowLoading();

            if (value == true)
            {
                DisableButton();
                DarkMode();
            }
            else
            {
                DisableButton();
                LightMode();
            }
        }

        private void FormMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
            {
                Application.Exit();
            }
        }
        #endregion

        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            FormUser formUser = new FormUser(isDarkMode, CurrentAccount);
            formUser.ShowDialog();
            LoadAccountData(formUser.CurrentAccount);
        }

        private void avatar_Click(object sender, EventArgs e)
        {
            LogOut(this, new EventArgs());
        }
    }
}
