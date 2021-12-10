using System.Collections.Generic;
using System.Data;
using WinFormsAppStoreManagement.DAL;

namespace WinFormsAppStoreManagement.BLL
{
    class CustomerBLL
    {
        private static CustomerBLL instance;
        public static CustomerBLL Instance
        {
            get { if (instance == null) instance = new CustomerBLL(); return CustomerBLL.instance; }
            private set { CustomerBLL.instance = value; }
        }
        private CustomerBLL() { }
        private int ConvertGenderToInt32(string gender)
        {
            if (gender == "Nam")
            {
                return 1;
            }
            else if (gender == "Nữ")
            {
                return 2;
            }
            else if (gender == "Khác")
            {
                return 0;
            }
            return 0;
        }
        public List<Customer> LoadCustomerList()
        {
            List<Customer> customers = new List<Customer>();
            string query = "SELECT * FROM VW_ShowCustomerList";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Customer customer = new Customer(item);
                customers.Add(customer);
            }
            return customers;
        }
        public string GetCustomerLevelById(string customerId)
        {
            string query = "SELECT CustomerLevel FROM VW_ShowCustomerList WHERE CustomerId = @CustomerId";
            return DataProvider.Instance.ExecuteScalar(query, new object[] { customerId }).ToString();
        }
        public int AddCustomerToDatabase(Customer Customer)
        {
            string query = "INSERT INTO dbo.Customers (CustomerName , CustomerGender , CustomerBirth , CustomerCIC , CustomerAddress , CustomerTel , CustomerLevel , CustomerPoint , CustomerDescription) " +
                           "VALUES( @CustomerName , @CustomerGender , @CustomerBirth , @CustomerCIC , @CustomerAddress , @CustomerTel , @CustomerLevel , @CustomerPoint , @CustomerDescription )";
            return DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[]
                {
                    Customer.CustomerName,
                    ConvertGenderToInt32(Customer.GenderName),
                    Customer.CustomerBirth,
                    Customer.CustomerCIC,
                    Customer.CustomerAddress,
                    Customer.CustomerTel,
                    Customer.CustomerLevel,
                    Customer.CustomerPoint,
                    Customer.CustomerDescription
                }
            );
        }
        public int ModifyCustomerInDatabase(Customer Customer)
        {
            string query = "UPDATE dbo.Customers " +
                "SET CustomerName = @CustomerName , CustomerGender = @CustomerGender , CustomerBirth = @CustomerBirth , CustomerCIC = @CustomerCIC , " +
                "CustomerAddress = @CustomerAddress , CustomerTel = @CustomerTel , CustomerLevel = @CustomerLevel , CustomerPoint = @CustomerPoint , CustomerDescription = @CustomerDescription " +
                "WHERE CustomerId = @CustomerId ";
            return DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[]
                {
                    Customer.CustomerName,
                    ConvertGenderToInt32(Customer.GenderName),
                    Customer.CustomerBirth,
                    Customer.CustomerCIC,
                    Customer.CustomerAddress,
                    Customer.CustomerTel,
                    Customer.CustomerLevel,
                    Customer.CustomerPoint,
                    Customer.CustomerDescription,
                    Customer.CustomerId
                }
            );
        }
        public int RemoveCustomerFromDatabase(string CustomerId)
        {
            string query = "DELETE FROM dbo.Customers WHERE CustomerId = @CustomerId ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { CustomerId });
        }
    }
}
