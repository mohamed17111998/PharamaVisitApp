namespace PharamaVisitApp.Models
{
    public class UserLoginDto
    {
        public string Token { get; set; }
        public required bool Success { get; set; }
        public required string Message { get; set; }
    }
}
