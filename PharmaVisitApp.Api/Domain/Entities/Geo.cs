using PharmaVisitApp.Api.Domain.Interfaces;

namespace PharmaVisitApp.Api.Domain.Entities
{
    public class Geo : IAuditUser
    {
         private Geo(){}
        public Geo(string ug, int? codeIms, string? ugims)
        {
            Id = Guid.NewGuid();
            UG = ug;
            CodeIMS = codeIms;
            UGIMS = ugims;      
            Users = new List<User>();
        }

        #region Propreties

        public Guid Id { get; private set; }
        public string UG { get; private set; }
        public int? CodeIMS { get; private set; }
        public string? UGIMS { get; private set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public string? ModifiedBy { get; set; }
        public ICollection<User> Users { get; private set; }
        #endregion
    }
}
