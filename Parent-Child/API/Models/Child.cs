using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Child
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public DateTime? DateofBirth { get; set; }

    public int ParentId { get; set; }

    public virtual Parent Parent { get; set; } = null!;
}
