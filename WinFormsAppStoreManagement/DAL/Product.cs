using System;
using System.Data;
using System.Drawing;
using WinFormsAppStoreManagement.BLL;

namespace WinFormsAppStoreManagement.Database
{
    public class Category
    {
        private int categoryId;
        private string categoryName;
        public int CategoryId { get => categoryId; set => categoryId = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }
        public Category() { }
        public Category(int id, string name)
        {
            this.CategoryId = id;
            this.CategoryName = name;
        }
        public Category(DataRow row)
        {
            this.CategoryId = Convert.ToInt32(row["CategoryId"]);
            this.CategoryName = row["CategoryName"].ToString();
        }
    }
    public class Product
    {
        private string productId;
        private string productName;
        private Image productImage;
        private string productUnit;
        private double productPrice;
        private double productTotalQuantity;
        private string categoryName;
        private string productDescription;

        public string ProductId { get => productId; set => productId = value; }
        public string ProductName { get => productName; set => productName = value; }
        public Image ProductImage { get => productImage; set => productImage = value; }
        public string ProductUnit { get => productUnit; set => productUnit = value; }
        public double ProductPrice { get => productPrice; set => productPrice = value; }
        public double ProductTotalQuantity { get => productTotalQuantity; set => productTotalQuantity = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }
        public string ProductDescription { get => productDescription; set => productDescription = value; }

        public Product() { }
        public Product(string id, string name, Image image, string unit, double price, double totalQuantity, string category, string description)
        {
            this.ProductId = id;
            this.ProductName = name;
            this.CategoryName = category;
            this.ProductImage = image;
            this.ProductUnit = unit;
            this.ProductPrice = price;
            this.ProductTotalQuantity = totalQuantity;
            this.ProductDescription = description;
        }
        public Product(DataRow row)
        {
            this.ProductId = row["ProductId"].ToString();
            this.ProductName = row["ProductName"].ToString();
            this.ProductImage = ImageProcessing.ConvertByteArrayToImage((byte[])row["ProductImage"]);
            this.CategoryName = row["CategoryName"].ToString();
            this.ProductUnit = row["ProductUnit"].ToString();
            this.ProductPrice = Convert.ToDouble(row["ProductPrice"]);
            this.ProductTotalQuantity = Convert.ToDouble(row["ProductTotalQuantity"]);
            this.ProductDescription = row["ProductDescription"].ToString();
        }
    }
}
