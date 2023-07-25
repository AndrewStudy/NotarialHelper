using System;
using System.Collections.Generic;

namespace NotarialHelper;

public partial class Service
{
    public int IdService { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual ICollection<Deal> Deals { get; set; } = new List<Deal>();
}
