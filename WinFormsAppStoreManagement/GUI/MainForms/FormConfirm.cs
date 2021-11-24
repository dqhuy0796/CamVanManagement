using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppStoreManagement.UserInterface.MainForms
{
    public partial class FormConfirm : Form
    {
        #region Drag form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #endregion
        public FormConfirm()
        {
            InitializeComponent();
            Customize();
        }
        public FormConfirm(string titleString, string confirmString, string cancelString)
        {
            InitializeComponent();
            lblTitle.Text = titleString;
            btnConfirm.Text = confirmString;
            btnCancel.Text = cancelString;
            Customize();
        }
        private void Customize()
        {
            btnConfirm.TextAlign = ContentAlignment.BottomCenter;
            btnConfirm.Padding = new Padding(0, 0, 0, 6);
            btnCancel.TextAlign = ContentAlignment.BottomCenter;
            btnCancel.Padding = new Padding(0, 0, 0, 6);
        }

        private void tlpContainer_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
