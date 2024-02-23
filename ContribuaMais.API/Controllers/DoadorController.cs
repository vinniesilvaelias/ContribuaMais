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

        protected override Doador Converta(DtoDoador dto)
        {
            var objeto = new Doador
            {
                Codigo = dto.Codigo,
                Nome = dto.Nome,
                Cpf = dto.Cpf,
                Id = Guid.NewGuid()
            };

            return objeto;
        }

        protected override DtoDoador Converta(Doador objeto)
        {
            var dto = new DtoDoador { };

            return dto;
        }
    }
}
