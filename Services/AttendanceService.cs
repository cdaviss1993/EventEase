namespace EventEase.Services
{
    public class AttendanceService
    {
        private readonly List<(string EventName, string UserName, string Email)> _attendees = new();

        public void Register(string eventName, string userName, string email)
        {
            _attendees.Add((eventName, userName, email));
        }

        public IEnumerable<string> GetAttendeesForEvent(string eventName)
        {
            return _attendees
                .Where(a => a.EventName == eventName)
                .Select(a => $"{a.UserName} ({a.Email})");
        }
    }
}