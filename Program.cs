using System;
using System.Threading;
using static Task2.Program;

namespace Task2
{
    public interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }

    public class Logger : ILogger
    {
        public void Event(string message)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public void Error(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }

    public interface IWorker
    {
        void Work();
    }

    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new Logger();
            var worker1 = new Worker1(logger);
            var worker2 = new Worker2(logger);
            var worker3 = new Worker3(logger);

            worker1.Work();
            worker2.Work();
            worker3.Work();

            Console.WriteLine("All work completed.");
        }
    }
}
