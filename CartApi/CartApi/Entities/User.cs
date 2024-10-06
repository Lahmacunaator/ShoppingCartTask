using System.ComponentModel.DataAnnotations;

namespace CartApi.Entities;

public class User
{
    public int Id { get; set; }
    [MaxLength(20)]
    public required string Username { get; set; }
    [MaxLength(30)]
    public required string Password { get; set; }
}