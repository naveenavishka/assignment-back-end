using System;
using System.Collections.Generic;

namespace assignment.Models;

public partial class Sale
{
    public int Id { get; set; }

    public int? SalesDate { get; set; }

    public int? DiscountPercentage { get; set; }

    public decimal? Discount { get; set; }

    public decimal? Total { get; set; }

    public decimal? Paid { get; set; }

    public decimal? Balance { get; set; }

    public int? CustomerId { get; set; }
}
