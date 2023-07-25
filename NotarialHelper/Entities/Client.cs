using System.Collections.Generic;

namespace NotarialHelper;

public partial class Client
{
    public int IdClient { get; set; }

    public string FullName { get; set; } = null!;

    public string KindActivity { get; set; } = null!;

    public string Adress { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public virtual ICollection<Deal> Deals { get; set; } = new List<Deal>();
}
