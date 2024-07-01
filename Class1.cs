using Task2;

namespace Task2
{
    public class Worker1 : IWorker
    {
        private readonly ILogger _logger;

        public Worker1(ILogger logger)
        {
            _logger = logger;
        }

        public void Work()
        {
            _logger.Event("Worker 1 started");
            Thread.Sleep(3000);
            _logger.Event("Worker 1 stopped");
        }
    }

    public class Worker2 : IWorker
    {
        private readonly ILogger _logger;

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
