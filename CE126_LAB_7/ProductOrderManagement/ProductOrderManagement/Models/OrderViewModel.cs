using System.ComponentModel.DataAnnotations;

namespace ProductOrderManagement.Models
{
    public class OrderViewModel
    {
        [Required(ErrorMessage = "Customer name is required.")]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; } = "";

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Phone number is required.")]
        [Phone(ErrorMessage = "Please enter a valid phone number.")]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; } = "";

        [Required(ErrorMessage = "Please select a product.")]
        [Display(Name = "Product")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Quantity is required.")]
        [Range(1, 100, ErrorMessage = "Quantity must be between 1 and 100.")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        [Display(Name = "Delivery Address")]
        public string DeliveryAddress { get; set; } = "";

        [Required(ErrorMessage = "City is required.")]
        public string City { get; set; } = "";

        [Required(ErrorMessage = "Pincode is required.")]
        [RegularExpression(@"^\d{6}$",
            ErrorMessage = "Pincode must contain exactly 6 digits.")]
        public string Pincode { get; set; } = "";
    }
}