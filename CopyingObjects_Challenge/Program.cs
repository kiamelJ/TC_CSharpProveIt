
using Newtonsoft.Json;

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



            // Set the value of the secondPerson to be a copy of the firstPerson (first method)

            // Genom att använda oss av serialization så hämtar vi alla värden från firstPerson
            // i json-format och sedan kör vi deserialization för att konvertera tillbaka värdena
            // till objekt så vi kan arbeta med det. Om man skulle göra som jag gjorde först 
            // (secondPerson = firstPerson) så pekar det bara till samma adress vilket gör att ändringar som
            // görs i ena objektet kommer synas även i andra och det vill vi inte.
            // Sättet nedan fungerar bara om alla props är publika, den tar inte med privata.

            //string tempPerson = JsonConvert.SerializeObject(firstPerson);
            //secondPerson = JsonConvert.DeserializeObject<PersonModel>(tempPerson);

            // ****Det här är en så kallad "deep copy", vilket innebär att den kopierar
            // även nästlade properties (som adressen i det här fallet ****************


            // Set the value of the secondPerson to be a copy of the firstPerson (second method)

            // Ett annat sätt att göra det här är att skapa en konstruktor (i båda klasserna) som
            // sätter värdena. Du har även en tom ctor där men den är bara för att kunna skapa ett objekt
            // utan inpara. Genom konstruktorn så skickar man in firstPerson vilket sätter urpsprungsvärdena
            // som man sedan kan ändra i secondPerson utan att det påverkar originalvärdena. Även detta är en 
            // deep copy

            secondPerson = new PersonModel(firstPerson);


            // Update the secondPerson's FirstName to "Bob" 
            // and change the Street Address for each of Bob's addresses
            // to a different value
            secondPerson.FirstName = "Bob";
            secondPerson.Addresses[0].StreetAddress = "Härbrevägen 42";
            secondPerson.Addresses[1].StreetAddress = "Nyhammar 114";


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
