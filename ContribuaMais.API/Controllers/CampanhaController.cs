using ContribuaMais.API.Models.Dados;
using ContribuaMais.API.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace ContribuaMais.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CampanhaController : ControladorBase<DtoCampanha, Campanha>
    {
        protected override void Imprima(DtoCampanha EntidadeBase)
        {
            Console.Clear();
            Console.WriteLine(EntidadeBase.Codigo);
            Console.WriteLine(EntidadeBase.Descricao);
            Console.WriteLine(EntidadeBase.Inicio);
            Console.WriteLine(EntidadeBase.Objetivo);
            Console.WriteLine(EntidadeBase.Arrecadado);
        }

        protected override Campanha Converta(DtoCampanha dto)
        {
            var campanha = Entidades.Where(x => x.Codigo == dto.Codigo).FirstOrDefault();

            if (campanha == null)
            {
                campanha = new Campanha
                {
                    Codigo = Entidades.Count + 1,
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
                    Codigo = Entidades.Count + 1,
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
                    Codigo = 1,
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
