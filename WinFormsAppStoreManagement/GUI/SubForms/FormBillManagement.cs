using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppStoreManagement.UserInterface.SubForms
{
    public partial class FormBillManagement : Form
    {
        private bool isDarkMode = false;
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

            pnlHeader.RectColor = HtmlColor.border1;
            pnlFooter.RectColor = HtmlColor.border1;
            pnlLeft.RectColor = HtmlColor.border1;
            pnlRight.RectColor = HtmlColor.border1;

            dgvBill.BackgroundColor = HtmlColor.dark3;
            dgvBill.StripeEvenColor = HtmlColor.dark2;
            dgvBill.StripeOddColor = HtmlColor.dark3;
            dgvBill.ForeColor = HtmlColor.light1;

            //uiPagination.FillColor = HtmlColor.dark3;

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

            dgvBill.BackgroundColor = HtmlColor.white;
            dgvBill.StripeEvenColor = HtmlColor.light2;
            dgvBill.StripeOddColor = HtmlColor.white;
            dgvBill.ForeColor = HtmlColor.dark1;

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
        private void LoadBillData()
        {
            string query = "SELECT * FROM VW_ShowBillList";
            dgvBill.DataSource = Controller.DataProvider.Instance.ExecuteQuery(query);
        }
        #endregion

        #region Events
        private void btnToggleTool_Click(object sender, EventArgs e)
        {
            ToggleToolPanel();
        }
        #endregion
    }
}
