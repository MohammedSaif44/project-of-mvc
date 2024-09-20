namespace project_of_mvc
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
            //app.UseEndpoints(Endpoint =>
            //{
            //    Endpoint.MapGet("/Home", async context =>
            //    {
            //        await context.Response.WriteAsync("Ypu Are at Home Page");
            //    }
            //    );
            //    Endpoint.MapGet("/Products/{id :int?}", async context =>
            //    {
            //        var idData= Convert.ToInt32(context.Request.RouteValues["id"]);
            //        if (idData is not null)
            //        {
            //            int data = Convert.ToInt32(idData);
            //            await context.Response.WriteAsync($"Ypu Are at Products Page id=>{idData}");
            //        }
            //        else
            //        {
            //            await context.Response.WriteAsync("Ypu Are at Products Page");
            //        }
            //    }
            //   );
            //    Endpoint.MapGet("/Books/{Id}/{Auther}", async context =>
            //    {
            //        int id = Convert.ToInt32(context.Request.RouteValues["Id"]);
            //        string name = context.Request.RouteValues["Auther"].ToString();
            //        await context.Response.WriteAsync($"Ypu Are at Books Page id=>{id},at Auther=>{name}");
            //    }
            //);

            //});
            app.MapControllerRoute(
                name: "default",
                pattern: "/{Controller=Home}/{Action=Index}",
                defaults: new { Controller = "Home", Action = "Index" }
                );

            Console.WriteLine("hello from DEV");

            
            //app.Run(async (HttpContent) => { await HttpContent.Response.WriteAsync("Ypur product Page not Found"); });
            //app.MapGet("/Home", () => "Hello World!");
            app.Run();
        }
    }
}
