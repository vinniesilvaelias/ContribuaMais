using ContribuaMais.API.Dados;
using ContribuaMais.API.Dados.Interfaces;
using ContribuaMais.API.Dados.Repositorios;
using ContribuaMais.API.Dados.Repositorios.Infraestrutura;
using ContribuaMais.API.Models.Dados;
using ContribuaMais.API.Models.Dados.Infraestrutura;
using ContribuaMais.API.Servicos.Implementacoes;
using ContribuaMais.API.Servicos.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var conexaoBancoDeDados = builder.Configuration.GetConnectionString("ContribuaMais");

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies()); 

builder.Services.AddScoped(typeof(IServico<>), typeof(ServicoBase<>));

builder.Services.AddScoped(typeof(IRepositorio<>), typeof(RepositorioBase<>));

builder.Services.AddScoped(typeof(IRepositorio<Doacao>), typeof(RepositorioDoacao));

builder.Services.AddScoped(typeof(IRepositorio<ProjetoSocial>), typeof(RepositorioProjetoSocial));

builder.Services.AddScoped(typeof(IRepositorio<Doador>), typeof(RepositorioDoador));

builder.Services.AddScoped(typeof(IRepositorio<Pessoa>), typeof(RepositorioPessoa));

builder.Services.AddDbContext<ContribuaMaisContexto>(
    opc => opc.UseSqlServer(conexaoBancoDeDados));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();   
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();