using PharmaVisitApp.Api.Domain.Interfaces;

namespace PharmaVisitApp.Api.Domain.Entities
{
    public class MenuItem : IAuditUser
    {
        private MenuItem()
        {

        }

        #region Propreties
        public Guid Id { get; private set; }
        public string Action { get; private set; }
        public string Controller { get; private set; }
        public string Area { get; private set; }
        public string Path { get; private set; }
        public string CssIcon { get; private set; }
        public int Order { get; private set; }
        public Guid ProfileId { get; private set; }
        public string Title { get; private set; }
        public int? TagNumber { get; private set; }
        public string? TagTitle { get; private set; }

        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public string? ModifiedBy { get; set; }
        #endregion
    }
}
