using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using WinFormsAppStoreManagement.BLL;

namespace WinFormsAppStoreManagement.DAL
{
    public class Account
    {
        string username;
        string password;
        int typeAccount;
        string employeeId;
        Image avatar;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int TypeAccount { get => typeAccount; set => typeAccount = value; }
        public string EmployeeId { get => employeeId; set => employeeId = value; }
        public Image Avatar { get => avatar; set => avatar = value; }

        public Account() { }

        public Account(string user, string pass, int type, string id, Image avt)
        {
            this.Username = user;
            this.Password = pass;
            this.TypeAccount = type;
            this.EmployeeId = id;
            this.Avatar = avt;
        }
        public Account(DataRow row)
        {
            this.Username = row["Username"].ToString();
            this.Password = row["Password"].ToString();
            this.TypeAccount = Convert.ToInt32(row["TypeAccount"]);
            this.EmployeeId = row["EmployeeId"].ToString();
            //this.Avatar = ImageProcessing.ConvertByteArrayToImage((byte[])row["Avartar"]);
            this.Avatar = Properties.Resources.squid_game_avatar;
        }
    }
}
