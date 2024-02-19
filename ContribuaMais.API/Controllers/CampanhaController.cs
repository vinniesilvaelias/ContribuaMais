using ContribuaMais.API.Models.Dados;
using ContribuaMais.API.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace ContribuaMais.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CampanhaController : ControladorBase<DtoCampanha, Campanha>
    {
        protected override void Imprima(DtoCampanha dto)
        {
            Console.Clear();
            Console.WriteLine(dto.Codigo);
            Console.WriteLine(dto.Descricao);
            Console.WriteLine(dto.Inicio);
            Console.WriteLine(dto.Objetivo);
            Console.WriteLine(dto.Arrecadado);
        }

        protected override Campanha Converta(DtoCampanha dto)
        {
            var campanha = Entidades.Where(x => x.Codigo == dto.Codigo).FirstOrDefault();

            if (campanha == null)
            {
                campanha = new Campanha
                {
                    Codigo = dto.Codigo,
                    Descricao = dto.Descricao,
                    Inicio = dto.Inicio,
                    Fim = dto.Fim,
                    Objetivo = dto.Objetivo,
                    Arrecadado = dto.Arrecadado,
                    Id = Guid.NewGuid()
                };
            }

            return campanha;
        }

        protected override DtoCampanha Converta(Campanha objeto)
        {
            var dto = Dtos.Where(x => x.Codigo == objeto.Codigo).FirstOrDefault();

            if (dto == null)
            {
                dto = new DtoCampanha
                {
                    Codigo = Dtos.Count + 1,
                    Descricao = objeto.Descricao,
                    Inicio = objeto.Inicio,
                    Fim = objeto.Fim,
                    Objetivo = objeto.Objetivo,
                    Arrecadado = dto.Arrecadado,
                };
            }

            return dto;
        }

        protected override void MockEntidades()
        {
            Entidades = Dtos.Select(Converta).ToList();
        }

        protected override void MockDtos()
        {
            Dtos = new List<DtoCampanha>
            {
                new DtoCampanha
                {
                    Codigo = 1,
                    Descricao = "Natal sem fome",
                    Inicio = DateTime.Now,
                    Fim = DateTime.Now.AddMonths(3),
                    Objetivo = 1000,
                    Arrecadado = 150
                },
                new DtoCampanha
                {
                    Codigo = 2,
                    Descricao = "Gotas de vida",
                    Inicio = DateTime.Now,
                    Fim = DateTime.Now.AddMonths(3),
                    Objetivo = 100,
                    Arrecadado = 10
                },
                new DtoCampanha
                {
                    Codigo = 3,
                    Descricao = "Dentes limpos",
                    Inicio = DateTime.Now,
                    Fim = DateTime.Now.AddMonths(3),
                    Objetivo = 1000,
                    Arrecadado = 150
                },
            };
        }
    }
}
