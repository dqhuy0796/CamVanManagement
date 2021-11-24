using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WinFormsAppStoreManagement.Database
{
    public class OrderDetail
    {
        private string orderId;
        private int productQuantity;
        private string productId;
        private string productName;
        private string productUnit;
        private double productPrice;
        private double subTotal;

        public string OrderId { get => orderId; set => orderId = value; }
        public int ProductQuantity { get => productQuantity; set => productQuantity = value; }
        public string ProductId { get => productId; set => productId = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string ProductUnit { get => productUnit; set => productUnit = value; }
        public double ProductPrice { get => productPrice; set => productPrice = value; }
        public double SubTotal { get => subTotal; set => subTotal = value; }

        public OrderDetail() { }
        public OrderDetail(string order, int quantity, string id, string name, string unit, double price)
        {
            this.OrderId = order;
            this.ProductQuantity = quantity;
            this.ProductId = id;
            this.ProductName = name;
            this.ProductUnit = unit;
            this.ProductPrice = price;
            this.SubTotal = this.ProductQuantity * this.ProductPrice;
        }
        public OrderDetail(DataRow row)
        {
            this.OrderId = row["OrderId"].ToString();
            this.ProductQuantity = Convert.ToInt32(row["ProductQuantity"]);
            this.ProductId = row["ProductId"].ToString();
            this.ProductName = row["ProductName"].ToString();
            this.ProductUnit = row["ProductUnit"].ToString();
            this.ProductPrice = Convert.ToDouble(row["ProductPrice"]);
            this.SubTotal = Convert.ToDouble(row["SubTotal"]);
        }
    }
}
