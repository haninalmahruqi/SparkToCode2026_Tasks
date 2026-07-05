namespace SolveTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////Task 1 – Absolute Difference

            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double difference = Math.Abs(num1 - num2);

            Console.WriteLine("Positive Difference: " + difference);



            ///////////////////////////////////////////////////////////////
            ///


            /////Task 2 – Power & Root Explorer


            Console.Write("Enter a number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Square: " + Math.Pow(number, 2));
            Console.WriteLine("Square Root: " + Math.Sqrt(number));


            ////////////////////////////////////////////////////////////////
            ///


            ///Task 3 – Name Formatter
            ///

            Console.Write("Enter your full name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Uppercase: " + name.ToUpper());
            Console.WriteLine("Lowercase: " + name.ToLower());
            Console.WriteLine("Characters: " + name.Length);

            ///////////////////////////////////////////////////////////////
            ///

            ///Task 4 – Subscription End Date
            ///


            Console.Write("Enter free trial days: ");
            int days = Convert.ToInt32(Console.ReadLine());

            DateTime endDate = DateTime.Today.AddDays(days);

            Console.WriteLine("End Date: " + endDate.ToString("yyyy-MM-dd"));

            ///////////////////////////////////////////////////////////////
            ///

















































        }
    }
}
