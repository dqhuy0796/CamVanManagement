using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WinFormsAppStoreManagement.BLL;
using WinFormsAppStoreManagement.DAL;
using WinFormsAppStoreManagement.UserInterface.Modals;

namespace WinFormsAppStoreManagement.GUI.Modals
{
    public partial class FormBill : Form
    {
        #region private system method

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #endregion

        #region Fields
        private bool isNewOrder = false;
        private bool isDarkMode = false;
        public event EventHandler CancelExportBill;
        private Order currentOrder = new Order();
        private Bill currentBill = new Bill();
        public Order CurrentOrder { get => currentOrder; set => currentOrder = value; }
        public Bill CurrentBill { get => currentBill; set => currentBill = value; }
        #endregion

        #region Constructors
        public FormBill(bool theme, Bill bill)
        {
            InitializeComponent();
            Customize(theme);
            LoadOrderData(bill.OrderId);
            LoadOrderDetailData(bill.OrderId);
            LoadMemberDiscount();
            LoadDiscount();
            LoadTax();
            AutoCalculate();
            CurrentBill = bill;
            lblTitle.Text = $"Thông tin hoá đơn [{bill.BillId}]";
            dtpBillTimeStamp.Value = bill.BillTimeStamp;
            isNewOrder = false;
            pnlModifyButton.Visible = true;
            pnlRemoveButton.Visible = true;
        }
        public FormBill(bool theme, Order order, DataTable orderDetails)
        {
            InitializeComponent();
            Customize(theme);
            LoadOrderData(order);
            LoadOrderDetailData(orderDetails);
            LoadMemberDiscount();
            LoadDiscount();
            LoadTax();
            AutoCalculate();
            isNewOrder = true;
        }
        #endregion

        #region UI Methods
        private void Customize(bool darkmode)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            btnCancel.TextAlign = ContentAlignment.BottomCenter;
            btnCancel.Padding = new Padding(0, 0, 0, 6);
            btnModify.TextAlign = ContentAlignment.BottomCenter;
            btnModify.Padding = new Padding(0, 0, 0, 6);
            btnRemove.TextAlign = ContentAlignment.BottomCenter;
            btnRemove.Padding = new Padding(0, 0, 0, 6);

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
            isDarkMode = true;

            pnlHeader.BackColor = HtmlColor.dark2;
            pnlFooter.BackColor = pnlHeader.BackColor;
            pnlContainer.BackColor = HtmlColor.dark1;
            txtOrderId.FillColor = HtmlColor.dark3;
            txtBillDescription.FillColor = txtOrderId.FillColor;
            txtCustomerName.FillColor = txtOrderId.FillColor;
            txtEmployeeId.FillColor = txtOrderId.FillColor;
            txtEmployeeName.FillColor = txtOrderId.FillColor;
            txtSubTotal.FillColor = txtOrderId.FillColor;
            txtTotalDiscount.FillColor = txtOrderId.FillColor;
            txtTotalPayment.FillColor = txtOrderId.FillColor;
            txtTotalTax.FillColor = txtOrderId.FillColor;
            dtpBillTimeStamp.FillColor = txtOrderId.FillColor;
            txtCustomerId.FillColor = txtOrderId.FillColor;
            cboDiscount.FillColor = txtOrderId.FillColor;
            cboMemberDiscount.FillColor = txtOrderId.FillColor;
            cboTax.FillColor = txtOrderId.FillColor;

