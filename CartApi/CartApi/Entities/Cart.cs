namespace CartApi.Entities;

public class Cart
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public DateTimeOffset ChangedAt { get; set; }
    
    public ICollection<CartItem> CartItems { get; set; }
}