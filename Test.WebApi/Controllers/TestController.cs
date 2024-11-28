using MediatREvent;
using Microsoft.AspNetCore.Mvc;

namespace Test.WebApi.Controllers;
[ApiController]
[Route("[controller]/[action]")]
public class TestController:ControllerBase
{
    private readonly IDomainEvents events;

    public TestController(IDomainEvents events)
    {
        this.events = events;
    }
    [HttpGet]
    public async Task<IActionResult> TestAsync()
    {
        events.AddEvent(new Entity(Guid.NewGuid(),"HelloWorld!"));
        events.Publish();
        return Ok();
    }
}
