namespace CopyingObjects_Challenge
{
    public class AddressModel : ICloneable
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public AddressModel()
        {

        }

        public AddressModel(AddressModel adress)
        {
            StreetAddress = adress.StreetAddress;
        }

        public object Clone()
        {
            return new AddressModel(this);
        }
    }
}
