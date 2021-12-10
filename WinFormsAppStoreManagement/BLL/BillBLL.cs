using System.Collections.Generic;
using System.Data;
using WinFormsAppStoreManagement.DAL;

namespace WinFormsAppStoreManagement.BLL
{
    public class BillBLL
    {
        private static BillBLL instance;
        public static BillBLL Instance
        {
            get { if (instance == null) instance = new BillBLL(); return BillBLL.instance; }
            private set { BillBLL.instance = value; }
        }
        private BillBLL() { }
        public List<Discount> LoadDiscount()
        {
            List<Discount> discounts = new List<Discount>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Discount");
            foreach (DataRow item in data.Rows)
            {
                Discount discount = new Discount(item);
                discounts.Add(discount);
            }
            return discounts;
        }
        public List<Tax> LoadTax()
        {
            List<Tax> taxes = new List<Tax>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Tax");
            foreach (DataRow item in data.Rows)
            {
                Tax tax = new Tax(item);
                taxes.Add(tax);
            }
            return taxes;
        }
        public DataTable LoadBillList()
        {
            string query = "SELECT * FROM VW_ShowBillList ORDER BY BillId DESC";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public int AddBillToDatabase(Bill bill)
        {
            string query = "INSERT INTO dbo.Bills ( OrderId , BillTimeStamp , Tax , Discount , TotalPayment , BillStatus , BillDescription ) " +
                    "VALUES ( @OrderId , @BillTimeStamp , @Tax , @Discount , @TotalPayment , @BillStatus , @BillDescription )";
            return DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[]
                {
                    bill.OrderId,
                    bill.BillTimeStamp,
                    bill.Tax,
                    bill.Discount,
                    bill.TotalPayment,
                    bill.BillStatus,
                    bill.BillDescription
                }
            );
        }
        public int ModifyBillInDatabase(Bill bill)
        {
            string query = "UPDATE dbo.Bills SET OrderId = @OrderId , BillTimeStamp = @BillTimeStamp , Tax = @Tax , Discount = @Discount , " +
                "TotalPayment = @TotalPayment , BillStatus = @BillStatus , BillDescription = BillDescription WHERE BillId = @BillId ";
            return DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[]
                {
                    bill.OrderId,
                    bill.BillTimeStamp,
                    bill.Tax,
                    bill.Discount,
                    bill.TotalPayment,
                    bill.BillStatus,
                    bill.BillDescription,
                    bill.BillId
                }
            );
        }
        public int RemoveBillFromDatabase(Bill bill)
        {
            string query = "DELETE FROM dbo.Bills WHERE BillId = @BillId ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { bill.BillId });
        }
    }
}
