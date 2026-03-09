using Microsoft.Extensions.Logging;
using PetRec.Core.Interfaces;
using PetRec.Infrastructure;

namespace PetRec.Mobile;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

        // DI registrations
        builder.Services.AddSingleton<IAppDataPathProvider, MauiAppDataPathProvider>();
        //builder.Services.AddSingleton<IPetDatabase<PetEntity>>(sp =>
        //{
        //    var pathProvider = sp.GetRequiredService<IAppDataPathProvider>();
        //    return new PetDatabase(pathProvider);
        //});

        builder.Services.AddInfrastructure();
        //builder.Services.AddSingleton<IRepository, PetRepository>();  // injects IPetDatabase inside repo
        //builder.Services.AddSingleton<MainPageViewModel>();

        return builder.Build();
    }
}
