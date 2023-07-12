namespace Master.Models
{
    public class SalesInvoice
    {
        public int Id { get; set; }
        public int  CustomerId { get; set; }
        public   List<Item> ? items { get; set; }
        public int? SalesInvoiceQuantity { get; set; }
        public decimal SalesInvoicePrice { get; set; }
        public decimal SalesDiscount { get; set; }
        public decimal GrandTotal { get; set; }



    }
    public class SaleInvoiceDTO
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }
        public List<Item>? Items { get; set; }
        public int? SalesInvoiceQuantity { get; set; }
        public decimal SalesInvoicePrice { get; set; }
        public decimal SalesDiscount { get; set; }
        public decimal GrandTotal { get; set; }

    }
}
