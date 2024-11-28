using MediatR;

namespace Test.WebApi.Controllers;

public record Entity(Guid Id,string Name):INotification;
public class EntityHandler : INotificationHandler<Entity>
{
    public Task Handle(Entity notification, CancellationToken cancellationToken)
    {
        Console.WriteLine($"{notification.Id}-{notification.Name}");
        return Task.CompletedTask;
    }
}
