namespace StudentPortalSystem.Models.ViewModels
{
    public class AdminUserViewModel
{
    public string Id { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public List<string> Roles { get; set; } = new();

    public bool IsActive { get; set; }  // optional, for locking users
}
}

