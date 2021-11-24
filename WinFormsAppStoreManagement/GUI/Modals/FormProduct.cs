using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using WinFormsAppStoreManagement.Controller;
using WinFormsAppStoreManagement.Database;

namespace WinFormsAppStoreManagement.UserInterface.Modals
{
    public partial class FormProduct : Form
    {
        #region private system method

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #endregion

        #region Field
        private Product baseProduct;
        #endregion

        #region Constructors
        public FormProduct()
        {
            InitializeComponent();
            Customize(false);
        }
        public FormProduct(bool theme)
        {
            InitializeComponent();
            Customize(theme);
            lblTitle.Text = "Thêm mặt hàng mới";
            LoadCategory();
            pnlSaveAndQuitButton.Visible = true;
        }
        public FormProduct(bool theme, Product product)
        {
            InitializeComponent();
            Customize(theme);
            lblTitle.Text = "Thông tin mặt hàng";
            LoadCategory();
            LoadData(product);
            baseProduct = product;
            pnlRemoveButton.Visible = true;
            pnlModifyButton.Visible = true;
        }
        #endregion

        #region UI Methods
        private void Customize(bool darkmode)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            btnCancel.TextAlign = ContentAlignment.BottomCenter;
            btnCancel.Padding = new Padding(0, 0, 0, 5);
            btnSaveAndQuit.TextAlign = ContentAlignment.BottomCenter;
            btnSaveAndQuit.Padding = new Padding(0, 0, 0, 5);
            btnUploadPicture.TextAlign = ContentAlignment.BottomCenter;
            btnUploadPicture.Padding = new Padding(0, 0, 0, 5);

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
            lblId.ForeColor = lblTitle.ForeColor;
            lblName.ForeColor = lblTitle.ForeColor;
            lblCategory.ForeColor = lblTitle.ForeColor;
            lblUnit.ForeColor = lblTitle.ForeColor;
            lblPrice.ForeColor = lblTitle.ForeColor;
            lblQuantity.ForeColor = lblTitle.ForeColor;
            lblDescription.ForeColor = lblTitle.ForeColor;

            txtId.ForeColor = HtmlColor.light1;
            txtName.ForeColor = lblTitle.ForeColor;
            cboCategory.ForeColor = lblTitle.ForeColor;
            txtUnit.ForeColor = lblTitle.ForeColor;
            txtPrice.ForeColor = lblTitle.ForeColor;
            txtQuantity.ForeColor = lblTitle.ForeColor;
            txtDescription.ForeColor = lblTitle.ForeColor;

            txtId.FillColor = HtmlColor.dark3;
            txtName.FillColor = txtId.FillColor;
            cboCategory.FillColor = txtId.FillColor;
            txtUnit.FillColor = txtId.FillColor;
            txtPrice.FillColor = txtId.FillColor;
            txtQuantity.FillColor = txtId.FillColor;
            txtDescription.FillColor = txtId.FillColor;

            btnQuit.BackgroundImage = Properties.Resources.white_exit_32;
        }
        private void LightMode()
        {
            pnlHeader.BackColor = HtmlColor.white;
            pnlFooter.BackColor = pnlHeader.BackColor;
            pnlContainer.BackColor = HtmlColor.light3;

            lblTitle.ForeColor = HtmlColor.dark1;
            lblId.ForeColor = lblTitle.ForeColor;
            lblName.ForeColor = lblTitle.ForeColor;
            lblCategory.ForeColor = lblTitle.ForeColor;
            lblUnit.ForeColor = lblTitle.ForeColor;
            lblPrice.ForeColor = lblTitle.ForeColor;
            lblQuantity.ForeColor = lblTitle.ForeColor;
            lblDescription.ForeColor = lblTitle.ForeColor;

            txtId.ForeColor = HtmlColor.dark1;
            txtName.ForeColor = lblTitle.ForeColor;
            cboCategory.ForeColor = lblTitle.ForeColor;
            txtUnit.ForeColor = lblTitle.ForeColor;
            txtPrice.ForeColor = lblTitle.ForeColor;
            txtQuantity.ForeColor = lblTitle.ForeColor;
            txtDescription.ForeColor = lblTitle.ForeColor;

            txtId.FillColor = HtmlColor.white;
            txtName.FillColor = txtId.FillColor;
            cboCategory.FillColor = txtId.FillColor;
            txtUnit.FillColor = txtId.FillColor;
            txtPrice.FillColor = txtId.FillColor;
            txtQuantity.FillColor = txtId.FillColor;
            txtDescription.FillColor = txtId.FillColor;

            btnQuit.BackgroundImage = Properties.Resources.black_exit_32;
        }
        #endregion

