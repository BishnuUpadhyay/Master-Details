using System.ComponentModel.DataAnnotations;

namespace Master.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Customer Name")]
        public string CustomerName { get; set; }
        public string Address { get; set; }
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
    }
    public class CustomerDTO
    {
        public string customerName { get; set; }
        public string address { get; set; }
        public string phoneNumber { get; set; }
    }
}
