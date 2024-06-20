using Contracts;
using MassTransit;

namespace loggerservice;

public class ErrorCreatedConsumer : IConsumer<ErrorCreated>
{
    public async Task Consume(ConsumeContext<ErrorCreated> context)
    {
        Console.WriteLine("New error created");
    }
}