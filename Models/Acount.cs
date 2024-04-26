using System;
using System.Collections.Generic;

namespace Lab5.Models;

public partial class Acount
{
    public int Id { get; set; }

    public string? Fullname { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public DateOnly? Dod { get; set; }

    public string? Gender { get; set; }

    public string? Status { get; set; }

    public int? Role { get; set; }
}
