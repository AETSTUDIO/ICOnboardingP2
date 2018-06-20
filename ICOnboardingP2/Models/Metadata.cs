using System;
using System.ComponentModel.DataAnnotations;

namespace ICOnboardingP2.Models
{
    public class CustomerMetadata
    {
        [Required]
        [StringLength(255)]
        public string Name;

        [Required]
        [StringLength(255)]
        public string Address;

    }

    public class ProductMetadata
    {
        [Required]
        [StringLength(255)]
        public string Name;

        [Required]
        [Range(0.01, 99999.99)]
        public decimal Price;
    }

    public class StoreMetadata
    {
        [Required]
        [StringLength(255)]
        public string Name;

        [Required]
        [StringLength(255)]
        public string Address;
    }

    public class ProductSoldMetadata
    {
        [Required]
        [Display(Name = "Date Sold")]
        public DateTime DateSold;
    }
}