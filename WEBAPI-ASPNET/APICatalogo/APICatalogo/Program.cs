using APICatalogo.Context;
using APICatalogo.DTOs.Mappings;
using APICatalogo.Models;
using APICatalogo.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

string sqlServerConnection = builder.Configuration.GetConnectionString("DefaultConnection"); //pegando a string de conexão do arquivo appsettings.json

builder.Services.AddDbContext<AppDbContext>(options => //adicionando o contexto do banco de dados ao contêiner de serviços
    options.UseSqlServer(sqlServerConnection));

var secretKey = builder.Configuration["JWT:SecretKey"]
            ?? throw new ArgumentException("A chave secreta para autenticação JWT é invalida.");
    ; //pegando a chave secreta do arquivo appsettings.json para usar na autenticação JWT

builder.Services.AddAuthentication(options =>
{     options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
      options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.SaveToken = true;
    options.RequireHttpsMetadata = false;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ClockSkew = TimeSpan.Zero, //removendo o tempo de tolerância para expiração do token, para que ele expire exatamente no tempo definido
        ValidAudience = builder.Configuration["JWT:ValidAudience"], //definindo o emissor do token, pode ser o nome da sua aplicação ou domínio
        ValidIssuer = builder.Configuration["JWT:ValidIssuer"], //definindo o público do token, pode ser o nome da sua aplicação ou domínio
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey)) //definindo a chave de assinatura do token, usando a chave secreta definida no arquivo appsettings.json
    };
}

); 



builder.Services.AddScoped<ICategoriaRepository, CategoriaRepository>(); //registrando o repositório de categorias no contêiner de serviços, para que ele possa ser injetado nos controladores

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>)); //registrando o repositório genérico no contêiner de serviços, para que ele possa ser injetado nos controladores

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>(); //registrando a unidade de trabalho no contêiner de serviços, para que ela possa ser injetada nos controladores

builder.Services.AddAutoMapper(typeof(ProdutoDTOMappingProfile)); //registrando o AutoMapper no contêiner de serviços, para que ele possa ser injetado nos controladores e usado para mapear as entidades para os DTOs e vice-versa

builder.Services.AddAuthentication("Bearer").AddJwtBearer(); //adicionando a autenticação JWT ao contêiner de serviços, para proteger as rotas da API

builder.Services.AddIdentity<ApplicationUser, IdentityRole>() //adicionando o Identity ao contêiner de serviços, para gerenciar os usuários e as funções da aplicação
    .AddEntityFrameworkStores<AppDbContext>() //configurando o Identity para usar o contexto do banco de dados para armazenar os dados dos usuários e das funções
    .AddDefaultTokenProviders(); //adicionando os provedores de token padrão do Identity, para gerar tokens de autenticação e autorização

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options => options.SwaggerEndpoint("/openapi/v1.json", "weather api"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
