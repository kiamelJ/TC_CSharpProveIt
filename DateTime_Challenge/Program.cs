namespace DateTime_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Basic challenge
            // Calculate how many days ago a input date was
            var dateInput = string.Empty;
            Console.Write("Please enter a date: ");
            dateInput = Console.ReadLine();
            TimeSpan dateDifference = DateTime.Now - Convert.ToDateTime(dateInput);
            Console.WriteLine($"That day was {dateDifference.Days} days ago");
            Console.ReadLine();

            // Calculate how many hours and minutes ago a inpute time was
            var timeInput = string.Empty;
            Console.Write("Please enter a time (hours and minutes): ");
            timeInput = Console.ReadLine();
            var timeDifference = DateTime.Now - Convert.ToDateTime(timeInput);
            Console.WriteLine($"That was {timeDifference.Hours} hours and {timeDifference.Minutes} minutes ago");
            Console.ReadLine();

            //********************************************************************************************************

            // Bonus challenge



        }
    }
}