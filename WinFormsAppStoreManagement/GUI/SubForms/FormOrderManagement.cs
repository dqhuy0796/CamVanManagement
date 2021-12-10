using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsAppStoreManagement.BLL;
using WinFormsAppStoreManagement.DAL;
using WinFormsAppStoreManagement.UserInterface.Modals;

namespace WinFormsAppStoreManagement.UserInterface.SubForms
{
    public partial class FormOrderManagement : Form
    {
        #region Fields
        private bool isDarkMode = false;
        #endregion

        #region Constructors
        public FormOrderManagement()
        {
            InitializeComponent();
            Customize(false);
            LoadStatus();
            LoadOrderData();
        }
        public FormOrderManagement(bool theme)
        {
            InitializeComponent();
            Customize(theme);
            LoadStatus();
            LoadOrderData();
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
            btnCreate.TextAlign = ContentAlignment.BottomCenter;
            btnCreate.Padding = new Padding(0, 0, 0, 5);
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

            cboFilterByStatus.FillColor = HtmlColor.dark3;
            cboFilterByTime.FillColor = cboFilterByStatus.FillColor;
            cboFilterByStatus.ForeColor = HtmlColor.white;
            cboFilterByTime.ForeColor = cboFilterByStatus.ForeColor;

            pnlHeader.RectColor = HtmlColor.border1;
            pnlFooter.RectColor = HtmlColor.border1;
            pnlLeft.RectColor = HtmlColor.border1;
            pnlRight.RectColor = HtmlColor.border1;

            dgvOrder.BackgroundColor = HtmlColor.dark3;
            dgvOrder.StripeEvenColor = HtmlColor.dark2;
            dgvOrder.StripeOddColor = HtmlColor.dark3;
            dgvOrder.ForeColor = HtmlColor.light1;

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

            cboFilterByStatus.FillColor = HtmlColor.white;
            cboFilterByTime.FillColor = cboFilterByStatus.FillColor;
            cboFilterByStatus.ForeColor = HtmlColor.dark1;
            cboFilterByTime.ForeColor = cboFilterByStatus.ForeColor;

            pnlHeader.RectColor = HtmlColor.border2;
            pnlFooter.RectColor = HtmlColor.border2;
            pnlLeft.RectColor = HtmlColor.border2;
            pnlRight.RectColor = HtmlColor.border2;

            dgvOrder.BackgroundColor = HtmlColor.white;
            dgvOrder.StripeEvenColor = HtmlColor.light2;
            dgvOrder.StripeOddColor = HtmlColor.white;
            dgvOrder.ForeColor = HtmlColor.dark1;

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
        private void LoadStatus()
        {
            List<Status> statuses = OrderBLL.Instance.LoadStatusList();
            foreach (var item in statuses)
            {
                cboFilterByStatus.Items.Add(item.StatusName);
            }
            cboFilterByStatus.Text = string.Empty;
        }
        private void LoadOrderData()
        {
            dgvOrder.DataSource = OrderBLL.Instance.LoadOrderList();
        }
        
        #endregion

        #region Events
        private void btnToggleTool_Click(object sender, EventArgs e)
        {
            ToggleToolPanel();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormOrder formOrder = new FormOrder(isDarkMode);
            formOrder.FormClosed += FormOrder_FormClosed;
            formOrder.Show();
        }

        private void cboFilterByTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboFilterByStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboFilterByTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboFilterByStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {

        }

        private void dgvOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvOrder.CurrentCell.RowIndex;
            string orderId = dgvOrder.Rows[index].Cells["colOrderId"].Value.ToString();
            string customerId = dgvOrder.Rows[index].Cells["colCustomerId"].Value.ToString();
            string customerName = dgvOrder.Rows[index].Cells["colCustomerName"].Value.ToString();
            string employeeId = dgvOrder.Rows[index].Cells["colEmployeeId"].Value.ToString();
            string employeeName = dgvOrder.Rows[index].Cells["colEmployeeName"].Value.ToString();
            DateTime time = (DateTime)dgvOrder.Rows[index].Cells["colOrderTimeStamp"].Value;
            string status = dgvOrder.Rows[index].Cells["colOrderStatus"].Value.ToString();
            string description = dgvOrder.Rows[index].Cells["colOrderDescription"].Value.ToString();
            Order order = new Order(orderId, customerId, customerName, employeeId, employeeName, time, status, description);

            FormOrder formOrder = new FormOrder(isDarkMode, order);
            formOrder.FormClosed += FormOrder_FormClosed;
            formOrder.Show();
        }

        private void FormOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadOrderData();
        }
        #endregion
    }
}
