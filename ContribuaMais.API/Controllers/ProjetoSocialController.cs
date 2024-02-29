using AutoMapper;
using ContribuaMais.API.Models.Dados;
using ContribuaMais.API.Models.Dtos;
using ContribuaMais.API.Servicos.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ContribuaMais.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjetoSocialController : ControladorBase<DtoProjetoSocial, ProjetoSocial>
    {
        public ProjetoSocialController(IServico<ProjetoSocial> servico, IMapper mapper) : base(servico, mapper)
        {
        }
    }
}
