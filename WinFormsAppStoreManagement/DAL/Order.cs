using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WinFormsAppStoreManagement.DAL
{
    public class Status
    {
        private int statusId;
        private string statusName;
        public int StatusId { get => statusId; set => statusId = value; }
        public string StatusName { get => statusName; set => statusName = value; }
        public Status() { }
        public Status(int id, string name)
        {
            this.StatusId = id;
            this.StatusName = name;
        }
        public Status(DataRow row)
        {
            this.StatusId = Convert.ToInt32(row["StatusId"]);
            this.StatusName = row["StatusName"].ToString();
        }
    }
    public class Order
    {
        private string orderId;
        private string customerId;
        private string customerName;
        private string employeeId;
        private string employeeName;
        private DateTime orderTimeStamp;
        private string statusName;
        private string orderDescription;

        public string OrderId { get => orderId; set => orderId = value; }
        public string CustomerId { get => customerId; set => customerId = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public string EmployeeId { get => employeeId; set => employeeId = value; }
        public string EmployeeName { get => employeeName; set => employeeName = value; }
        public DateTime OrderTimeStamp { get => orderTimeStamp; set => orderTimeStamp = value; }
        public string StatusName { get => statusName; set => statusName = value; }
        public string OrderDescription { get => orderDescription; set => orderDescription = value; }

        public Order() { }
        public Order(string id, string customerId, string customerName, string employeeId, string employeeName, DateTime time, string status, string description)
        {
            this.OrderId = id;
            this.CustomerId = customerId;
            this.CustomerName = customerName;
            this.EmployeeId = employeeId;
            this.EmployeeName = employeeName;
            this.OrderTimeStamp = time;
            this.StatusName = status;
            this.OrderDescription = description;
        }
        public Order(DataRow row)
        {
            this.OrderId = row["OrderId"].ToString();
            this.CustomerId = row["CustomerId"].ToString();
            this.CustomerName = row["CustomerName"].ToString();
            this.EmployeeId = row["EmployeeId"].ToString();
            this.EmployeeName = row["EmployeeName"].ToString();
            this.OrderTimeStamp = (DateTime)row["OrderTimeStamp"];
            this.StatusName = row["StatusName"].ToString();
            this.OrderDescription = row["OrderDescription"].ToString();
        }
    }
}
