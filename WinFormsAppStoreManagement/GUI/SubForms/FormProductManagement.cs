using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WinFormsAppStoreManagement.Controller;
using WinFormsAppStoreManagement.Database;
using WinFormsAppStoreManagement.UserInterface.Modals;

namespace WinFormsAppStoreManagement.UserInterface.SubForms
{
    public partial class FormProductManagement : Form
    {
        #region Fields
        private bool isDarkMode = false;
        private List<Product> baseProducts;
        private List<Product> filteredProducts;
        private List<Product> currentProducts;
        #endregion

        #region Constructors
        public FormProductManagement()
        {
            InitializeComponent();
            Customize(false);
            LoadCategory();
            LoadProductData();
        }
        public FormProductManagement(bool theme)
        {
            InitializeComponent();
            Customize(theme);
            LoadCategory();
            LoadProductData();
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

            dgvProduct.BackgroundColor = HtmlColor.dark3;
            dgvProduct.StripeEvenColor = HtmlColor.dark2;
            dgvProduct.StripeOddColor = HtmlColor.dark3;
            dgvProduct.ForeColor = HtmlColor.light1;

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

            dgvProduct.BackgroundColor = HtmlColor.white;
            dgvProduct.StripeEvenColor = HtmlColor.light2;
            dgvProduct.StripeOddColor = HtmlColor.white;
            dgvProduct.ForeColor = HtmlColor.dark1;

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
        private void LoadCategory()
        {
            List<Category> categories = ProductBLL.Instance.LoadCategoryList();
            foreach (var item in categories)
            {
                cboFilterByCategory.Items.Add(item.CategoryName);
            }
            cboFilterByCategory.Text = string.Empty;
        }
        private void LoadProductData()
        {
            baseProducts = ProductBLL.Instance.LoadProductList();
            filteredProducts = baseProducts;
            currentProducts = baseProducts;
            dgvProduct.DataSource = baseProducts;
        }
        private List<Product> FilterByCategory(string category, List<Product> products)
        {
            List<Product> temp = new List<Product>();
            foreach (var item in products)
            {
                if (item.CategoryName == category)
                {
                    temp.Add(item);
                }
            }
            return temp;
        }
        private List<Product> FilterByStatusProduct(string statusArrangement, List<Product> products)
        {
            switch (statusArrangement)
            {
                case "Phổ biến nhất":
                    break;
                case "Mới nhất":
                    products.Sort((x, y) => y.ProductId.CompareTo(x.ProductId));
                    break;
                case "Còn nhiều":
                    products.Sort((x, y) => y.ProductTotalQuantity.CompareTo(x.ProductTotalQuantity));
                    break;
                case "Còn ít":
                    products.Sort((x, y) => x.ProductTotalQuantity.CompareTo(y.ProductTotalQuantity));
                    break;
                default:
                    products.Sort((x, y) => x.ProductId.CompareTo(y.ProductId));
                    break;
            }
            return products;
        }
        private List<Product> FilterByPriceProduct(string priceArrangement, List<Product> products)
        {
            switch (priceArrangement)
            {
                case "Cao đến thấp":
                    products.Sort((x, y) => y.ProductPrice.CompareTo(x.ProductPrice));
                    break;
                case "Thấp đến cao":
                    products.Sort((x, y) => x.ProductPrice.CompareTo(y.ProductPrice));
                    break;
                default:
                    products.Sort((x, y) => x.ProductId.CompareTo(y.ProductId));
                    break;
            }
            return products;
        }
        #endregion

        #region Events
        private void btnToggleTool_Click(object sender, EventArgs e)
        {
            ToggleToolPanel();
        }

        private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvProduct.CurrentCell.RowIndex;
            string id = dgvProduct.Rows[index].Cells["colProductId"].Value.ToString();
            string name = dgvProduct.Rows[index].Cells["colProductName"].Value.ToString();
            Image image = (Image)dgvProduct.Rows[index].Cells["colProductImage"].Value;
            string unit = dgvProduct.Rows[index].Cells["colProductUnit"].Value.ToString();
            double price = Convert.ToDouble(dgvProduct.Rows[index].Cells["colProductPrice"].Value.ToString());
            double quantity = Convert.ToDouble(dgvProduct.Rows[index].Cells["colProductTotalQuantity"].Value.ToString());
            string description = dgvProduct.Rows[index].Cells["colProductDescription"].Value.ToString();
            string category = dgvProduct.Rows[index].Cells["colCategoryName"].Value.ToString();
            Product product = new Product(id, name, image, unit, price, quantity, category, description);

            FormProduct formProduct = new FormProduct(isDarkMode, product);
            formProduct.ShowDialog();
            LoadProductData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormProduct formProduct = new FormProduct(isDarkMode);
            formProduct.ShowDialog();
            LoadProductData();
        }

