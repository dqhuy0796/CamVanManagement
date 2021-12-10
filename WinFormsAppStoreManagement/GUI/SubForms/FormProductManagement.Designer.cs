
namespace WinFormsAppStoreManagement.UserInterface.SubForms
{
    partial class FormProductManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductManagement));
            this.pnlFooter = new Sunny.UI.UIPanel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.btnRemove = new Sunny.UI.UIButton();
            this.panel15 = new System.Windows.Forms.Panel();
            this.btnModify = new Sunny.UI.UIButton();
            this.panel17 = new System.Windows.Forms.Panel();
            this.btnAdd = new Sunny.UI.UIButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnBackToMainMenu = new Sunny.UI.UIButton();
            this.pnlHeader = new Sunny.UI.UIPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnResetFilter = new Sunny.UI.UIButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboFilterByCategory = new Sunny.UI.UIComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cboFilterByPrice = new Sunny.UI.UIComboBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cboFilterByStatus = new Sunny.UI.UIComboBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblOrderBy = new System.Windows.Forms.Label();
            this.pnlContainer = new Sunny.UI.UIPanel();
            this.pnlLeft = new Sunny.UI.UIPanel();
            this.dgvProduct = new Sunny.UI.UIDataGridView();
            this.colProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.colCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductTotalQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlRight = new Sunny.UI.UIPanel();
            this.pnlTool = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.pnlAdvanceSearch = new Sunny.UI.UITitlePanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txtSearchByField = new Sunny.UI.UITextBox();
            this.btnSearchByField = new Sunny.UI.UIAvatar();
            this.cboFilterByField = new Sunny.UI.UIComboBox();
            this.btnToggleTool = new System.Windows.Forms.Button();
            this.uiComboBox2 = new Sunny.UI.UIComboBox();
            this.uiDatePicker1 = new Sunny.UI.UIDatePicker();
            this.pnlFooter.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.pnlRight.SuspendLayout();
            this.pnlTool.SuspendLayout();
            this.panel13.SuspendLayout();
            this.pnlAdvanceSearch.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.panel16);
            this.pnlFooter.Controls.Add(this.panel15);
            this.pnlFooter.Controls.Add(this.panel17);
            this.pnlFooter.Controls.Add(this.panel5);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.FillColor = System.Drawing.Color.White;
            this.pnlFooter.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlFooter.Location = new System.Drawing.Point(0, 537);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlFooter.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(20);
            this.pnlFooter.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.pnlFooter.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.pnlFooter.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Top;
            this.pnlFooter.Size = new System.Drawing.Size(1333, 72);
            this.pnlFooter.Style = Sunny.UI.UIStyle.Custom;
            this.pnlFooter.StyleCustomMode = true;
            this.pnlFooter.TabIndex = 5;
            this.pnlFooter.Text = null;
            this.pnlFooter.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.Transparent;
            this.panel16.Controls.Add(this.btnRemove);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel16.Location = new System.Drawing.Point(773, 20);
            this.panel16.Name = "panel16";
            this.panel16.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel16.Size = new System.Drawing.Size(180, 32);
            this.panel16.TabIndex = 10;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemove.Enabled = false;
            this.btnRemove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnRemove.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.btnRemove.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btnRemove.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btnRemove.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.Location = new System.Drawing.Point(10, 0);
            this.btnRemove.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Radius = 30;
            this.btnRemove.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnRemove.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.btnRemove.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btnRemove.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btnRemove.Size = new System.Drawing.Size(160, 32);
            this.btnRemove.Style = Sunny.UI.UIStyle.Red;
            this.btnRemove.StyleCustomMode = true;
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Xoá mặt hàng";
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Transparent;
            this.panel15.Controls.Add(this.btnModify);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel15.Location = new System.Drawing.Point(953, 20);
            this.panel15.Name = "panel15";
            this.panel15.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel15.Size = new System.Drawing.Size(180, 32);
            this.panel15.TabIndex = 9;
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.Transparent;
            this.btnModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModify.Enabled = false;
            this.btnModify.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModify.Location = new System.Drawing.Point(10, 0);
            this.btnModify.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnModify.Name = "btnModify";
            this.btnModify.Radius = 30;
            this.btnModify.Size = new System.Drawing.Size(160, 32);
            this.btnModify.StyleCustomMode = true;
            this.btnModify.TabIndex = 1;
            this.btnModify.Text = "Sửa thông tin mặt hàng";
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Transparent;
            this.panel17.Controls.Add(this.btnAdd);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel17.Location = new System.Drawing.Point(1133, 20);
            this.panel17.Name = "panel17";
            this.panel17.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel17.Size = new System.Drawing.Size(180, 32);
            this.panel17.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.btnAdd.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(203)))), ((int)(((byte)(189)))));
            this.btnAdd.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(138)))));
            this.btnAdd.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(138)))));
            this.btnAdd.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(10, 0);
            this.btnAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Radius = 30;
            this.btnAdd.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.btnAdd.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(203)))), ((int)(((byte)(189)))));
            this.btnAdd.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(138)))));
            this.btnAdd.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(138)))));
            this.btnAdd.Size = new System.Drawing.Size(160, 32);
            this.btnAdd.Style = Sunny.UI.UIStyle.Colorful;
            this.btnAdd.StyleCustomMode = true;
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm mặt hàng mới";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.btnBackToMainMenu);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(20, 20);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel5.Size = new System.Drawing.Size(120, 32);
            this.panel5.TabIndex = 2;
            // 
            // btnBackToMainMenu
            // 
            this.btnBackToMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnBackToMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBackToMainMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnBackToMainMenu.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.btnBackToMainMenu.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btnBackToMainMenu.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btnBackToMainMenu.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBackToMainMenu.Location = new System.Drawing.Point(10, 0);
            this.btnBackToMainMenu.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnBackToMainMenu.Name = "btnBackToMainMenu";
            this.btnBackToMainMenu.Radius = 30;
            this.btnBackToMainMenu.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnBackToMainMenu.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.btnBackToMainMenu.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btnBackToMainMenu.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btnBackToMainMenu.Size = new System.Drawing.Size(100, 32);
            this.btnBackToMainMenu.Style = Sunny.UI.UIStyle.Red;
            this.btnBackToMainMenu.StyleCustomMode = true;
            this.btnBackToMainMenu.TabIndex = 1;
            this.btnBackToMainMenu.Text = "Trở về";
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.panel6);
            this.pnlHeader.Controls.Add(this.panel1);
            this.pnlHeader.Controls.Add(this.panel7);
            this.pnlHeader.Controls.Add(this.panel9);
            this.pnlHeader.Controls.Add(this.panel10);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.FillColor = System.Drawing.Color.White;
            this.pnlHeader.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlHeader.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(14);
            this.pnlHeader.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.pnlHeader.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.pnlHeader.RectSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.pnlHeader.Size = new System.Drawing.Size(1333, 60);
            this.pnlHeader.Style = Sunny.UI.UIStyle.Custom;
            this.pnlHeader.StyleCustomMode = true;
            this.pnlHeader.TabIndex = 4;
            this.pnlHeader.Text = null;
            this.pnlHeader.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.btnResetFilter);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(634, 14);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.panel6.Size = new System.Drawing.Size(110, 32);
            this.panel6.TabIndex = 17;
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnResetFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnResetFilter.Enabled = false;
            this.btnResetFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.btnResetFilter.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(203)))), ((int)(((byte)(189)))));
            this.btnResetFilter.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(138)))));
            this.btnResetFilter.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(138)))));
            this.btnResetFilter.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnResetFilter.Location = new System.Drawing.Point(0, 0);
            this.btnResetFilter.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Radius = 30;
            this.btnResetFilter.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.btnResetFilter.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(203)))), ((int)(((byte)(189)))));
            this.btnResetFilter.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(138)))));
            this.btnResetFilter.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(138)))));
            this.btnResetFilter.Size = new System.Drawing.Size(95, 32);
            this.btnResetFilter.Style = Sunny.UI.UIStyle.Colorful;
            this.btnResetFilter.StyleCustomMode = true;
            this.btnResetFilter.TabIndex = 1;
            this.btnResetFilter.Text = "Đặt lại";
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.cboFilterByCategory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(464, 14);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.panel1.Size = new System.Drawing.Size(170, 32);
            this.panel1.TabIndex = 10;
            // 
            // cboFilterByCategory
            // 
            this.cboFilterByCategory.DataSource = null;
            this.cboFilterByCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboFilterByCategory.FillColor = System.Drawing.Color.White;
            this.cboFilterByCategory.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboFilterByCategory.Location = new System.Drawing.Point(0, 0);
            this.cboFilterByCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboFilterByCategory.MaxDropDownItems = 5;
            this.cboFilterByCategory.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboFilterByCategory.Name = "cboFilterByCategory";
            this.cboFilterByCategory.Padding = new System.Windows.Forms.Padding(5, 0, 30, 5);
            this.cboFilterByCategory.Radius = 16;
            this.cboFilterByCategory.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.cboFilterByCategory.Size = new System.Drawing.Size(155, 32);
            this.cboFilterByCategory.Style = Sunny.UI.UIStyle.Colorful;
            this.cboFilterByCategory.StyleCustomMode = true;
            this.cboFilterByCategory.TabIndex = 1;
            this.cboFilterByCategory.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboFilterByCategory.Watermark = "Danh mục";
            this.cboFilterByCategory.TextChanged += new System.EventHandler(this.cboFilterByCategory_TextChanged);
            this.cboFilterByCategory.SelectedIndexChanged += new System.EventHandler(this.cboFilterByCategory_SelectedIndexChanged);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.cboFilterByPrice);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(294, 14);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.panel7.Size = new System.Drawing.Size(170, 32);
            this.panel7.TabIndex = 9;
            // 
            // cboFilterByPrice
            // 
            this.cboFilterByPrice.DataSource = null;
            this.cboFilterByPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboFilterByPrice.FillColor = System.Drawing.Color.White;
            this.cboFilterByPrice.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboFilterByPrice.Items.AddRange(new object[] {
            "Cao đến thấp",
            "Thấp đến cao"});
            this.cboFilterByPrice.Location = new System.Drawing.Point(0, 0);
            this.cboFilterByPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboFilterByPrice.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboFilterByPrice.Name = "cboFilterByPrice";
            this.cboFilterByPrice.Padding = new System.Windows.Forms.Padding(5, 0, 30, 2);
            this.cboFilterByPrice.Radius = 16;
            this.cboFilterByPrice.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.cboFilterByPrice.Size = new System.Drawing.Size(155, 32);
            this.cboFilterByPrice.Style = Sunny.UI.UIStyle.Colorful;
            this.cboFilterByPrice.StyleCustomMode = true;
            this.cboFilterByPrice.TabIndex = 1;
            this.cboFilterByPrice.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboFilterByPrice.Watermark = "Giá";
            this.cboFilterByPrice.TextChanged += new System.EventHandler(this.cboFilterByPrice_TextChanged);
            this.cboFilterByPrice.SelectedIndexChanged += new System.EventHandler(this.cboFilterByPrice_SelectedIndexChanged);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.Controls.Add(this.cboFilterByStatus);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(124, 14);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.panel9.Size = new System.Drawing.Size(170, 32);
            this.panel9.TabIndex = 8;
            // 
            // cboFilterByStatus
            // 
            this.cboFilterByStatus.DataSource = null;
            this.cboFilterByStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboFilterByStatus.FillColor = System.Drawing.Color.White;
            this.cboFilterByStatus.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboFilterByStatus.Items.AddRange(new object[] {
            "Phổ biến nhất",
            "Mới nhất",
            "Còn nhiều",
            "Còn ít"});
            this.cboFilterByStatus.Location = new System.Drawing.Point(0, 0);
            this.cboFilterByStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboFilterByStatus.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboFilterByStatus.Name = "cboFilterByStatus";
            this.cboFilterByStatus.Padding = new System.Windows.Forms.Padding(5, 0, 30, 2);
            this.cboFilterByStatus.Radius = 16;
            this.cboFilterByStatus.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.cboFilterByStatus.Size = new System.Drawing.Size(155, 32);
            this.cboFilterByStatus.Style = Sunny.UI.UIStyle.Colorful;
            this.cboFilterByStatus.StyleCustomMode = true;
            this.cboFilterByStatus.TabIndex = 1;
            this.cboFilterByStatus.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboFilterByStatus.Watermark = "Trạng thái";
            this.cboFilterByStatus.TextChanged += new System.EventHandler(this.cboFilterByStatus_TextChanged);
            this.cboFilterByStatus.SelectedIndexChanged += new System.EventHandler(this.cboFilterByStatus_SelectedIndexChanged);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel10.Controls.Add(this.lblOrderBy);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(14, 14);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.panel10.Size = new System.Drawing.Size(110, 32);
            this.panel10.TabIndex = 7;
            // 
            // lblOrderBy
            // 
            this.lblOrderBy.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOrderBy.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrderBy.Location = new System.Drawing.Point(0, 0);
            this.lblOrderBy.Name = "lblOrderBy";
            this.lblOrderBy.Size = new System.Drawing.Size(95, 32);
            this.lblOrderBy.TabIndex = 0;
            this.lblOrderBy.Text = "Sắp xếp theo";
            this.lblOrderBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.pnlLeft);
            this.pnlContainer.Controls.Add(this.pnlRight);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.FillColor = System.Drawing.Color.White;
            this.pnlContainer.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlContainer.Location = new System.Drawing.Point(0, 60);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlContainer.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Radius = 0;
            this.pnlContainer.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.pnlContainer.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.pnlContainer.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pnlContainer.Size = new System.Drawing.Size(1333, 477);
            this.pnlContainer.Style = Sunny.UI.UIStyle.Custom;
            this.pnlContainer.StyleCustomMode = true;
            this.pnlContainer.TabIndex = 6;
            this.pnlContainer.Text = null;
            this.pnlContainer.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.dgvProduct);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.FillColor = System.Drawing.Color.Transparent;
            this.pnlLeft.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlLeft.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(10);
            this.pnlLeft.Radius = 16;
            this.pnlLeft.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.pnlLeft.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.pnlLeft.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pnlLeft.Size = new System.Drawing.Size(833, 477);
            this.pnlLeft.Style = Sunny.UI.UIStyle.Custom;
            this.pnlLeft.StyleCustomMode = true;
            this.pnlLeft.TabIndex = 5;
            this.pnlLeft.Text = null;
            this.pnlLeft.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(251)))), ((int)(((byte)(250)))));
            this.dgvProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProduct.ColumnHeadersHeight = 32;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductId,
            this.colProductName,
            this.colProductImage,
            this.colCategoryName,
            this.colProductUnit,
            this.colProductPrice,
            this.colProductTotalQuantity,
            this.colProductDescription});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduct.EnableHeadersVisualStyles = false;
            this.dgvProduct.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.dgvProduct.Location = new System.Drawing.Point(10, 10);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(251)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.RowHeight = 120;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            this.dgvProduct.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvProduct.RowTemplate.Height = 120;
            this.dgvProduct.SelectedIndex = -1;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvProduct.ShowGridLine = true;
            this.dgvProduct.Size = new System.Drawing.Size(813, 457);
            this.dgvProduct.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(251)))), ((int)(((byte)(250)))));
            this.dgvProduct.Style = Sunny.UI.UIStyle.Colorful;
            this.dgvProduct.StyleCustomMode = true;
            this.dgvProduct.TabIndex = 1;
            this.dgvProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellDoubleClick);
            // 
            // colProductId
            // 
            this.colProductId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colProductId.DataPropertyName = "ProductId";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colProductId.DefaultCellStyle = dataGridViewCellStyle3;
            this.colProductId.HeaderText = "Mã mặt hàng";
            this.colProductId.MinimumWidth = 120;
            this.colProductId.Name = "colProductId";
            this.colProductId.ReadOnly = true;
            this.colProductId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colProductId.ToolTipText = "Mã mặt hàng tự động";
            this.colProductId.Width = 120;
            // 
            // colProductName
            // 
            this.colProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProductName.DataPropertyName = "ProductName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colProductName.DefaultCellStyle = dataGridViewCellStyle4;
            this.colProductName.FillWeight = 50F;
            this.colProductName.HeaderText = "Tên mặt hàng";
            this.colProductName.MinimumWidth = 160;
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            this.colProductName.ToolTipText = "Tên mặt hàng nè bạn nhỏ";
            // 
            // colProductImage
            // 
            this.colProductImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colProductImage.DataPropertyName = "ProductImage";
            this.colProductImage.HeaderText = "Hình ảnh";
            this.colProductImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.colProductImage.MinimumWidth = 120;
            this.colProductImage.Name = "colProductImage";
            this.colProductImage.ReadOnly = true;
            this.colProductImage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colProductImage.Width = 120;
            // 
            // colCategoryName
            // 
            this.colCategoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCategoryName.DataPropertyName = "CategoryName";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colCategoryName.DefaultCellStyle = dataGridViewCellStyle5;
            this.colCategoryName.FillWeight = 10F;
            this.colCategoryName.HeaderText = "Danh mục";
            this.colCategoryName.MinimumWidth = 120;
            this.colCategoryName.Name = "colCategoryName";
            this.colCategoryName.ReadOnly = true;
            this.colCategoryName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCategoryName.ToolTipText = "Danh mục chung của loại mặt hàng này";
            this.colCategoryName.Width = 120;
            // 
            // colProductUnit
            // 
            this.colProductUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colProductUnit.DataPropertyName = "ProductUnit";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colProductUnit.DefaultCellStyle = dataGridViewCellStyle6;
            this.colProductUnit.HeaderText = "Đơn vị tính";
            this.colProductUnit.MinimumWidth = 120;
            this.colProductUnit.Name = "colProductUnit";
            this.colProductUnit.ReadOnly = true;
            this.colProductUnit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colProductUnit.ToolTipText = "Cách tính sao cho nó chuẩn hiểu chứ?";
            this.colProductUnit.Width = 120;
            // 
            // colProductPrice
            // 
            this.colProductPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colProductPrice.DataPropertyName = "ProductPrice";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "C0";
            dataGridViewCellStyle7.NullValue = "Unknown";
            this.colProductPrice.DefaultCellStyle = dataGridViewCellStyle7;
            this.colProductPrice.HeaderText = "Đơn giá";
            this.colProductPrice.MinimumWidth = 120;
            this.colProductPrice.Name = "colProductPrice";
            this.colProductPrice.ReadOnly = true;
            this.colProductPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colProductPrice.Width = 120;
            // 
            // colProductTotalQuantity
            // 
            this.colProductTotalQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colProductTotalQuantity.DataPropertyName = "ProductTotalQuantity";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colProductTotalQuantity.DefaultCellStyle = dataGridViewCellStyle8;
            this.colProductTotalQuantity.HeaderText = "Số lượng";
            this.colProductTotalQuantity.MinimumWidth = 120;
            this.colProductTotalQuantity.Name = "colProductTotalQuantity";
            this.colProductTotalQuantity.ReadOnly = true;
            this.colProductTotalQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colProductTotalQuantity.ToolTipText = "Số lượng còn trong hệ thống để bán hiện nay";
            this.colProductTotalQuantity.Width = 120;
            // 
            // colProductDescription
            // 
            this.colProductDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProductDescription.DataPropertyName = "ProductDescription";
            this.colProductDescription.HeaderText = "Mô tả";
            this.colProductDescription.MinimumWidth = 160;
            this.colProductDescription.Name = "colProductDescription";
            this.colProductDescription.ReadOnly = true;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.pnlTool);
            this.pnlRight.Controls.Add(this.btnToggleTool);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.FillColor = System.Drawing.Color.Transparent;
            this.pnlRight.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlRight.Location = new System.Drawing.Point(833, 0);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlRight.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Radius = 16;
            this.pnlRight.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.pnlRight.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.pnlRight.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.pnlRight.Size = new System.Drawing.Size(500, 477);
            this.pnlRight.Style = Sunny.UI.UIStyle.Custom;
            this.pnlRight.StyleCustomMode = true;
            this.pnlRight.TabIndex = 2;
            this.pnlRight.Text = null;
            this.pnlRight.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTool
            // 
            this.pnlTool.BackColor = System.Drawing.Color.Transparent;
            this.pnlTool.Controls.Add(this.panel13);
            this.pnlTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTool.Location = new System.Drawing.Point(0, 0);
            this.pnlTool.Name = "pnlTool";
            this.pnlTool.Padding = new System.Windows.Forms.Padding(10);
            this.pnlTool.Size = new System.Drawing.Size(476, 477);
            this.pnlTool.TabIndex = 1;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.pnlAdvanceSearch);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(10, 10);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.panel13.Size = new System.Drawing.Size(456, 103);
            this.panel13.TabIndex = 4;
            // 
            // pnlAdvanceSearch
            // 
            this.pnlAdvanceSearch.Controls.Add(this.panel2);
            this.pnlAdvanceSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdvanceSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(251)))), ((int)(((byte)(250)))));
            this.pnlAdvanceSearch.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlAdvanceSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlAdvanceSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlAdvanceSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlAdvanceSearch.Name = "pnlAdvanceSearch";
            this.pnlAdvanceSearch.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.pnlAdvanceSearch.Radius = 16;
            this.pnlAdvanceSearch.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.pnlAdvanceSearch.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.pnlAdvanceSearch.Size = new System.Drawing.Size(456, 87);
            this.pnlAdvanceSearch.Style = Sunny.UI.UIStyle.Custom;
            this.pnlAdvanceSearch.StyleCustomMode = true;
            this.pnlAdvanceSearch.TabIndex = 4;
            this.pnlAdvanceSearch.Text = "Tìm kiếm nâng cao";
            this.pnlAdvanceSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlAdvanceSearch.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel12);
            this.panel2.Controls.Add(this.btnSearchByField);
            this.panel2.Controls.Add(this.cboFilterByField);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(456, 52);
            this.panel2.TabIndex = 0;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.txtSearchByField);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(142, 10);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel12.Size = new System.Drawing.Size(272, 32);
            this.panel12.TabIndex = 7;
            // 
            // txtSearchByField
            // 
            this.txtSearchByField.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchByField.ButtonSymbol = 61761;
            this.txtSearchByField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchByField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchByField.FillColor = System.Drawing.Color.White;
            this.txtSearchByField.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchByField.Location = new System.Drawing.Point(10, 0);
            this.txtSearchByField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchByField.Maximum = 2147483647D;
            this.txtSearchByField.Minimum = -2147483648D;
            this.txtSearchByField.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSearchByField.Name = "txtSearchByField";
            this.txtSearchByField.Radius = 16;
            this.txtSearchByField.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.txtSearchByField.Size = new System.Drawing.Size(252, 32);
            this.txtSearchByField.Style = Sunny.UI.UIStyle.Colorful;
            this.txtSearchByField.StyleCustomMode = true;
            this.txtSearchByField.TabIndex = 4;
            this.txtSearchByField.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSearchByField.Watermark = "Nhập thông tin tìm kiếm";
            // 
            // btnSearchByField
            // 
            this.btnSearchByField.AvatarSize = 30;
            this.btnSearchByField.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearchByField.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearchByField.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.btnSearchByField.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchByField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.btnSearchByField.Icon = Sunny.UI.UIAvatar.UIIcon.Image;
            this.btnSearchByField.Image = global::WinFormsAppStoreManagement.Properties.Resources.white_search_32;
            this.btnSearchByField.ImageOffset = new System.Drawing.Point(-1, -1);
            this.btnSearchByField.Location = new System.Drawing.Point(414, 10);
            this.btnSearchByField.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSearchByField.Name = "btnSearchByField";
            this.btnSearchByField.Size = new System.Drawing.Size(32, 32);
            this.btnSearchByField.Style = Sunny.UI.UIStyle.Custom;
            this.btnSearchByField.StyleCustomMode = true;
            this.btnSearchByField.TabIndex = 6;
            // 
            // cboFilterByField
            // 
            this.cboFilterByField.DataSource = null;
            this.cboFilterByField.Dock = System.Windows.Forms.DockStyle.Left;
            this.cboFilterByField.DropDownWidth = 132;
            this.cboFilterByField.FillColor = System.Drawing.Color.White;
            this.cboFilterByField.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboFilterByField.Items.AddRange(new object[] {
            "Mã mặt hàng",
            "Tên mặt hàng"});
            this.cboFilterByField.Location = new System.Drawing.Point(10, 10);
            this.cboFilterByField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboFilterByField.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboFilterByField.Name = "cboFilterByField";
            this.cboFilterByField.Padding = new System.Windows.Forms.Padding(5, 0, 30, 2);
            this.cboFilterByField.Radius = 16;
            this.cboFilterByField.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.cboFilterByField.Size = new System.Drawing.Size(132, 32);
            this.cboFilterByField.Style = Sunny.UI.UIStyle.Colorful;
            this.cboFilterByField.StyleCustomMode = true;
            this.cboFilterByField.TabIndex = 2;
            this.cboFilterByField.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboFilterByField.Watermark = "Tìm kiếm theo";
            // 
            // btnToggleTool
            // 
            this.btnToggleTool.BackColor = System.Drawing.Color.Transparent;
            this.btnToggleTool.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnToggleTool.BackgroundImage")));
            this.btnToggleTool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnToggleTool.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnToggleTool.FlatAppearance.BorderSize = 0;
            this.btnToggleTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleTool.Location = new System.Drawing.Point(476, 0);
            this.btnToggleTool.Name = "btnToggleTool";
            this.btnToggleTool.Size = new System.Drawing.Size(24, 477);
            this.btnToggleTool.TabIndex = 0;
            this.btnToggleTool.UseVisualStyleBackColor = false;
            this.btnToggleTool.Click += new System.EventHandler(this.btnToggleTool_Click);
            // 
            // uiComboBox2
            // 
            this.uiComboBox2.DataSource = null;
            this.uiComboBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiComboBox2.DropDownWidth = 132;
            this.uiComboBox2.FillColor = System.Drawing.Color.White;
            this.uiComboBox2.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiComboBox2.Items.AddRange(new object[] {
            "Tên khách hàng",
            "Tên nhân viên"});
            this.uiComboBox2.Location = new System.Drawing.Point(5, 10);
            this.uiComboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox2.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox2.Name = "uiComboBox2";
            this.uiComboBox2.Padding = new System.Windows.Forms.Padding(5, 0, 30, 2);
            this.uiComboBox2.Radius = 16;
            this.uiComboBox2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.uiComboBox2.Size = new System.Drawing.Size(132, 32);
            this.uiComboBox2.Style = Sunny.UI.UIStyle.Black;
            this.uiComboBox2.StyleCustomMode = true;
            this.uiComboBox2.TabIndex = 2;
            this.uiComboBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox2.Watermark = "Chọn loại tên";
            // 
            // uiDatePicker1
            // 
            this.uiDatePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiDatePicker1.FillColor = System.Drawing.Color.White;
            this.uiDatePicker1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiDatePicker1.Location = new System.Drawing.Point(200, 10);
            this.uiDatePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiDatePicker1.MaxLength = 10;
            this.uiDatePicker1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiDatePicker1.Name = "uiDatePicker1";
            this.uiDatePicker1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiDatePicker1.Radius = 16;
            this.uiDatePicker1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.uiDatePicker1.ShowToday = true;
            this.uiDatePicker1.Size = new System.Drawing.Size(223, 32);
            this.uiDatePicker1.Style = Sunny.UI.UIStyle.Custom;
            this.uiDatePicker1.StyleCustomMode = true;
            this.uiDatePicker1.SymbolDropDown = 61555;
            this.uiDatePicker1.SymbolNormal = 61555;
            this.uiDatePicker1.TabIndex = 5;
            this.uiDatePicker1.Text = "2021-10-17";
            this.uiDatePicker1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiDatePicker1.Value = new System.DateTime(2021, 10, 17, 18, 3, 32, 866);
            // 
            // FormProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1333, 609);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(744, 609);
            this.Name = "FormProductManagement";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormProduct";
            this.pnlFooter.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.pnlTool.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.pnlAdvanceSearch.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel pnlFooter;
        private System.Windows.Forms.Panel panel16;
        private Sunny.UI.UIButton btnRemove;
        private System.Windows.Forms.Panel panel15;
        private Sunny.UI.UIButton btnModify;
        private System.Windows.Forms.Panel panel17;
        private Sunny.UI.UIButton btnAdd;
        private System.Windows.Forms.Panel panel5;
        private Sunny.UI.UIButton btnBackToMainMenu;
        private Sunny.UI.UIPanel pnlHeader;
        private System.Windows.Forms.Panel panel7;
        private Sunny.UI.UIComboBox cboFilterByPrice;
        private System.Windows.Forms.Panel panel9;
        private Sunny.UI.UIComboBox cboFilterByStatus;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lblOrderBy;
        private Sunny.UI.UIPanel pnlContainer;
        private Sunny.UI.UIPanel pnlRight;
        private System.Windows.Forms.Panel pnlTool;
        private System.Windows.Forms.Panel panel13;
        private Sunny.UI.UITitlePanel pnlAdvanceSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel12;
        private Sunny.UI.UITextBox txtSearchByField;
        private Sunny.UI.UIAvatar btnSearchByField;
        private Sunny.UI.UIComboBox cboFilterByField;
        private System.Windows.Forms.Button btnToggleTool;
        private System.Windows.Forms.Panel panel6;
        private Sunny.UI.UIButton btnResetFilter;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UIComboBox cboFilterByCategory;
        private Sunny.UI.UIComboBox uiComboBox2;
        private Sunny.UI.UIDatePicker uiDatePicker1;
        private Sunny.UI.UIPanel pnlLeft;
        private Sunny.UI.UIDataGridView dgvProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewImageColumn colProductImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductTotalQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductDescription;
    }
}