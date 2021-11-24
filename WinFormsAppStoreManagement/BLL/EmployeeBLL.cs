using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using WinFormsAppStoreManagement.Database;

namespace WinFormsAppStoreManagement.Controller
{
    public class EmployeeBLL
    {
        private static EmployeeBLL instance;
        public static EmployeeBLL Instance
        {
            get { if (instance == null) instance = new EmployeeBLL(); return EmployeeBLL.instance; }
            private set { EmployeeBLL.instance = value; }
        }
        private EmployeeBLL() { }
        public List<Role> LoadRoleList()
        {
            List<Role> roles = new List<Role>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM VW_ShowRoleList");
            foreach (DataRow item in data.Rows)
            {
                Role Role = new Role(item);
                roles.Add(Role);
            }
            return roles;
        }
        public List<Employee> LoadEmployeeList()
        {
            List<Employee> Employees = new List<Employee>();
            string query = "SELECT * FROM VW_ShowEmployeeList";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Employee Employee = new Employee(item);
                Employees.Add(Employee);
            }
            return Employees;
        }
        private int ConvertCategoryToInt32(string roleString)
        {
            List<Role> roles = LoadRoleList();
            foreach (Role item in roles)
            {
                if (item.RoleName == roleString)
                {
                    return item.RoleId;
                }
            }
            return -1;
        }
    }
}
