namespace PharmaVisitApp.Api.Entities.Interfaces
{
    public interface IAuditUser
    {
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
