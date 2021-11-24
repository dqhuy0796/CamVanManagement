using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WinFormsAppStoreManagement.Controller;
using WinFormsAppStoreManagement.Database;

namespace WinFormsAppStoreManagement.UserInterface.Modals
{
    public partial class FormOrder : Form
    {
        #region private system method

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #endregion

        #region Fields
        private bool isDarkMode = false;
        private Order baseOrder;
        private List<Product> products;

        public Order BaseOrder { get => baseOrder; set => baseOrder = value; }
        #endregion

        #region Constructor
        public FormOrder()
        {
            InitializeComponent();
            Customize(isDarkMode);
            LoadProductData();
        }
        public FormOrder(bool theme)
        {
            InitializeComponent();
            Customize(theme);
            LoadProductData();
            LoadCustomerData();
            lblTitle.Text = "Thêm đơn hàng mới";
            txtOrderId.Text = "Đơn mới";
            txtEmployeeId.Text = "NV000002";
            txtEmployeeName.Text = "Nguyễn Thị Hoài";
            dtpOrderTimeStamp.Value = DateTime.Now;
            pnlExportBill.Visible = true;
            pnlSaveOrder.Visible = true;
        }
        public FormOrder(bool theme, Order order)
        {
            InitializeComponent();
            Customize(theme);
            LoadProductData();
            LoadCustomerData();
            lblTitle.Text = "Thông tin đơn hàng";
            pnlExportBill.Visible = true;
            pnlModifyOrder.Visible = true;
            pnlRemoveOrder.Visible = true;
            // modify or remove
            this.BaseOrder = order;
            LoadOrderData();
            LoadOrderDetailData();
            AutoCalculateSubTotal();
        }
        #endregion

        #region UI Methods
        private void Customize(bool darkmode)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            btnCancel.TextAlign = ContentAlignment.BottomCenter;
            btnCancel.Padding = new Padding(0, 0, 0, 6);
            btnExportBill.TextAlign = ContentAlignment.BottomCenter;
            btnExportBill.Padding = new Padding(0, 0, 0, 6);
            btnSaveNewOrder.TextAlign = ContentAlignment.BottomCenter;
            btnSaveNewOrder.Padding = new Padding(0, 0, 0, 6);

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
            flpChooseProduct.FillColor = pnlHeader.BackColor;
            pnlLeft.BackColor = HtmlColor.dark1;
            pnlRight.BackColor = pnlLeft.BackColor;

            lblTitle.ForeColor = HtmlColor.white;
            lblCustomerId.ForeColor = lblTitle.ForeColor;
            lblCustomerName.ForeColor = lblTitle.ForeColor;
            lblOrderId.ForeColor = lblTitle.ForeColor;
            lblEmployeeId.ForeColor = lblTitle.ForeColor;
            lblEmployeeName.ForeColor = lblTitle.ForeColor;
            lblOrderTimeStamp.ForeColor = lblTitle.ForeColor;
            lblOrderDescription.ForeColor = lblTitle.ForeColor;
            lblSubTotal.ForeColor = lblTitle.ForeColor;

            txtOrderId.ForeColor = lblTitle.ForeColor;
            dtpOrderTimeStamp.ForeColor = lblTitle.ForeColor;
            cboCustomerId.ForeColor = lblTitle.ForeColor;
            cboCategory.ForeColor = lblTitle.ForeColor;
            txtSearchbox.ForeColor = lblTitle.ForeColor;
            txtCustomerName.ForeColor = lblTitle.ForeColor;
            txtEmployeeId.ForeColor = lblTitle.ForeColor;
            txtEmployeeName.ForeColor = lblTitle.ForeColor;
            txtOrderDescription.ForeColor = lblTitle.ForeColor;
            txtSubTotal.ForeColor = lblTitle.ForeColor;

            txtOrderId.FillColor = HtmlColor.dark3;
            dtpOrderTimeStamp.FillColor = txtOrderId.FillColor;
            cboCustomerId.FillColor = txtOrderId.FillColor;
            cboCategory.FillColor = txtOrderId.FillColor;
            txtSearchbox.FillColor = txtOrderId.FillColor;
            txtCustomerName.FillColor = txtOrderId.FillColor;
            txtEmployeeId.FillColor = txtOrderId.FillColor;
            txtEmployeeName.FillColor = txtOrderId.FillColor;
            txtOrderDescription.FillColor = txtOrderId.FillColor;
            txtSubTotal.FillColor = txtOrderId.FillColor;

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
            flpChooseProduct.FillColor = pnlHeader.BackColor;
            pnlLeft.BackColor = HtmlColor.light3;
            pnlRight.BackColor = pnlLeft.BackColor;

