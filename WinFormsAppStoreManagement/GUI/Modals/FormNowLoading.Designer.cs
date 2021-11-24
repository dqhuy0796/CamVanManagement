
namespace WinFormsAppStoreManagement.UserInterface.Modals
{
    partial class FormNowLoading
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
            this.pnlContainer = new Sunny.UI.UIPanel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblTips = new System.Windows.Forms.Label();
            this.lblAsYouKnow = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.uiNowLoading = new Sunny.UI.UIProgressIndicator();
            this.timerShow = new System.Windows.Forms.Timer(this.components);
            this.pnlContainer.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.pnlFooter);
            this.pnlContainer.Controls.Add(this.lblTitle);
            this.pnlContainer.Controls.Add(this.uiNowLoading);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.FillColor = System.Drawing.Color.White;
            this.pnlContainer.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlContainer.Location = new System.Drawing.Point(1, 1);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlContainer.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Radius = 24;
            this.pnlContainer.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.pnlContainer.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pnlContainer.Size = new System.Drawing.Size(477, 177);
            this.pnlContainer.Style = Sunny.UI.UIStyle.White;
            this.pnlContainer.StyleCustomMode = true;
            this.pnlContainer.TabIndex = 0;
            this.pnlContainer.Text = null;
            this.pnlContainer.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlContainer.UseWaitCursor = true;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.Transparent;
            this.pnlFooter.Controls.Add(this.lblTips);
            this.pnlFooter.Controls.Add(this.lblAsYouKnow);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 127);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.pnlFooter.Size = new System.Drawing.Size(477, 50);
            this.pnlFooter.TabIndex = 5;
            this.pnlFooter.UseWaitCursor = true;
            // 
            // lblTips
            // 
            this.lblTips.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTips.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTips.Location = new System.Drawing.Point(10, 20);
            this.lblTips.Name = "lblTips";
            this.lblTips.Size = new System.Drawing.Size(457, 20);
            this.lblTips.TabIndex = 3;
            this.lblTips.Text = "Bạn có thể tuỳ chỉnh giao diện sáng tối trong phần cài đặt của ứng dụng.";
            this.lblTips.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTips.UseWaitCursor = true;
            // 
            // lblAsYouKnow
            // 
            this.lblAsYouKnow.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAsYouKnow.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAsYouKnow.Location = new System.Drawing.Point(10, 0);
            this.lblAsYouKnow.Name = "lblAsYouKnow";
            this.lblAsYouKnow.Size = new System.Drawing.Size(457, 20);
            this.lblAsYouKnow.TabIndex = 2;
            this.lblAsYouKnow.Text = "Có thể bạn đã biết";
            this.lblAsYouKnow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAsYouKnow.UseWaitCursor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(477, 30);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Đang tải...";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblTitle.UseWaitCursor = true;
            // 
            // uiNowLoading
            // 
            this.uiNowLoading.BackColor = System.Drawing.Color.Transparent;
            this.uiNowLoading.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiNowLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.uiNowLoading.Location = new System.Drawing.Point(188, 33);
            this.uiNowLoading.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiNowLoading.Name = "uiNowLoading";
            this.uiNowLoading.Size = new System.Drawing.Size(100, 100);
            this.uiNowLoading.Style = Sunny.UI.UIStyle.Colorful;
            this.uiNowLoading.StyleCustomMode = true;
            this.uiNowLoading.TabIndex = 3;
            this.uiNowLoading.Text = "uiProgressIndicator1";
            this.uiNowLoading.UseWaitCursor = true;
            // 
            // timerShow
            // 
            this.timerShow.Enabled = true;
            this.timerShow.Interval = 500;
            this.timerShow.Tick += new System.EventHandler(this.timerShow_Tick);
            // 
            // FormNowLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(480, 180);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNowLoading";
            this.Padding = new System.Windows.Forms.Padding(1, 1, 2, 2);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormNowLoading";
            this.UseWaitCursor = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNowLoading_FormClosing);
            this.Load += new System.EventHandler(this.FormNowLoading_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIPanel pnlContainer;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblTips;
        private System.Windows.Forms.Label lblAsYouKnow;
        private System.Windows.Forms.Label lblTitle;
        private Sunny.UI.UIProgressIndicator uiNowLoading;
        private System.Windows.Forms.Timer timerShow;
    }
}