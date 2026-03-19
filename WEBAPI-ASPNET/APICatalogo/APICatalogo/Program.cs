using APICatalogo.Context;
using APICatalogo.DTOs.Mappings;
using APICatalogo.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

string sqlServerConnection = builder.Configuration.GetConnectionString("DefaultConnection"); //pegando a string de conexão do arquivo appsettings.json

builder.Services.AddDbContext<AppDbContext>(options => //adicionando o contexto do banco de dados ao contêiner de serviços
    options.UseSqlServer(sqlServerConnection));

builder.Services.AddScoped<ICategoriaRepository, CategoriaRepository>(); //registrando o repositório de categorias no contêiner de serviços, para que ele possa ser injetado nos controladores

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>)); //registrando o repositório genérico no contêiner de serviços, para que ele possa ser injetado nos controladores

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>(); //registrando a unidade de trabalho no contêiner de serviços, para que ela possa ser injetada nos controladores

builder.Services.AddAutoMapper(typeof(ProdutoDTOMappingProfile)); //registrando o AutoMapper no contêiner de serviços, para que ele possa ser injetado nos controladores e usado para mapear as entidades para os DTOs e vice-versa

builder.Services.AddAuthentication("Bearer").AddJwtBearer(); //adicionando a autenticação JWT ao contêiner de serviços, para proteger as rotas da API

builder.Services.AddIdentity<IdentityUser, IdentityRole>() //adicionando o Identity ao contêiner de serviços, para gerenciar os usuários e as funções da aplicação
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