            lblTitle.ForeColor = HtmlColor.dark1;
            lblCustomerId.ForeColor = lblTitle.ForeColor;
            lblCustomerName.ForeColor = lblTitle.ForeColor;
            lblOrderId.ForeColor = lblTitle.ForeColor;
            lblEmployeeId.ForeColor = lblTitle.ForeColor;
            lblEmployeeName.ForeColor = lblTitle.ForeColor;
            lblOrderTimeStamp.ForeColor = lblTitle.ForeColor;
            lblOrderDescription.ForeColor = lblTitle.ForeColor;
            lblSubTotal.ForeColor = lblTitle.ForeColor;

            txtOrderId.ForeColor = lblTitle.ForeColor;
            dtpOrderTimeStamp.ForeColor = lblTitle.ForeColor;
            cboCustomerId.ForeColor = lblTitle.ForeColor;
            cboCategory.ForeColor = lblTitle.ForeColor;
            txtSearchbox.ForeColor = lblTitle.ForeColor;
            txtCustomerName.ForeColor = lblTitle.ForeColor;
            txtEmployeeId.ForeColor = lblTitle.ForeColor;
            txtEmployeeName.ForeColor = lblTitle.ForeColor;
            txtOrderDescription.ForeColor = lblTitle.ForeColor;
            txtSubTotal.ForeColor = lblTitle.ForeColor;

            txtOrderId.FillColor = HtmlColor.white;
            dtpOrderTimeStamp.FillColor = txtOrderId.FillColor;
            cboCustomerId.FillColor = txtOrderId.FillColor;
            cboCategory.FillColor = txtOrderId.FillColor;
            txtSearchbox.FillColor = txtOrderId.FillColor;
            txtCustomerName.FillColor = txtOrderId.FillColor;
            txtEmployeeId.FillColor = txtOrderId.FillColor;
            txtEmployeeName.FillColor = txtOrderId.FillColor;
            txtOrderDescription.FillColor = txtOrderId.FillColor;
            txtSubTotal.FillColor = txtOrderId.FillColor;

            dgvOrderDetail.BackgroundColor = HtmlColor.white;
            dgvOrderDetail.StripeEvenColor = HtmlColor.light2;
            dgvOrderDetail.StripeOddColor = HtmlColor.white;
            dgvOrderDetail.ForeColor = HtmlColor.dark1;

            btnQuit.BackgroundImage = Properties.Resources.black_exit_32;
        }
        #endregion

