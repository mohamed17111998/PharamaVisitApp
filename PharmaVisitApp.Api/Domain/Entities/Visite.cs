using PharmaVisitApp.Api.Domain.Interfaces;

namespace PharmaVisitApp.Api.Domain.Entities
{
    public class Visite : IAuditUser
    {
        private Visite()
        {

        }
        public Visite(Guid pharmacieId, DateOnly? dateVisite, bool? pharmacieVu, bool? bonCommande, bool? formationDipensee, bool? remisePlv, int? visiteDouble, 
            Guid userId, Guid? cycleId, int? semaine, string username)
        {
            Id = Guid.NewGuid();
            PharmacieId = pharmacieId;
            DateVisite = dateVisite;
            PharmacieVu = pharmacieVu;
            BonCommande = bonCommande;
            FormationDipensee = formationDipensee;
            RemisePlv = remisePlv;
            VisiteDouble = visiteDouble;
            UserId = userId;
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
        public Guid PharmacieId { get; private set; }
        public DateOnly? DateVisite { get; private set; }
        public bool? PharmacieVu { get; private set; }
        public bool? BonCommande { get; private set; }
        public bool? FormationDipensee { get; private set; }
        public bool? RemisePlv { get; private set; }
        public int? VisiteDouble { get; private set; }
        public Guid UserId { get; private set; }
        public Guid? CycleId { get; private set; }
        public int? Semaine { get; private set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public string? ModifiedBy { get; set; }
        #endregion
    }
}
