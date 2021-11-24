using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using WinFormsAppStoreManagement.Database;

namespace WinFormsAppStoreManagement.Controller
{
    class OrderDetailBLL
    {
        private static OrderDetailBLL instance;
        public static OrderDetailBLL Instance
        {
            get { if (instance == null) instance = new OrderDetailBLL(); return OrderDetailBLL.instance; }
            private set { OrderDetailBLL.instance = value; }
        }
        private OrderDetailBLL() { }
        public DataTable LoadOrderDetailList(string orderId)
        {
            string query = "EXECUTE USP_ShowOrderDetail @OrderId ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { orderId });
            return data;
        }
        public int AddOrderDetailToDatabase(OrderDetail detail, string orderId)
        {
            string query = "INSERT INTO dbo.OrderDetail ( OrderId , ProductId , ProductQuantity ) VALUES ( @OrderId , @ProductId , @ProductQuantity )";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { orderId, detail.ProductId, detail.ProductQuantity });
        }
        public int DeleteOrderDetailFromDatabase(string orderId)
        {
            string query = "DELETE FROM dbo.OrderDetail WHERE OrderId = @OrderId";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { orderId });
        }
    }
}
