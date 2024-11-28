using MediatR;

namespace MediatREvent;

public interface IDomainEvents
{
    List<INotification> GetAllEvents();
    void AddEvent(INotification item);
    void AddEventIfNoExist(INotification item);
    void ClearAllEvents();
    void Publish();
}
