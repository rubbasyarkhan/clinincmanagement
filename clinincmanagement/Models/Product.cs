namespace clinincmanagement.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public string? Category { get; set; }

    public int? Stock { get; set; }

    public decimal Price { get; set; }

    public DateOnly? ExpiryDate { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
