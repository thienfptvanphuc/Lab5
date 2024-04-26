using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Lab5.Models;

public partial class Category
{
    public int Id { get; set; }

    [Required]
    public string? Name { get; set; }

    public string? Slug { get; set; }

    public string? Des { get; set; }

    public int? Status { get; set; }
}
