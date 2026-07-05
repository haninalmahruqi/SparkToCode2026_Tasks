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


            //problem2: Rectangle Calculator
            Console.WriteLine("Enter length: ");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter width: ");
            double width = double.Parse(Console.ReadLine());

            double area = length * width;
            double perimeter = 2 * (length + width);

            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter);




            //problem3: Even or Odd Checker
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0) Console.WriteLine("Even");
            else Console.WriteLine("Odd");























        }
    }
}
