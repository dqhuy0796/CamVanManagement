
namespace WinFormsAppStoreManagement.UserInterface.Modals
{
    partial class FormCustomer
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
            this.pnlAddress = new System.Windows.Forms.Panel();
            this.txtAddress = new Sunny.UI.UITextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.pnlBirth = new System.Windows.Forms.Panel();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.lblBirth = new System.Windows.Forms.Label();
            this.pnlCIC = new System.Windows.Forms.Panel();
            this.txtCIC = new Sunny.UI.UITextBox();
            this.lblCIC = new System.Windows.Forms.Label();
            this.pnlTel = new System.Windows.Forms.Panel();
            this.txtTel = new Sunny.UI.UITextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.pnlGender = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoOther = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPoint = new System.Windows.Forms.Label();
            this.txtPoint = new Sunny.UI.UITextBox();
            this.txtLevel = new Sunny.UI.UITextBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.pnlName = new System.Windows.Forms.Panel();
            this.txtName = new Sunny.UI.UITextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlId = new System.Windows.Forms.Panel();
            this.txtId = new Sunny.UI.UITextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlRemoveButton.SuspendLayout();
            this.pnlModifyButton.SuspendLayout();
            this.pnlSaveAndQuitButton.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.pnlDescription.SuspendLayout();
            this.pnlAddress.SuspendLayout();
            this.pnlBirth.SuspendLayout();
            this.pnlCIC.SuspendLayout();
            this.pnlTel.SuspendLayout();
            this.pnlGender.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlName.SuspendLayout();
            this.pnlId.SuspendLayout();
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
            this.pnlHeader.TabIndex = 1;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(154, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
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
            this.lblTitle.Text = "Thông tin khách hàng";
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
            this.pnlFooter.TabIndex = 2;
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
            this.pnlRemoveButton.TabIndex = 16;
            this.pnlRemoveButton.Visible = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Left;
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
            this.btnRemove.TabIndex = 15;
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
            this.pnlModifyButton.TabIndex = 15;
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
            this.pnlContainer.Controls.Add(this.pnlAddress);
            this.pnlContainer.Controls.Add(this.pnlBirth);
            this.pnlContainer.Controls.Add(this.pnlCIC);
            this.pnlContainer.Controls.Add(this.pnlTel);
            this.pnlContainer.Controls.Add(this.pnlGender);
            this.pnlContainer.Controls.Add(this.panel1);
            this.pnlContainer.Controls.Add(this.pnlName);
            this.pnlContainer.Controls.Add(this.pnlId);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlContainer.Location = new System.Drawing.Point(1, 73);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Padding = new System.Windows.Forms.Padding(40, 10, 40, 10);
            this.pnlContainer.Size = new System.Drawing.Size(638, 494);
            this.pnlContainer.TabIndex = 4;
            // 
            // pnlDescription
            // 
            this.pnlDescription.BackColor = System.Drawing.Color.Transparent;
            this.pnlDescription.Controls.Add(this.txtDescription);
            this.pnlDescription.Controls.Add(this.lblDescription);
            this.pnlDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDescription.Location = new System.Drawing.Point(40, 386);
            this.pnlDescription.Name = "pnlDescription";
            this.pnlDescription.Padding = new System.Windows.Forms.Padding(10);
            this.pnlDescription.Size = new System.Drawing.Size(558, 98);
            this.pnlDescription.TabIndex = 18;
            // 
            // txtDescription
            // 
            this.txtDescription.ButtonSymbol = 61761;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.FillColor = System.Drawing.Color.White;
            this.txtDescription.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescription.Location = new System.Drawing.Point(125, 10);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescription.Maximum = 2147483647D;
            this.txtDescription.Minimum = -2147483648D;
            this.txtDescription.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Radius = 8;
            this.txtDescription.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.txtDescription.Size = new System.Drawing.Size(423, 78);
            this.txtDescription.Style = Sunny.UI.UIStyle.Colorful;
            this.txtDescription.StyleCustomMode = true;
            this.txtDescription.TabIndex = 1;
            this.txtDescription.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDescription.Watermark = "";
            // 
            // lblDescription
            // 
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDescription.Location = new System.Drawing.Point(10, 10);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(115, 78);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Ghi chú";
            // 
            // pnlAddress
            // 
            this.pnlAddress.BackColor = System.Drawing.Color.Transparent;
            this.pnlAddress.Controls.Add(this.txtAddress);
            this.pnlAddress.Controls.Add(this.lblAddress);
            this.pnlAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAddress.Location = new System.Drawing.Point(40, 339);
            this.pnlAddress.Name = "pnlAddress";
            this.pnlAddress.Padding = new System.Windows.Forms.Padding(10);
            this.pnlAddress.Size = new System.Drawing.Size(558, 47);
            this.pnlAddress.TabIndex = 17;
            // 
            // txtAddress
            // 
            this.txtAddress.ButtonSymbol = 61761;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddress.FillColor = System.Drawing.Color.White;
            this.txtAddress.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddress.Location = new System.Drawing.Point(125, 10);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Maximum = 2147483647D;
            this.txtAddress.Minimum = -2147483648D;
            this.txtAddress.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Radius = 8;
            this.txtAddress.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.txtAddress.Size = new System.Drawing.Size(423, 27);
            this.txtAddress.Style = Sunny.UI.UIStyle.Colorful;
            this.txtAddress.StyleCustomMode = true;
            this.txtAddress.TabIndex = 1;
            this.txtAddress.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtAddress.Watermark = "Địa chỉ";
            // 
            // lblAddress
            // 
            this.lblAddress.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblAddress.Location = new System.Drawing.Point(10, 10);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(115, 27);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Địa chỉ";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBirth
            // 
            this.pnlBirth.BackColor = System.Drawing.Color.Transparent;
            this.pnlBirth.Controls.Add(this.dtpBirth);
            this.pnlBirth.Controls.Add(this.lblBirth);
            this.pnlBirth.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBirth.Location = new System.Drawing.Point(40, 292);
            this.pnlBirth.Name = "pnlBirth";
            this.pnlBirth.Padding = new System.Windows.Forms.Padding(10);
            this.pnlBirth.Size = new System.Drawing.Size(558, 47);
            this.pnlBirth.TabIndex = 16;
            // 
            // dtpBirth
            // 
            this.dtpBirth.CalendarMonthBackground = System.Drawing.Color.DarkRed;
            this.dtpBirth.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.dtpBirth.CalendarTrailingForeColor = System.Drawing.Color.Orange;
            this.dtpBirth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpBirth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirth.Location = new System.Drawing.Point(125, 10);
            this.dtpBirth.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpBirth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(423, 27);
            this.dtpBirth.TabIndex = 1;
            // 
            // lblBirth
            // 
            this.lblBirth.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblBirth.Location = new System.Drawing.Point(10, 10);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(115, 27);
            this.lblBirth.TabIndex = 0;
            this.lblBirth.Text = "Ngày sinh";
            this.lblBirth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlCIC
            // 
            this.pnlCIC.BackColor = System.Drawing.Color.Transparent;
            this.pnlCIC.Controls.Add(this.txtCIC);
            this.pnlCIC.Controls.Add(this.lblCIC);
            this.pnlCIC.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCIC.Location = new System.Drawing.Point(40, 245);
            this.pnlCIC.Name = "pnlCIC";
            this.pnlCIC.Padding = new System.Windows.Forms.Padding(10);
            this.pnlCIC.Size = new System.Drawing.Size(558, 47);
            this.pnlCIC.TabIndex = 15;
            // 
            // txtCIC
            // 
            this.txtCIC.ButtonSymbol = 61761;
            this.txtCIC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCIC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCIC.FillColor = System.Drawing.Color.White;
            this.txtCIC.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCIC.Location = new System.Drawing.Point(125, 10);
            this.txtCIC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCIC.Maximum = 2147483647D;
            this.txtCIC.Minimum = -2147483648D;
            this.txtCIC.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCIC.Name = "txtCIC";
            this.txtCIC.Radius = 8;
            this.txtCIC.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.txtCIC.Size = new System.Drawing.Size(423, 27);
            this.txtCIC.Style = Sunny.UI.UIStyle.Colorful;
            this.txtCIC.StyleCustomMode = true;
            this.txtCIC.TabIndex = 1;
            this.txtCIC.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtCIC.Watermark = "Chứng minh nhân dân/Căn cước công dân";
            // 
            // lblCIC
            // 
            this.lblCIC.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCIC.Location = new System.Drawing.Point(10, 10);
            this.lblCIC.Name = "lblCIC";
            this.lblCIC.Size = new System.Drawing.Size(115, 27);
            this.lblCIC.TabIndex = 0;
            this.lblCIC.Text = "CMND/CCCD";
            this.lblCIC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTel
            // 
            this.pnlTel.BackColor = System.Drawing.Color.Transparent;
            this.pnlTel.Controls.Add(this.txtTel);
            this.pnlTel.Controls.Add(this.lblTel);
            this.pnlTel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTel.Location = new System.Drawing.Point(40, 198);
            this.pnlTel.Name = "pnlTel";
            this.pnlTel.Padding = new System.Windows.Forms.Padding(10);
            this.pnlTel.Size = new System.Drawing.Size(558, 47);
            this.pnlTel.TabIndex = 14;
            // 
            // txtTel
            // 
            this.txtTel.ButtonSymbol = 61761;
            this.txtTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTel.FillColor = System.Drawing.Color.White;
            this.txtTel.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTel.Location = new System.Drawing.Point(125, 10);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTel.Maximum = 2147483647D;
            this.txtTel.Minimum = -2147483648D;
            this.txtTel.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtTel.Name = "txtTel";
            this.txtTel.Radius = 8;
            this.txtTel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.txtTel.Size = new System.Drawing.Size(423, 27);
            this.txtTel.Style = Sunny.UI.UIStyle.Colorful;
            this.txtTel.StyleCustomMode = true;
            this.txtTel.TabIndex = 1;
            this.txtTel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTel.Watermark = "Số điện thoại";
            // 
            // lblTel
            // 
            this.lblTel.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTel.Location = new System.Drawing.Point(10, 10);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(115, 27);
            this.lblTel.TabIndex = 0;
            this.lblTel.Text = "Số điện thoại";
            this.lblTel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlGender
            // 
            this.pnlGender.BackColor = System.Drawing.Color.Transparent;
            this.pnlGender.Controls.Add(this.tableLayoutPanel1);
            this.pnlGender.Controls.Add(this.lblGender);
            this.pnlGender.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGender.Location = new System.Drawing.Point(40, 151);
            this.pnlGender.Name = "pnlGender";
            this.pnlGender.Padding = new System.Windows.Forms.Padding(10);
            this.pnlGender.Size = new System.Drawing.Size(558, 47);
            this.pnlGender.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.rdoFemale, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rdoOther, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.rdoMale, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(125, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(423, 27);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(144, 3);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(46, 21);
            this.rdoFemale.TabIndex = 4;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Nữ";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoOther
            // 
            this.rdoOther.AutoSize = true;
            this.rdoOther.Location = new System.Drawing.Point(285, 3);
            this.rdoOther.Name = "rdoOther";
            this.rdoOther.Size = new System.Drawing.Size(59, 21);
            this.rdoOther.TabIndex = 1;
            this.rdoOther.TabStop = true;
            this.rdoOther.Text = "Khác";
            this.rdoOther.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(3, 3);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(57, 21);
            this.rdoMale.TabIndex = 0;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Nam";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblGender.Location = new System.Drawing.Point(10, 10);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(115, 27);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "Giới tính";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblPoint);
            this.panel1.Controls.Add(this.txtPoint);
            this.panel1.Controls.Add(this.txtLevel);
            this.panel1.Controls.Add(this.lblLevel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(40, 104);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(558, 47);
            this.panel1.TabIndex = 12;
            // 
            // lblPoint
            // 
            this.lblPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPoint.Location = new System.Drawing.Point(245, 10);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(183, 27);
            this.lblPoint.TabIndex = 4;
            this.lblPoint.Text = "Điểm";
            this.lblPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPoint
            // 
            this.txtPoint.ButtonSymbol = 61761;
            this.txtPoint.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPoint.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtPoint.FillColor = System.Drawing.Color.White;
            this.txtPoint.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPoint.Location = new System.Drawing.Point(428, 10);
            this.txtPoint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPoint.Maximum = 2147483647D;
            this.txtPoint.Minimum = -2147483648D;
            this.txtPoint.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Radius = 8;
            this.txtPoint.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.txtPoint.Size = new System.Drawing.Size(120, 27);
            this.txtPoint.Style = Sunny.UI.UIStyle.Colorful;
            this.txtPoint.StyleCustomMode = true;
            this.txtPoint.TabIndex = 3;
            this.txtPoint.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPoint.Watermark = "Điểm tiêu dùng";
            this.txtPoint.TextChanged += new System.EventHandler(this.txtPoint_TextChanged);
            // 
            // txtLevel
            // 
            this.txtLevel.ButtonSymbol = 61761;
            this.txtLevel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLevel.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtLevel.FillColor = System.Drawing.Color.White;
            this.txtLevel.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLevel.Location = new System.Drawing.Point(125, 10);
            this.txtLevel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLevel.Maximum = 2147483647D;
            this.txtLevel.Minimum = -2147483648D;
            this.txtLevel.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Radius = 8;
            this.txtLevel.ReadOnly = true;
            this.txtLevel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.txtLevel.Size = new System.Drawing.Size(120, 27);
            this.txtLevel.Style = Sunny.UI.UIStyle.Colorful;
            this.txtLevel.StyleCustomMode = true;
            this.txtLevel.TabIndex = 1;
            this.txtLevel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtLevel.Watermark = "Cấp thành viên";
            // 
            // lblLevel
            // 
            this.lblLevel.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLevel.Location = new System.Drawing.Point(10, 10);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(115, 27);
            this.lblLevel.TabIndex = 0;
            this.lblLevel.Text = "Cấp bậc";
            this.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlName
            // 
            this.pnlName.BackColor = System.Drawing.Color.Transparent;
            this.pnlName.Controls.Add(this.txtName);
            this.pnlName.Controls.Add(this.lblName);
            this.pnlName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlName.Location = new System.Drawing.Point(40, 57);
            this.pnlName.Name = "pnlName";
            this.pnlName.Padding = new System.Windows.Forms.Padding(10);
            this.pnlName.Size = new System.Drawing.Size(558, 47);
            this.pnlName.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.ButtonSymbol = 61761;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.FillColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(125, 10);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Maximum = 2147483647D;
            this.txtName.Minimum = -2147483648D;
            this.txtName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtName.Name = "txtName";
            this.txtName.Radius = 8;
            this.txtName.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.txtName.Size = new System.Drawing.Size(423, 27);
            this.txtName.Style = Sunny.UI.UIStyle.Colorful;
            this.txtName.StyleCustomMode = true;
            this.txtName.TabIndex = 1;
            this.txtName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtName.Watermark = "Tên khách hàng";
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblName.Location = new System.Drawing.Point(10, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(115, 27);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Tên khách hàng";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlId
            // 
            this.pnlId.BackColor = System.Drawing.Color.Transparent;
            this.pnlId.Controls.Add(this.txtId);
            this.pnlId.Controls.Add(this.lblId);
            this.pnlId.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlId.Location = new System.Drawing.Point(40, 10);
            this.pnlId.Name = "pnlId";
            this.pnlId.Padding = new System.Windows.Forms.Padding(10);
            this.pnlId.Size = new System.Drawing.Size(558, 47);
            this.pnlId.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.ButtonSymbol = 61761;
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtId.FillColor = System.Drawing.Color.White;
            this.txtId.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtId.Location = new System.Drawing.Point(125, 10);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtId.Maximum = 2147483647D;
            this.txtId.Minimum = -2147483648D;
            this.txtId.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtId.Name = "txtId";
            this.txtId.Radius = 8;
            this.txtId.ReadOnly = true;
            this.txtId.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.txtId.Size = new System.Drawing.Size(423, 27);
            this.txtId.Style = Sunny.UI.UIStyle.Colorful;
            this.txtId.StyleCustomMode = true;
            this.txtId.TabIndex = 1;
            this.txtId.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtId.Watermark = "Mã khách hàng tự động";
            // 
            // lblId
            // 
            this.lblId.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblId.Location = new System.Drawing.Point(10, 10);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(115, 27);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Mã khách hàng";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(640, 640);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCustomer";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormCustomer";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlRemoveButton.ResumeLayout(false);
            this.pnlModifyButton.ResumeLayout(false);
            this.pnlSaveAndQuitButton.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            this.pnlDescription.ResumeLayout(false);
            this.pnlAddress.ResumeLayout(false);
            this.pnlBirth.ResumeLayout(false);
            this.pnlCIC.ResumeLayout(false);
            this.pnlTel.ResumeLayout(false);
            this.pnlGender.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlName.ResumeLayout(false);
            this.pnlId.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnlName;
        private Sunny.UI.UITextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlId;
        private Sunny.UI.UITextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Panel pnlRemoveButton;
        private Sunny.UI.UIButton btnRemove;
        private System.Windows.Forms.Panel pnlModifyButton;
        private Sunny.UI.UIButton btnModify;
        private System.Windows.Forms.Panel pnlDescription;
        private Sunny.UI.UITextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel pnlAddress;
        private Sunny.UI.UITextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Panel pnlBirth;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.Panel pnlCIC;
        private Sunny.UI.UITextBox txtCIC;
        private System.Windows.Forms.Label lblCIC;
        private System.Windows.Forms.Panel pnlTel;
        private Sunny.UI.UITextBox txtTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Panel pnlGender;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoOther;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPoint;
        private Sunny.UI.UITextBox txtPoint;
        private Sunny.UI.UITextBox txtLevel;
        private System.Windows.Forms.Label lblLevel;
    }
}