using System;
using System.Data;

namespace WinFormsAppStoreManagement.DAL
{
    public class Role
    {
        private int roleId;
        private string roleName;

        public int RoleId { get => roleId; set => roleId = value; }
        public string RoleName { get => roleName; set => roleName = value; }

        public Role() { }
        public Role(int id, string role)
        {
            this.RoleId = id;
            this.RoleName = role;
        }
        public Role(DataRow row)
        {
            this.RoleId = Convert.ToInt32(row["RoleId"]);
            this.RoleName = row["RoleName"].ToString();
        }
    }
    public class Employee
    {
        private string employeeId;
        private string employeeName;
        private string genderName;
        private DateTime employeeBirth;
        private string employeeCIC;
        private string employeeTel;
        private string employeeAddress;
        private string employeeDescription;
        private string roleName;
        private double salary;
        private double workedTime;
        private DateTime dayStarted;

        public string EmployeeId { get => employeeId; set => employeeId = value; }
        public string EmployeeName { get => employeeName; set => employeeName = value; }
        public string GenderName { get => genderName; set => genderName = value; }
        public DateTime EmployeeBirth { get => employeeBirth; set => employeeBirth = value; }
        public string EmployeeCIC { get => employeeCIC; set => employeeCIC = value; }
        public string EmployeeTel { get => employeeTel; set => employeeTel = value; }
        public string EmployeeAddress { get => employeeAddress; set => employeeAddress = value; }
        public string EmployeeDescription { get => employeeDescription; set => employeeDescription = value; }
        public string RoleName { get => roleName; set => roleName = value; }
        public double Salary { get => salary; set => salary = value; }
        public double WorkedTime { get => workedTime; set => workedTime = value; }
        public DateTime DayStarted { get => dayStarted; set => dayStarted = value; }

        public Employee() { }
        public Employee(string id, string name, string gender, DateTime birth, string CIC, string tel, string role,
            string address, string description, double salary, double workedHours, DateTime dateStarted)
        {
            this.EmployeeId = id;
            this.EmployeeName = name;
            this.GenderName = gender;
            this.EmployeeBirth = birth;
            this.RoleName = role;
            this.EmployeeCIC = CIC;
            this.EmployeeTel = tel;
            this.EmployeeAddress = address;
            this.EmployeeDescription = description;
            this.Salary = salary;
            this.WorkedTime = workedHours;
            this.DayStarted = dateStarted;
        }
        public Employee(DataRow row)
        {
            this.RoleName = row["RoleName"].ToString();
            this.EmployeeId = row["EmployeeId"].ToString();
            this.GenderName = row["GenderName"].ToString();
            this.EmployeeCIC = row["EmployeeCIC"].ToString();
            this.EmployeeTel = row["EmployeeTel"].ToString();
            this.EmployeeName = row["EmployeeName"].ToString();
            this.EmployeeAddress = row["EmployeeAddress"].ToString();
            this.EmployeeDescription = row["EmployeeDescription"].ToString();
            this.Salary = Convert.ToDouble(row["Salary"]);
            this.WorkedTime = Convert.ToDouble(row["WorkedTime"]);
            this.DayStarted = Convert.ToDateTime(row["DayStarted"]);
            this.EmployeeBirth = Convert.ToDateTime(row["EmployeeBirth"]);
        }
    }
}
