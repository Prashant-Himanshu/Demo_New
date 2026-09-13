namespace Demo_New
{
    internal class Program
    {
        static void Main(string[] args)
        {





            Console.WriteLine("Application Started");
            Console.WriteLine("Welcome to Git Practice");

            string name = "Prashant";
            int age = 30;
            string city = "Pune";

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"City: {city}");

            int number1 = 10;
            int number2 = 20;

            int sum = number1 + number2;
            int difference = number2 - number1;
            int multiplication = number1 * number2;

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Multiplication: {multiplication}");

            if (age >= 18)
            {
                Console.WriteLine("User is an adult");
            }
            else
            {
                Console.WriteLine("User is a minor");
            }

            Console.WriteLine("Main branch change 1");
            Console.WriteLine("Main branch change 2");
            Console.WriteLine("Main branch change 3");
            Console.WriteLine("Main branch change 4");
            Console.WriteLine("Main branch change 5");

            Console.WriteLine("Calculating result...");

            int result = sum + multiplication;

            Console.WriteLine($"Final Result: {result}");

            Console.WriteLine("Main branch completed");
            Console.WriteLine("Application Finished");

            /*________________________________________________*/

            //I am going to create conflict in when you will merge me with main branch lets check.
        }
    }




}