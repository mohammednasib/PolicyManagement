namespace PolicyManagement.Models;

public class User
{
    public required string Username { get; set; }
    public required string Password { get; set; }
    public required string Name { get; set; }
    public required string UserId { get; set; }
    public required List<string> Roles { get; set; }
    public required List<string> Permissions { get; set; }
}