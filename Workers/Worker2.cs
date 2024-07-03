using Task._2.Interfaces;
using Task._2.Worker;

namespace Task._2.Workers
{
    public class Worker2 : IWorker
    {
        ILogger _logger; // просто объявление, его можно поменять где угодно в таком виде, нарушаются принципы инкапсуляции

        public Worker2(ILogger logger)
        {
            _logger = logger;
        }

        public void Work()
        {
            _logger.Event("Worker 2 started");
            Thread.Sleep(3000);
            _logger.Event("Worker 2 stopped");
        }
    }
}
