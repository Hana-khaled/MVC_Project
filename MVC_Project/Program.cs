namespace MVC_Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

            var app = builder.Build();

            app.UseRouting();

            #region Routing and Parameters
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/Home", async context =>
            //    {
            //        await context.Response.WriteAsync("You are at Home Page");
            //    });

            //    endpoints.MapGet("/Products/{id:int?}", async context =>
            //    {
            //        var idData = context.Request.RouteValues["id"];
            //        if(idData is not null)
            //        {
            //            int data = Convert.ToInt32(idData);
            //            await context.Response.WriteAsync($"You are at Products Page id => {data}");
            //        }
            //        else
            //        {
            //            await context.Response.WriteAsync("You are at Products Page");
            //        }
            //    });

            //    endpoints.MapGet("/Books/ {ID}/ {Author:alpha:minlength(5):maxlength(10)}", async context =>
            //    {
            //        int id = Convert.ToInt32(context.Request.RouteValues["ID"]);
            //        string name = context.Request.RouteValues["Author"].ToString();

            //        await context.Response.WriteAsync($"You are at Products Page id => {id}, Author => {name}");
            //    });
            //}); 
            #endregion

            app.MapControllerRoute(
                name: "default",
                pattern: "/{Controller = Home}/{Action = Index}",
                defaults: new {Controller = "Home", Action = "Index"}
                );

            //app.Run(async (HttpContext) => {
            //    await HttpContext.Response.WriteAsync("Your requested Page not Found");
            //});

            app.Run();
        }
    }
}
