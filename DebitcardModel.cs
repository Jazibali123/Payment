using System.ComponentModel.DataAnnotations;


namespace UserCard.Models
{
    public class PaymentData
    {
        
        [Required]
        public string Name { get; set; } 

        [Required(ErrorMessage = "Card Number is required")]
        [RegularExpression(@"^\d{16}$", ErrorMessage = "Please enter a valid 16-digit card number")]
        public string CardNumber { get; set; }

        [Required(ErrorMessage = "Expiration Date is required")]
        [RegularExpression(@"^(0[1-9]|1[0-2])\/20[0-9]{2}$", ErrorMessage = "Please enter a valid expiration date in MM/YYYY format")]
        public string ExpirationDate { get; set; }

        [Required(ErrorMessage = "CVV/CVC is required")]
        [RegularExpression(@"^\d{3}$", ErrorMessage = "Please enter a valid 3-digit CVV/CVC number")]
        public string CVV { get; set; }

        [Required(ErrorMessage = "Billing Address is required")]
        public string BillingAddress { get; set; }

        [Required(ErrorMessage = "Card Type is required")]  
        public string CardType { get; set; }

        [Required(ErrorMessage = "Amount is required")]
        public string Amount { get; set; }
    }
   


       
}
