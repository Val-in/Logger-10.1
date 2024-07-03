using Task._2.Interfaces;
using Task._2.Worker;

namespace Task._2.Workers
{
    public class Worker3 : IWorker
    {
        private readonly ILogger _logger;

        public Worker3(ILogger logger)
        {
            _logger = logger;
        }

        public void Work()
        {
            _logger.Event("Worker 3 started");
            Thread.Sleep(3000);
            _logger.Event("Worker 3 stopped");
        }
    }
}
