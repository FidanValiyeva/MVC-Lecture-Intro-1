using Microsoft.Extensions.DependencyInjection;

namespace ToDoApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            var app = builder.Build();
            app.MapGet("/bdu", () => new
            {
                name = "bp215",
                lesson = "mvc"

            });
            app.MapControllerRoute("default","{controller}/{action}");
            app.Run();

        }
    }
}
