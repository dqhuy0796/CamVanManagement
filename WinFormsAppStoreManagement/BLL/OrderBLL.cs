using System;
using System.Collections.Generic;
using System.Data;
using WinFormsAppStoreManagement.DAL;

namespace WinFormsAppStoreManagement.BLL
{
    public class OrderBLL
    {
        private static OrderBLL instance;
        public static OrderBLL Instance
        {
            get { if (instance == null) instance = new OrderBLL(); return OrderBLL.instance; }
            private set { OrderBLL.instance = value; }
        }
        private OrderBLL() { }
        private int ConvertStatusToInt32(string statusString)
        {
            List<Status> statuses = LoadStatusList();
            foreach (Status item in statuses)
            {
                if (item.StatusName == statusString)
                {
                    return item.StatusId;
                }
            }
            return 0;
        }
        public List<Status> LoadStatusList()
        {
            List<Status> statuses = new List<Status>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM VW_ShowStatusList");
            foreach (DataRow item in data.Rows)
            {
                Status Status = new Status(item);
                statuses.Add(Status);
            }
            return statuses;
        }
        public DataTable LoadOrderList()
        {
            string query = "SELECT * FROM VW_ShowOrderList ORDER BY OrderId DESC";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool IsExistOrder(string orderId)
        {
            string query = "SELECT COUNT(*) FROM VW_ShowOrderList WHERE OrderId = @OrderId";
            if (Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query, new object[] { orderId })) > 0)
            {
                return true;
            }
            return false;
        }
        public Order GetOrderByOrderId(string orderId)
        {
            string query = "SELECT * FROM VW_ShowOrderList WHERE OrderId = @OrderId ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { orderId });
            return new Order(data.Rows[0]);
        }
        public string GetLastestOrderFromDatabase()
        {
            string query = "EXECUTE USP_GetLastestOrder";
            return DataProvider.Instance.ExecuteScalar(query).ToString();
        }
        public int AddOrderToDatabase(Order order)
        {
            string query = "INSERT INTO dbo.Orders ( CustomerId , EmployeeId , OrderTimeStamp , OrderStatus , OrderDescription ) " +
                "VALUES ( @CustomerId , @EmployeeId , @OrderTimeStamp , @OrderStatus , @OrderDescription )";
            return DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[]
                {
                    order.CustomerId,
                    order.EmployeeId,
                    order.OrderTimeStamp,
                    ConvertStatusToInt32(order.StatusName),
                    order.OrderDescription
                }
            );
        }
        public int ModifyOrderInDatabase(Order order)
        {
            string query = "UPDATE dbo.Orders " +
                "SET CustomerId = @CustomerId , EmployeeId = @EmployeeId , OrderTimeStamp = @OrderTimeStamp , OrderStatus = @OrderStatus , OrderDescription = @OrderDescription " +
                "WHERE OrderId = @OrderId ";
            return DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[]
                {
                    order.CustomerId,
                    order.EmployeeId,
                    order.OrderTimeStamp,
                    ConvertStatusToInt32(order.StatusName),
                    order.OrderDescription,
                    order.OrderId
                }
            );
        }
        public int RemoveOrderFromDatabase(string orderId)
        {
            OrderDetailBLL.Instance.RemoveOrderDetailFromDatabase(orderId);
            string queryDeleteOrder = "DELETE FROM dbo.Orders WHERE OrderId = @OderId ";
            return DataProvider.Instance.ExecuteNonQuery(queryDeleteOrder, new object[] { orderId });
        }
    }
}
