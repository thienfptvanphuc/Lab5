using System;
using System.Collections.Generic;

namespace Lab5.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public byte[]? Image { get; set; }

    public string? Des { get; set; }

    public double? Price { get; set; }

    public int? IdCate { get; set; }

    public DateOnly? Date { get; set; }

    public int? Status { get; set; }
}
