using System;
using System.Data;

namespace WinFormsAppStoreManagement.DAL
{
    public class Discount
    {
        private int discountId;
        private double discountPercent;

        public int DiscountId { get => discountId; set => discountId = value; }
        public double DiscountPercent { get => discountPercent; set => discountPercent = value; }
        public Discount() { }
        public Discount(int id, double percent)
        {
            this.DiscountId = id;
            this.DiscountPercent = percent;
        }
        public Discount(DataRow row)
        {
            this.DiscountId = Convert.ToInt32(row["DiscountId"]);
            this.DiscountPercent = Convert.ToDouble(row["DiscountPercent"]);
        }
    }
    public class Tax
    {
        private int taxId;
        private double taxPercent;

        public int TaxId { get => taxId; set => taxId = value; }
        public double TaxPercent { get => taxPercent; set => taxPercent = value; }

        public Tax() { }
        public Tax(int id, double percent)
        {
            this.TaxId = id;
            this.TaxPercent = percent;
        }
        public Tax(DataRow row)
        {
            this.TaxId = Convert.ToInt32(row["TaxId"]);
            this.TaxPercent = Convert.ToDouble(row["TaxPercent"]);
        }
    }
    public class Bill
    {
        private string billId;
        private string orderId;
        private DateTime billTimeStamp;
        private double tax;
        private double discount;
        private double totalPayment;
        private int billStatus;
        private string billDescription;

        public string BillId { get => billId; set => billId = value; }
        public string OrderId { get => orderId; set => orderId = value; }
        public DateTime BillTimeStamp { get => billTimeStamp; set => billTimeStamp = value; }
        public double Tax { get => tax; set => tax = value; }
        public double Discount { get => discount; set => discount = value; }
        public double TotalPayment { get => totalPayment; set => totalPayment = value; }
        public int BillStatus { get => billStatus; set => billStatus = value; }
        public string BillDescription { get => billDescription; set => billDescription = value; }

        public Bill() { }
        public Bill(string bill, string order, DateTime time, double tax, double discount, double total, int status, string description)
        {
            this.BillId = bill;
            this.OrderId = order;
            this.BillTimeStamp = time;
            this.Tax = tax;
            this.Discount = discount;
            this.TotalPayment = total;
            this.BillStatus = status;
            this.BillDescription = description;
        }
        public Bill(DataRow row)
        {
            this.BillId = row["BillId"].ToString();
            this.OrderId = row["OrderId"].ToString();
            this.BillTimeStamp = Convert.ToDateTime(row["BillTimeStamp"]);
            this.Tax = Convert.ToDouble(row["Tax"]);
            this.Discount = Convert.ToDouble(row["Discount"]);
            this.TotalPayment = Convert.ToDouble(row["TotalPayment"]);
            this.BillStatus = Convert.ToInt32(row["BillStatus"]);
            this.BillDescription = row["BillDescription"].ToString();
        }
    }
}
