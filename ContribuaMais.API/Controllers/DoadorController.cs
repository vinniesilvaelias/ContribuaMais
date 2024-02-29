using AutoMapper;
using ContribuaMais.API.Models.Dados;
using ContribuaMais.API.Models.Dtos;
using ContribuaMais.API.Servicos.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ContribuaMais.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DoadorController : ControladorBase<DtoDoador, Doador>
    {
        public DoadorController(IServico<Doador> servico, IMapper mapper) : base(servico, mapper)
        {
        }
    }
}
