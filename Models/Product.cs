using System;
using System.Collections.Generic;

namespace assignment.Models;

public partial class Product
{
    public int Id { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal? PurchasePrice { get; set; }

    public decimal SellingPrice { get; set; }

    public string? Description { get; set; }

    public string? Image { get; set; }
}
