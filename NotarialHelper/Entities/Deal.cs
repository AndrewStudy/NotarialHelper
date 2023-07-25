namespace NotarialHelper;

public partial class Deal
{
    public int? IdDeal { get; set; }

    public int? IdClient { get; set; }

    public int? IdService { get; set; }

    public string? Sum { get; set; } = null!;

    public string? Commission { get; set; } = null!;

    public string? Description { get; set; }

    public virtual Client IdClientNavigation { get; set; } = null!;

    public virtual Service IdServiceNavigation { get; set; } = null!;
}