            lblTitle.ForeColor = HtmlColor.white;
            pnlHeader.ForeColor = HtmlColor.white;
            pnlFooter.ForeColor = pnlHeader.ForeColor;
            pnlContainer.ForeColor = HtmlColor.white;
            txtOrderId.ForeColor = HtmlColor.white;
            txtBillDescription.ForeColor = txtOrderId.ForeColor;
            txtCustomerName.ForeColor = txtOrderId.ForeColor;
            txtEmployeeId.ForeColor = txtOrderId.ForeColor;
            txtEmployeeName.ForeColor = txtOrderId.ForeColor;
            txtSubTotal.ForeColor = txtOrderId.ForeColor;
            txtTotalDiscount.ForeColor = txtOrderId.ForeColor;
            txtTotalPayment.ForeColor = txtOrderId.ForeColor;
            txtTotalTax.ForeColor = txtOrderId.ForeColor;
            dtpBillTimeStamp.ForeColor = txtOrderId.ForeColor;
            txtCustomerId.ForeColor = txtOrderId.ForeColor;
            cboDiscount.ForeColor = txtOrderId.ForeColor;
            cboMemberDiscount.ForeColor = txtOrderId.ForeColor;
            cboTax.ForeColor = txtOrderId.ForeColor;

            dgvOrderDetail.BackgroundColor = HtmlColor.dark3;
            dgvOrderDetail.StripeEvenColor = HtmlColor.dark2;
            dgvOrderDetail.StripeOddColor = HtmlColor.dark3;
            dgvOrderDetail.ForeColor = HtmlColor.light1;

            btnQuit.BackgroundImage = Properties.Resources.white_exit_32;
        }
        private void LightMode()
        {
            isDarkMode = false;

            pnlHeader.BackColor = HtmlColor.white;
            pnlFooter.BackColor = pnlHeader.BackColor;
            pnlContainer.BackColor = HtmlColor.light3;
            txtOrderId.FillColor = HtmlColor.white;
            txtBillDescription.FillColor = txtOrderId.FillColor;
            txtCustomerName.FillColor = txtOrderId.FillColor;
            txtEmployeeId.FillColor = txtOrderId.FillColor;
            txtEmployeeName.FillColor = txtOrderId.FillColor;
            txtSubTotal.FillColor = txtOrderId.FillColor;
            txtTotalDiscount.FillColor = txtOrderId.FillColor;
            txtTotalPayment.FillColor = txtOrderId.FillColor;
            txtTotalTax.FillColor = txtOrderId.FillColor;
            dtpBillTimeStamp.FillColor = txtOrderId.FillColor;
            txtCustomerId.FillColor = txtOrderId.FillColor;
            cboDiscount.FillColor = txtOrderId.FillColor;
            cboMemberDiscount.FillColor = txtOrderId.FillColor;
            cboTax.FillColor = txtOrderId.FillColor;

            lblTitle.ForeColor = HtmlColor.dark1;
            pnlHeader.ForeColor = HtmlColor.dark1;
            pnlFooter.ForeColor = pnlHeader.ForeColor;
            pnlContainer.ForeColor = HtmlColor.dark1;
            txtOrderId.ForeColor = HtmlColor.dark1;
            txtBillDescription.ForeColor = txtOrderId.ForeColor;
            txtCustomerName.ForeColor = txtOrderId.ForeColor;
            txtEmployeeId.ForeColor = txtOrderId.ForeColor;
            txtEmployeeName.ForeColor = txtOrderId.ForeColor;
            txtSubTotal.ForeColor = txtOrderId.ForeColor;
            txtTotalDiscount.ForeColor = txtOrderId.ForeColor;
            txtTotalPayment.ForeColor = txtOrderId.ForeColor;
            txtTotalTax.ForeColor = txtOrderId.ForeColor;
            dtpBillTimeStamp.ForeColor = txtOrderId.ForeColor;
            txtCustomerId.ForeColor = txtOrderId.ForeColor;
            cboDiscount.ForeColor = txtOrderId.ForeColor;
            cboMemberDiscount.ForeColor = txtOrderId.ForeColor;
            cboTax.ForeColor = txtOrderId.ForeColor;

            dgvOrderDetail.BackgroundColor = HtmlColor.white;
            dgvOrderDetail.StripeEvenColor = HtmlColor.light2;
            dgvOrderDetail.StripeOddColor = HtmlColor.white;
            dgvOrderDetail.ForeColor = HtmlColor.dark1;

            btnQuit.BackgroundImage = Properties.Resources.black_exit_32;
        }
        #endregion

