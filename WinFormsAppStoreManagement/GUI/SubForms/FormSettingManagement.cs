using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppStoreManagement.UserInterface.SubForms
{
    public partial class frmSetting : Form
    {
        public frmSetting()
        {
            InitializeComponent();
        }
        //private void DarkMode()
        //{
        //    pnlNavbar.BackColor = HtmlColor.dark0;
        //    pnlLogo.BackColor = HtmlColor.dark1;
        //    pnlHeader.BackColor = HtmlColor.dark1;
        //    pnlContainer.BackColor = Color.Transparent;
        //}
        //private void LightMode()
        //{
        //    pnlNavbar.BackColor = HtmlColor.light2;
        //    pnlLogo.BackColor = HtmlColor.light1;
        //    pnlHeader.BackColor = HtmlColor.light1;
        //    pnlContainer.BackColor = Color.Transparent;
        //}
        private void uiSwitch1_ValueChanged(object sender, bool value)
        {
            if(value == true)
            {
                
            }
        }
    }
}
