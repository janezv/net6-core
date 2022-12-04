using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Parent
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public virtual ICollection<Child> Children { get; } = new List<Child>();
}
