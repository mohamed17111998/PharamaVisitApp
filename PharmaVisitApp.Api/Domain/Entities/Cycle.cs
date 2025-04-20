using PharmaVisitApp.Api.Domain.Interfaces;

namespace PharmaVisitApp.Api.Domain.Entities
{
    public class Cycle : IAuditUser
    {
        private Cycle()
        {

        }
        public Cycle(string nom, DateOnly dateDebut, DateOnly dateFin, int nbrSemaine, string username)
        {
            Id = Guid.NewGuid();
            DateDebut = dateDebut;
            DateFin = dateFin;
            NbrSemaine = nbrSemaine;
            Nom = nom;
            
            // Audit
            CreatedAt = DateTime.Now;
            CreatedBy = username;
            ModifiedAt = DateTime.Now;
            ModifiedBy = username;
        }

        #region Propreties
        public Guid Id { get; private set; }
        public string Nom { get; private set; }
        public DateOnly DateDebut { get; private set; }
        public DateOnly DateFin { get; private set; }
        public int? NbrSemaine { get; private set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public string? ModifiedBy { get; set; }
        #endregion
    }
}
