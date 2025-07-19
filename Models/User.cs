namespace PolicyManagement.Models;

public class User
{
    public string UserId { get; set; }
    public string Name { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public List<string> Roles { get; set; }
    public List<string> Permissions { get; set; }
}
