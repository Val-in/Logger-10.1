using Task._2.Interfaces;
using Task._2.Worker;

namespace Task._2.Workers
{
    public class Worker1 : IWorker
    {
        ILogger _logger { get; } //здесь сначала пусто, get; позволяет не менять переменную после инициализации, иначе логика работы может поломаться

        public Worker1(ILogger logger) //передаем переменную типа ILogger, то есть фактически присваеваем _logger значение 
        {
            _logger = logger; //устанавливаем значение, даем доступ к интерфейсу, если его сюда не проставить, будет отсутствовать значение
        }

        public void Work()
        {
            _logger.Event("Worker 1 started");
            Thread.Sleep(3000);
            _logger.Event("Worker 1 stopped");
        }
    }
}
