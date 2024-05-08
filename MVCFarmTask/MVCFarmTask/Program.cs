using Microsoft.EntityFrameworkCore;
using MVCFarmTask.DAL;

namespace MVCFarmTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(options =>

            options.UseSqlServer("Server=HUAWEI;Database=FarmDB;Trusted_Connection=true;Integrated Security=true;TrustServerCertificate=true")


            );
            var app = builder.Build();

            app.UseStaticFiles();

            app.MapControllerRoute(name: "default", pattern: "{controller=home}/{action=index}");

            app.Run();
        }
    }
}
