using System;
using System.Drawing;
using System.Windows.Forms;
using WinFormsAppStoreManagement.BLL;
using WinFormsAppStoreManagement.DAL;
using WinFormsAppStoreManagement.GUI.Modals;
using WinFormsAppStoreManagement.UserInterface.Modals;

namespace WinFormsAppStoreManagement.UserInterface.SubForms
{
    public partial class FormBillManagement : Form
    {
        #region Fields
        private bool isDarkMode = false;
        #endregion

        #region Constructors
        public FormBillManagement()
        {
            InitializeComponent();
            Customize(false);
            LoadBillData();
        }
        public FormBillManagement(bool theme)
        {
            InitializeComponent();
            Customize(theme);
            LoadBillData();
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

            cboFilterByTotalPayment.FillColor = HtmlColor.dark3;
            cboFilterByTime.FillColor = cboFilterByTotalPayment.FillColor;
            cboFilterByTotalPayment.ForeColor = HtmlColor.white;
            cboFilterByTime.ForeColor = cboFilterByTotalPayment.ForeColor;

            pnlHeader.RectColor = HtmlColor.border1;
            pnlFooter.RectColor = HtmlColor.border1;
            pnlLeft.RectColor = HtmlColor.border1;
            pnlRight.RectColor = HtmlColor.border1;

            dgvBill.BackgroundColor = HtmlColor.dark3;
            dgvBill.StripeEvenColor = HtmlColor.dark2;
            dgvBill.StripeOddColor = HtmlColor.dark3;
            dgvBill.ForeColor = HtmlColor.light1;

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

            cboFilterByTotalPayment.FillColor = HtmlColor.white;
            cboFilterByTime.FillColor = cboFilterByTotalPayment.FillColor;
            cboFilterByTotalPayment.ForeColor = HtmlColor.dark1;
            cboFilterByTime.ForeColor = cboFilterByTotalPayment.ForeColor;

            pnlHeader.RectColor = HtmlColor.border2;
            pnlFooter.RectColor = HtmlColor.border2;
            pnlLeft.RectColor = HtmlColor.border2;
            pnlRight.RectColor = HtmlColor.border2;

            dgvBill.BackgroundColor = HtmlColor.white;
            dgvBill.StripeEvenColor = HtmlColor.light2;
            dgvBill.StripeOddColor = HtmlColor.white;
            dgvBill.ForeColor = HtmlColor.dark1;

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
        private void LoadBillData()
        {
            dgvBill.DataSource = BillBLL.Instance.LoadBillList();
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

        private void FormOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadBillData();
        }

        private void dgvBill_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvBill.CurrentCell.RowIndex;
            string billId = dgvBill.Rows[index].Cells["colBillId"].Value.ToString();
            string orderId = dgvBill.Rows[index].Cells["colOrderId"].Value.ToString();
            DateTime time = Convert.ToDateTime(dgvBill.Rows[index].Cells["colBillTimeStamp"].Value);
            double tax = Convert.ToDouble(dgvBill.Rows[index].Cells["colTax"].Value);
            double discount = Convert.ToDouble(dgvBill.Rows[index].Cells["colDiscount"].Value);
            double total = Convert.ToDouble(dgvBill.Rows[index].Cells["colTotalPayment"].Value);
            string status = dgvBill.Rows[index].Cells["colStatus"].Value.ToString();
            string description = dgvBill.Rows[index].Cells["colBillDescription"].Value.ToString();
            Bill selectedBill = new Bill(billId, orderId, time, tax, discount, total, 0, description);

            FormBill formBill = new FormBill(isDarkMode, selectedBill);
            formBill.FormClosed += FormBill_FormClosed;
            formBill.Show();
        }

        private void FormBill_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadBillData();
        }
        #endregion
    }
}
