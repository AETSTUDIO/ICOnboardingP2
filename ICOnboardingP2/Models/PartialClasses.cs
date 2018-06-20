using System;
using System.ComponentModel.DataAnnotations;

namespace ICOnboardingP2.Models
{
    [MetadataType(typeof(CustomerMetadata))]
    public partial class Customer
    {
    }

    [MetadataType(typeof(ProductMetadata))]
    public partial class Product
    {
    }

    [MetadataType(typeof(StoreMetadata))]
    public partial class Store
    {
    }

    [MetadataType(typeof(ProductSoldMetadata))]
    public partial class ProductSold
    {
    }
}