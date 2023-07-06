using Shop.Model;

namespace Shop.Core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
            
            builder.Services.AddTransient<ICategories, Categories>();
            builder.Services.AddTransient<ICars, Cars>();
            builder.Services.AddMvc(option => option.EnableEndpointRouting = false);
            
            WebApplication app = builder.Build();
            app.MapGet("/", () => "Hello World!");
            app.UseMvc(routes => routes.MapRoute("Default", "{controller=Home}/{action=Index}/{id?}"));
            app.Run();
        }
    }
}