using ContribuaMais.API.Models.Dados;
using ContribuaMais.API.Models.Dtos;
using ContribuaMais.API.Models.Enumeradores;
using Microsoft.AspNetCore.Mvc;

namespace ContribuaMais.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjetoSocialController : ControladorBase<DtoProjetoSocial, ProjetoSocial>
    {
        protected override void Imprima(DtoProjetoSocial dto)
        {
            Console.Clear();
            Console.WriteLine(dto.Nome);
            Console.WriteLine(dto.Cnpj);
        }

        protected override ProjetoSocial Converta(DtoProjetoSocial dto)
        {
            var objeto = Entidades.Where(x => x.Codigo == dto.Codigo).FirstOrDefault();

            if (objeto == null)
            {
                objeto = new ProjetoSocial
                {
                    Codigo = dto.Codigo,
                    Nome = dto.Nome,
                    Cnpj = dto.Cnpj
                };
            }

            return objeto;
        }

        protected override DtoProjetoSocial Converta(ProjetoSocial objeto)
        {
            var dto = Dtos.Where(x => x.Codigo == objeto.Codigo).FirstOrDefault();

            if (dto == null)
            {
                dto = new DtoProjetoSocial
                {
                    Codigo = Dtos.Count + 1,
                    Nome = objeto.Nome,
                    Cnpj = objeto.Cnpj
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
            Dtos = new List<DtoProjetoSocial>
            {
                new DtoProjetoSocial
                {
                    Codigo = 1,
                    Nome = "Criança Esperança",
                    Cnpj = "111111111"
                },
                new DtoProjetoSocial
                {
                    Codigo = 2,
                    Nome = "Teletom",
                    Cnpj = "222222222"
                },
                new DtoProjetoSocial
                {
                    Codigo = 3,
                    Nome = "OVG",
                    Cnpj = "3333333333333"
                },
            };
        }
    }
}
