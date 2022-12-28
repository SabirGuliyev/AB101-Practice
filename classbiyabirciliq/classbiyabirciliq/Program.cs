namespace classbiyabirciliq
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseRouting();
            app.UseStaticFiles();
            app.MapControllerRoute(
                "default",
                "{controller=home}/{action=index}"
                );
            //app.MapDefaultControllerRoute();
            app.Run();
        }
    }
}