using Financas.Dominio.Interfaces;
using Financas.Negocio.Interfaces;
using Financas.Negocio.Negocios;
using Financas.Repositorio.Contexto;
using Financas.Repositorio.Repositorios;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// 1. Busca o valor real do arquivo
var secretKey = builder.Configuration["JwtSettings:Secret"];
var chave = Encoding.UTF8.GetBytes(secretKey); // Use UTF8 para bater com o AuthService  

builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(x =>
{
    x.RequireHttpsMetadata = false;
    x.SaveToken = true;
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(chave),
        ValidateIssuer = false,
        ValidateAudience = false
    };
});

// Add services to the container.
#region [Adicionando serviços ao container]
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.IgnoreReadOnlyFields = true;
    })
    .AddNewtonsoftJson(op =>
    {
        op.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
    });

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddDbContext<DbContexto>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularApp", builder =>
        builder.WithOrigins("http://localhost:4200")
               .AllowAnyMethod()
               .AllowAnyHeader());
});

#region [Área de configuracao dos serviços] 
builder.Services.AddScoped<INegocioUsuario, NegocioUsuario>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<INegocioPerfil, NegocioPerfil>();
builder.Services.AddScoped<INegocioDespesa, NegocioDespesa>();
builder.Services.AddScoped<INegocioReceita, NegocioReceita>();
builder.Services.AddScoped<INegocioFonteRenda, NegocioFonteRenda>();
builder.Services.AddScoped<INegocioBalanceteContabil, NegocioBalanceteContabil>();
builder.Services.AddScoped<IRepositorioUsuario, RepositorioUsuario>();
builder.Services.AddScoped<IRepositorioPerfil, RepositorioPerfil>();
builder.Services.AddScoped<IRepositorioDespesa, RepositorioDespesa>();
builder.Services.AddScoped<IRepositorioReceita, RepositorioReceita>();
builder.Services.AddScoped<IRepositorioFonteRenda, RepositorioFonteRenda>();
builder.Services.AddScoped<IRepositorioBalanceteContabil, RepositorioBalanceteContabil>();
#endregion

#endregion

var app = builder.Build();

#region [Configuração do HTTP Request]

app.UseCors("AllowAngularApp");
app.UseHttpsRedirection();

// --- 2. ORDEM DOS MIDDLEWARES (AJUSTE CRUCIAL) ---
app.UseAuthentication(); 
app.UseAuthorization();  // Esta já existia, mas deve vir DEPOIS da Authentication

app.UseStaticFiles();
app.MapControllers();
app.Run();
#endregion
