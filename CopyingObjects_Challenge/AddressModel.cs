namespace CopyingObjects_Challenge
{
    public class AddressModel
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public AddressModel()
        {

        }

        public AddressModel(AddressModel addressToCopy)
        {
            StreetAddress = addressToCopy.StreetAddress;
            City = addressToCopy.City;
            State = addressToCopy.State;
            ZipCode = addressToCopy.ZipCode;
        }
    }
}