        #region Data Methods
        private void LoadOrderData(Order order)
        {
            CurrentOrder = order;
            txtOrderId.Text = CurrentOrder.OrderId;
            dtpBillTimeStamp.Value = DateTime.Now;
            txtCustomerId.Text = CurrentOrder.CustomerId;
            txtCustomerName.Text = CurrentOrder.CustomerName;
            txtEmployeeId.Text = CurrentOrder.EmployeeId;
            txtEmployeeName.Text = CurrentOrder.EmployeeName;
        }
        private void LoadOrderData(string orderId)
        {
            CurrentOrder = OrderBLL.Instance.GetOrderByOrderId(orderId);
            txtOrderId.Text = CurrentOrder.OrderId;
            dtpBillTimeStamp.Value = DateTime.Now;
            txtCustomerId.Text = CurrentOrder.CustomerId;
            txtCustomerName.Text = CurrentOrder.CustomerName;
            txtEmployeeId.Text = CurrentOrder.EmployeeId;
            txtEmployeeName.Text = CurrentOrder.EmployeeName;
        }
        private void LoadOrderDetailData(string orderId)
        {
            dgvOrderDetail.DataSource = OrderDetailBLL.Instance.LoadOrderDetailList(orderId);
        }
        private void LoadOrderDetailData(DataTable orderDetails)
        {
            dgvOrderDetail.DataSource = orderDetails;
        }
        private double ConvertCustomerLevelToDiscount(string customerLevel)
        {
            if (customerLevel.ToLower().Contains("vàng"))
            {
                return 15;
            }
            else if (customerLevel.ToLower().Contains("bạc"))
            {
                return 10;
            }
            else if (customerLevel.ToLower().Contains("đồng"))
            {
                return 05;
            }
            return 0;
        }
        private void LoadMemberDiscount()
        {
            if (!string.IsNullOrWhiteSpace(txtCustomerId.Text))
            {
                cboMemberDiscount.Text = CustomerBLL.Instance.GetCustomerLevelById(txtCustomerId.Text);
            }
        }
        private void LoadDiscount()
        {
            cboDiscount.DataSource = BillBLL.Instance.LoadDiscount();
            cboDiscount.DisplayMember = "DiscountPercent";
        }
        private void LoadTax()
        {
            cboTax.DataSource = BillBLL.Instance.LoadTax();
            cboTax.DisplayMember = "TaxPercent";
        }
        private void AutoCalculate()
        {
            // tổng phụ
            double subTotal = 0;
            for (int i = 0; i < dgvOrderDetail.Rows.Count; i++)
            {
                subTotal += Convert.ToDouble(dgvOrderDetail.Rows[i].Cells["colSubTotal"].Value);
            }
            txtSubTotal.Text = subTotal.ToString("c0");
            // khuyến mãi
            double promotion = Convert.ToDouble(cboDiscount.Text);
            double discount = ConvertCustomerLevelToDiscount(cboMemberDiscount.Text);
            CurrentBill.Discount = Convert.ToDouble(cboDiscount.Text) + ConvertCustomerLevelToDiscount(cboMemberDiscount.Text);
            //CurrentBill.Discount = promotion + discount;
            double discountPrice = CurrentBill.Discount / 100 * subTotal;
            txtTotalDiscount.Text = "-" + discountPrice.ToString("c0");
            // thuế
            //CurrentBill.Tax = Convert.ToDouble(cboTax.Text);
            CurrentBill.Tax = Convert.ToDouble("10");
            double taxPrice = CurrentBill.Tax / 100 * subTotal;
            txtTotalTax.Text = "+" + taxPrice.ToString("c0");
            // thành tiền
            CurrentBill.TotalPayment = subTotal - discountPrice + taxPrice;
            txtTotalPayment.Text = CurrentBill.TotalPayment.ToString("c0");
        }
        private Bill GetBillData()
        {
            CurrentBill.BillId = lblTitle.Text.Substring(lblTitle.Text.Length - 10);
            CurrentBill.OrderId = txtOrderId.Text;
            CurrentBill.BillTimeStamp = dtpBillTimeStamp.Value;
            CurrentBill.BillStatus = 0;
            CurrentBill.BillDescription = txtBillDescription.Text;
            return CurrentBill;
        }
        private int CreateNewBill(Bill bill)
        {
            return BillBLL.Instance.AddBillToDatabase(bill);
        }
        private int ModifyBill(Bill bill)
        {
            return BillBLL.Instance.ModifyBillInDatabase(bill);
        }
        private int RemoveBill(Bill bill)
        {
            return BillBLL.Instance.RemoveBillFromDatabase(bill);
        }
        private int CreateNewOrder(Order order)
        {
            if (OrderBLL.Instance.AddOrderToDatabase(order) > 0)
            {
                int result = 0;
                DataTable saveData = dgvOrderDetail.DataSource as DataTable;
                foreach (DataRow row in saveData.Rows)
                {
                    OrderDetail detail = new OrderDetail(row);
                    result = OrderDetailBLL.Instance.AddOrderDetailToDatabase(detail, CurrentOrder.OrderId);
                }
                return result;
            }
            return 0;
        }
        private int ModifyOrder(Order order)
        {
            if (OrderBLL.Instance.ModifyOrderInDatabase(CurrentOrder) > 0 && OrderDetailBLL.Instance.RemoveOrderDetailFromDatabase(order.OrderId) > 0)
            {
                int result = 0;
                DataTable saveData = dgvOrderDetail.DataSource as DataTable;
                foreach (DataRow row in saveData.Rows)
                {
                    OrderDetail detail = new OrderDetail(row);
                    result = OrderDetailBLL.Instance.AddOrderDetailToDatabase(detail, order.OrderId);
                }
                return result;
            }
            return 0;
        }
        #endregion

