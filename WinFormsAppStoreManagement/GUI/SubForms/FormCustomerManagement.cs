using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsAppStoreManagement.Controller;
using WinFormsAppStoreManagement.Database;
using WinFormsAppStoreManagement.UserInterface.Modals;

namespace WinFormsAppStoreManagement.UserInterface.SubForms
{
    public partial class FormCustomerManagement : Form
    {
        #region Fields
        private bool isDarkMode = false;
        private List<Customer> baseCustomers;
        private List<Customer> filteredCustomers;
        private List<Customer> currentCustomers;
        #endregion

        #region Constructors
        public FormCustomerManagement()
        {
            InitializeComponent();
            Customize(false);
            LoadCustomerData();
        }
        public FormCustomerManagement(bool theme)
        {
            InitializeComponent();
            Customize(theme);
            LoadCustomerData();
        }
        #endregion

        #region UI Methods
        public void Customize(bool darkmode)
        {
            pnlRight.Width = 24;
            btnToggleTool.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 190, 172);
            btnToggleTool.FlatAppearance.MouseOverBackColor = Color.FromArgb(130, 223, 214);
            btnBackToMainMenu.TextAlign = ContentAlignment.BottomCenter;
            btnBackToMainMenu.Padding = new Padding(0, 0, 0, 5);
            btnResetFilter.TextAlign = ContentAlignment.BottomCenter;
            btnResetFilter.Padding = new Padding(0, 0, 0, 5);
            btnAdd.TextAlign = ContentAlignment.BottomCenter;
            btnAdd.Padding = new Padding(0, 0, 0, 5);
            btnModify.TextAlign = ContentAlignment.BottomCenter;
            btnModify.Padding = new Padding(0, 0, 0, 5);
            btnRemove.TextAlign = ContentAlignment.BottomCenter;
            btnRemove.Padding = new Padding(0, 0, 0, 5);
            if (darkmode == true)
            {
                DarkMode();
            }
            else
            {
                LightMode();
            }
        }
        public void DarkMode()
        {
            isDarkMode = true;

            this.BackColor = HtmlColor.dark2;

            pnlHeader.FillColor = HtmlColor.dark2;
            pnlFooter.FillColor = pnlHeader.FillColor;
            pnlRight.FillColor = pnlHeader.FillColor;
            pnlLeft.FillColor = HtmlColor.dark1;

            pnlHeader.RectColor = HtmlColor.border1;
            pnlFooter.RectColor = HtmlColor.border1;
            pnlLeft.RectColor = HtmlColor.border1;
            pnlRight.RectColor = HtmlColor.border1;

            dgvCustomer.BackgroundColor = HtmlColor.dark3;
            dgvCustomer.StripeEvenColor = HtmlColor.dark2;
            dgvCustomer.StripeOddColor = HtmlColor.dark3;
            dgvCustomer.ForeColor = HtmlColor.light1;

            lblOrderBy.ForeColor = HtmlColor.white;

            btnToggleTool.BackgroundImage = Properties.Resources.white_left_32;
        }
        public void LightMode()
        {
            isDarkMode = false;

            this.BackColor = HtmlColor.white;

            pnlHeader.FillColor = HtmlColor.white;
            pnlFooter.FillColor = pnlHeader.FillColor;
            pnlRight.FillColor = pnlHeader.FillColor;
            pnlLeft.FillColor = HtmlColor.light3;

            pnlHeader.RectColor = HtmlColor.border2;
            pnlFooter.RectColor = HtmlColor.border2;
            pnlLeft.RectColor = HtmlColor.border2;
            pnlRight.RectColor = HtmlColor.border2;

            dgvCustomer.BackgroundColor = HtmlColor.white;
            dgvCustomer.StripeEvenColor = HtmlColor.light2;
            dgvCustomer.StripeOddColor = HtmlColor.white;
            dgvCustomer.ForeColor = HtmlColor.dark1;

            //uiPagination.FillColor = HtmlColor.dark3;

            lblOrderBy.ForeColor = HtmlColor.dark1;

            btnToggleTool.BackgroundImage = Properties.Resources.black_left_32;
        }
        private void ToggleToolPanel()
        {
            if (pnlRight.Width > 100)
            {
                pnlRight.Width = 24;
                btnToggleTool.BackgroundImage = (isDarkMode) ? Properties.Resources.white_left_32 : Properties.Resources.black_left_32;
            }
            else
            {
                pnlRight.Width = 500;
                btnToggleTool.BackgroundImage = (isDarkMode) ? Properties.Resources.white_right_32 : Properties.Resources.black_right_32;
            }
        }
        #endregion

