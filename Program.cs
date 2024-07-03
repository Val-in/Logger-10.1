using Task._2.Interfaces;
using Task._2.Workers;
using Task._2;

namespace Task2
{
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
