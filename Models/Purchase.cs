using System;
using System.Collections.Generic;

namespace assignment.Models;

public partial class Purchase
{
    public int Id { get; set; }

    public int? ProductId { get; set; }

    public decimal? PurchasePrice { get; set; }

    public DateOnly? PurchaseDate { get; set; }

    public int? Qty { get; set; }
}
