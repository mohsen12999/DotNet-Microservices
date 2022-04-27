using System.Text;
using System.Text.Json;
using PlatformService.Dtos;

namespace PlatformService.SyncDataServices.Http;

public class HttpCommandDataClient : ICommandDataClient
{
    private readonly HttpClient _httpClient;

    public HttpCommandDataClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public async Task SendPlatformToCommand(PlatformReadDto plat)
    {
        var httpContent = new StringContent(
            JsonSerializer.Serialize(plat),
            Encoding.UTF8,
            "application/json");

        var response = await _httpClient.PostAsync("http://localhost:6000/api/c/platforms", httpContent);

        if(response.IsSuccessStatusCode)
        {
            Console.WriteLine("--> Sync Post to Command service was OK");
        }
        else
        {
            Console.WriteLine("--> Sync Post to Command service was Not OK");
        }
    }
}