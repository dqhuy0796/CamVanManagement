
namespace WinFormsAppStoreManagement.UserInterface.Modals
{
    partial class FormProduct
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlRemoveButton = new System.Windows.Forms.Panel();
            this.btnRemove = new Sunny.UI.UIButton();
            this.pnlModifyButton = new System.Windows.Forms.Panel();
            this.btnModify = new Sunny.UI.UIButton();
            this.btnCancel = new Sunny.UI.UIButton();
            this.pnlSaveAndQuitButton = new System.Windows.Forms.Panel();
            this.btnSaveAndQuit = new Sunny.UI.UIButton();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlDescription = new System.Windows.Forms.Panel();
            this.txtDescription = new Sunny.UI.UITextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtQuantity = new Sunny.UI.UITextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.pnlAddress = new System.Windows.Forms.Panel();
            this.txtPrice = new Sunny.UI.UITextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.pnlCIC = new System.Windows.Forms.Panel();
            this.txtUnit = new Sunny.UI.UITextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.pnlTel = new System.Windows.Forms.Panel();
            this.cboCategory = new Sunny.UI.UIComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAddCategory = new Sunny.UI.UIButton();
            this.lblCategory = new System.Windows.Forms.Label();
            this.pnlName = new System.Windows.Forms.Panel();
            this.txtName = new Sunny.UI.UITextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlId = new System.Windows.Forms.Panel();
            this.txtId = new Sunny.UI.UITextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUploadPicture = new Sunny.UI.UIButton();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.pnlHeader.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlRemoveButton.SuspendLayout();
            this.pnlModifyButton.SuspendLayout();
            this.pnlSaveAndQuitButton.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.pnlDescription.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlAddress.SuspendLayout();
            this.pnlCIC.SuspendLayout();
            this.pnlTel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnlName.SuspendLayout();
            this.pnlId.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Controls.Add(this.btnQuit);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(1, 1);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(20);
            this.pnlHeader.Size = new System.Drawing.Size(638, 72);
            this.pnlHeader.TabIndex = 2;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(174, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnQuit.BackgroundImage = global::WinFormsAppStoreManagement.Properties.Resources.black_exit_32;
            this.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnQuit.Location = new System.Drawing.Point(586, 20);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(32, 32);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("Roboto Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(246, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thông tin mặt hàng";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.Controls.Add(this.pnlRemoveButton);
            this.pnlFooter.Controls.Add(this.pnlModifyButton);
            this.pnlFooter.Controls.Add(this.btnCancel);
            this.pnlFooter.Controls.Add(this.pnlSaveAndQuitButton);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(1, 567);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(20);
            this.pnlFooter.Size = new System.Drawing.Size(638, 72);
            this.pnlFooter.TabIndex = 3;
            // 
            // pnlRemoveButton
            // 
            this.pnlRemoveButton.BackColor = System.Drawing.Color.Transparent;
            this.pnlRemoveButton.Controls.Add(this.btnRemove);
            this.pnlRemoveButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRemoveButton.Location = new System.Drawing.Point(258, 20);
            this.pnlRemoveButton.Name = "pnlRemoveButton";
            this.pnlRemoveButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.pnlRemoveButton.Size = new System.Drawing.Size(120, 32);
            this.pnlRemoveButton.TabIndex = 18;
            this.pnlRemoveButton.Visible = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnRemove.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.btnRemove.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btnRemove.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btnRemove.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.Location = new System.Drawing.Point(20, 0);
            this.btnRemove.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Radius = 16;
            this.btnRemove.RectColor = System.Drawing.Color.White;
            this.btnRemove.RectDisableColor = System.Drawing.Color.White;
            this.btnRemove.RectHoverColor = System.Drawing.Color.White;
            this.btnRemove.RectPressColor = System.Drawing.Color.White;
            this.btnRemove.RectSelectedColor = System.Drawing.Color.White;
            this.btnRemove.Size = new System.Drawing.Size(100, 32);
            this.btnRemove.Style = Sunny.UI.UIStyle.Custom;
            this.btnRemove.StyleCustomMode = true;
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "Xoá";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // pnlModifyButton
            // 
            this.pnlModifyButton.BackColor = System.Drawing.Color.Transparent;
            this.pnlModifyButton.Controls.Add(this.btnModify);
            this.pnlModifyButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlModifyButton.Location = new System.Drawing.Point(378, 20);
            this.pnlModifyButton.Name = "pnlModifyButton";
            this.pnlModifyButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.pnlModifyButton.Size = new System.Drawing.Size(120, 32);
            this.pnlModifyButton.TabIndex = 16;
            this.pnlModifyButton.Visible = false;
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.Transparent;
            this.btnModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModify.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.btnModify.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(203)))), ((int)(((byte)(189)))));
            this.btnModify.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(138)))));
            this.btnModify.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(138)))));
            this.btnModify.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModify.Location = new System.Drawing.Point(20, 0);
            this.btnModify.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnModify.Name = "btnModify";
            this.btnModify.Radius = 16;
            this.btnModify.RectColor = System.Drawing.Color.White;
            this.btnModify.RectDisableColor = System.Drawing.Color.White;
            this.btnModify.RectHoverColor = System.Drawing.Color.White;
            this.btnModify.RectPressColor = System.Drawing.Color.White;
            this.btnModify.RectSelectedColor = System.Drawing.Color.White;
            this.btnModify.Size = new System.Drawing.Size(100, 32);
            this.btnModify.Style = Sunny.UI.UIStyle.Custom;
            this.btnModify.StyleCustomMode = true;
            this.btnModify.TabIndex = 1;
            this.btnModify.Text = "Cập nhật";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCancel.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.btnCancel.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btnCancel.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btnCancel.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(20, 20);
            this.btnCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Radius = 16;
            this.btnCancel.RectColor = System.Drawing.Color.White;
            this.btnCancel.RectDisableColor = System.Drawing.Color.White;
            this.btnCancel.RectHoverColor = System.Drawing.Color.White;
            this.btnCancel.RectPressColor = System.Drawing.Color.White;
            this.btnCancel.RectSelectedColor = System.Drawing.Color.White;
            this.btnCancel.Size = new System.Drawing.Size(100, 32);
            this.btnCancel.Style = Sunny.UI.UIStyle.Custom;
            this.btnCancel.StyleCustomMode = true;
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlSaveAndQuitButton
            // 
            this.pnlSaveAndQuitButton.BackColor = System.Drawing.Color.Transparent;
            this.pnlSaveAndQuitButton.Controls.Add(this.btnSaveAndQuit);
            this.pnlSaveAndQuitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSaveAndQuitButton.Location = new System.Drawing.Point(498, 20);
            this.pnlSaveAndQuitButton.Name = "pnlSaveAndQuitButton";
            this.pnlSaveAndQuitButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.pnlSaveAndQuitButton.Size = new System.Drawing.Size(120, 32);
            this.pnlSaveAndQuitButton.TabIndex = 12;
            this.pnlSaveAndQuitButton.Visible = false;
            // 
            // btnSaveAndQuit
            // 
            this.btnSaveAndQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveAndQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveAndQuit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveAndQuit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.btnSaveAndQuit.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(203)))), ((int)(((byte)(189)))));
            this.btnSaveAndQuit.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(138)))));
            this.btnSaveAndQuit.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(138)))));
            this.btnSaveAndQuit.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveAndQuit.Location = new System.Drawing.Point(20, 0);
            this.btnSaveAndQuit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSaveAndQuit.Name = "btnSaveAndQuit";
            this.btnSaveAndQuit.Radius = 16;
            this.btnSaveAndQuit.RectColor = System.Drawing.Color.White;
            this.btnSaveAndQuit.RectDisableColor = System.Drawing.Color.White;
            this.btnSaveAndQuit.RectHoverColor = System.Drawing.Color.White;
            this.btnSaveAndQuit.RectPressColor = System.Drawing.Color.White;
            this.btnSaveAndQuit.RectSelectedColor = System.Drawing.Color.White;
            this.btnSaveAndQuit.Size = new System.Drawing.Size(100, 32);
            this.btnSaveAndQuit.Style = Sunny.UI.UIStyle.Custom;
            this.btnSaveAndQuit.StyleCustomMode = true;
            this.btnSaveAndQuit.TabIndex = 1;
            this.btnSaveAndQuit.Text = "Lưu và Thoát";
            this.btnSaveAndQuit.Click += new System.EventHandler(this.btnSaveAndQuit_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.White;
            this.pnlContainer.Controls.Add(this.pnlDescription);
            this.pnlContainer.Controls.Add(this.panel1);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlContainer.Location = new System.Drawing.Point(1, 73);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.pnlContainer.Size = new System.Drawing.Size(638, 494);
            this.pnlContainer.TabIndex = 5;
            // 
            // pnlDescription
            // 
            this.pnlDescription.BackColor = System.Drawing.Color.Transparent;
            this.pnlDescription.Controls.Add(this.txtDescription);
            this.pnlDescription.Controls.Add(this.lblDescription);
            this.pnlDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDescription.Location = new System.Drawing.Point(15, 302);
            this.pnlDescription.Name = "pnlDescription";
            this.pnlDescription.Padding = new System.Windows.Forms.Padding(5);
            this.pnlDescription.Size = new System.Drawing.Size(608, 182);
            this.pnlDescription.TabIndex = 13;
            // 
            // txtDescription
            // 
            this.txtDescription.ButtonSymbol = 61761;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.FillColor = System.Drawing.Color.White;
            this.txtDescription.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescription.Location = new System.Drawing.Point(5, 32);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescription.Maximum = 2147483647D;
            this.txtDescription.Minimum = -2147483648D;
            this.txtDescription.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Radius = 8;
            this.txtDescription.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.txtDescription.Size = new System.Drawing.Size(598, 145);
            this.txtDescription.Style = Sunny.UI.UIStyle.Colorful;
            this.txtDescription.StyleCustomMode = true;
            this.txtDescription.TabIndex = 1;
            this.txtDescription.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDescription.Watermark = "";
            // 
            // lblDescription
            // 
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDescription.Location = new System.Drawing.Point(5, 5);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(598, 27);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Mô tả";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(15, 10);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(608, 292);
            this.panel1.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.pnlAddress);
            this.panel3.Controls.Add(this.pnlCIC);
            this.panel3.Controls.Add(this.pnlTel);
            this.panel3.Controls.Add(this.pnlName);
            this.panel3.Controls.Add(this.pnlId);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(205, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(398, 282);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.txtQuantity);
            this.panel4.Controls.Add(this.lblQuantity);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 235);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.panel4.Size = new System.Drawing.Size(398, 47);
            this.panel4.TabIndex = 18;
            // 
            // txtQuantity
            // 
            this.txtQuantity.ButtonSymbol = 61761;
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQuantity.FillColor = System.Drawing.Color.White;
            this.txtQuantity.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuantity.Location = new System.Drawing.Point(110, 10);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuantity.Maximum = 2147483647D;
            this.txtQuantity.Minimum = -2147483648D;
            this.txtQuantity.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Radius = 8;
            this.txtQuantity.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.txtQuantity.Size = new System.Drawing.Size(288, 27);
            this.txtQuantity.Style = Sunny.UI.UIStyle.Colorful;
            this.txtQuantity.StyleCustomMode = true;
            this.txtQuantity.TabIndex = 1;
            this.txtQuantity.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtQuantity.Watermark = "Số lượng hàng trong hệ thống bán";
            // 
            // lblQuantity
            // 
            this.lblQuantity.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblQuantity.Location = new System.Drawing.Point(10, 10);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(100, 27);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Số lượng còn";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlAddress
            // 
            this.pnlAddress.BackColor = System.Drawing.Color.Transparent;
            this.pnlAddress.Controls.Add(this.txtPrice);
            this.pnlAddress.Controls.Add(this.lblPrice);
            this.pnlAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAddress.Location = new System.Drawing.Point(0, 188);
            this.pnlAddress.Name = "pnlAddress";
            this.pnlAddress.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.pnlAddress.Size = new System.Drawing.Size(398, 47);
            this.pnlAddress.TabIndex = 17;
            // 
            // txtPrice
            // 
            this.txtPrice.ButtonSymbol = 61761;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrice.FillColor = System.Drawing.Color.White;
            this.txtPrice.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrice.Location = new System.Drawing.Point(110, 10);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrice.Maximum = 2147483647D;
            this.txtPrice.Minimum = -2147483648D;
            this.txtPrice.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Radius = 8;
            this.txtPrice.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.txtPrice.Size = new System.Drawing.Size(288, 27);
            this.txtPrice.Style = Sunny.UI.UIStyle.Colorful;
            this.txtPrice.StyleCustomMode = true;
            this.txtPrice.TabIndex = 1;
            this.txtPrice.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPrice.Watermark = "Đơn giá";
            // 
            // lblPrice
            // 
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPrice.Location = new System.Drawing.Point(10, 10);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(100, 27);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Đơn giá";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlCIC
            // 
            this.pnlCIC.BackColor = System.Drawing.Color.Transparent;
            this.pnlCIC.Controls.Add(this.txtUnit);
            this.pnlCIC.Controls.Add(this.lblUnit);
            this.pnlCIC.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCIC.Location = new System.Drawing.Point(0, 141);
            this.pnlCIC.Name = "pnlCIC";
            this.pnlCIC.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.pnlCIC.Size = new System.Drawing.Size(398, 47);
            this.pnlCIC.TabIndex = 16;
            // 
            // txtUnit
            // 
            this.txtUnit.ButtonSymbol = 61761;
            this.txtUnit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUnit.FillColor = System.Drawing.Color.White;
            this.txtUnit.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUnit.Location = new System.Drawing.Point(110, 10);
            this.txtUnit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUnit.Maximum = 2147483647D;
            this.txtUnit.Minimum = -2147483648D;
            this.txtUnit.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Radius = 8;
            this.txtUnit.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.txtUnit.Size = new System.Drawing.Size(288, 27);
            this.txtUnit.Style = Sunny.UI.UIStyle.Colorful;
            this.txtUnit.StyleCustomMode = true;
            this.txtUnit.TabIndex = 1;
            this.txtUnit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtUnit.Watermark = "Đơn vị tính";
            // 
            // lblUnit
            // 
            this.lblUnit.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblUnit.Location = new System.Drawing.Point(10, 10);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(100, 27);
            this.lblUnit.TabIndex = 0;
            this.lblUnit.Text = "Đơn vị tính";
            this.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTel
            // 
            this.pnlTel.BackColor = System.Drawing.Color.Transparent;
            this.pnlTel.Controls.Add(this.cboCategory);
            this.pnlTel.Controls.Add(this.panel5);
            this.pnlTel.Controls.Add(this.lblCategory);
            this.pnlTel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTel.Location = new System.Drawing.Point(0, 94);
            this.pnlTel.Name = "pnlTel";
            this.pnlTel.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.pnlTel.Size = new System.Drawing.Size(398, 47);
            this.pnlTel.TabIndex = 15;
            // 
            // cboCategory
            // 
            this.cboCategory.DataSource = null;
            this.cboCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboCategory.FillColor = System.Drawing.Color.White;
            this.cboCategory.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboCategory.Location = new System.Drawing.Point(110, 10);
            this.cboCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboCategory.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboCategory.Radius = 8;
            this.cboCategory.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.cboCategory.Size = new System.Drawing.Size(251, 27);
            this.cboCategory.Style = Sunny.UI.UIStyle.Colorful;
            this.cboCategory.StyleCustomMode = true;
            this.cboCategory.TabIndex = 3;
            this.cboCategory.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboCategory.Watermark = "Danh mục";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnAddCategory);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(361, 10);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel5.Size = new System.Drawing.Size(37, 27);
            this.panel5.TabIndex = 1;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddCategory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.btnAddCategory.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(203)))), ((int)(((byte)(189)))));
            this.btnAddCategory.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(138)))));
            this.btnAddCategory.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(138)))));
            this.btnAddCategory.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddCategory.Location = new System.Drawing.Point(10, 0);
            this.btnAddCategory.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.RectColor = System.Drawing.Color.White;
            this.btnAddCategory.RectDisableColor = System.Drawing.Color.White;
            this.btnAddCategory.RectHoverColor = System.Drawing.Color.White;
            this.btnAddCategory.RectPressColor = System.Drawing.Color.White;
            this.btnAddCategory.RectSelectedColor = System.Drawing.Color.White;
            this.btnAddCategory.Size = new System.Drawing.Size(27, 27);
            this.btnAddCategory.Style = Sunny.UI.UIStyle.Custom;
            this.btnAddCategory.StyleCustomMode = true;
            this.btnAddCategory.TabIndex = 0;
            this.btnAddCategory.Text = "+";
            // 
            // lblCategory
            // 
            this.lblCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCategory.Location = new System.Drawing.Point(10, 10);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(100, 27);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Danh mục";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlName
            // 
            this.pnlName.BackColor = System.Drawing.Color.Transparent;
            this.pnlName.Controls.Add(this.txtName);
            this.pnlName.Controls.Add(this.lblName);
            this.pnlName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlName.Location = new System.Drawing.Point(0, 47);
            this.pnlName.Name = "pnlName";
            this.pnlName.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.pnlName.Size = new System.Drawing.Size(398, 47);
            this.pnlName.TabIndex = 14;
            // 
            // txtName
            // 
            this.txtName.ButtonSymbol = 61761;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.FillColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(110, 10);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Maximum = 2147483647D;
            this.txtName.Minimum = -2147483648D;
            this.txtName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtName.Name = "txtName";
            this.txtName.Radius = 8;
            this.txtName.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.txtName.Size = new System.Drawing.Size(288, 27);
            this.txtName.Style = Sunny.UI.UIStyle.Colorful;
            this.txtName.StyleCustomMode = true;
            this.txtName.TabIndex = 1;
            this.txtName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtName.Watermark = "Tên mặt hàng";
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblName.Location = new System.Drawing.Point(10, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 27);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Tên mặt hàng";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlId
            // 
            this.pnlId.BackColor = System.Drawing.Color.Transparent;
            this.pnlId.Controls.Add(this.txtId);
            this.pnlId.Controls.Add(this.lblId);
            this.pnlId.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlId.Location = new System.Drawing.Point(0, 0);
            this.pnlId.Name = "pnlId";
            this.pnlId.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.pnlId.Size = new System.Drawing.Size(398, 47);
            this.pnlId.TabIndex = 13;
            // 
            // txtId
            // 
            this.txtId.ButtonSymbol = 61761;
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtId.FillColor = System.Drawing.Color.White;
            this.txtId.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtId.Location = new System.Drawing.Point(110, 10);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtId.Maximum = 2147483647D;
            this.txtId.Minimum = -2147483648D;
            this.txtId.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtId.Name = "txtId";
            this.txtId.Radius = 8;
            this.txtId.ReadOnly = true;
            this.txtId.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.txtId.Size = new System.Drawing.Size(288, 27);
            this.txtId.Style = Sunny.UI.UIStyle.Colorful;
            this.txtId.StyleCustomMode = true;
            this.txtId.TabIndex = 1;
            this.txtId.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtId.Watermark = "Mã mặt hàng tự động";
            // 
            // lblId
            // 
            this.lblId.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblId.Location = new System.Drawing.Point(10, 10);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(100, 27);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Mã mặt hàng";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnUploadPicture);
            this.panel2.Controls.Add(this.picProduct);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel2.Size = new System.Drawing.Size(200, 282);
            this.panel2.TabIndex = 0;
            // 
            // btnUploadPicture
            // 
            this.btnUploadPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUploadPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadPicture.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.btnUploadPicture.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(203)))), ((int)(((byte)(189)))));
            this.btnUploadPicture.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(138)))));
            this.btnUploadPicture.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(138)))));
            this.btnUploadPicture.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUploadPicture.Location = new System.Drawing.Point(50, 232);
            this.btnUploadPicture.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUploadPicture.Name = "btnUploadPicture";
            this.btnUploadPicture.Radius = 16;
            this.btnUploadPicture.RectColor = System.Drawing.Color.White;
            this.btnUploadPicture.RectDisableColor = System.Drawing.Color.White;
            this.btnUploadPicture.RectHoverColor = System.Drawing.Color.White;
            this.btnUploadPicture.RectPressColor = System.Drawing.Color.White;
            this.btnUploadPicture.RectSelectedColor = System.Drawing.Color.White;
            this.btnUploadPicture.Size = new System.Drawing.Size(100, 32);
            this.btnUploadPicture.Style = Sunny.UI.UIStyle.Custom;
            this.btnUploadPicture.StyleCustomMode = true;
            this.btnUploadPicture.TabIndex = 1;
            this.btnUploadPicture.Text = "Tải ảnh lên";
            this.btnUploadPicture.Click += new System.EventHandler(this.btnUploadPicture_Click);
            // 
            // picProduct
            // 
            this.picProduct.BackColor = System.Drawing.Color.Transparent;
            this.picProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.picProduct.Location = new System.Drawing.Point(0, 10);
            this.picProduct.Name = "picProduct";
            this.picProduct.Padding = new System.Windows.Forms.Padding(1);
            this.picProduct.Size = new System.Drawing.Size(200, 200);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProduct.TabIndex = 0;
            this.picProduct.TabStop = false;
            this.picProduct.WaitOnLoad = true;
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(640, 640);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormProduct";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormProduct";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlRemoveButton.ResumeLayout(false);
            this.pnlModifyButton.ResumeLayout(false);
            this.pnlSaveAndQuitButton.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            this.pnlDescription.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pnlAddress.ResumeLayout(false);
            this.pnlCIC.ResumeLayout(false);
            this.pnlTel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.pnlName.ResumeLayout(false);
            this.pnlId.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlFooter;
        private Sunny.UI.UIButton btnCancel;
        private System.Windows.Forms.Panel pnlSaveAndQuitButton;
        private Sunny.UI.UIButton btnSaveAndQuit;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlDescription;
        private Sunny.UI.UITextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Sunny.UI.UITextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Panel pnlAddress;
        private Sunny.UI.UITextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Panel pnlCIC;
        private Sunny.UI.UITextBox txtUnit;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Panel pnlTel;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Panel pnlName;
        private Sunny.UI.UITextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlId;
        private Sunny.UI.UITextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Panel panel2;
        private Sunny.UI.UIButton btnUploadPicture;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.Panel pnlModifyButton;
        private Sunny.UI.UIButton btnModify;
        private System.Windows.Forms.Panel pnlRemoveButton;
        private Sunny.UI.UIButton btnRemove;
        private Sunny.UI.UIComboBox cboCategory;
        private System.Windows.Forms.Panel panel5;
        private Sunny.UI.UIButton btnAddCategory;
    }
}