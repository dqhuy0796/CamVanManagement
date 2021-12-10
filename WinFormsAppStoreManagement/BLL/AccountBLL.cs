using System.Collections.Generic;
using System.Data;
using WinFormsAppStoreManagement.DAL;

namespace WinFormsAppStoreManagement.BLL
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
        public List<Role> GetRoleList()
        {
            List<Role> roles = new List<Role>();
            string query = "SELECT * FROM VW_ShowRoleList";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                Role role = new Role(row);
                roles.Add(role);
            }
            return roles;
        }
        public int ConvertRoleToInt32(string role)
        {
            foreach (Role item in GetRoleList())
            {
                if (item.RoleName == role)
                {
                    return item.RoleId;
                }
            }
            return -1;
        }
        public int ModifyAccountInDatabaseWithImage(Account account)
        {
            string query = "UPDATE dbo.Accounts SET [Password] = @Password , TypeAccount = @TypeAccount , DisplayName = @DisplayName , Avatar = @Avatar WHERE Username = @Username ";
            return DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[]
                {
                    account.Password,
                    ConvertRoleToInt32(account.TypeAccount),
                    account.DisplayName,
                    ImageProcessing.ConvertImageToByteArray(account.Avatar),
                    account.Username
                });
        }
        public int ModifyAccountInDatabaseWithoutImage(Account account)
        {
            string query = "UPDATE dbo.Accounts SET [Password] = @Password , TypeAccount = @TypeAccount , DisplayName = @DisplayName WHERE Username = @Username ";
            return DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[]
                {
                    account.Password,
                    ConvertRoleToInt32(account.TypeAccount),
                    account.DisplayName,
                    account.Username
                });
        }
    }
}
