
namespace WinFormsAppStoreManagement.UserInterface.SubForms
{
    partial class FormOrderManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrderManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlLeft = new Sunny.UI.UIPanel();
            this.dgvOrder = new Sunny.UI.UIDataGridView();
            this.pnlRight = new Sunny.UI.UIPanel();
            this.pnlTool = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.pnlAdvanceSearch = new Sunny.UI.UITitlePanel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dtpFilterByPickTime = new Sunny.UI.UIDatePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSearchByName = new Sunny.UI.UITextBox();
            this.uiAvatar1 = new Sunny.UI.UIAvatar();
            this.cboFilterByName = new Sunny.UI.UIComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txtSearchById = new Sunny.UI.UITextBox();
            this.btnSearchById = new Sunny.UI.UIAvatar();
            this.cboFilterById = new Sunny.UI.UIComboBox();
            this.btnToggleTool = new System.Windows.Forms.Button();
            this.pnlFooter = new Sunny.UI.UIPanel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.btnRemove = new Sunny.UI.UIButton();
            this.panel15 = new System.Windows.Forms.Panel();
            this.btnModify = new Sunny.UI.UIButton();
            this.panel17 = new System.Windows.Forms.Panel();
            this.btnCreate = new Sunny.UI.UIButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnBackToMainMenu = new Sunny.UI.UIButton();
            this.pnlHeader = new Sunny.UI.UIPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnResetFilter = new Sunny.UI.UIButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cboFilterByStatus = new Sunny.UI.UIComboBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cboFilterByTime = new Sunny.UI.UIComboBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblOrderBy = new System.Windows.Forms.Label();
            this.colOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderTimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlContainer.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.pnlRight.SuspendLayout();
            this.pnlTool.SuspendLayout();
            this.panel13.SuspendLayout();
            this.pnlAdvanceSearch.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel12.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.pnlLeft);
            this.pnlContainer.Controls.Add(this.pnlRight);
            this.pnlContainer.Controls.Add(this.pnlFooter);
            this.pnlContainer.Controls.Add(this.pnlHeader);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1317, 609);
            this.pnlContainer.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.Transparent;
            this.pnlLeft.Controls.Add(this.dgvOrder);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.FillColor = System.Drawing.Color.Transparent;
            this.pnlLeft.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlLeft.Location = new System.Drawing.Point(0, 60);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlLeft.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(10);
            this.pnlLeft.Radius = 16;
            this.pnlLeft.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.pnlLeft.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.pnlLeft.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pnlLeft.Size = new System.Drawing.Size(817, 477);
            this.pnlLeft.Style = Sunny.UI.UIStyle.Custom;
            this.pnlLeft.StyleCustomMode = true;
            this.pnlLeft.TabIndex = 7;
            this.pnlLeft.Text = null;
            this.pnlLeft.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(251)))), ((int)(((byte)(250)))));
            this.dgvOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrder.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrder.ColumnHeadersHeight = 32;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderId,
            this.colOrderTimeStamp,
            this.colCustomerId,
            this.colCustomerName,
            this.colEmployeeId,
            this.colEmployeeName,
            this.colOrderStatus,
            this.colOrderDescription});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrder.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrder.EnableHeadersVisualStyles = false;
            this.dgvOrder.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.dgvOrder.Location = new System.Drawing.Point(10, 10);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(251)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvOrder.RowHeight = 25;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgvOrder.RowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvOrder.RowTemplate.Height = 25;
            this.dgvOrder.SelectedIndex = -1;
            this.dgvOrder.ShowGridLine = true;
            this.dgvOrder.Size = new System.Drawing.Size(797, 457);
            this.dgvOrder.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(251)))), ((int)(((byte)(250)))));
            this.dgvOrder.Style = Sunny.UI.UIStyle.Colorful;
            this.dgvOrder.StyleCustomMode = true;
            this.dgvOrder.TabIndex = 1;
            this.dgvOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellDoubleClick);
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.Transparent;
            this.pnlRight.Controls.Add(this.pnlTool);
            this.pnlRight.Controls.Add(this.btnToggleTool);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.FillColor = System.Drawing.Color.White;
            this.pnlRight.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlRight.Location = new System.Drawing.Point(817, 60);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlRight.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Radius = 16;
            this.pnlRight.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.pnlRight.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.pnlRight.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.pnlRight.Size = new System.Drawing.Size(500, 477);
            this.pnlRight.Style = Sunny.UI.UIStyle.White;
            this.pnlRight.StyleCustomMode = true;
            this.pnlRight.TabIndex = 5;
            this.pnlRight.Text = null;
            this.pnlRight.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTool
            // 
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
            this.panel13.Size = new System.Drawing.Size(456, 218);
            this.panel13.TabIndex = 4;
            // 
            // pnlAdvanceSearch
            // 
            this.pnlAdvanceSearch.Controls.Add(this.panel11);
            this.pnlAdvanceSearch.Controls.Add(this.panel3);
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
            this.pnlAdvanceSearch.Size = new System.Drawing.Size(456, 202);
            this.pnlAdvanceSearch.Style = Sunny.UI.UIStyle.Custom;
            this.pnlAdvanceSearch.StyleCustomMode = true;
            this.pnlAdvanceSearch.TabIndex = 4;
            this.pnlAdvanceSearch.Text = "Tìm kiếm nâng cao";
            this.pnlAdvanceSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlAdvanceSearch.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Transparent;
            this.panel11.Controls.Add(this.dtpFilterByPickTime);
            this.panel11.Controls.Add(this.label1);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 139);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(10);
            this.panel11.Size = new System.Drawing.Size(456, 52);
            this.panel11.TabIndex = 2;
            // 
            // dtpFilterByPickTime
            // 
            this.dtpFilterByPickTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFilterByPickTime.FillColor = System.Drawing.Color.White;
            this.dtpFilterByPickTime.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFilterByPickTime.Location = new System.Drawing.Point(205, 10);
            this.dtpFilterByPickTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFilterByPickTime.MaxLength = 10;
            this.dtpFilterByPickTime.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtpFilterByPickTime.Name = "dtpFilterByPickTime";
            this.dtpFilterByPickTime.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dtpFilterByPickTime.Radius = 16;
            this.dtpFilterByPickTime.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.dtpFilterByPickTime.ShowToday = true;
            this.dtpFilterByPickTime.Size = new System.Drawing.Size(241, 32);
            this.dtpFilterByPickTime.Style = Sunny.UI.UIStyle.Custom;
            this.dtpFilterByPickTime.StyleCustomMode = true;
            this.dtpFilterByPickTime.SymbolDropDown = 61555;
            this.dtpFilterByPickTime.SymbolNormal = 61555;
            this.dtpFilterByPickTime.TabIndex = 5;
            this.dtpFilterByPickTime.Text = "2021-10-17";
            this.dtpFilterByPickTime.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtpFilterByPickTime.Value = new System.DateTime(2021, 10, 17, 18, 3, 32, 866);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tìm ngày lập hoá đơn cụ thể";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.uiAvatar1);
            this.panel3.Controls.Add(this.cboFilterByName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 87);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(456, 52);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtSearchByName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(142, 10);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel4.Size = new System.Drawing.Size(272, 32);
            this.panel4.TabIndex = 7;
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchByName.ButtonSymbol = 61761;
            this.txtSearchByName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchByName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchByName.FillColor = System.Drawing.Color.White;
            this.txtSearchByName.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchByName.Location = new System.Drawing.Point(10, 0);
            this.txtSearchByName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchByName.Maximum = 2147483647D;
            this.txtSearchByName.Minimum = -2147483648D;
            this.txtSearchByName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Radius = 16;
            this.txtSearchByName.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.txtSearchByName.Size = new System.Drawing.Size(252, 32);
            this.txtSearchByName.Style = Sunny.UI.UIStyle.Custom;
            this.txtSearchByName.StyleCustomMode = true;
            this.txtSearchByName.TabIndex = 4;
            this.txtSearchByName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSearchByName.Watermark = "Nhập tên tìm kiếm";
            // 
            // uiAvatar1
            // 
            this.uiAvatar1.AvatarSize = 30;
            this.uiAvatar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.uiAvatar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.uiAvatar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.uiAvatar1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiAvatar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.uiAvatar1.Icon = Sunny.UI.UIAvatar.UIIcon.Image;
            this.uiAvatar1.Image = global::WinFormsAppStoreManagement.Properties.Resources.white_search_32;
            this.uiAvatar1.ImageOffset = new System.Drawing.Point(-1, -1);
            this.uiAvatar1.Location = new System.Drawing.Point(414, 10);
            this.uiAvatar1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiAvatar1.Name = "uiAvatar1";
            this.uiAvatar1.Shape = Sunny.UI.UIShape.Square;
            this.uiAvatar1.Size = new System.Drawing.Size(32, 32);
            this.uiAvatar1.Style = Sunny.UI.UIStyle.Custom;
            this.uiAvatar1.StyleCustomMode = true;
            this.uiAvatar1.TabIndex = 6;
            // 
            // cboFilterByName
            // 
            this.cboFilterByName.DataSource = null;
            this.cboFilterByName.Dock = System.Windows.Forms.DockStyle.Left;
            this.cboFilterByName.DropDownWidth = 132;
            this.cboFilterByName.FillColor = System.Drawing.Color.White;
            this.cboFilterByName.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboFilterByName.Items.AddRange(new object[] {
            "Tên khách hàng",
            "Tên nhân viên"});
            this.cboFilterByName.Location = new System.Drawing.Point(10, 10);
            this.cboFilterByName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboFilterByName.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboFilterByName.Name = "cboFilterByName";
            this.cboFilterByName.Padding = new System.Windows.Forms.Padding(5, 0, 30, 2);
            this.cboFilterByName.Radius = 16;
            this.cboFilterByName.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.cboFilterByName.Size = new System.Drawing.Size(132, 32);
            this.cboFilterByName.Style = Sunny.UI.UIStyle.Black;
            this.cboFilterByName.StyleCustomMode = true;
            this.cboFilterByName.TabIndex = 2;
            this.cboFilterByName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboFilterByName.Watermark = "Chọn loại tên";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel12);
            this.panel2.Controls.Add(this.btnSearchById);
            this.panel2.Controls.Add(this.cboFilterById);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(456, 52);
            this.panel2.TabIndex = 0;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.txtSearchById);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(142, 10);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel12.Size = new System.Drawing.Size(272, 32);
            this.panel12.TabIndex = 7;
            // 
            // txtSearchById
            // 
            this.txtSearchById.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchById.ButtonSymbol = 61761;
            this.txtSearchById.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchById.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchById.FillColor = System.Drawing.Color.White;
            this.txtSearchById.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchById.Location = new System.Drawing.Point(10, 0);
            this.txtSearchById.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchById.Maximum = 2147483647D;
            this.txtSearchById.Minimum = -2147483648D;
            this.txtSearchById.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSearchById.Name = "txtSearchById";
            this.txtSearchById.Radius = 16;
            this.txtSearchById.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.txtSearchById.Size = new System.Drawing.Size(252, 32);
            this.txtSearchById.Style = Sunny.UI.UIStyle.Custom;
            this.txtSearchById.StyleCustomMode = true;
            this.txtSearchById.TabIndex = 4;
            this.txtSearchById.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSearchById.Watermark = "Nhập mã tìm kiếm";
            // 
            // btnSearchById
            // 
            this.btnSearchById.AvatarSize = 30;
            this.btnSearchById.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearchById.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearchById.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.btnSearchById.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchById.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.btnSearchById.Icon = Sunny.UI.UIAvatar.UIIcon.Image;
            this.btnSearchById.Image = global::WinFormsAppStoreManagement.Properties.Resources.white_search_32;
            this.btnSearchById.ImageOffset = new System.Drawing.Point(-1, -1);
            this.btnSearchById.Location = new System.Drawing.Point(414, 10);
            this.btnSearchById.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSearchById.Name = "btnSearchById";
            this.btnSearchById.Shape = Sunny.UI.UIShape.Square;
            this.btnSearchById.Size = new System.Drawing.Size(32, 32);
            this.btnSearchById.Style = Sunny.UI.UIStyle.Custom;
            this.btnSearchById.StyleCustomMode = true;
            this.btnSearchById.TabIndex = 6;
            // 
            // cboFilterById
            // 
            this.cboFilterById.DataSource = null;
            this.cboFilterById.Dock = System.Windows.Forms.DockStyle.Left;
            this.cboFilterById.DropDownWidth = 132;
            this.cboFilterById.FillColor = System.Drawing.Color.White;
            this.cboFilterById.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboFilterById.Items.AddRange(new object[] {
            "Mã hoá đơn",
            "Mã đơn hàng",
            "Mã khách hàng",
            "Giá trị đơn hàng",
            "Giảm giá",
            "Khuyến mại"});
            this.cboFilterById.Location = new System.Drawing.Point(10, 10);
            this.cboFilterById.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboFilterById.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboFilterById.Name = "cboFilterById";
            this.cboFilterById.Padding = new System.Windows.Forms.Padding(5, 0, 30, 2);
            this.cboFilterById.Radius = 16;
            this.cboFilterById.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.cboFilterById.Size = new System.Drawing.Size(132, 32);
            this.cboFilterById.Style = Sunny.UI.UIStyle.Black;
            this.cboFilterById.StyleCustomMode = true;
            this.cboFilterById.TabIndex = 2;
            this.cboFilterById.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboFilterById.Watermark = "Chọn loại mã";
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
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.Transparent;
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
            this.pnlFooter.Size = new System.Drawing.Size(1317, 72);
            this.pnlFooter.Style = Sunny.UI.UIStyle.Custom;
            this.pnlFooter.StyleCustomMode = true;
            this.pnlFooter.TabIndex = 4;
            this.pnlFooter.Text = null;
            this.pnlFooter.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.Transparent;
            this.panel16.Controls.Add(this.btnRemove);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel16.Location = new System.Drawing.Point(757, 20);
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
            this.btnRemove.Radius = 16;
            this.btnRemove.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnRemove.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.btnRemove.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btnRemove.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btnRemove.Size = new System.Drawing.Size(160, 32);
            this.btnRemove.Style = Sunny.UI.UIStyle.Red;
            this.btnRemove.StyleCustomMode = true;
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Xoá đơn hàng";
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Transparent;
            this.panel15.Controls.Add(this.btnModify);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel15.Location = new System.Drawing.Point(937, 20);
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
            this.btnModify.Radius = 16;
            this.btnModify.Size = new System.Drawing.Size(160, 32);
            this.btnModify.StyleCustomMode = true;
            this.btnModify.TabIndex = 1;
            this.btnModify.Text = "Sửa thông tin đơn hàng";
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Transparent;
            this.panel17.Controls.Add(this.btnCreate);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel17.Location = new System.Drawing.Point(1117, 20);
            this.panel17.Name = "panel17";
            this.panel17.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel17.Size = new System.Drawing.Size(180, 32);
            this.panel17.TabIndex = 8;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.btnCreate.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(203)))), ((int)(((byte)(189)))));
            this.btnCreate.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(138)))));
            this.btnCreate.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(138)))));
            this.btnCreate.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.Location = new System.Drawing.Point(10, 0);
            this.btnCreate.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Radius = 16;
            this.btnCreate.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.btnCreate.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(203)))), ((int)(((byte)(189)))));
            this.btnCreate.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(138)))));
            this.btnCreate.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(138)))));
            this.btnCreate.Size = new System.Drawing.Size(160, 32);
            this.btnCreate.Style = Sunny.UI.UIStyle.Colorful;
            this.btnCreate.StyleCustomMode = true;
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Tạo đơn hàng mới";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
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
            this.btnBackToMainMenu.Radius = 16;
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
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.Controls.Add(this.panel6);
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
            this.pnlHeader.Size = new System.Drawing.Size(1317, 60);
            this.pnlHeader.Style = Sunny.UI.UIStyle.Custom;
            this.pnlHeader.StyleCustomMode = true;
            this.pnlHeader.TabIndex = 2;
            this.pnlHeader.Text = null;
            this.pnlHeader.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.btnResetFilter);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(464, 14);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.panel6.Size = new System.Drawing.Size(100, 32);
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
            this.btnResetFilter.Radius = 16;
            this.btnResetFilter.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.btnResetFilter.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(203)))), ((int)(((byte)(189)))));
            this.btnResetFilter.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(138)))));
            this.btnResetFilter.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(138)))));
            this.btnResetFilter.Size = new System.Drawing.Size(85, 32);
            this.btnResetFilter.Style = Sunny.UI.UIStyle.Colorful;
            this.btnResetFilter.StyleCustomMode = true;
            this.btnResetFilter.TabIndex = 1;
            this.btnResetFilter.Text = "Đặt lại";
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.cboFilterByStatus);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(294, 14);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.panel7.Size = new System.Drawing.Size(170, 32);
            this.panel7.TabIndex = 9;
            // 
            // cboFilterByStatus
            // 
            this.cboFilterByStatus.DataSource = null;
            this.cboFilterByStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboFilterByStatus.FillColor = System.Drawing.Color.White;
            this.cboFilterByStatus.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboFilterByStatus.Location = new System.Drawing.Point(0, 0);
            this.cboFilterByStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboFilterByStatus.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboFilterByStatus.Name = "cboFilterByStatus";
            this.cboFilterByStatus.Padding = new System.Windows.Forms.Padding(5, 0, 30, 2);
            this.cboFilterByStatus.Radius = 16;
            this.cboFilterByStatus.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.cboFilterByStatus.Size = new System.Drawing.Size(155, 32);
            this.cboFilterByStatus.Style = Sunny.UI.UIStyle.Black;
            this.cboFilterByStatus.StyleCustomMode = true;
            this.cboFilterByStatus.TabIndex = 1;
            this.cboFilterByStatus.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboFilterByStatus.Watermark = "Trạng thái đơn";
            this.cboFilterByStatus.TextChanged += new System.EventHandler(this.cboFilterByStatus_TextChanged);
            this.cboFilterByStatus.SelectedIndexChanged += new System.EventHandler(this.cboFilterByStatus_SelectedIndexChanged);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.Controls.Add(this.cboFilterByTime);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(124, 14);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.panel9.Size = new System.Drawing.Size(170, 32);
            this.panel9.TabIndex = 8;
            // 
            // cboFilterByTime
            // 
            this.cboFilterByTime.DataSource = null;
            this.cboFilterByTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboFilterByTime.FillColor = System.Drawing.Color.White;
            this.cboFilterByTime.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboFilterByTime.Items.AddRange(new object[] {
            "Mới nhất",
            "Cũ nhất",
            "Hôm nay",
            "Tuần này",
            "Tháng này",
            "Năm nay"});
            this.cboFilterByTime.Location = new System.Drawing.Point(0, 0);
            this.cboFilterByTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboFilterByTime.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboFilterByTime.Name = "cboFilterByTime";
            this.cboFilterByTime.Padding = new System.Windows.Forms.Padding(5, 0, 30, 2);
            this.cboFilterByTime.Radius = 16;
            this.cboFilterByTime.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.cboFilterByTime.Size = new System.Drawing.Size(155, 32);
            this.cboFilterByTime.Style = Sunny.UI.UIStyle.Black;
            this.cboFilterByTime.StyleCustomMode = true;
            this.cboFilterByTime.TabIndex = 1;
            this.cboFilterByTime.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboFilterByTime.Watermark = "Thời gian";
            this.cboFilterByTime.TextChanged += new System.EventHandler(this.cboFilterByTime_TextChanged);
            this.cboFilterByTime.SelectedIndexChanged += new System.EventHandler(this.cboFilterByTime_SelectedIndexChanged);
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
            // colOrderId
            // 
            this.colOrderId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colOrderId.DataPropertyName = "OrderId";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colOrderId.DefaultCellStyle = dataGridViewCellStyle3;
            this.colOrderId.HeaderText = "Mã đơn hàng";
            this.colOrderId.MinimumWidth = 120;
            this.colOrderId.Name = "colOrderId";
            this.colOrderId.ReadOnly = true;
            this.colOrderId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colOrderId.ToolTipText = "Mã đơn hàng được tạo tự động";
            this.colOrderId.Width = 120;
            // 
            // colOrderTimeStamp
            // 
            this.colOrderTimeStamp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOrderTimeStamp.DataPropertyName = "OrderTimeStamp";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colOrderTimeStamp.DefaultCellStyle = dataGridViewCellStyle4;
            this.colOrderTimeStamp.FillWeight = 20F;
            this.colOrderTimeStamp.HeaderText = "Thời gian";
            this.colOrderTimeStamp.MinimumWidth = 160;
            this.colOrderTimeStamp.Name = "colOrderTimeStamp";
            this.colOrderTimeStamp.ReadOnly = true;
            this.colOrderTimeStamp.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colOrderTimeStamp.ToolTipText = "Thời gian tạo đơn hàng và lưu vào hệ thống";
            // 
            // colCustomerId
            // 
            this.colCustomerId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCustomerId.DataPropertyName = "CustomerId";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colCustomerId.DefaultCellStyle = dataGridViewCellStyle5;
            this.colCustomerId.HeaderText = "Mã khách hàng";
            this.colCustomerId.MinimumWidth = 120;
            this.colCustomerId.Name = "colCustomerId";
            this.colCustomerId.ReadOnly = true;
            this.colCustomerId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCustomerId.Width = 120;
            // 
            // colCustomerName
            // 
            this.colCustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCustomerName.DataPropertyName = "CustomerName";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colCustomerName.DefaultCellStyle = dataGridViewCellStyle6;
            this.colCustomerName.FillWeight = 20F;
            this.colCustomerName.HeaderText = "Khách hàng";
            this.colCustomerName.MinimumWidth = 150;
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.ReadOnly = true;
            this.colCustomerName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCustomerName.ToolTipText = "Thông tin của khách hàng";
            // 
            // colEmployeeId
            // 
            this.colEmployeeId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colEmployeeId.DataPropertyName = "EmployeeId";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colEmployeeId.DefaultCellStyle = dataGridViewCellStyle7;
            this.colEmployeeId.HeaderText = "Mã nhân viên";
            this.colEmployeeId.MinimumWidth = 120;
            this.colEmployeeId.Name = "colEmployeeId";
            this.colEmployeeId.ReadOnly = true;
            this.colEmployeeId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colEmployeeId.Width = 120;
            // 
            // colEmployeeName
            // 
            this.colEmployeeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEmployeeName.DataPropertyName = "EmployeeName";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colEmployeeName.DefaultCellStyle = dataGridViewCellStyle8;
            this.colEmployeeName.FillWeight = 20F;
            this.colEmployeeName.HeaderText = "Nhân viên";
            this.colEmployeeName.MinimumWidth = 150;
            this.colEmployeeName.Name = "colEmployeeName";
            this.colEmployeeName.ReadOnly = true;
            this.colEmployeeName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colEmployeeName.ToolTipText = "Tên nhân viên tạo đơn";
            // 
            // colOrderStatus
            // 
            this.colOrderStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOrderStatus.DataPropertyName = "StatusName";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colOrderStatus.DefaultCellStyle = dataGridViewCellStyle9;
            this.colOrderStatus.FillWeight = 20F;
            this.colOrderStatus.HeaderText = "Trạng thái";
            this.colOrderStatus.MinimumWidth = 120;
            this.colOrderStatus.Name = "colOrderStatus";
            this.colOrderStatus.ReadOnly = true;
            this.colOrderStatus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colOrderStatus.ToolTipText = "Trạng thái xử lý đơn hàng trong hệ thống";
            // 
            // colOrderDescription
            // 
            this.colOrderDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOrderDescription.DataPropertyName = "OrderDescription";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colOrderDescription.DefaultCellStyle = dataGridViewCellStyle10;
            this.colOrderDescription.HeaderText = "Ghi chú";
            this.colOrderDescription.MinimumWidth = 160;
            this.colOrderDescription.Name = "colOrderDescription";
            this.colOrderDescription.ReadOnly = true;
            this.colOrderDescription.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colOrderDescription.ToolTipText = "Thích ghi gì thì ghi";
            // 
            // FormOrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1317, 609);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(744, 609);
            this.Name = "FormOrderManagement";
            this.Text = "FormOrder";
            this.pnlContainer.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.pnlTool.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.pnlAdvanceSearch.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private Sunny.UI.UIPanel pnlHeader;
        private System.Windows.Forms.Panel panel7;
        private Sunny.UI.UIComboBox cboFilterByStatus;
        private System.Windows.Forms.Panel panel9;
        private Sunny.UI.UIComboBox cboFilterByTime;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lblOrderBy;
        private Sunny.UI.UIPanel pnlFooter;
        private System.Windows.Forms.Panel panel16;
        private Sunny.UI.UIButton btnRemove;
        private System.Windows.Forms.Panel panel15;
        private Sunny.UI.UIButton btnModify;
        private System.Windows.Forms.Panel panel17;
        private Sunny.UI.UIButton btnCreate;
        private System.Windows.Forms.Panel panel5;
        private Sunny.UI.UIButton btnBackToMainMenu;
        private Sunny.UI.UIPanel pnlRight;
        private System.Windows.Forms.Panel pnlTool;
        private System.Windows.Forms.Panel panel13;
        private Sunny.UI.UITitlePanel pnlAdvanceSearch;
        private System.Windows.Forms.Panel panel11;
        private Sunny.UI.UIDatePicker dtpFilterByPickTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Sunny.UI.UITextBox txtSearchByName;
        private Sunny.UI.UIAvatar uiAvatar1;
        private Sunny.UI.UIComboBox cboFilterByName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel12;
        private Sunny.UI.UITextBox txtSearchById;
        private Sunny.UI.UIAvatar btnSearchById;
        private Sunny.UI.UIComboBox cboFilterById;
        private System.Windows.Forms.Button btnToggleTool;
        private Sunny.UI.UIPanel pnlLeft;
        private Sunny.UI.UIDataGridView dgvOrder;
        private System.Windows.Forms.Panel panel6;
        private Sunny.UI.UIButton btnResetFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderTimeStamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderDescription;
    }
}