        private void cboFilterByStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboFilterByPrice.Text = string.Empty;
            filteredProducts = FilterByStatusProduct(cboFilterByStatus.Text, baseProducts);
            currentProducts = (string.IsNullOrWhiteSpace(cboFilterByCategory.Text)) 
                ? FilterByStatusProduct(cboFilterByStatus.Text, baseProducts) 
                : FilterByStatusProduct(cboFilterByStatus.Text, currentProducts);
            dgvProduct.DataSource = currentProducts;
        }

        private void cboFilterByPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboFilterByStatus.Text = string.Empty;
            filteredProducts = FilterByPriceProduct(cboFilterByPrice.Text, baseProducts);
            currentProducts = (string.IsNullOrWhiteSpace(cboFilterByCategory.Text))
                ? FilterByPriceProduct(cboFilterByPrice.Text, baseProducts)
                : FilterByPriceProduct(cboFilterByPrice.Text, currentProducts);
            dgvProduct.DataSource = currentProducts;
        }

        private void cboFilterByCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentProducts = (string.IsNullOrWhiteSpace(cboFilterByStatus.Text) || string.IsNullOrWhiteSpace(cboFilterByPrice.Text))
                ? FilterByCategory(cboFilterByCategory.Text, baseProducts)
                : FilterByCategory(cboFilterByCategory.Text, filteredProducts);
            dgvProduct.DataSource = currentProducts;
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            cboFilterByCategory.Text = string.Empty;
            cboFilterByField.Text = string.Empty;
            cboFilterByPrice.Text = string.Empty;
            cboFilterByStatus.Text = string.Empty;
            txtSearchByField.Text = string.Empty;
            dgvProduct.DataSource = baseProducts;
        }

        private void cboFilterByCategory_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboFilterByCategory.Text))
            {
                dgvProduct.DataSource = filteredProducts;
            }
            if(string.IsNullOrWhiteSpace(cboFilterByCategory.Text) && string.IsNullOrWhiteSpace(cboFilterByStatus.Text) && string.IsNullOrWhiteSpace(cboFilterByPrice.Text))
            {
                btnResetFilter.Enabled = false;
                LoadProductData();
            }
            else
            {
                btnResetFilter.Enabled = true;
            }
        }

        private void cboFilterByStatus_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboFilterByStatus.Text))
            {
                currentProducts.Sort((x, y) => x.ProductId.CompareTo(y.ProductId));
                dgvProduct.DataSource = currentProducts;
            }
            if (string.IsNullOrWhiteSpace(cboFilterByCategory.Text) && string.IsNullOrWhiteSpace(cboFilterByStatus.Text) && string.IsNullOrWhiteSpace(cboFilterByPrice.Text))
            {
                btnResetFilter.Enabled = false;
                LoadProductData();
            }
            else
            {
                btnResetFilter.Enabled = true;
            }
        }

        private void cboFilterByPrice_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboFilterByPrice.Text))
            {
                currentProducts.Sort((x, y) => x.ProductId.CompareTo(y.ProductId));
                dgvProduct.DataSource = currentProducts;
            }
            if (string.IsNullOrWhiteSpace(cboFilterByCategory.Text) && string.IsNullOrWhiteSpace(cboFilterByStatus.Text) && string.IsNullOrWhiteSpace(cboFilterByPrice.Text))
            {
                btnResetFilter.Enabled = false;
                LoadProductData();
            }
            else
            {
                btnResetFilter.Enabled = true;
            }
        }
        #endregion
    }
}
