using PharmaVisitApp.Api.Domain.Entities.Enums;
using PharmaVisitApp.Api.Domain.Interfaces;

namespace PharmaVisitApp.Api.Domain.Entities
{
    public class PharmaLog : IAuditUserValidation
    {
        private PharmaLog()
        {

        }

        #region Propreties
        public Guid Id { get; private set; }
        public string CodeX3 { get; private set; }
        public string NomPharmacie { get; private set; }
        public string NomPharmacien { get; private set; }
        public string PrenomPharmacien { get; private set; }
        public Guid? GeoId { get; private set; }
        public string? Tel { get; private set; }
        public string? Adresse { get; private set; }
        public int? Potentiel { get; private set; }
        public Guid? PharmacieId { get; private set; }
        public bool? IsValid { get; private set; }
        public OperationType OperationType { get; private set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ValidatedAt { get; set; }
        public string? ValidatedBy { get; set; }
        #endregion
    }
}
