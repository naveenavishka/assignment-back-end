using System;
using System.Collections.Generic;

namespace assignment.Models;

public partial class SaleDetail
{
    public int Id { get; set; }

    public int SalesId { get; set; }

    public int? ProductId { get; set; }

    public int? Qty { get; set; }

    public decimal? PriceItem { get; set; }

    public decimal? Total { get; set; }
}
