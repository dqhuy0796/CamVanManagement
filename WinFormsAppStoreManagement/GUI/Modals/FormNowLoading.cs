using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppStoreManagement.UserInterface.Modals
{
    public partial class FormNowLoading : Form
    {
        private Timer animation = new Timer();
        private int tempIndexForTipAndTrick = 100;

        public FormNowLoading()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 24, 24));
        }
        public FormNowLoading(bool theme)
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 24, 24));
            Customize(theme);
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int left, int top, int right, int bottom, int width, int height);
        private string TipsAndTrick()
        {
            Random random = new Random();
            List<string> tipsList = new List<string>()
            {
                "Bạn có thể thay đổi giao diện sáng tối trong phần cài đặt của ứng dụng!",
                "Người thiết kế chính của ứng dụng - anh Huy không thích cái ứng dụng này",
                "Nhóm phát triển ứng dụng - BollyWood là một rạp xiếc trung ương =))",
                "Mất 2 tuần vừa học vừa làm là khoảng thời gian để xây dựng nên ứng dụng",
                "Người thiết kế của ứng dụng này học về web mà phải thiết kế winform",
                "Bạn có thể thấy ứng dụng chạy chẳng ra đâu với đâu, không sao kệ bạn :))",
                "Nhóm trưởng Hoài là nhất! Nhóm trưởng thứ 2 không ai dám Chủ nhật =]]"
            };
            int index = random.Next(tipsList.Count);
            while (tempIndexForTipAndTrick == index)
            {
                index = random.Next(tipsList.Count);
            }
            tempIndexForTipAndTrick = index;
            return tipsList[index];
        }
        public void Customize(bool darkmode)
        {
            this.BackColor = Color.FromArgb(0, 190, 172);
            lblTips.Text = TipsAndTrick();
            if (darkmode == true)
            {
                DarkMode();
            }
            else
            {
                LightMode();
            }
        }
        public void DarkMode()
        {
            pnlContainer.FillColor = HtmlColor.dark2;

            lblTitle.ForeColor = HtmlColor.light2;
            lblAsYouKnow.ForeColor = HtmlColor.light2;
            lblTips.ForeColor = HtmlColor.light2;
        }
        public void LightMode()
        {
            pnlContainer.FillColor = HtmlColor.light2;

            lblTitle.ForeColor = HtmlColor.dark2;
            lblAsYouKnow.ForeColor = HtmlColor.dark2;
            lblTips.ForeColor = HtmlColor.dark2;
        }

        #region Events
        private void FormNowLoading_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;

            animation.Interval = 10;  //we'll increase the opacity every 10ms
            animation.Tick += new EventHandler(fadeIn);
            animation.Start();
        }

        private void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                animation.Stop();
            else
                Opacity += 0.05;
        }

        private void FormNowLoading_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            animation.Tick += new EventHandler(fadeOut); 
            animation.Start();

            if (Opacity <= 0.6)      
                e.Cancel = false;  
        }
        
        void fadeOut(object sender, EventArgs e)
        {
            if (Opacity <= 0.6)
            {
                animation.Stop();
                this.Close();
            }
            else
                Opacity -= 0.05;
        }

        private void timerShow_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
