using Finances.Web;
using Finances.Web.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var baseUrl = "https://localhost:7099";

builder.Services.AddScoped(sp => new HttpClient 
{ 
    BaseAddress = new Uri(baseUrl) 
});

builder.Services.AddScoped<IReceitaService, ReceitaService>();
builder.Services.AddScoped<IDespesaService, DespesaService>();

await builder.Build().RunAsync();
