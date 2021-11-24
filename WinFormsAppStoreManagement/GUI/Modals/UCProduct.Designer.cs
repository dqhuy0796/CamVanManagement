
namespace WinFormsAppStoreManagement.UserInterface.Modals
{
    partial class UCProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.White;
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPrice.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.ForeColor = System.Drawing.Color.Red;
            this.lblPrice.Location = new System.Drawing.Point(0, 163);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(180, 17);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Đơn giá";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblName
            // 
            this.lblName.AutoEllipsis = true;
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(0, 145);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(180, 18);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Tên hàng";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // UCProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(170)))));
            this.BackgroundImage = global::WinFormsAppStoreManagement.Properties.Resources.squid_game_avatar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPrice);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "UCProduct";
            this.Size = new System.Drawing.Size(180, 180);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
    }
}
