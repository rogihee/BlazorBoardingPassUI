using BoardingPassComponents;
using BoardingPassShared;
using BoardingPassShared.Helpers;
using BoardingPassWasmApp;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddOptions();

builder.Services.AddBoardingPassComponentsServices();
builder.Services.AddBoardingPassSharedServices(fake:true);

builder.Services.ConfigureOptions<ConfigureJsonOptions>();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
