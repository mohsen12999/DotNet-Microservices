using CommandsService.Models;
using CommandsService.SyncDataServices.Grpc;

namespace CommandsService.Data;

public class PrepDb
{
    public static void PrepPopulation(IApplicationBuilder applicationBuilder)
    {
        using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
        {
            var gprcClient = serviceScope.ServiceProvider.GetService<IPlatformDataClient>();

            var platform = gprcClient.ReturnAllPlatforms();

            SeedData(serviceScope.ServiceProvider.GetService<ICommandRepo>(), platform );
        }
    }

    private static void SeedData(ICommandRepo repo, IEnumerable<Platform> platforms)
    {
        Console.WriteLine("--> Seeding new platforms...");

        foreach (var plat in platforms)
        {
            if(!repo.ExternalPlatformExist(plat.ExternalId))
            {
                repo.CreatePlatform(plat);
            }
            repo.SaveChanges();
        }
    }
}