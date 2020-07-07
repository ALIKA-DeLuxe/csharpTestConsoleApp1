using System;

namespace Test_ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyInfo;
            Console.WriteLine("Press <Enter> to exit.");
            try
            {
                do
                {
                    keyInfo = Console.ReadKey(false);
                    var time = DateTime.Now.ToString();
                    Console.WriteLine("{0}: {1} is sent.", time, keyInfo.Key.ToString());
                } while (keyInfo.Key != ConsoleKey.Enter);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.StackTrace);
            }
            finally
            {
                Console.WriteLine("\nHit return key.");
                Console.Read();
            }
        }
    }
}
