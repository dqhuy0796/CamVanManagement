
namespace WinFormsAppStoreManagement.UserInterface.MainForms
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.pnlRight = new Sunny.UI.UIPanel();
            this.pnlAuthentication = new System.Windows.Forms.Panel();
            this.chkShowPassword = new Sunny.UI.UICheckBox();
            this.btnLogin = new Sunny.UI.UIButton();
            this.pnlAuthenticate = new System.Windows.Forms.Panel();
            this.lblIncorrect = new System.Windows.Forms.Label();
            this.txtPassword = new Sunny.UI.UITextBox();
            this.txtUsername = new Sunny.UI.UITextBox();
            this.picPassword = new System.Windows.Forms.PictureBox();
            this.picUsername = new System.Windows.Forms.PictureBox();
            this.pnlLoginHeader = new System.Windows.Forms.Panel();
            this.lblLoginHeader = new Sunny.UI.UILabel();
            this.lblForgotPassword = new Sunny.UI.UILabel();
            this.pnlUserSelect = new System.Windows.Forms.Panel();
            this.uiSwitch1 = new Sunny.UI.UISwitch();
            this.uiComboBox1 = new Sunny.UI.UIComboBox();
            this.btnQuit = new Sunny.UI.UIImageButton();
            this.pnlLeft = new Sunny.UI.UIPanel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlRight.SuspendLayout();
            this.pnlAuthentication.SuspendLayout();
            this.pnlAuthenticate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsername)).BeginInit();
            this.pnlLoginHeader.SuspendLayout();
            this.pnlUserSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnQuit)).BeginInit();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.Transparent;
            this.pnlRight.Controls.Add(this.pnlAuthentication);
            this.pnlRight.Controls.Add(this.pnlAuthenticate);
            this.pnlRight.Controls.Add(this.pnlLoginHeader);
            this.pnlRight.Controls.Add(this.lblForgotPassword);
            this.pnlRight.Controls.Add(this.pnlUserSelect);
            this.pnlRight.Controls.Add(this.btnQuit);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.FillColor = System.Drawing.Color.White;
            this.pnlRight.FillDisableColor = System.Drawing.Color.White;
            this.pnlRight.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlRight.ForeColor = System.Drawing.Color.White;
            this.pnlRight.ForeDisableColor = System.Drawing.Color.White;
            this.pnlRight.Location = new System.Drawing.Point(450, 1);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlRight.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(40, 80, 40, 80);
            this.pnlRight.Radius = 0;
            this.pnlRight.RectColor = System.Drawing.Color.Red;
            this.pnlRight.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pnlRight.Size = new System.Drawing.Size(449, 598);
            this.pnlRight.Style = Sunny.UI.UIStyle.Custom;
            this.pnlRight.StyleCustomMode = true;
            this.pnlRight.TabIndex = 3;
            this.pnlRight.Text = null;
            this.pnlRight.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlRight_MouseDown);
            // 
            // pnlAuthentication
            // 
            this.pnlAuthentication.BackColor = System.Drawing.Color.Transparent;
            this.pnlAuthentication.Controls.Add(this.chkShowPassword);
            this.pnlAuthentication.Controls.Add(this.btnLogin);
            this.pnlAuthentication.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAuthentication.Location = new System.Drawing.Point(40, 404);
            this.pnlAuthentication.Name = "pnlAuthentication";
            this.pnlAuthentication.Padding = new System.Windows.Forms.Padding(10);
            this.pnlAuthentication.Size = new System.Drawing.Size(369, 60);
            this.pnlAuthentication.TabIndex = 15;
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.CheckBoxColor = System.Drawing.Color.Black;
            this.chkShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkShowPassword.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkShowPassword.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkShowPassword.ForeColor = System.Drawing.Color.Black;
            this.chkShowPassword.ImageInterval = 5;
            this.chkShowPassword.Location = new System.Drawing.Point(39, 10);
            this.chkShowPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.chkShowPassword.Size = new System.Drawing.Size(193, 40);
            this.chkShowPassword.Style = Sunny.UI.UIStyle.Custom;
            this.chkShowPassword.StyleCustomMode = true;
            this.chkShowPassword.TabIndex = 5;
            this.chkShowPassword.Text = "Hiện mật khẩu";
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnLogin.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(203)))), ((int)(((byte)(189)))));
            this.btnLogin.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(138)))));
            this.btnLogin.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(138)))));
            this.btnLogin.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(232, 10);
            this.btnLogin.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Radius = 36;
            this.btnLogin.RectColor = System.Drawing.Color.White;
            this.btnLogin.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(203)))), ((int)(((byte)(189)))));
            this.btnLogin.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(138)))));
            this.btnLogin.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(138)))));
            this.btnLogin.Size = new System.Drawing.Size(127, 40);
            this.btnLogin.Style = Sunny.UI.UIStyle.Custom;
            this.btnLogin.StyleCustomMode = true;
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnlAuthenticate
            // 
            this.pnlAuthenticate.BackColor = System.Drawing.Color.Transparent;
            this.pnlAuthenticate.Controls.Add(this.lblIncorrect);
            this.pnlAuthenticate.Controls.Add(this.txtPassword);
            this.pnlAuthenticate.Controls.Add(this.txtUsername);
            this.pnlAuthenticate.Controls.Add(this.picPassword);
            this.pnlAuthenticate.Controls.Add(this.picUsername);
            this.pnlAuthenticate.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAuthenticate.Location = new System.Drawing.Point(40, 274);
            this.pnlAuthenticate.Name = "pnlAuthenticate";
            this.pnlAuthenticate.Size = new System.Drawing.Size(369, 130);
            this.pnlAuthenticate.TabIndex = 14;
            // 
            // lblIncorrect
            // 
            this.lblIncorrect.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblIncorrect.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIncorrect.ForeColor = System.Drawing.Color.Red;
            this.lblIncorrect.Location = new System.Drawing.Point(0, 0);
            this.lblIncorrect.Name = "lblIncorrect";
            this.lblIncorrect.Size = new System.Drawing.Size(369, 20);
            this.lblIncorrect.TabIndex = 10000000;
            this.lblIncorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.ButtonSymbol = 61761;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FillColor = System.Drawing.Color.White;
            this.txtPassword.FillDisableColor = System.Drawing.Color.LightGray;
            this.txtPassword.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(37, 81);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Maximum = 2147483647D;
            this.txtPassword.MaxLength = 1000;
            this.txtPassword.Minimum = -2147483648D;
            this.txtPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Radius = 36;
            this.txtPassword.RectColor = System.Drawing.Color.Black;
            this.txtPassword.Size = new System.Drawing.Size(330, 40);
            this.txtPassword.Style = Sunny.UI.UIStyle.Custom;
            this.txtPassword.StyleCustomMode = true;
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPassword.Watermark = "Mật khẩu";
            this.txtPassword.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txtPassword.DoEnter += new System.EventHandler(this.txtPassword_DoEnter);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.ButtonSymbol = 61761;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.FillColor = System.Drawing.Color.White;
            this.txtUsername.FillDisableColor = System.Drawing.Color.LightGray;
            this.txtUsername.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(37, 31);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.Maximum = 2147483647D;
            this.txtUsername.MaxLength = 1000;
            this.txtUsername.Minimum = -2147483648D;
            this.txtUsername.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.txtUsername.Radius = 36;
            this.txtUsername.RectColor = System.Drawing.Color.Black;
            this.txtUsername.Size = new System.Drawing.Size(330, 40);
            this.txtUsername.Style = Sunny.UI.UIStyle.Custom;
            this.txtUsername.StyleCustomMode = true;
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtUsername.Watermark = "Tên đăng nhập";
            this.txtUsername.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txtUsername.DoEnter += new System.EventHandler(this.txtUsername_DoEnter);
            // 
            // picPassword
            // 
            this.picPassword.Image = global::WinFormsAppStoreManagement.Properties.Resources.black_lock_32;
            this.picPassword.Location = new System.Drawing.Point(0, 81);
            this.picPassword.Name = "picPassword";
            this.picPassword.Size = new System.Drawing.Size(32, 40);
            this.picPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPassword.TabIndex = 2;
            this.picPassword.TabStop = false;
            // 
            // picUsername
            // 
            this.picUsername.Image = global::WinFormsAppStoreManagement.Properties.Resources.black_user_32;
            this.picUsername.Location = new System.Drawing.Point(0, 31);
            this.picUsername.Name = "picUsername";
            this.picUsername.Size = new System.Drawing.Size(32, 40);
            this.picUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUsername.TabIndex = 1;
            this.picUsername.TabStop = false;
            // 
            // pnlLoginHeader
            // 
            this.pnlLoginHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlLoginHeader.Controls.Add(this.lblLoginHeader);
            this.pnlLoginHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLoginHeader.Location = new System.Drawing.Point(40, 124);
            this.pnlLoginHeader.Name = "pnlLoginHeader";
            this.pnlLoginHeader.Padding = new System.Windows.Forms.Padding(20);
            this.pnlLoginHeader.Size = new System.Drawing.Size(369, 150);
            this.pnlLoginHeader.TabIndex = 12;
            // 
            // lblLoginHeader
            // 
            this.lblLoginHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLoginHeader.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLoginHeader.ForeColor = System.Drawing.Color.Black;
            this.lblLoginHeader.Location = new System.Drawing.Point(20, 20);
            this.lblLoginHeader.Name = "lblLoginHeader";
            this.lblLoginHeader.Size = new System.Drawing.Size(329, 110);
            this.lblLoginHeader.Style = Sunny.UI.UIStyle.Custom;
            this.lblLoginHeader.StyleCustomMode = true;
            this.lblLoginHeader.TabIndex = 0;
            this.lblLoginHeader.Text = "Đăng nhập";
            this.lblLoginHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblForgotPassword.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblForgotPassword.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblForgotPassword.ForeColor = System.Drawing.Color.Black;
            this.lblForgotPassword.Location = new System.Drawing.Point(40, 493);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(369, 25);
            this.lblForgotPassword.Style = Sunny.UI.UIStyle.Custom;
            this.lblForgotPassword.StyleCustomMode = true;
            this.lblForgotPassword.TabIndex = 13;
            this.lblForgotPassword.Text = "Quên mật khẩu ?";
            this.lblForgotPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblForgotPassword.Click += new System.EventHandler(this.lblForgotPassword_Click);
            // 
            // pnlUserSelect
            // 
            this.pnlUserSelect.BackColor = System.Drawing.Color.Transparent;
            this.pnlUserSelect.Controls.Add(this.uiSwitch1);
            this.pnlUserSelect.Controls.Add(this.uiComboBox1);
            this.pnlUserSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserSelect.Location = new System.Drawing.Point(40, 80);
            this.pnlUserSelect.Name = "pnlUserSelect";
            this.pnlUserSelect.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.pnlUserSelect.Size = new System.Drawing.Size(369, 44);
            this.pnlUserSelect.TabIndex = 11;
            this.pnlUserSelect.Visible = false;
            // 
            // uiSwitch1
            // 
            this.uiSwitch1.Active = true;
            this.uiSwitch1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.uiSwitch1.ActiveText = "";
            this.uiSwitch1.Dock = System.Windows.Forms.DockStyle.Right;
            this.uiSwitch1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiSwitch1.InActiveText = "";
            this.uiSwitch1.Location = new System.Drawing.Point(316, 10);
            this.uiSwitch1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSwitch1.Name = "uiSwitch1";
            this.uiSwitch1.Size = new System.Drawing.Size(48, 24);
            this.uiSwitch1.Style = Sunny.UI.UIStyle.Colorful;
            this.uiSwitch1.StyleCustomMode = true;
            this.uiSwitch1.TabIndex = 1;
            this.uiSwitch1.Text = "uiSwitch1";
            // 
            // uiComboBox1
            // 
            this.uiComboBox1.DataSource = null;
            this.uiComboBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiComboBox1.DropDownWidth = 100;
            this.uiComboBox1.FillColor = System.Drawing.Color.White;
            this.uiComboBox1.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiComboBox1.ItemHeight = 24;
            this.uiComboBox1.Items.AddRange(new object[] {
            "English",
            "Tiếng Việt"});
            this.uiComboBox1.Location = new System.Drawing.Point(5, 10);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(4, 0, 30, 2);
            this.uiComboBox1.Radius = 16;
            this.uiComboBox1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.uiComboBox1.Size = new System.Drawing.Size(100, 24);
            this.uiComboBox1.Style = Sunny.UI.UIStyle.Gray;
            this.uiComboBox1.StyleCustomMode = true;
            this.uiComboBox1.TabIndex = 0;
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox1.Watermark = "Language";
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuit.ForeColor = System.Drawing.Color.Transparent;
            this.btnQuit.Image = global::WinFormsAppStoreManagement.Properties.Resources.black_exit_32;
            this.btnQuit.Location = new System.Drawing.Point(421, 0);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(28, 28);
            this.btnQuit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnQuit.TabIndex = 10;
            this.btnQuit.TabStop = false;
            this.btnQuit.Text = null;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.Transparent;
            this.pnlLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLeft.BackgroundImage")));
            this.pnlLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLeft.Controls.Add(this.uiLabel2);
            this.pnlLeft.Controls.Add(this.uiLabel1);
            this.pnlLeft.Controls.Add(this.pictureBox1);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pnlLeft.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlLeft.Location = new System.Drawing.Point(1, 1);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlLeft.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(40, 40, 40, 14);
            this.pnlLeft.Radius = 0;
            this.pnlLeft.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.pnlLeft.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pnlLeft.Size = new System.Drawing.Size(449, 598);
            this.pnlLeft.Style = Sunny.UI.UIStyle.Red;
            this.pnlLeft.StyleCustomMode = true;
            this.pnlLeft.TabIndex = 2;
            this.pnlLeft.Text = null;
            this.pnlLeft.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiLabel2.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel2.ForeColor = System.Drawing.Color.White;
            this.uiLabel2.Location = new System.Drawing.Point(40, 548);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(369, 18);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.StyleCustomMode = true;
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "Powered by team BollyWood";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiLabel1.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel1.ForeColor = System.Drawing.Color.White;
            this.uiLabel1.Location = new System.Drawing.Point(40, 566);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(369, 18);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.StyleCustomMode = true;
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "Copyright 2021 ©. All rights reserved";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::WinFormsAppStoreManagement.Properties.Resources.White_Rectanngle_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(40, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.pnlRight.ResumeLayout(false);
            this.pnlAuthentication.ResumeLayout(false);
            this.pnlAuthenticate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsername)).EndInit();
            this.pnlLoginHeader.ResumeLayout(false);
            this.pnlUserSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnQuit)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void TxtPassword_GotFocus(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void TxtUsername_GotFocus(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private Sunny.UI.UIPanel pnlRight;
        private Sunny.UI.UIPanel pnlLeft;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UIImageButton btnQuit;
        private System.Windows.Forms.Panel pnlAuthentication;
        private Sunny.UI.UICheckBox chkShowPassword;
        private Sunny.UI.UIButton btnLogin;
        private System.Windows.Forms.Panel pnlAuthenticate;
        private System.Windows.Forms.Label lblIncorrect;
        private Sunny.UI.UITextBox txtPassword;
        private Sunny.UI.UITextBox txtUsername;
        private System.Windows.Forms.PictureBox picPassword;
        private System.Windows.Forms.PictureBox picUsername;
        private System.Windows.Forms.Panel pnlLoginHeader;
        private Sunny.UI.UILabel lblLoginHeader;
        private Sunny.UI.UILabel lblForgotPassword;
        private System.Windows.Forms.Panel pnlUserSelect;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UISwitch uiSwitch1;
    }
}