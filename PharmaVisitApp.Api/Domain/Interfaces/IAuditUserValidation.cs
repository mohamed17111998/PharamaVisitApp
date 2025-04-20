namespace PharmaVisitApp.Api.Domain.Interfaces
{
    public interface IAuditUserValidation
    {
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ValidatedAt { get; set; }
        public string? ValidatedBy { get; set; }
    }
}
