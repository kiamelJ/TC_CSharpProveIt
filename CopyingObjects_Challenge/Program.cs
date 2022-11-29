namespace CopyingObjects_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonModel firstPerson = new PersonModel
            {
                FirstName = "Sue",
                LastName = "Storm",
                DateOfBirth = new DateTime(1998, 7, 19),
                Addresses = new List<AddressModel>
                {
                    new AddressModel
                    {
                        StreetAddress = "101 State Street",
                        City = "Salt Lake City",
                        State = "UT",
                        ZipCode = "76321"
                    },
                    new AddressModel
                    {
                        StreetAddress = "842 Lawrence Way",
                        City = "Jupiter",
                        State = "FL",
                        ZipCode = "22558"
                    }
                }
            };

            // Creates a second PersonModel object
            PersonModel secondPerson = null;



            // Set the value of the secondPerson to be a copy of the firstPerson
            secondPerson = new PersonModel(firstPerson);

            // Update the secondPerson's FirstName to "Bob" 
            // and change the Street Address for each of Bob's addresses
            // to a different value
            secondPerson.FirstName = "Bob";
            secondPerson.Addresses[0].StreetAddress = "Härbrevägen 42";
            

            // Ensure that the following statements are true
            Console.WriteLine($"{firstPerson.FirstName} != {secondPerson.FirstName}");
            Console.WriteLine($"{firstPerson.LastName} == {secondPerson.LastName}");
            Console.WriteLine($"{firstPerson.DateOfBirth.ToShortDateString()} == {secondPerson.DateOfBirth.ToShortDateString()}");
            Console.WriteLine($"{firstPerson.Addresses[0].StreetAddress} != {secondPerson.Addresses[0].StreetAddress}");
            Console.WriteLine($"{firstPerson.Addresses[0].City} == {secondPerson.Addresses[0].City}");
            Console.WriteLine($"{firstPerson.Addresses[1].StreetAddress} != {secondPerson.Addresses[1].StreetAddress}");
            Console.WriteLine($"{firstPerson.Addresses[1].City} == {secondPerson.Addresses[1].City}");

            Console.ReadLine();
        }
    }
}
