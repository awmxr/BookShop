using System.ComponentModel.DataAnnotations;

namespace test.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string PostalCode { get; set; }
        [Required]
        [StringLength(maximumLength:12,MinimumLength =12,ErrorMessage = "must be 12 digit")]
        [RegularExpression("^[0-9]*$" , ErrorMessage = "must be a number")]
        public string PhoneNumber { get; set; }
        [Required]
        public int BookId { get; set; }
        [Required]
        public int Price { get; set; }

        public DateTime TimeCreated { get; set; }

        public OrderStatus State { get; set; }

    }
    public enum OrderStatus
    {
        New = 0,
        Delivered = 1
    }
}
