using Smart.Kafka.Mock.Core;

namespace Smart.Kafka.Mock.BackgroundServices
{
    public class TestBackgroundWorker : BackgroundService
    {
        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            //consumer.Subscribe(new string[] { "topic1", "topic2" });
            new Test().Transform();
            return Task.CompletedTask;
        }
    }
}
