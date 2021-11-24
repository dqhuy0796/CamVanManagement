
namespace WinFormsAppStoreManagement.UserInterface.Modals
{
    partial class FormUser
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
            this.components = new System.ComponentModel.Container();
            this.epdInput = new System.Windows.Forms.ErrorProvider(this.components);
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnUploadPicture = new Sunny.UI.UIButton();
            this.picProduct = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.epdInput)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlRemoveButton.SuspendLayout();
            this.pnlModifyButton.SuspendLayout();
            this.pnlSaveAndQuitButton.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // epdInput
            // 
            this.epdInput.ContainerControl = this;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Controls.Add(this.btnQuit);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(5, 5);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(20);
            this.pnlHeader.Size = new System.Drawing.Size(630, 72);
            this.pnlHeader.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(194, 116);
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
            this.btnQuit.Location = new System.Drawing.Point(578, 20);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(32, 32);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.UseVisualStyleBackColor = false;
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
            this.lblTitle.Text = "Thông tin tài khoản";
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
            this.pnlFooter.Location = new System.Drawing.Point(5, 563);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(20);
            this.pnlFooter.Size = new System.Drawing.Size(630, 72);
            this.pnlFooter.TabIndex = 7;
            // 
            // pnlRemoveButton
            // 
            this.pnlRemoveButton.BackColor = System.Drawing.Color.Transparent;
            this.pnlRemoveButton.Controls.Add(this.btnRemove);
            this.pnlRemoveButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRemoveButton.Location = new System.Drawing.Point(250, 20);
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
            // 
            // pnlModifyButton
            // 
            this.pnlModifyButton.BackColor = System.Drawing.Color.Transparent;
            this.pnlModifyButton.Controls.Add(this.btnModify);
            this.pnlModifyButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlModifyButton.Location = new System.Drawing.Point(370, 20);
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
            // 
            // pnlSaveAndQuitButton
            // 
            this.pnlSaveAndQuitButton.BackColor = System.Drawing.Color.Transparent;
            this.pnlSaveAndQuitButton.Controls.Add(this.btnSaveAndQuit);
            this.pnlSaveAndQuitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSaveAndQuitButton.Location = new System.Drawing.Point(490, 20);
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
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.White;
            this.pnlContainer.Controls.Add(this.panel2);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlContainer.Location = new System.Drawing.Point(5, 77);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.pnlContainer.Size = new System.Drawing.Size(630, 486);
            this.pnlContainer.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picProduct);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(15, 10);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(200, 10, 200, 10);
            this.panel2.Size = new System.Drawing.Size(600, 272);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnUploadPicture);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(200, 210);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(200, 52);
            this.panel4.TabIndex = 3;
            // 
            // btnUploadPicture
            // 
            this.btnUploadPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUploadPicture.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.btnUploadPicture.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(203)))), ((int)(((byte)(189)))));
            this.btnUploadPicture.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(138)))));
            this.btnUploadPicture.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(138)))));
            this.btnUploadPicture.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUploadPicture.Location = new System.Drawing.Point(10, 10);
            this.btnUploadPicture.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUploadPicture.Name = "btnUploadPicture";
            this.btnUploadPicture.Radius = 16;
            this.btnUploadPicture.RectColor = System.Drawing.Color.White;
            this.btnUploadPicture.RectDisableColor = System.Drawing.Color.White;
            this.btnUploadPicture.RectHoverColor = System.Drawing.Color.White;
            this.btnUploadPicture.RectPressColor = System.Drawing.Color.White;
            this.btnUploadPicture.RectSelectedColor = System.Drawing.Color.White;
            this.btnUploadPicture.Size = new System.Drawing.Size(180, 32);
            this.btnUploadPicture.Style = Sunny.UI.UIStyle.Custom;
            this.btnUploadPicture.StyleCustomMode = true;
            this.btnUploadPicture.TabIndex = 2;
            this.btnUploadPicture.Text = "Tải ảnh lên";
            // 
            // picProduct
            // 
            this.picProduct.BackColor = System.Drawing.Color.Transparent;
            this.picProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picProduct.Location = new System.Drawing.Point(200, 10);
            this.picProduct.Name = "picProduct";
            this.picProduct.Padding = new System.Windows.Forms.Padding(1);
            this.picProduct.Size = new System.Drawing.Size(200, 200);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProduct.TabIndex = 4;
            this.picProduct.TabStop = false;
            this.picProduct.WaitOnLoad = true;
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 640);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlFooter);
            this.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormUser";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormUser";
            ((System.ComponentModel.ISupportInitialize)(this.epdInput)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlRemoveButton.ResumeLayout(false);
            this.pnlModifyButton.ResumeLayout(false);
            this.pnlSaveAndQuitButton.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider epdInput;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlRemoveButton;
        private Sunny.UI.UIButton btnRemove;
        private System.Windows.Forms.Panel pnlModifyButton;
        private Sunny.UI.UIButton btnModify;
        private Sunny.UI.UIButton btnCancel;
        private System.Windows.Forms.Panel pnlSaveAndQuitButton;
        private Sunny.UI.UIButton btnSaveAndQuit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.Panel panel4;
        private Sunny.UI.UIButton btnUploadPicture;
    }
}