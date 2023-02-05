namespace Generics_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            List<string> maleList = new List<string>();
            maleList.Add("Tom");
            maleList.Add("John");
            maleList.Add("Lukas");
            maleList.Add("Kalle");
            maleList.Add("Nils");
            maleList.Add("Petter");


            List<string> femaleList = new List<string>
            {
                "Jennifer",
                "Sue",
                "Ellen",
                "Mary"
            };

            var hej = MergeLists(maleList, femaleList);

            foreach (var item in hej)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }

        // TC solution. Fortsätt och gå igenom exakt vad den här koden gör så du 
        // greppar det lite iaf.
        private static List<T> MergeLists<T>(List<T> list1, List<T> list2)
        {
            List<T> output = new List<T>();
            List<T> biggerList;
            List<T> smallerList;

            if (list1.Count > list2.Count)
            {
                biggerList = list1;
                smallerList = list2;
            }
            else
            {
                biggerList=list2;
                smallerList=list1;
            }

            int smallerCount = smallerList.Count;

            for (int i = 0; i < biggerList.Count; i++)
            {
                output.Add(biggerList[i]);

                if (i < smallerCount)
                {
                    output.Add(smallerList[i]);
                }
            }

            return output;
        }

        // Mitt försök. Det blev knas där med inparametrarna för jag kunde inte
        // använda count på dom och då visste jag inte hur jag skulle kunna gå vidare.

        //private static List<T> GenericMethod<T, U>(T maleList, U femaleList)
        //{
        //    var maleListLength = maleList.ToString().Count();
        //    var femaleListLength = femaleList.ToString().Count();
        //    var intermixed = new List<T>();

        //    int i = 0;
        //    int j = 0;

        //    while (i < maleListLength && j < femaleListLength)
        //    {
        //        intermixed.Add(maleList[i]);
        //    }


        //    return Outputter;
        //}

        
      
        
    }
}