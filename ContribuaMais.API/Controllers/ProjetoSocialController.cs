using ContribuaMais.API.Dados.Interfaces;
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
        public ProjetoSocialController(IRepositorio<ProjetoSocial> repositorio) : base(repositorio)
        {
        }

        protected override ProjetoSocial Converta(DtoProjetoSocial dto)
        {
            var objeto = new ProjetoSocial
                {
                    Codigo = dto.Codigo,
                    Nome = dto.Nome,
                    Cnpj = dto.Cnpj
                };

            return objeto;
        }

        protected override DtoProjetoSocial Converta(ProjetoSocial objeto)
        {
            if (objeto is null)
            {
                return new DtoProjetoSocial();
            }

            var dto = new DtoProjetoSocial
            {
                Codigo =  1,
                Nome = objeto.Nome,
                Cnpj = objeto.Cnpj
            };

            return dto;
        }
    }
}
