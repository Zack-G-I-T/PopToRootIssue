using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace ModalPopToRootIssue
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            Routing.RegisterRoute("SecondPage", typeof(SecondPage));
            builder.Services.AddTransient<SecondPage>();
            Routing.RegisterRoute("ThirdPage", typeof(ThirdPage));
            builder.Services.AddTransient<ThirdPage>();
            Routing.RegisterRoute("FourthPage", typeof(FourthPage));
            builder.Services.AddTransient<FourthPage>();
            Routing.RegisterRoute("FifthPage", typeof(FifthPage));
            builder.Services.AddTransient<FifthPage>();
            Routing.RegisterRoute("SixthPage", typeof(SixthPage));
            builder.Services.AddTransient<SixthPage>();
            Routing.RegisterRoute("SeventhPage", typeof(SeventhPage));
            builder.Services.AddTransient<SeventhPage>();
            Routing.RegisterRoute("EighthPage", typeof(EighthPage));
            builder.Services.AddTransient<EighthPage>();
            Routing.RegisterRoute("NinthPage", typeof(NinthPage));
            builder.Services.AddTransient<NinthPage>();
            Routing.RegisterRoute("TenthPage", typeof(TenthPage));
            builder.Services.AddTransient<TenthPage>();
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
