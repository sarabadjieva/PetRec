using Microsoft.Extensions.DependencyInjection;
using PetRec.Core.Interfaces;
using PetRec.Infrastructure.Repositories;

namespace PetRec.Infrastructure;

public static class InfrastructureServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services)
    {
        services.AddSingleton<IDatabase, SqliteDatabase>();
        services.AddSingleton<IPetRepository, PetRepository>();
        services.AddSingleton<ICalendarRepository, CalendarRepository>();

        return services;
    }
}
