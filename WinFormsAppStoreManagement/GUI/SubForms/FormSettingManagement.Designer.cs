
namespace WinFormsAppStoreManagement.UserInterface.SubForms
{
    partial class frmSetting
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
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiSwitch1 = new Sunny.UI.UISwitch();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.uiPanel1.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiButton1.Location = new System.Drawing.Point(65, 97);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(100, 35);
            this.uiButton1.TabIndex = 0;
            this.uiButton1.Text = "uiButton1";
            // 
            // uiSwitch1
            // 
            this.uiSwitch1.ActiveText = "";
            this.uiSwitch1.Dock = System.Windows.Forms.DockStyle.Right;
            this.uiSwitch1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiSwitch1.InActiveText = "";
            this.uiSwitch1.Location = new System.Drawing.Point(680, 40);
            this.uiSwitch1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSwitch1.Name = "uiSwitch1";
            this.uiSwitch1.Size = new System.Drawing.Size(60, 32);
            this.uiSwitch1.TabIndex = 1;
            this.uiSwitch1.Text = "uiSwitch1";
            this.uiSwitch1.ValueChanged += new Sunny.UI.UISwitch.OnValueChanged(this.uiSwitch1_ValueChanged);
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiLabel1);
            this.uiPanel1.Controls.Add(this.uiSwitch1);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiPanel1.Location = new System.Drawing.Point(10, 10);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Padding = new System.Windows.Forms.Padding(40);
            this.uiPanel1.Size = new System.Drawing.Size(780, 112);
            this.uiPanel1.TabIndex = 2;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiLabel1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel1.Location = new System.Drawing.Point(40, 40);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(200, 32);
            this.uiLabel1.TabIndex = 2;
            this.uiLabel1.Text = "Dark mode";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.uiButton1);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPanel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiPanel2.Location = new System.Drawing.Point(10, 513);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(780, 180);
            this.uiPanel2.TabIndex = 3;
            this.uiPanel2.Text = "uiPanel2";
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 703);
            this.Controls.Add(this.uiPanel2);
            this.Controls.Add(this.uiPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSetting";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Tag = "Cài đặt";
            this.Text = "FormSetting";
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UISwitch uiSwitch1;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIPanel uiPanel2;
    }
}