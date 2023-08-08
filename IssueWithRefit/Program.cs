using Refit;
namespace IssueWithRefit
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            
            builder.Services.AddAuthorization();
            builder.Services.AddRefitClient<GeneratedCode.IMyApiClient>();

            var app = builder.Build();            

            app.UseAuthorization();

            app.MapGet("/weatherforecast", (HttpContext httpContext, GeneratedCode.IMyApiClient myApiClient) =>
            {

            });

            app.Run();
        }
    }
}