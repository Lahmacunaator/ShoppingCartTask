using CartApi.Entities;

namespace CartApi.Models;

public class GetCartModel(List<Item> items)
{
    public List<Item> Items { get; set; } = items;
}