using PharmaVisitApp.Api.Entities.Interfaces;

namespace PharmaVisitApp.Api.Entities.Entities
{
    public class User : IAuditUser
    {
        private User()
        {

        }
        public User(string username, string lastName, string firstName, string email, string? phoneNumber, bool? validatedPlan,
            bool? isValidatedPlan, string passwordSalt, string passwordHash, string? adConnect, Guid profileId, Guid? responsableId, bool isActive, List<Geo> geos)
        {
            Id = Guid.NewGuid();
            Username = username;
            LastName = lastName;
            FirstName = firstName;
            Email = email;
            PhoneNumber = phoneNumber;
            ValidatedPlan = validatedPlan;
            IsValidatedPlan = isValidatedPlan;
            PasswordSalt = passwordSalt;
            PasswordHash = passwordHash;
            AdConnect = adConnect;
            ProfileId = profileId;
            ResponsableId = responsableId;
            Geos = geos;
            IsActive = isActive;
        }
        public Guid Id { get; private set; }
        public string Username { get; private set; }
        public string LastName { get; private set; }
        public string FirstName { get; private set; }
        public string Email { get; private set; }
        public string? PhoneNumber { get; private set; }
        public bool? ValidatedPlan { get; private set; }
        public bool? IsValidatedPlan { get; private set; }
        public string PasswordSalt { get; private set; }
        public string PasswordHash { get; private set; }
        public string? AdConnect { get; private set; }
        public Guid ProfileId { get; private set; }
        public Guid? ResponsableId { get; private set; }
        public bool IsActive { get; private set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public string? ModifiedBy { get; set; }
        public ICollection<Geo> Geos { get; private set; }
    }
}
