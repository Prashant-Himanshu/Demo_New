using Application1;
using Application2;

namespace Demo_New
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is first version before pushing on git");
            Console.WriteLine("First Change in Main Method");

            Application1.Class1 c = new Application1.Class1();
            c.Display();



        }
    }
}
