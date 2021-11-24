using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppStoreManagement.UserInterface.Modals
{
    public partial class UCProduct : UserControl
    {
        public UCProduct()
        {
            InitializeComponent();
            WireAllControls(this);
        }
        public UCProduct(string id, string name, double price, Image image)
        {
            InitializeComponent();
            Id = id;
            this.lblName.Text = name;
            this.lblPrice.Text = price.ToString("c0");
            this.BackgroundImage = image;
        }
        public string Id
        {
            get { return this.Tag.ToString(); }
            set { this.Tag = value; }
        }

        private void WireAllControls(Control cont)
        {
            foreach (Control ctl in cont.Controls)
            {
                ctl.Click += ctl_Click;
                if (ctl.HasChildren)
                {
                    WireAllControls(ctl);
                }
            }
        }

        private void ctl_Click(object sender, EventArgs e)
        {
            this.InvokeOnClick(this, EventArgs.Empty);
        }
    }
}
