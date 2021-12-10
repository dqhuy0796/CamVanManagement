using System.Collections.Generic;
using System.Data;
using WinFormsAppStoreManagement.DAL;

namespace WinFormsAppStoreManagement.BLL
{
    public class ProductBLL
    {
        private static ProductBLL instance;
        public static ProductBLL Instance
        {
            get { if (instance == null) instance = new ProductBLL(); return ProductBLL.instance; }
            private set { ProductBLL.instance = value; }
        }
        private ProductBLL() { }
        public List<Category> LoadCategoryList()
        {
            List<Category> categories = new List<Category>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM VW_ShowCategoryList");
            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                categories.Add(category);
            }
            return categories;
        }
        public List<Product> LoadProductList()
        {
            List<Product> products = new List<Product>();
            string query = "SELECT * FROM VW_ShowProductList";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Product product = new Product(item);
                products.Add(product);
            }
            return products;
        }
        private int ConvertCategoryToInt32(string categoryString)
        {
            List<Category> categories = LoadCategoryList();
            foreach (Category item in categories)
            {
                if (item.CategoryName == categoryString)
                {
                    return item.CategoryId;
                }
            }
            return 0;
        }
        public int AddProductToDatabase(Product product)
        {
            string query = "INSERT INTO dbo.Products (ProductName, ProductImage, ProductUnit, ProductPrice, ProductTotalQuantity, CategoryId, ProductDescription) " +
                           "VALUES( @ProductName , @ProductImage , @ProductUnit , @ProductPrice , @ProductTotalQuantity , @CategoryId , @ProductDescription )";
            return DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[]
                {
                    product.ProductName,
                    ImageProcessing.ConvertImageToByteArray(product.ProductImage),
                    product.ProductUnit,
                    product.ProductPrice,
                    product.ProductTotalQuantity,
                    ConvertCategoryToInt32(product.CategoryName),
                    product.ProductDescription
                }
            );
        }
        public int ModifyProductInDatabaseWithImage(Product product)
        {
            string query = "UPDATE dbo.Products SET ProductName = @Name , ProductImage = @Image , ProductUnit = @Unit , ProductPrice = @Price ," +
                " ProductTotalQuantity = @Quantity , CategoryId = @CategoryId , ProductDescription = @Description WHERE ProductId = @Id ";
            return DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[]
                {
                    product.ProductName,
                    ImageProcessing.ConvertImageToByteArray(product.ProductImage),
                    product.ProductUnit,
                    product.ProductPrice,
                    product.ProductTotalQuantity,
                    ConvertCategoryToInt32(product.CategoryName),
                    product.ProductDescription,
                    product.ProductId
                }
            );
        }
        public int ModifyProductInDatabaseWithoutImage(Product product)
        {
            string query = "UPDATE dbo.Products SET ProductName = @Name , ProductUnit = @Unit , ProductPrice = @Price ," +
                " ProductTotalQuantity = @Quantity , CategoryId = @CategoryId , ProductDescription = @Description WHERE ProductId = @Id ";
            return DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[]
                {
                    product.ProductName,
                    product.ProductUnit,
                    product.ProductPrice,
                    product.ProductTotalQuantity,
                    ConvertCategoryToInt32(product.CategoryName),
                    product.ProductDescription,
                    product.ProductId
                }
            );
        }
        public int RemoveProductFromDatabase(string productId)
        {
            string query = "DELETE FROM dbo.Products WHERE ProductId = @id ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { productId });
        }
    }
}
