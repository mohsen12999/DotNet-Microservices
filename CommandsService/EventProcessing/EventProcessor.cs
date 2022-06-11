using System.Text.Json;
using AutoMapper;
using CommandsService.Dtos;

namespace CommandsService.EventProcessing;
public class EventProcessor : IEventProcessor
{
    private readonly IServiceScopeFactory _scopeFactory;
    private readonly IMapper _mapper;

    public EventProcessor(IServiceScopeFactory scopeFactory, IMapper mapper)
    {
        _scopeFactory = scopeFactory;
        _mapper = mapper;
    }

    public void ProcessEvent(string message)
    {
        throw new NotImplementedException();
    }

    private EventType DetermineEvent(string notificationEvent)
    {
        Console.WriteLine("--> Determining Event");
        var eventType = JsonSerializer.Deserialize<GenericEventDto>(notificationEvent);

        switch (eventType.Event)
        {
            case "Platform_Published":
                Console.WriteLine("--> Platform Published Event Detected.");
                return EventType.PlatformPublished;
            default:
                Console.WriteLine("--> Could not determine event type.");
                return EventType.Undetermined;
        }
    }
}

enum EventType
{
    PlatformPublished,
    Undetermined
}