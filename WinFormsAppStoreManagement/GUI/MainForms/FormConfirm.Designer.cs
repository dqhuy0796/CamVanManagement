
namespace WinFormsAppStoreManagement.UserInterface.MainForms
{
    partial class FormConfirm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlpContainer = new System.Windows.Forms.TableLayoutPanel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnCancel = new Sunny.UI.UIButton();
            this.btnConfirm = new Sunny.UI.UIButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tlpContainer.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.tlpContainer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 198);
            this.panel1.TabIndex = 0;
            // 
            // tlpContainer
            // 
            this.tlpContainer.BackColor = System.Drawing.Color.White;
            this.tlpContainer.ColumnCount = 1;
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContainer.Controls.Add(this.btnQuit, 0, 0);
            this.tlpContainer.Controls.Add(this.pnlBottom, 0, 2);
            this.tlpContainer.Controls.Add(this.lblTitle, 0, 1);
            this.tlpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContainer.Location = new System.Drawing.Point(0, 0);
            this.tlpContainer.Margin = new System.Windows.Forms.Padding(0);
            this.tlpContainer.Name = "tlpContainer";
            this.tlpContainer.RowCount = 3;
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tlpContainer.Size = new System.Drawing.Size(498, 198);
            this.tlpContainer.TabIndex = 5;
            this.tlpContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tlpContainer_MouseDown);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.OrangeRed;
            this.btnQuit.BackgroundImage = global::WinFormsAppStoreManagement.Properties.Resources.white_exit_32;
            this.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnQuit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Location = new System.Drawing.Point(470, 0);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(0);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(28, 28);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Controls.Add(this.btnConfirm);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(0, 99);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Padding = new System.Windows.Forms.Padding(60, 33, 60, 33);
            this.pnlBottom.Size = new System.Drawing.Size(498, 99);
            this.pnlBottom.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCancel.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.btnCancel.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btnCancel.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btnCancel.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(278, 33);
            this.btnCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Radius = 30;
            this.btnCancel.RectColor = System.Drawing.Color.White;
            this.btnCancel.RectDisableColor = System.Drawing.Color.White;
            this.btnCancel.RectHoverColor = System.Drawing.Color.White;
            this.btnCancel.RectPressColor = System.Drawing.Color.White;
            this.btnCancel.RectSelectedColor = System.Drawing.Color.White;
            this.btnCancel.Size = new System.Drawing.Size(160, 33);
            this.btnCancel.Style = Sunny.UI.UIStyle.Custom;
            this.btnCancel.StyleCustomMode = true;
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnConfirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.btnConfirm.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(203)))), ((int)(((byte)(189)))));
            this.btnConfirm.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(138)))));
            this.btnConfirm.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(138)))));
            this.btnConfirm.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirm.Location = new System.Drawing.Point(60, 33);
            this.btnConfirm.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Radius = 30;
            this.btnConfirm.RectColor = System.Drawing.Color.White;
            this.btnConfirm.RectDisableColor = System.Drawing.Color.White;
            this.btnConfirm.RectHoverColor = System.Drawing.Color.White;
            this.btnConfirm.RectPressColor = System.Drawing.Color.White;
            this.btnConfirm.RectSelectedColor = System.Drawing.Color.White;
            this.btnConfirm.Size = new System.Drawing.Size(160, 33);
            this.btnConfirm.Style = Sunny.UI.UIStyle.Custom;
            this.btnConfirm.StyleCustomMode = true;
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(3, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(492, 71);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "This is Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(500, 200);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(500, 200);
            this.MinimumSize = new System.Drawing.Size(500, 200);
            this.Name = "FormConfirm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormConfirmAction";
            this.panel1.ResumeLayout(false);
            this.tlpContainer.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.TableLayoutPanel tlpContainer;
        private System.Windows.Forms.Panel pnlBottom;
        private Sunny.UI.UIButton btnCancel;
        private Sunny.UI.UIButton btnConfirm;
        private System.Windows.Forms.Label lblTitle;
    }
}