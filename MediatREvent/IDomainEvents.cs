using MediatR;

namespace MediatREvent;

public interface IDomainEvents
{
    void AddEvent(INotification item); 
    void AddEventIfNoExist(INotification item);
    Task PublishAsync(INotification item);
    Task PublishAsync<T>();
    Task PublishAllAsync();
}
