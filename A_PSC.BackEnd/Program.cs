using A_PSC.BackEnd.Data;
using A_PSC.BackEnd.IdentitySupport;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);
//Añadimos la clase contexto 
builder.Services.AddDbContext<APSCContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Activar la api
builder.Services.AddIdentityApiEndpoints<ApplicationUser>()
    .AddEntityFrameworkStores<APSCContext>();

// Habilitar Cors
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// Simular servicios de correo electronico y recuperación de contraseña
builder.Services.AddTransient<IEmailSender<ApplicationUser>, DummyEmailSender>();


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddOpenApi();


var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapIdentityApi<ApplicationUser>();

app.UseHttpsRedirection();
app.UseCors(); // Aplicar los CORS
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();
