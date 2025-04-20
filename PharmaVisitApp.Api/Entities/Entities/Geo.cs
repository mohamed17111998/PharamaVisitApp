using PharmaVisitApp.Api.Entities.Interfaces;

namespace PharmaVisitApp.Api.Entities.Entities
{
    public class Geo : IAuditUser
    {
         private Geo(){}
        public Geo(string ug, string codeIms, string ugims)
        {
            Id = Guid.NewGuid();
            UG = ug;
            CodeIMS = codeIms;
            UGIMS = ugims;      
            Users = new List<User>();
        }
        public Guid Id { get; private set; }
        public string UG { get; private set; }
        public string CodeIMS { get; private set; }
        public string UGIMS { get; private set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public string? ModifiedBy { get; set; }
        public ICollection<User> Users { get; private set; }
    }
}
