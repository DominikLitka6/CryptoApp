using CryptoApp.Services;
using Microsoft.Extensions.Logging;

namespace CryptoApp
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
                })
                  .RegisterViewModels()
                  .RegisterAppServices()
                  .RegisterViews();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }

        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddTransient<ViewModels.CryptoDetailsViewModel>();
            mauiAppBuilder.Services.AddTransient<ViewModels.CryptoListViewModel>();
            mauiAppBuilder.Services.AddTransient<ViewModels.MainPageViewModel>();

            return mauiAppBuilder;
        }

        public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddTransient<Views.CryptoDetailsView>();
            mauiAppBuilder.Services.AddTransient<Views.CryptoListView>();
            mauiAppBuilder.Services.AddTransient<Views.MainPage>();

            return mauiAppBuilder;
        }

        public static MauiAppBuilder RegisterAppServices(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<ICryptoApiService, CryptoApiService>();
            
            return mauiAppBuilder;
        }
    }
}
