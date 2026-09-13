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

            Application2.Class1 obj2 = new Application2.Class1();
            obj2.Display();


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("This new added line for newbranch Line number 19");
               

            }



        }
    }
}