        #region Data Methods
        private void LoadCategory()
        {
            List<Category> categories = ProductBLL.Instance.LoadCategoryList();
            foreach (var item in categories)
            {
                cboCategory.Items.Add(item.CategoryName);
            }
            cboCategory.Text = string.Empty;
        }
        private void LoadData(Product product)
        {
            this.txtId.Text = product.ProductId;
            this.txtName.Text = product.ProductName;
            this.picProduct.Image = product.ProductImage;
            this.cboCategory.Text = product.CategoryName;
            this.txtPrice.Text = product.ProductPrice.ToString();
            this.txtQuantity.Text = product.ProductTotalQuantity.ToString();
            this.txtUnit.Text = product.ProductUnit;
            this.txtDescription.Text = product.ProductDescription;
        }
        private static decimal ToDecimal(string str)
        {
            return decimal.Parse(str, NumberStyles.Currency);
        }
        private Product GetAllData()
        {
            return new Product(
                    txtId.Text.Trim(),
                    txtName.Text.Trim(),
                    picProduct.Image,
                    txtUnit.Text.Trim(),
                    Convert.ToDouble(ToDecimal(txtPrice.Text.Trim())),
                    Convert.ToDouble(txtQuantity.Text.Trim()),
                    cboCategory.Text.Trim(),
                    txtDescription.Text.Trim()
                );
        }
        private bool isValid()
        {
            if (txtName.Text.Trim().Length > 0 
                && txtUnit.Text.Trim().Length > 0 
                && char.IsDigit(txtPrice.Text.ToString(), txtPrice.Text.Length - 1) 
                && char.IsDigit(txtQuantity.Text, txtQuantity.Text.Length - 1) 
                && picProduct.Image != null)
            {
                return true;
            }
            return false;
        }
        private int SaveProduct()
        {
            if (isValid())
            {
                return ProductBLL.Instance.AddProductToDatabase(GetAllData());
            }
            return 0;
        }
        private int ModifyProduct()
        {
            if (isValid())
            {
                if (picProduct.Image != baseProduct.ProductImage)
                {
                    return ProductBLL.Instance.ModifyProductInDatabaseWithImage(GetAllData());
                }
                return ProductBLL.Instance.ModifyProductInDatabaseWithoutImage(GetAllData());
            }
            return 0;
        }
        private int RemoveProduct()
        {
            if (isValid())
            {
                return ProductBLL.Instance.RemoveProductFromDatabase(txtId.Text);
            }
            return 0;
        }
        #endregion

        #region Events
        private void btnUploadPicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() {Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif", Multiselect = false})
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picProduct.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveAndQuit_Click(object sender, EventArgs e)
        {
            if(SaveProduct() != 0)
                this.Close();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (baseProduct != GetAllData()) // kiểm tra nếu dữ liệu có sự thay đổi thì mới tiến hành cập nhật
            {
                if (ModifyProduct() != 0)
                {
                    string content = (ModifyProduct() < 10) 
                        ? $"0{ModifyProduct()} bản ghi cập nhật thành công." 
                        : $"{ModifyProduct()} bản ghi cập nhật thành công.";
                    string title = "Chỉnh sửa thông tin mặt hàng";
                    DialogResult msgbox = MessageBox.Show(content, title, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);
                    this.Close();
                }
                else
                {
                    string content = "Cập nhật không thành công! Vui lòng kiểm tra lại!";
                    string title = "Chỉnh sửa thông tin mặt hàng";
                    DialogResult msgbox = MessageBox.Show(content, title, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);
                    this.Close();
                }
            }
            else
            {
                string content = "Cập nhật không thành công! Vui lòng kiểm tra lại!";
                string title = "Chỉnh sửa thông tin mặt hàng";
                DialogResult msgbox = MessageBox.Show(content, title, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);
                this.Close();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (RemoveProduct() != 0)
                this.Close();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}
