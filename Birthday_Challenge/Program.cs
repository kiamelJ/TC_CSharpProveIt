namespace Birthday_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skulle nog behöva avsätta mer tid här men känner inte att det här är prio
            // just nu så jag hoppar vidare bland utmaningarna. Återkom om tid finnes.
            // Kort så kan man säga att det är inte exakt så lätt som man tror att räkna ut någons ålder.

            //Console.WriteLine(Age());
            //Console.WriteLine(AgeCalcOne());
            //Console.WriteLine(AgeCalcTwo());
            Console.WriteLine(AgeCalcChatGPT());


            Console.ReadLine();
        }

        static private DateTime YearOfBirth()
        {
            var output = new DateTime(1976, 12, 28);
            return output;
        }

        static private DateTime CurrentDate()
        {
            var output = DateTime.Now;
            return output;
        }

        static private double Age()
        {
            var currentDate = CurrentDate();
            var yearOfBirth = YearOfBirth();
            var output = currentDate.Subtract(yearOfBirth);
            return Math.Round(output.TotalDays);
        }

        static private int AgeCalcOne()
        {
            // This is not correct because it says that I have
            // already had my 47 birthday
            var dob = new DateTime(1976, 12, 28);
            var age = DateTime.Now.Year - dob.Year;
            return age;
        }

        static private int AgeCalcTwo()
        {
            // This gives the right number of years
            var dob = new DateTime(1976, 12, 28);
            var age = (int)((DateTime.Now - dob).TotalDays / 365.242199);
            return age;
        }

        static private int AgeCalcChatGPT()
        {
            var dob = new DateTime(1976, 12, 28);
            var now = DateTime.Now;

            int age = now.Year - dob.Year;
            if (now < dob.AddYears(age))
            {
                age--;
            }
            return age;
        }

    }
}