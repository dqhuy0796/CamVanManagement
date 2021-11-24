using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using WinFormsAppStoreManagement.DAL;

namespace WinFormsAppStoreManagement.Controller
{
    public class AccountBLL
    {
        private static AccountBLL instance;
        public static AccountBLL Instance
        {
            get { if (instance == null) instance = new AccountBLL(); return AccountBLL.instance; }
            private set { AccountBLL.instance = value; }
        }
        private AccountBLL() { }
        public DataTable Authentication(string username, string password)
        {
            string query = $"EXECUTE USP_Authetication @username , @password ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });
            return data;                              
        }
    }
}
