namespace PharmaVisitApp.Api.Entities.Entities
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
        public Guid Id { get; private set; }
        public string Reference { get; private set; }
        public string Label { get; private set; }
    }
}
