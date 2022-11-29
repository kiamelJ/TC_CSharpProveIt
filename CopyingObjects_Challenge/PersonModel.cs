namespace CopyingObjects_Challenge
{
    public class PersonModel : ICloneable
    {
        AddressModel address = new AddressModel();

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<AddressModel> Addresses { get; set; } = new List<AddressModel>();

        public PersonModel()
        {

        }

        public PersonModel(PersonModel person)
        {
            FirstName = person.FirstName;
            LastName = person.LastName;
            DateOfBirth = person.DateOfBirth;
            Addresses = (AddressModel)person.Addresses.;
        }

        public object Clone()
        {
            return new PersonModel(this);
        }
    }
}