        #region Data Methods
        private void LoadCustomerData()
        {
            baseCustomers = CustomerBLL.Instance.LoadCustomerList();
            filteredCustomers = baseCustomers;
            currentCustomers = baseCustomers;
            dgvCustomer.DataSource = baseCustomers;
        }
        private List<Customer> FilterByLevel(string level, List<Customer> customers)
        {
            List<Customer> temp = new List<Customer>();
            foreach (var item in customers)
            {
                if (item.CustomerLevel == level)
                {
                    temp.Add(item);
                }
            }
            return temp;
        }
        private List<Customer> FilterByStatusCustomer(string statusArrangement, List<Customer> customers)
        {
            switch (statusArrangement)
            {
                case "Cũ nhất":
                    customers.Sort((x, y) => x.CustomerId.CompareTo(y.CustomerId));
                    break;
                case "Mới nhất":
                    customers.Sort((x, y) => y.CustomerId.CompareTo(x.CustomerId));
                    break;
                default:
                    customers.Sort((x, y) => x.CustomerId.CompareTo(y.CustomerId));
                    break;
            }
            return customers;
        }
        private List<Customer> FilterByPriceCustomer(string priceArrangement, List<Customer> customers)
        {
            switch (priceArrangement)
            {
                case "Cao đến thấp":
                    customers.Sort((x, y) => y.CustomerPoint.CompareTo(x.CustomerPoint));
                    break;
                case "Thấp đến cao":
                    customers.Sort((x, y) => x.CustomerPoint.CompareTo(y.CustomerPoint));
                    break;
                default:
                    customers.Sort((x, y) => x.CustomerId.CompareTo(y.CustomerId));
                    break;
            }
            return customers;
        }
        #endregion

        #region Event
        private void btnToggleTool_Click(object sender, EventArgs e)
        {
            ToggleToolPanel();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormCustomer formCustomer = new FormCustomer(isDarkMode);
            formCustomer.ShowDialog();
            LoadCustomerData();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            FormCustomer formCustomer = new FormCustomer(isDarkMode);
            formCustomer.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            cboFilterByLevel.Text = string.Empty;
            cboFilterByTime.Text = string.Empty;
            cboFilterByPoint.Text = string.Empty;
            cboFilterByField.Text = string.Empty;
            txtSearchByField.Text = string.Empty;
            dgvCustomer.DataSource = baseCustomers;
        }

