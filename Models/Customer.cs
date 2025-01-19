using System;
using System.Collections.Generic;

namespace assignment.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string? CustomerName { get; set; }

    public string? CustomerPhone { get; set; }

    public string? CustomerEmail { get; set; }

    public int? BitActive { get; set; }
}
