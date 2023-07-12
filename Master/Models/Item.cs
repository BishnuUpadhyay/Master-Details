using System.ComponentModel.DataAnnotations;

namespace Master.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Item Name")]
        public string ItemName { get; set; }
        public string ? Descriptionn { get; set; }
        public int ? ItemQuantity { get; set; }
        public string ?  Price { get; set; }
    }


}


