using System;
namespace StopWatchApp
{
    class Program
    {
        static void Main(string[] args) 
        {
            var stopwatch = new Stopwatch();
     
            Console.WriteLine(@"Type 'start' to start the stopwatch, 'stop' to stop it or ''quit' to close the program");

            var input = Console.ReadLine().ToLower();

            while (true)
            {
                if (input == "start")
                {
                    stopwatch.Start();
                    Console.WriteLine(@"Type 'stop' to stop the stopwatch or 'quit' to close the program");
                    input = Console.ReadLine();
                }
                else if (input == "stop")
                {
                    stopwatch.Stop();
                    var duration = stopwatch.Duration();
                    Console.WriteLine("The duration was {0}", duration);
                    Console.WriteLine(@"Type 'start'  to restart or 'quit' to end the program");
                    input = Console.ReadLine();           
                }
                else if (input == "quit")
                {             
                 break;
                }
            }
        }
    }
}
