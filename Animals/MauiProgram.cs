using Microsoft.Extensions.Logging;

namespace Animals
{
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
            //NOTE: ez a sor nagyon fontos, mert ettől lesz a Maui Appon belül minden oldalon használható ugyanaz az AnimalService
            //későbbiekben ugyanígy lesz használatban DbContext, HttpClient stb...
            builder.Services.AddSingleton<IAnimalService, AnimalService>();

            return builder.Build();
        }
    }
}
