namespace EventEase.Services
{
    public class UserSessionService
    {
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? SelectedEvent { get; set; }

        public bool IsRegistered => !string.IsNullOrWhiteSpace(UserName) && !string.IsNullOrWhiteSpace(Email);
    }
}