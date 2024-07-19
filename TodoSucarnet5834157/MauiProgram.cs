using Microsoft.Extensions.Logging;
using TodoSucarnet5834157.Data;
using TodoSucarnet5834157.Views;

namespace TodoSucarnet5834157
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
            builder.Services.AddSingleton<TodoListPage>();
            builder.Services.AddTransient<TodoItemPage>();

            builder.Services.AddSingleton<TodoItemDatabase>();
            return builder.Build();
        }
    }
}
