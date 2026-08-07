using KodeFlow.Data.Context;
using KodeFlow.Extensions;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Evitar serialização cíclica entre os objetos =========================================================================================
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler =
        ReferenceHandler.IgnoreCycles;
    });

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();


// Busca Connection String e Configura o AppDbContext =========================================================================================
string connectionString = builder.Configuration.GetConnectionString("DefaultConnection")!;

// Utilizando instância de IConfiguration na propriedade Configuration para buscar valores ====================================
// do arquivo de configuração ====================================
string valorChave1 = builder.Configuration["Estudos1"];
Console.WriteLine(valorChave1);

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(connectionString)
    .LogTo(Console.WriteLine, LogLevel.Information); //Loga todas as queries
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
    app.ConfigureExceptionHandler(); //Utilizando método de extensão
}

app.UseHttpsRedirection();

app.UseAuthorization();

//Criando um middleware personalizado =========================================================================
//Passando HttpContext e RequestDelegate
// Middleware 1
app.Use(async (context, next) =>
{
    //Adiciona o código antes do request
    Console.WriteLine("1 - Antes");
    await next(context);
    //Adiciona o código depois do request
    Console.WriteLine("1 - Depois");
});

// Middleware 2
app.Use(async (context, next) =>
{
    //Adiciona o código antes do request
    Console.WriteLine("2 - Antes");
    await next(context);
    //Adiciona o código depois do request
    Console.WriteLine("2 - Depois");
});

// Middleware 3 último, sem next — normalmente o que gera a resposta)
//app.Run(async context =>
//{
//    Console.WriteLine("3 - Gerando Resposta!");
//    await context.Response.WriteAsync("Olá!");
//});

app.MapControllers();

app.Run();