        private void cboFilterByLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentCustomers = (string.IsNullOrWhiteSpace(cboFilterByTime.Text) || string.IsNullOrWhiteSpace(cboFilterByPoint.Text))
                ? FilterByLevel(cboFilterByLevel.Text, baseCustomers)
                : FilterByLevel(cboFilterByLevel.Text, filteredCustomers);
            dgvCustomer.DataSource = currentCustomers;
        }

        private void cboFilterByTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboFilterByPoint.Text = string.Empty;
            filteredCustomers = FilterByStatusCustomer(cboFilterByTime.Text, baseCustomers);
            currentCustomers = (string.IsNullOrWhiteSpace(cboFilterByLevel.Text))
                ? FilterByStatusCustomer(cboFilterByTime.Text, baseCustomers)
                : FilterByStatusCustomer(cboFilterByTime.Text, currentCustomers);
            dgvCustomer.DataSource = currentCustomers;
        }

        private void cboFilterByPoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboFilterByTime.Text = string.Empty;
            filteredCustomers = FilterByPriceCustomer(cboFilterByPoint.Text, baseCustomers);
            currentCustomers = (string.IsNullOrWhiteSpace(cboFilterByLevel.Text))
                ? FilterByPriceCustomer(cboFilterByPoint.Text, baseCustomers)
                : FilterByPriceCustomer(cboFilterByPoint.Text, currentCustomers);
            dgvCustomer.DataSource = currentCustomers;
        }

        private void cboFilterByLevel_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboFilterByLevel.Text))
            {
                dgvCustomer.DataSource = filteredCustomers;
            }
            if (string.IsNullOrWhiteSpace(cboFilterByLevel.Text) && string.IsNullOrWhiteSpace(cboFilterByTime.Text) && string.IsNullOrWhiteSpace(cboFilterByPoint.Text))
            {
                btnResetFilter.Enabled = false;
                LoadCustomerData();
            }
            else
            {
                btnResetFilter.Enabled = true;
            }
        }

        private void cboFilterByTime_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboFilterByTime.Text))
            {
                currentCustomers.Sort((x, y) => x.CustomerId.CompareTo(y.CustomerId));
                dgvCustomer.DataSource = currentCustomers;
            }
            if (string.IsNullOrWhiteSpace(cboFilterByLevel.Text) && string.IsNullOrWhiteSpace(cboFilterByTime.Text) && string.IsNullOrWhiteSpace(cboFilterByPoint.Text))
            {
                btnResetFilter.Enabled = false;
                LoadCustomerData();
            }
            else
            {
                btnResetFilter.Enabled = true;
            }
        }

        private void cboFilterByPoint_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboFilterByPoint.Text))
            {
                currentCustomers.Sort((x, y) => x.CustomerId.CompareTo(y.CustomerId));
                dgvCustomer.DataSource = currentCustomers;
            }
            if (string.IsNullOrWhiteSpace(cboFilterByLevel.Text) && string.IsNullOrWhiteSpace(cboFilterByTime.Text) && string.IsNullOrWhiteSpace(cboFilterByPoint.Text))
            {
                btnResetFilter.Enabled = false;
                LoadCustomerData();
            }
            else
            {
                btnResetFilter.Enabled = true;
            }
        }

        private void dgvCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvCustomer.CurrentCell.RowIndex;
            string id = dgvCustomer.Rows[index].Cells["colCustomerId"].Value.ToString();
            string name = dgvCustomer.Rows[index].Cells["colCustomerName"].Value.ToString();
            string gender = dgvCustomer.Rows[index].Cells["colCustomerGender"].Value.ToString();
            string CIC = dgvCustomer.Rows[index].Cells["colCustomerCIC"].Value.ToString();
            DateTime birth = (DateTime)dgvCustomer.Rows[index].Cells["colCustomerBirth"].Value;
            string tel = dgvCustomer.Rows[index].Cells["colCustomerTel"].Value.ToString();
            string level = dgvCustomer.Rows[index].Cells["colCustomerLevel"].Value.ToString();
            string address = dgvCustomer.Rows[index].Cells["colCustomerAddress"].Value.ToString();
            int point = Convert.ToInt32(dgvCustomer.Rows[index].Cells["colCustomerPoint"].Value.ToString());
            string description = dgvCustomer.Rows[index].Cells["colCustomerDescription"].Value.ToString();
            Customer customer = new Customer(id, name, gender, CIC, birth, tel, address, level, point, description);

            FormCustomer formCustomer = new FormCustomer(isDarkMode, customer);
            formCustomer.ShowDialog();
            LoadCustomerData();
        }
        #endregion
    }
}
