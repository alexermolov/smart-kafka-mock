using Smart.Kafka.Mock.Core;

namespace Smart.Kafka.Mock.BackgroundServices
{
    public class TestBackgroundWorker : BackgroundService
    {
        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            new Test().Transform();
            return Task.CompletedTask;
        }
    }
}
