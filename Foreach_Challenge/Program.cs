namespace Foreach_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persons> persons = GetPersonNames();


            foreach (var item in persons)
            {
                Console.WriteLine($"First name: {item.FirstName}. Last name: {item.LastName}");
            }

            Console.ReadLine();
        }

        internal static List<Persons> GetPersonNames()
        {
            List<Persons> persons = new List<Persons>();
            persons.Add(new Persons { FirstName = "Tim", LastName = "Corey" });
            persons.Add(new Persons { FirstName = "Mike", LastName = "Jones" });
            persons.Add(new Persons { FirstName = "Sue", LastName = "Storm" });
            persons.Add(new Persons { FirstName = "Super", LastName = "Man" });

            return persons;
        }
    }
}