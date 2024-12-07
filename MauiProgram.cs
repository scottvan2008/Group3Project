using Microsoft.Extensions.Logging;
using Blazorise;
using Blazorise.Bootstrap.Components;
using Blazorise.Bootstrap;
using Blazorise.Bootstrap5;

namespace OOP2_final_LibrarySystem
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
                });

            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddBlazorise(options => { options.Immediate = true; }).AddBootstrapProviders();
            builder.Services
                .AddBlazorise()
                .AddBootstrapProviders();

#if DEBUG
			builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
