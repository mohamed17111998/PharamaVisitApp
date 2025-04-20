namespace PharmaVisitApp.Api.Domain.Entities
{
    public class Profile
    {
        private Profile()
        {

        }
        public Profile(string reference, string label)
        {
            Id = Guid.NewGuid();
            Reference = reference;
            Label = label;
        }

        #region Propreties
        public Guid Id { get; private set; }
        public string Reference { get; private set; }
        public string Label { get; private set; }
        #endregion
    }
}