        #region Data Methods
        private void LoadCategoryData()
        {
            cboCategory.Clear();
            List<Category> categories = ProductBLL.Instance.LoadCategoryList();
            cboCategory.DataSource = categories;
            cboCategory.DisplayMember = "CategoryName";
        }
        private void LoadOrderData()
        {
            txtOrderId.Text = BaseOrder.OrderId;
            dtpOrderTimeStamp.Value = BaseOrder.OrderTimeStamp;
            cboCustomerId.Text = BaseOrder.CustomerId;
            txtCustomerName.Text = BaseOrder.CustomerName;
            txtEmployeeId.Text = BaseOrder.EmployeeId;
            txtEmployeeName.Text = BaseOrder.EmployeeName;
            txtOrderDescription.Text = BaseOrder.OrderDescription;
        }
        private void LoadProductData()
        {
            LoadCategoryData();
            flpChooseProduct.Clear();
            products = ProductBLL.Instance.LoadProductList();
            foreach (Product item in products)
            {
                UCProduct product = new UCProduct(item.ProductId, item.ProductName, item.ProductPrice, item.ProductImage);
                product.Click += new EventHandler(this.UserControl_Click);
                flpChooseProduct.Controls.Add(product);
            }
        }
        private void LoadCustomerData()
        {
            cboCustomerId.Clear();
            List<Customer> customers = CustomerBLL.Instance.LoadCustomerList();
            cboCustomerId.DataSource = customers;
            cboCustomerId.DisplayMember = "CustomerId";
            //txtCustomerName.DataBindings.Add(new Binding("Text", cboCustomerId.DataSource, "CustomerName"));
        }
        private void LoadOrderDetailData()
        {
            dgvOrderDetail.DataSource = OrderDetailBLL.Instance.LoadOrderDetailList(BaseOrder.OrderId);
        }
        private void AutoCalculateSubTotal()
        {
            double sum = 0;
            for (int i = 0; i < dgvOrderDetail.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dgvOrderDetail.Rows[i].Cells["colSubTotal"].Value);
            }
            txtSubTotal.Text = sum.ToString("c0");
        }
        private Order GetAllData()
        {
            return new Order
                (
                    txtOrderId.Text,
                    cboCustomerId.Text,
                    txtCustomerName.Text,
                    txtEmployeeId.Text,
                    txtEmployeeName.Text,
                    dtpOrderTimeStamp.Value,
                    "Chưa hoàn thành",
                    txtOrderDescription.Text
                );
        }
        private bool IsExistProductInOrderDetail(string id)
        {
            int count = dgvOrderDetail.Rows.Count;
            List<string> productIds = new List<string>();
            for (int i = 0; i < count; i++)
            {
                productIds.Add(dgvOrderDetail.Rows[i].Cells["colProductId"].Value.ToString());
            }
            if (productIds.IndexOf(id) != -1)
                return true;
            return false;
        }
        private bool IsValidData()
        {
            if (!string.IsNullOrWhiteSpace(cboCustomerId.Text)
                && !string.IsNullOrWhiteSpace(txtOrderId.Text)
                && !string.IsNullOrWhiteSpace(txtCustomerName.Text)
                && !string.IsNullOrWhiteSpace(txtEmployeeId.Text)
                && !string.IsNullOrWhiteSpace(txtEmployeeName.Text)
                && !string.IsNullOrWhiteSpace(dtpOrderTimeStamp.Text)
                )
            {
                return true;
            }
            return false;
        }
        private void AddOrderDetailToDataGridView(string id)
        {
            Product product = new Product();
            foreach (Product item in products)
            {
                if (item.ProductId != id)
                    continue;
                product = item;
            }
            // nếu datagridview đã có dữ liệu
            if (dgvOrderDetail.Rows.Count > 0)
            {
                // Nếu chưa có sản phẩm đó trong đơn hàng thì tạo mới
                if (!IsExistProductInOrderDetail(id))
                {
                    DataTable data = dgvOrderDetail.DataSource as DataTable;
                    DataRow row = data.NewRow();
                    row["OrderId"] = txtOrderId.Text;
                    row["ProductId"] = product.ProductId;
                    row["ProductName"] = product.ProductName;
                    row["ProductQuantity"] = 1;
                    row["ProductUnit"] = product.ProductUnit;
                    row["ProductPrice"] = product.ProductPrice;
                    row["SubTotal"] = product.ProductPrice;
                    data.Rows.InsertAt(row, 0);
                }
                // Nếu đã có sản phẩm đó trong đơn hàng thì tăng số lượng thêm 1
            }
            // Nếu datagridview chưa có dữ liệu
            else
            {
                DataTable data = new DataTable();
                data.Clear();
                data.Columns.Add("OrderId", typeof(string));
                data.Columns.Add("ProductId", typeof(string));
                data.Columns.Add("ProductName", typeof(string));
                data.Columns.Add("ProductQuantity", typeof(int));
                data.Columns.Add("ProductUnit", typeof(string));
                data.Columns.Add("ProductPrice", typeof(double));
                data.Columns.Add("SubTotal", typeof(double));
                DataRow row = data.NewRow();
                row["OrderId"] = txtOrderId.Text;
                row["ProductId"] = product.ProductId;
                row["ProductName"] = product.ProductName;
                row["ProductQuantity"] = 1;
                row["ProductUnit"] = product.ProductUnit;
                row["ProductPrice"] = product.ProductPrice;
                row["SubTotal"] = product.ProductPrice;
                data.Rows.InsertAt(row, 0);
                dgvOrderDetail.DataSource = data;
            }
        }
        private int CreateNewOrder()
        {
            if (OrderBLL.Instance.AddOrderToDatabase(GetAllData()) > 0)
            {
                string orderId = OrderBLL.Instance.GetLastestOrderFromDatabase();
                int result = 0;
                DataTable saveData = dgvOrderDetail.DataSource as DataTable;
                foreach (DataRow row in saveData.Rows)
                {
                    OrderDetail detail = new OrderDetail(row);
                    result = OrderDetailBLL.Instance.AddOrderDetailToDatabase(detail, orderId);
                }
                return result;
            }
            return 0;
        }
        private int ModifyOrder()
        {
            string orderId = txtOrderId.Text;
            if (OrderDetailBLL.Instance.DeleteOrderDetailFromDatabase(orderId) > 0)
            {
                int result = 0;
                DataTable saveData = dgvOrderDetail.DataSource as DataTable;
                foreach (DataRow row in saveData.Rows)
                {
                    OrderDetail detail = new OrderDetail(row);
                    result = OrderDetailBLL.Instance.AddOrderDetailToDatabase(detail, orderId);
                }
                return result;
            }
            return 0;
        }
        private int RemoveOrder()
        {
            string orderId = txtOrderId.Text;
            if (OrderDetailBLL.Instance.DeleteOrderDetailFromDatabase(orderId) > 0)
            {
                return OrderBLL.Instance.RemoveOrderFromDatabase(orderId);
            }
            return 0;
        }
        #endregion

        #region Events
        private void UserControl_Click(object sender, EventArgs e)
        {
            UCProduct productSender = sender as UCProduct;
            AddOrderDetailToDataGridView(productSender.Id);
            AutoCalculateSubTotal();
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            while (dgvOrderDetail.SelectedRows.Count > 0)
            {
                dgvOrderDetail.Rows.RemoveAt(dgvOrderDetail.SelectedRows[0].Index);
                AutoCalculateSubTotal();
            }
        }

        private void dgvOrderDetail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrderDetail.CurrentCell != null)
            {
                int index = dgvOrderDetail.CurrentCell.RowIndex;
                int quantity = Convert.ToInt32(dgvOrderDetail.Rows[index].Cells["colProductQuantity"].Value);
                double price = Convert.ToDouble(dgvOrderDetail.Rows[index].Cells["colProductPrice"].Value);
                dgvOrderDetail.Rows[index].Cells["colSubTotal"].Value = quantity * price;
                //Binding binding = new Binding("Value", dgvOrderDetail.Rows[index].Cells["colProductQuantity"], "Value", true, DataSourceUpdateMode.OnPropertyChanged);
                //updProductQuantity.DataBindings.Clear();
                //updProductQuantity.DataBindings.Add(binding);
                AutoCalculateSubTotal();
            }
        }

        private void dgvOrderDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrderDetail.CurrentCell != null)
            {
                int index = dgvOrderDetail.CurrentCell.RowIndex;
                updProductQuantity.Value = Convert.ToInt32(dgvOrderDetail.Rows[index].Cells["colProductQuantity"].Value);
            }
        }

        private void dgvOrderDetail_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrderDetail.SelectedRows.Count > 0)
            {
                btnRemoveProduct.Enabled = true;
            }
            else
            {
                btnRemoveProduct.Enabled = false;
            }
        }

        private void updProductQuantity_ValueChanged(object sender, int value)
        {
            if (dgvOrderDetail.CurrentCell != null)
            {
                int index = dgvOrderDetail.CurrentCell.RowIndex;
                dgvOrderDetail.Rows[index].Cells["colProductQuantity"].Value = updProductQuantity.Value;
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            FormCustomer frmCustomer = new FormCustomer(isDarkMode);
            frmCustomer.ShowDialog();
            LoadCustomerData();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportBill_Click(object sender, EventArgs e)
        {
            if (dgvOrderDetail.Rows.Count > 0)
            {
                this.Close();
            }
        }

        private void btnSaveNewOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrderDetail.Rows.Count > 0)
            {
                if (IsValidData())
                {
                    if (CreateNewOrder() > 0)
                    {
                        MessageBox.Show("Đơn hàng mới đã được cập nhật vào cơ sở dữ liệu.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra, huỷ thao tác!");
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập đủ dữ liệu!");
                }
            }
            else
            {
                MessageBox.Show("Đơn hàng phải có ít nhất một đơn vị mặt hàng (sản phẩm)!");
            }
        }

        private void btnModifyOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrderDetail.Rows.Count > 0)
            {
                if (IsValidData())
                {
                    if (ModifyOrder() > 0)
                    {
                        MessageBox.Show("Đơn hàng đã được cập nhật trên cơ sở dữ liệu.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra, huỷ thao tác!");
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập đủ dữ liệu!");
                }
            }
            else
            {
                MessageBox.Show("Đơn hàng phải có ít nhất một đơn vị mặt hàng (sản phẩm)!");
            }
        }

        private void btnRemoveOrder_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtOrderId.Text))
            {
                if (RemoveOrder() > 0)
                {
                    MessageBox.Show("Đơn hàng đã được loại bỏ khỏi cơ sở dữ liệu.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, huỷ thao tác!");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            FormProduct formProduct = new FormProduct(isDarkMode);
            formProduct.ShowDialog();
            LoadProductData();
        }

        private void cboCustomerId_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Customer> customers = CustomerBLL.Instance.LoadCustomerList();
            foreach (Customer item in customers)
            {
                if (item.CustomerId == cboCustomerId.Text)
                {
                    txtCustomerName.Text = item.CustomerName;
                }
            }
        }
        #endregion

    }
}
