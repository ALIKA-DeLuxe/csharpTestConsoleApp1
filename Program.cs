using System;

namespace Test_ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo ki;
            Console.WriteLine("Press <Enter> to exit.");
            try
            {
                do
                {
                    ki = Console.ReadKey(false);
                    string time = DateTime.Now.ToString();
                    Console.WriteLine("{0}: {1} is sent.", time, ki.ToString());
                } while (ki.Key != ConsoleKey.Enter);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.StackTrace);
            }
        }
    }
}
