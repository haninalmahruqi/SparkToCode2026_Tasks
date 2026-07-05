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




            ///Task 5 – Grade Rounding System
            ///


            Console.Write("Enter exam score: ");
            double score = Convert.ToDouble(Console.ReadLine());

            double rounded = Math.Round(score);

            Console.WriteLine("Rounded Score: " + rounded);

            if (rounded >= 60)
                Console.WriteLine("Pass");
            else
                Console.WriteLine("Fail");

            //////////////////////////////////////////////////////////////
            ///



            ///Task 6 – Password Strength Checker
            ///

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (password.Length >= 8 && !password.ToLower().Contains("password"))
            {
                Console.WriteLine("Strong Password");
            }
            else
            {
                Console.WriteLine("Weak Password");

                if (password.Length < 8)
                    Console.WriteLine("Reason: Less than 8 characters");

                if (password.ToLower().Contains("password"))
                    Console.WriteLine("Reason: Contains the word 'password'");
            }


            ///////////////////////////////////////////////////////////////////
            ///


            ///Task 7 – Clean Name Comparator
            ///

            Console.Write("Enter first name: ");
            string name1 = Console.ReadLine().Trim().ToUpper();

            Console.Write("Enter second name: ");
            string name2 = Console.ReadLine().Trim().ToUpper();

            if (name1 == name2)
                Console.WriteLine("Match");
            else
                Console.WriteLine("No Match");

            ////////////////////////////////////////////////////////////////
            ///

            ///Task 8 – Membership Expiry Checker
            ///

            try
            {
                Console.Write("Enter membership start date (yyyy-MM-dd): ");
                DateTime startDate = DateTime.Parse(Console.ReadLine());

                Console.Write("Enter membership days: ");

                DateTime expiry = startDate.AddDays(Convert.ToInt32(Console.ReadLine()));

                if (expiry >= DateTime.Today)
                    Console.WriteLine("Active");
                else
                    Console.WriteLine("Expired");

                Console.WriteLine("Expiry Date: " + expiry.ToString("yyyy-MM-dd"));
            }
            catch
            {
                Console.WriteLine("Invalid input.");
            }


            ///////////////////////////////////////////////////////////////////////////////
            ///




            ///Task 9 – Round Up / Round Down Explorer 
            ///


            Console.Write("Enter decimal number: ");
            _ = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nearest: " + Math.Round(number));
            Console.WriteLine("Round Up: " + Math.Ceiling(number));
            Console.WriteLine("Round Down: " + Math.Floor(number));

            ////////////////////////////////////////////////////////////////
            ///


            ///Task 10 – Word Position Finder
            ///

            Console.Write("Enter sentence: ");
            string sentence = Console.ReadLine();

            Console.Write("Enter word: ");
            string word = Console.ReadLine();

            int first = sentence.IndexOf(word);
            int last = sentence.LastIndexOf(word);

            if (first == -1)
            {
                Console.WriteLine("Word not found");
            }
            else
            {
                Console.WriteLine("First Position: " + first);
                Console.WriteLine("Last Position: " + last);
            }

            ////////////////////////////////////////////////////////////////
            ///



            ///Task 11 – One-Time Password (OTP) Generator
            ///


            ///////////////////////////////////////////////////////////////////////////////
            ///
































        }
    }
}
