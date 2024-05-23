namespace Challenge3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string containing both letters and numbers. I will return the sum of the numbers");
           string myString = Console.ReadLine();

            double sum = 0;
            for (int i = 0;i<myString.Length;i++)
            {
                double number = Char.GetNumericValue(myString, i);
                if (number != -1)
                {
                    sum = sum + number;
                }
             
            }
            Console.WriteLine($"The total of the numeric digits is {sum}");
        }
    }
}
