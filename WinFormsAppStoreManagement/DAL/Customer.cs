using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WinFormsAppStoreManagement.DAL
{
    public class Customer
    {
        private string customerId;
        private string customerName;
        private string genderName;
        private string customerCIC;
        private DateTime customerBirth;
        private string customerTel;
        private string customerAddress;
        private string customerLevel;
        private int customerPoint;
        private string customerDescription;
        public string CustomerId { get => customerId; set => customerId = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public string CustomerCIC { get => customerCIC; set => customerCIC = value; }
        public string GenderName { get => genderName; set => genderName = value; }
        public DateTime CustomerBirth { get => customerBirth; set => customerBirth = value; }
        public string CustomerTel { get => customerTel; set => customerTel = value; }
        public string CustomerAddress { get => customerAddress; set => customerAddress = value; }
        public string CustomerLevel { get => customerLevel; set => customerLevel = value; }
        public int CustomerPoint { get => customerPoint; set => customerPoint = value; }
        public string CustomerDescription { get => customerDescription; set => customerDescription = value; }

        public Customer() { }
        public Customer(string id, string name, string gender, string CIC, DateTime birth, string tel, string address, string level, int point, string description)
        {
            this.CustomerId = id;
            this.CustomerName = name;
            this.GenderName = gender;
            this.CustomerCIC = CIC;
            this.CustomerBirth = birth;
            this.CustomerTel = tel;
            this.CustomerAddress = address;
            this.CustomerLevel = level;
            this.CustomerPoint = point;
            this.CustomerDescription = description;
        }
        public Customer(DataRow row)
        {
            this.CustomerId = row["CustomerId"].ToString();
            this.CustomerName = row["CustomerName"].ToString(); 
            this.GenderName = row["GenderName"].ToString();
            this.CustomerCIC = row["CustomerCIC"].ToString();
            this.CustomerBirth = (DateTime)row["CustomerBirth"];
            this.CustomerTel = row["CustomerTel"].ToString();
            this.CustomerAddress = row["CustomerAddress"].ToString();
            this.CustomerLevel = row["CustomerLevel"].ToString();
            this.CustomerPoint = Convert.ToInt32(row["CustomerPoint"]);
            this.CustomerDescription = row["CustomerDescription"].ToString();
        }
    }
}
