using DemoApp.Handlers;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.PlatformConfiguration;


namespace Barbearia
{

    public static class MauiProgram
    {

        public static MauiApp CreateMauiApp()
        {
            FormHandler.RemoveBorders();
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

            return builder.Build();
        }
    }
}
