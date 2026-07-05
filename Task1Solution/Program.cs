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



            //Task 7: Movie Ticket Pricing 



            Console.Write("Enter age: ");

            _ = int.Parse(Console.ReadLine());

            if (age <= 12) Console.WriteLine("Child: 2.000 OMR");

            else if (age <= 59) Console.WriteLine("Adult: 5.000 OMR");

            else Console.WriteLine("Senior: 3.000 OMR");



            ///////////////////////////////////////////////////////// 

            /// 


            //Task 8: Restaurant Bill 



            Console.Write("Enter bill: ");

            double bill = double.Parse(Console.ReadLine());

            Console.Write("Member? (yes/no): ");

            bool isMember = Console.ReadLine() == "yes";

            double discount = (bill > 20 && isMember) ? bill * 0.15 : 0;

            Console.WriteLine($"Original: {bill}, Discount: {discount}, Total: {bill - discount}");



            ///////////////////////////////////////////////////////// 

            ///



            //Task 9: Day Name Finder 



            Console.Write("Enter day number (1-7): ");

            int day = int.Parse(Console.ReadLine());

            switch (day)

            {

                case 1: Console.WriteLine("Sunday"); break;

                case 2: Console.WriteLine("Monday"); break;

                // ... add cases 3-7 similarly 

                default: Console.WriteLine("Invalid day number"); break;

            }



            ///////////////////////////////////////////////////////// 

            /// 

            ///From 10 t0 15 i did not do it














































































        }


    }


}





