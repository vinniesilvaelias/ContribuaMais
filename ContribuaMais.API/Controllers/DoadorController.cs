using ContribuaMais.API.Dados.Interfaces;
using ContribuaMais.API.Models.Dados;
using ContribuaMais.API.Models.Dtos;
using ContribuaMais.API.Models.TiposBase;
using Microsoft.AspNetCore.Mvc;

namespace ContribuaMais.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DoadorController : ControladorBase<DtoDoador, Doador>
    {
        public DoadorController(IRepositorio<Doador> repositorio) : base(repositorio)
        {
        }

        protected override void Imprima(DtoDoador dto)
        {
            Console.Clear();
            Console.WriteLine(dto.Cpf);
            Console.WriteLine(dto.Endereco);
        }

        protected override Doador Converta(DtoDoador dto)
        {
            var objeto = Entidades.Where(x => x.Codigo == dto.Codigo).FirstOrDefault();

            if (objeto == null)
            {
                objeto = new Doador
                {
                    Codigo = dto.Codigo,
                    Nome = dto.Nome,
                    Cpf = dto.Cpf,
                    Id = Guid.NewGuid()
                };
            }

            return objeto;
        }

        protected override DtoDoador Converta(Doador objeto)
        {
            var dto = Dtos.Where(x => x.Codigo == objeto.Codigo).FirstOrDefault();

            if (dto == null)
            {
                dto = new DtoDoador
                {
                    Codigo = Dtos.Count + 1,
                    Nome = dto.Nome,
                    Cpf = dto.Cpf,
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
            Dtos = new List<DtoDoador>
            {
                new DtoDoador
                {
                    Codigo = 1,
                    Nome = "João",
                    Cpf = "1111111111"
                },
                new DtoDoador
                {
                    Codigo = 2,
                    Nome = "Maria",
                    Cpf = "22222222"
                },
                new DtoDoador
                {
                    Codigo = 3,
                    Nome = "José",
                    Cpf = "333333"
                },
            };
        }
    }
}
