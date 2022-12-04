namespace CopyingObjects_Challenge
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<AddressModel> Addresses { get; set; } = new List<AddressModel>();

        public PersonModel()
        {

        }

        public PersonModel(PersonModel personToCopy)
        {
            FirstName = personToCopy.FirstName;
            LastName = personToCopy.LastName;
            DateOfBirth = personToCopy.DateOfBirth;
            foreach (var originalAddress in personToCopy.Addresses)
            {
                var newAdress = new AddressModel(originalAddress);
                Addresses.Add(newAdress);
            }
        }
    }
}
