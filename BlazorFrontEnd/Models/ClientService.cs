namespace BlazorFrontEnd.Models
{
    public class ClientService
    {
        public int IdClient { get; set; }
        public string? Surname { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? City { get; set; }
        public string? Interest { get; set; }
        public string? Gender { get; set; }
        public bool HasPair { get; set; }
    }
}
