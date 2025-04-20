using PharmaVisitApp.Api.Domain.Interfaces;

namespace PharmaVisitApp.Api.Domain.Entities
{
    public class Pharmacie : IAuditUser
    {
        private Pharmacie()
        {

        }
        public Pharmacie(string nomPharmacie, string nomPharmacien, string prenomPharmacien, Guid geoId, string? tel, string? adresse, int? potentiel, string username)
        {
            Id = Guid.NewGuid();
            NomPharmacie = nomPharmacie;
            NomPharmacien = nomPharmacien;
            PrenomPharmacien = prenomPharmacien;
            GeoId = geoId;
            Tel = tel;
            Adresse = adresse;
            Potentiel = potentiel;

            // Audit
            CreatedAt = DateTime.Now;
            CreatedBy = username;
            ModifiedAt = DateTime.Now;
            ModifiedBy = username;
        }

        #region Propreties
        public Guid Id { get; private set; }
        public string NomPharmacie { get; private set; }
        public string NomPharmacien { get; private set; }
        public string PrenomPharmacien { get; private set; }
        public Guid? GeoId { get; private set; }
        public string? Tel { get; private set; }
        public string? Adresse { get; private set; }
        public int? Potentiel { get; private set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public string? ModifiedBy { get; set; }
        #endregion
    }
}
