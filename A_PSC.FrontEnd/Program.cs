using A_PSC.FrontEnd;
using A_PSC.FrontEnd.Services;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Para que el frontend se comunique con el backend
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration["WebApiAddress"]!) });

//Añadimos servicios
builder.Services.AddCascadingAuthenticationState();

builder.Services.AddAuthorizationCore();

builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();

// Soporte para localStorage 
builder.Services.AddBlazoredLocalStorage();

// 👉 Aquí puedes agregar tus servicios como:
// builder.Services.AddScoped<UsuarioService>();
// builder.Services.AddScoped<AuthService>();

await builder.Build().RunAsync();
