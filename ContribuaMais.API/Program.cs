using ContribuaMais.API.Dados;
using ContribuaMais.API.Dados.Interfaces;
using ContribuaMais.API.Dados.Repositorios;
using ContribuaMais.API.Models.Dados;
using ContribuaMais.API.Servicos.Implementacoes;
using ContribuaMais.API.Servicos.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var conexaoBancoDeDados = builder.Configuration.GetConnectionString("ContribuaMais");

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies()); 


builder.Services.AddScoped(typeof(IServico<>), typeof(ServicoBase<>));

builder.Services.AddScoped(typeof(IRepositorio<>), typeof(RepositorioBase<>));
builder.Services.AddScoped(typeof(IRepositorio<Doacao>), typeof(RepositorioDoacao));

builder.Services.AddDbContext<ContribuaMaisContexto>(
    opc => opc.UseSqlServer(conexaoBancoDeDados));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();   
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
