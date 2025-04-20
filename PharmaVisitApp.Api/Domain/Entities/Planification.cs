using PharmaVisitApp.Api.Domain.Interfaces;

namespace PharmaVisitApp.Api.Domain.Entities
{
    public class Planification : IAuditUser
    {
        private Planification()
        {

        }
        public Planification(Guid userId, Guid pharmacieId, Guid? cycleId, int? semaine, string username)
        {
            Id = Guid.NewGuid();
            UserId = userId;
            PharmacieId = pharmacieId;
            CycleId = cycleId;
            Semaine = semaine;

            // Audit
            CreatedAt = DateTime.Now;
            CreatedBy = username;
            ModifiedAt = DateTime.Now;
            ModifiedBy = username;
        }

        #region Propreties
        public Guid Id { get; private set; }
        public Guid UserId { get; private set; }
        public Guid PharmacieId { get; private set; }
        public Guid? CycleId { get; private set; }
        public int? Semaine { get; private set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public string? ModifiedBy { get; set; }
        #endregion
    }
}
