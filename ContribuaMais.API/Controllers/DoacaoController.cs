using AutoMapper;
using ContribuaMais.API.Models.Dados;
using ContribuaMais.API.Models.Dtos;
using ContribuaMais.API.Servicos.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ContribuaMais.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DoacaoController : ControladorBase<DtoDoacao, Doacao>
    {
        public DoacaoController(IServico<Doacao> servico, IMapper mapper) : base(servico, mapper)
        {
        }
    }
}
