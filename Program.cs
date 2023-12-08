using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;


WebApplicationOptions webApplicationOptions = new()
{
    Args = args,
  //  EnvironmentName = environmentName
};


WebApplicationBuilder builder = WebApplication.CreateBuilder(webApplicationOptions);
builder.Services.AddMvc();

var app = builder.Build();

app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=WhoAmI}/{action=Get}/{id?}");
app.Run();
