using MediatR;
using System.Reflection;

namespace MediatREvent;

public class DomainEvents : IDomainEvents
{
    private readonly List<INotification> DoaminEventList = new();
    private readonly IMediator mediator;

    public DomainEvents(IMediator mediator)
    {
        this.mediator = mediator;
    }
    public List<INotification> GetAllEvents()
    {
        return DoaminEventList;
    }
    public void AddEvent(INotification item)
    {
        var ass = Assembly.GetEntryAssembly()?.GetModules();
        DoaminEventList.Add(item);
    }
    public void AddEventIfNoExist(INotification item)
    {
        if (!DoaminEventList.Contains(item))
        {
            DoaminEventList.Add(item);
        }
    }
    public void ClearAllEvents()
    {
        DoaminEventList.Clear();
    }
    public void Publish()
    {
        foreach (var domainEvent in DoaminEventList)
        {
            mediator.Publish(domainEvent);
        }
    }
}
