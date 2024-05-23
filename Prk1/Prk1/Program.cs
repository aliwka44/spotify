using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Prk1.Dal;

namespace Prk1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("myDb1")));
            var app = builder.Build();
            app.UseStaticFiles();
            
                app.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Product}/{action=Index}/{id?}"
                );
            
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