        #region Events
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

        private void cboDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentBill.Discount = Convert.ToDouble(cboDiscount.Text);
            AutoCalculate();
        }

        private void cboMemberDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            AutoCalculate();
        }

        private void cboTax_SelectedIndexChanged(object sender, EventArgs e)
        {
            AutoCalculate();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            FormCustomer frmCustomer = new FormCustomer(isDarkMode);
            frmCustomer.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (isNewOrder)
            {
                CancelExportBill(this, new EventArgs());
            }
            else
            {
                this.Close();
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (isNewOrder)
            {
                CancelExportBill(this, new EventArgs());
            }
            else
            {
                this.Close();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (OrderBLL.Instance.IsExistOrder(CurrentOrder.OrderId))
            {
                CurrentOrder.OrderDescription = $"\nCập nhật lúc {DateTime.Now}";
                if (ModifyOrder(CurrentOrder) > 0)
                {
                    if (CreateNewBill(GetBillData()) > 0)
                    {
                        MessageBox.Show("Hoá đơn mới đã được thêm vào cơ sở dữ liệu");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra, vui lòng kiểm tra lại");
                    }
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, vui lòng kiểm tra lại");
                }
            }
            else
            {
                if (CreateNewOrder(CurrentOrder) > 0)
                {
                    if (CreateNewBill(GetBillData()) > 0)
                    {
                        MessageBox.Show("Hoá đơn mới đã được thêm vào cơ sở dữ liệu");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra, vui lòng kiểm tra lại");
                    }
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, vui lòng kiểm tra lại");
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (RemoveBill(CurrentBill) > 0)
            {
                MessageBox.Show($"Hoá đơn {CurrentBill.BillId} đã được xoá.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng kiểm tra lại!");
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (ModifyBill(CurrentBill) > 0)
            {
                MessageBox.Show($"Hoá đơn {CurrentBill.BillId} đã được cập nhật.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng kiểm tra lại!");
            }
        }
        #endregion
    }
}
