using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using WinFormsAppStoreManagement.DAL;

namespace WinFormsAppStoreManagement.BLL
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
            return DataProvider.Instance.ExecuteQuery(query, new object[] { orderId }) as DataTable;
        }
        public int AddOrderDetailToDatabase(OrderDetail detail, string orderId)
        {
            string query = "INSERT INTO dbo.OrderDetail ( OrderId , ProductId , ProductQuantity ) VALUES ( @OrderId , @ProductId , @ProductQuantity )";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { orderId, detail.ProductId, detail.ProductQuantity });
        }
        public int RemoveOrderDetailFromDatabase(string orderId)
        {
            string query = "DELETE FROM dbo.OrderDetail WHERE OrderId = @OrderId ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { orderId });
        }
    }
}
