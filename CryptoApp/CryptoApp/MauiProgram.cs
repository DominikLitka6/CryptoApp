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
                    fonts.AddFont("Rubik-Regular.ttf", "RubikRegular");
                    fonts.AddFont("Rubik-RegularItalic.ttf", "RubikRegularItalic");
                    fonts.AddFont("Rubik-Medium.ttf", "RubikMedium");
                    fonts.AddFont("Rubik-MediumItalic.ttf", "RubikMediumItalic");
                    fonts.AddFont("Rubik-Light.ttf", "RubikLight");
                    fonts.AddFont("Rubik-LightItalic.ttf", "RubikLightItalic");
                    fonts.AddFont("Rubik-Black.ttf", "RubikBlack");
                    fonts.AddFont("Rubik-BlackItalic.ttf", "RubikBlackItalic");
                    fonts.AddFont("Rubik-Bold.ttf", "RubikBold");
                    fonts.AddFont("Rubik-BoldItalic.ttf", "RubikBoldItalic");
                    fonts.AddFont("Rubik-SemiBold.ttf", "RubikSemiBold");
                    fonts.AddFont("Rubik-SemiBoldItalic.ttf", "RubikSemiBoldItalic");
                    fonts.AddFont("Rubik-ExtraBold.ttf", "RubikExtraBold");
                    fonts.AddFont("Rubik-ExtraBoldItalic.ttf", "RubikExtraBoldItalic");
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
            mauiAppBuilder.Services.AddSingleton<IDatabaseService, DatabaseService>();
            
            return mauiAppBuilder;
        }
    }
}
