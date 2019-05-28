using System;
namespace GitTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            p.TestFunction2();
            p.TestFunction();
        }

        private void TestFunction()
        {
        }

        private void TestFunction2()
        {
        }
    }
}