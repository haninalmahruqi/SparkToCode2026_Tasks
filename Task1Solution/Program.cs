namespace Task1Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //problem1:Personal Info Card
            String name = "Sara";
            int age = 21;
            double height = 1.65;
            bool isStudent = true;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Hight: " + height);
            Console.WriteLine("Student: " + isStudent);



            ////////////////////////////////////////////////
            ///




            //problem2: Rectangle Calculator
            Console.WriteLine("Enter length: ");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter width: ");
            double width = double.Parse(Console.ReadLine());

            double area = length * width;
            double perimeter = 2 * (length + width);

            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter);


            /////////////////////////////////////////
            ///


            //problem3: Even or Odd Checker
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0) Console.WriteLine("Even");
            else Console.WriteLine("Odd");


            //Task 4: Voting Eligibility 



            Console.Write("Enter age: ");

            _ = int.Parse(Console.ReadLine());

            Console.Write("Have valid ID? (yes/no): ");

            bool hasId = Console.ReadLine() == "yes";

            if (age >= 18 && hasId) Console.WriteLine("Eligible to vote.");

            else Console.WriteLine("Not eligible.");



            ////////////////////////////////////////////////////////// 

            ///


            //Task 5: Grade Letter Lookup 



            Console.Write("Enter grade (A/B/C/D/F): ");

            char grade = char.Parse(Console.ReadLine());

            switch (grade)

            {

                case 'A': Console.WriteLine("Excellent"); break;

                case 'B': Console.WriteLine("Very Good"); break;

                case 'C': Console.WriteLine("Good"); break;

                case 'D': Console.WriteLine("Pass"); break;

                case 'F': Console.WriteLine("Fail"); break;

                default: Console.WriteLine("Invalid grade"); break;

            }



            ////////////////////////////////////////////////////////// 

            /// 


            //Task 6: Temperature Converter 



            Console.Write("Enter Celsius: ");

            double c = double.Parse(Console.ReadLine());

            double f = (c * 9 / 5) + 32;

            Console.WriteLine($"Fahrenheit: {f}");

            if (c < 10) Console.WriteLine("Cold");

            else if (c <= 30) Console.WriteLine("Mild");

            else Console.WriteLine("Hot");



            ////////////////////////////////////////////////////////// 

            /// 


















        }
    }
}
