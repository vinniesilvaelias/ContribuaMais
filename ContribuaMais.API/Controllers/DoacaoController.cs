using ContribuaMais.API.Dados.Interfaces;
using ContribuaMais.API.Models.Dados;
using ContribuaMais.API.Models.Dtos;
using ContribuaMais.API.Models.Enumeradores;
using ContribuaMais.API.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ContribuaMais.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DoacaoController : ControladorBase<DtoDoacao, Doacao>
    {
        public DoacaoController(IRepositorio<Doacao> repositorio) : base(repositorio)
        {
        }

        protected override Doacao Converta(DtoDoacao dto)
        {
            var objeto = new Doacao { };

            return objeto;
        }

        protected override DtoDoacao Converta(Doacao objeto)
        {
           var dto = new DtoDoacao { };

            return dto;
        }
    }
}
